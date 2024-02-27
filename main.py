# Import Module
import os
import pandas as pd
import math
#import sklearn
import numpy as np
#from sklearn.feature_extraction.text import TfidfVectorizer

# Folder Path
path = "E:\pythonProject\DocumentCollection"
my_stopwords = ['i', 'me', 'my', 'myself', 'we', 'our', 'ours', 'ourselves', 'you', "you're", "you've", "you'll", "you'd", 'your', 'yours', 'yourself', 'yourselves', 'he', 'him', 'his', 'himself', 'she', "she's", 'her', 'hers', 'herself', 'it', "it's", 'its', 'itself', 'they', 'them', 'their', 'theirs', 'themselves', 'what', 'which', 'who', 'whom', 'this', 'that', "that'll", 'these', 'those', 'am', 'is', 'are', 'was', 'were', 'be', 'been', 'being', 'have', 'has', 'had', 'having', 'do', 'does', 'did', 'doing', 'a', 'an', 'the', 'and', 'but', 'if', 'or', 'because', 'as', 'until', 'while', 'of', 'at', 'by', 'for', 'with', 'about', 'against', 'between', 'into', 'through', 'during', 'before', 'after', 'above', 'below', 'from', 'up', 'down', 'out', 'on', 'off', 'over', 'under', 'again', 'further', 'then', 'once', 'here', 'there', 'when', 'why', 'how', 'all', 'any', 'both', 'each', 'few', 'more', 'most', 'other', 'some', 'such', 'no', 'nor', 'not', 'only', 'own', 'same', 'so', 'than', 'too', 'very', 's', 't', 'can', 'will', 'just', 'don', "don't", 'should', "should've", 'now', 'd', 'll', 'm', 'o', 're', 've', 'y', 'ain', 'aren', "aren't", 'couldn', "couldn't", 'didn', "didn't", 'doesn', "doesn't", 'hadn', "hadn't", 'hasn', "hasn't", 'haven', "haven't", 'isn', "isn't", 'ma', 'mightn', "mightn't", 'mustn', "mustn't", 'needn', "needn't", 'shan', "shan't", 'shouldn', "shouldn't", 'wasn', "wasn't", 'weren', "weren't", 'won', "won't", 'wouldn', "wouldn't"]
Token=[]
token_str=[]
pos_index={}
fileno=1
os.chdir(path)
def convert_docs_into_arrStr(file_path):
    with open(file_path, 'r') as f:
        content = f.read()
        token_str=content
        return token_str
def Tokinizar(file_path):
    with open(file_path, 'r') as f:
        content = f.read()
        content_list = content.split(" ")
        f.close()
        return content_list
def remove_mystopwords(sentence):
    tokens_filtered= [word.lower() for word in sentence if not word in my_stopwords]
    return tokens_filtered
def postional_index(final_token_list,fileno):

    pos=1
    for term in final_token_list:
        # If term already exists in the positional index diction
        if term in pos_index:
        # Increment total freq by 1
            pos_index[term][0] = pos_index[term][0] + 1
        # Check if the term has existed in that DocID before.
            if fileno in pos_index[term][1]:
                 pos_index[term][1][fileno].append(pos)

            else:
                pos_index[term][1][fileno] = [pos]
        # If term does not exist in the positional index dictionary
        else:
            # Initialize the list.
            pos_index[term] = []
            # The total frequency is 1.
            pos_index[term].append(1)
            # The postings list is initially empty.
            pos_index[term].append({})
            # Add doc ID to postings list.
            pos_index[term][1][fileno] = [pos]
        pos+=1
def retrieve_list(word):

    ans = []
    if word in pos_index.keys():

        ans = pos_index[word]
    else:
        print('Term : {} not present in dictionary'.format(word))
        return 0
    return ans
def positional_intersect(pos_list_1, pos_list_2, k):
    ans = []
    for file_id in pos_list_1.keys():
        if file_id in pos_list_2.keys():
            list_1 = pos_list_1[file_id]
            list_2 = pos_list_2[file_id]

            for pos1 in list_1:
                for pos2 in list_2:
                    if pos2 - pos1 == k:  # or pos1 - pos2 == k :
                        if file_id not in ans:
                            ans.append(file_id)

                        break
    return ans
def process_query(query):
    results = []
    query = remove_mystopwords(query)
    for i in range(len(query)):
        j = i + 1
        pos_list_1 = retrieve_list(query[i])
        if(pos_list_1):
            while j < len(query):
                pos_list_2 = retrieve_list(query[j])

                swap = False
                if(pos_list_2):
                    if pos_list_1[0] > pos_list_2[0]:

                        # print('Swapping')
                        pos_list_1, pos_list_2 = pos_list_2, pos_list_1
                        swap = True

                    if swap:
                        k = i - j
                    else:
                        k = j - i
                    # Small postings list is always first one for optimisation

                    ans = positional_intersect(pos_list_1[1], pos_list_2[1], k)
                    results.append(ans)
                    i+=1
                    break
                else:
                    return 0
        else:
            return 0
    return results
def construct_dict(lists):


    result = set(lists[0])
    for s in lists[1:]:
        result.intersection_update(s)

    return result
def print_output(results):
    query_founded=False
    if(results==0):
        print("False Query")
    elif(results==[]):
        print("there is no such file")
    else:
        query_founded=True
        print('-----------------------')

        i = 0
        while  i < len(results) :
            for x in results:
                    print('the phrase query matched with doc ', x)
                    i+=1



    return query_founded
def read_query(Query):
    query = Query.split()
    results = process_query(query)
    results = construct_dict(results)
    return print_output(results)
def compute_term_freq():
    all_word=[]
    for doc in Token:
        for word in doc:
            all_word.append(word)
    def get_freq(doc):
        word_f=dict.fromkeys(all_word,0)
        for word in doc:
            word_f[word]+=1
        return word_f
    term_freq= pd.DataFrame(get_freq(Token[0]).values(), index=get_freq(Token[0]).keys())
    for i in range(1,len(Token)):
        term_freq[i] = get_freq(Token[i]).values()
    term_freq.columns=["Doc"+str(i) for i in range(1,11)]
    return term_freq
def compute_weight_tf(i):
    if i>0:
        return math.log(i)+1
    return 0
def compute_IDF():
    term_freq=compute_term_freq()
    TDF=pd.DataFrame(columns=["freq","IDF"])
    for x in range(len(term_freq)):
        freq=term_freq.iloc[x].values.sum()
        TDF.loc[x,"freq"]=freq
        TDF.loc[x,"IDF"]=math.log((10/float(freq)),10)
    TDF.index=term_freq.index
    return TDF
def Displays_TF_tiems_IDF_matrix():
    term_freq=Apply_wtf()
    TDF=compute_IDF()
    term_freq_times_doc_freq = term_freq.multiply(TDF["IDF"], axis=0)
    return term_freq_times_doc_freq
def Apply_wtf():
    freq = compute_term_freq()
    for i in range(1, len(Token) + 1):
        freq["Doc"+str(i)]=freq["Doc"+str(i)].apply(compute_weight_tf)
    return freq
def compute_lenght():
    doc_len=pd.DataFrame()
    DF_IDF=Displays_TF_tiems_IDF_matrix()
    for col in DF_IDF.columns:
        doc_len.loc[0,col+"_lens"]=np.sqrt(DF_IDF[col].apply(lambda x:x**2).sum())

    return doc_len
def Compute_norm(col,x):
    doc_len = compute_lenght()
    try:
        return x/doc_len[col+"_lens"].values[0]
    except:

        return 0
def Normalization():
    DF_IDF = Displays_TF_tiems_IDF_matrix()
    norm=pd.DataFrame()
    for col in DF_IDF.columns:
        norm[col]=DF_IDF[col].apply(lambda x:Compute_norm(col,x))
    return norm
def query_wtf(x):
    try:
        return math.log10(x)+1
    except:
        return 0
def Query():
    idf=compute_IDF()
    query=input()
    if(read_query(query)):
        q=pd.DataFrame(index=compute_term_freq().index)
        q["TF"]=[1 if x in query.split() else 0 for x in list(compute_term_freq().index)]
        q["WTF"]=q["TF"].apply(lambda x: query_wtf(x))
        q["IDF"]=idf["IDF"]*q["WTF"]
        q["TF*IDF"]=q["TF"]*q["IDF"]
        q_len=np.sqrt(q["TF*IDF"].apply(lambda x:x**2).sum())
        q["Normalized"]=0
        for i in range(len(q)):
            q["Normalized"].iloc[i] = float(q["TF*IDF"].iloc[i]) / q_len
        print(q)
        #product(query*matched_doc)
        product1=Normalization().multiply(q["WTF"],axis=0)
        product2=product1.multiply(q["Normalized"],axis=0)
        #cosin similarty
        final_res={}
        for col in product2.columns:
            if 0 in product2[col].loc[query.split()].values:
                pass
            else:
                final_res[col]=product2[col].sum()
                print("Cosin similarity",final_res)
        product_result=product2[list(final_res.keys())].loc[query.split()]
        print(product_result)
        print(product_result.sum())
    else:
        return 0
for file in os.listdir(path):
    if file.endswith(".txt"):
        file_path = f"{path}\{file}"
        Sentance=Tokinizar(file_path)
        Token.append(remove_mystopwords(Sentance))
        postional_index(Token[fileno-1], fileno)
        token_str.append(convert_docs_into_arrStr(file_path))
    fileno+=1
print(pos_index)
"""
print("TERM FREQ")
print(compute_term_freq())
print("IDF\n")
print(compute_IDF())
print("W_TF\n")
print(Apply_wtf())
print("IDF*W_Tf\n")
print(Displays_TF_tiems_IDF_matrix())
print("LENGTH\n")
print(compute_lenght())
print("Normalization\n")
print(Normalization())
print(Query())
"""


































"""def MENU():
    print("-------------WHAT YOU WANT???------------")
    print("1-Find a matched documents for a query phrase.")
    print("2-Compute term frequency for each term in each document.")
    print("3-Compute Weight term Freq for each term.")
    print("4-Compute IDF for each term.")
    print("5-Displays TF.IDF matrix.")
    print("6-Displays cosine similarty")
    print("7-Exit")

    i=0

    while i<10:
        print("Enter your choice")
        ch = input()
        if(ch=="1"):
            print(read_query())
        elif(ch=="2"):
            print(compute_term_freq())
        elif(ch=="3"):
            Apply_wtf()
        elif(ch=="4"):
            print(compute_IDF())
        elif(ch=="5"):
            print(Displays_TF_tiems_IDF_matrix())
        elif(ch=="6"):
            print("enter your query")
            q=input()
            print(Compute_cosine(q))
        elif(ch=="6"):
            print(Displays_TF_tiems_IDF_matrix())
        elif(ch=="7"):
            return 0
        else:
            print("your choose is false enter again")
        i+=1
"""
"""def Compute_cosine(query):
    Token_list=token_str
    print(Token_list)
    vector = TfidfVectorizer()

    x = vector.fit_transform(Token_list)
    x = x.T.toarray()
    df = pd.DataFrame(x, index=vector.get_feature_names_out())
    q = [query]
    q_vector = vector.transform(q).toarray().reshape(df.shape[0])
    similarty = {}
    for i in range(len(Token_list)):
        similarty[i] = np.dot(df.loc[:, i].values, q_vector) / np.linalg.norm(df.loc[:, i]) * np.linalg.norm(
            df.loc[:, i])
    similarty_sorted = sorted(similarty.items(), key=lambda x: [x])
    for doc, score in similarty_sorted:
        if score > 0.5:
            print("the score is :", score)
            print("the doc is:", doc + 1)"""