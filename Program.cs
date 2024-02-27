using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApptryremove
{
    
    class Program
    {
        static public string[,] tran_table = new string[132, 40];
        static public int rowLength = tran_table.GetLength(0);
        static public int colLength = tran_table.GetLength(1);

        public static List<List<string>> Token = new List<List<string>>();
        public static List<List<string>> Entered_token = new List<List<string>>();
        public static void Dictionary()
        {

            
            // create list one and store values
            List<string> valSetOne = new List<string>();
            valSetOne.Add("32");
            valSetOne.Add("category");
            valSetOne.Add("Class");          
            //add to tran_tanle
            Token.Add( valSetOne);

            // create list two and store values
            List<String> valSetTwo = new List<String>();
            valSetTwo.Add("72");
            valSetTwo.Add("derive");
            valSetTwo.Add("Inheritance");
            //add to gtran_table
            Token.Add(valSetTwo);

            // create list three and store values
            List<String> valSetThree = new List<String>();
            valSetThree.Add("60");
            valSetThree.Add("if");
            valSetThree.Add("Condition");
            //add to tran_table
            Token.Add(valSetThree);

            // create list four and store values
            List<String> valSetFour = new List<String>();
            valSetFour.Add("66");
            valSetFour.Add("else");
            valSetFour.Add("Condition");
            //add to tra_table
            Token.Add(valSetFour);

            // create list six and store values
            List<string> valSetsix = new List<string>();
            valSetsix.Add("58");
            valSetsix.Add("ilap");
            valSetsix.Add("Integer");

            //add to tra_table
            Token.Add(valSetsix);
            // create list 50 and store values
            List<string> valSet50 = new List<string>();
            valSet50.Add("58");
            valSet50.Add("silap");
            valSet50.Add("SInteger");
            //add to tra_table
            Token.Add(valSetsix);
            // create list eight and store values
            List<String> valSet8 = new List<String>();
            valSet8.Add("40");
            valSet8.Add("clop");
            valSet8.Add("Character");
            Token.Add(valSet8);
            // create list eight and store values
            List<String> valSet49 = new List<String>();
            valSet49.Add("40");
            valSet49.Add("seop");
            valSet49.Add("Struct");
            Token.Add(valSet49);

            // create list nine and store values
            List<String> valSet9 = new List<String>();
            valSet9.Add("44");
            valSet9.Add("series");
            valSet9.Add("String");

            //add to tra_table
            Token.Add(valSet9);
            // create list 10 and store values
            List<String> valSet10 = new List<String>();
            valSet10.Add("59");
            valSet10.Add("ilapf");
            valSet10.Add("Float");
            //add to tra_table
            Token.Add(valSet10);

            List<String> valSet48 = new List<String>();
            // create list 12 and store values
            valSet48.Add("59");
            valSet48.Add("silapf");
            valSet48.Add("SFloat");
            Token.Add(valSet48);
            List<String> valSet12 = new List<String>();
            valSet12.Add("76");
            valSet12.Add("none");
            valSet12.Add("Void");
            //add to tra_table
            Token.Add(valSet12);
            // create list 13 and store values
            List<String> valSet13 = new List<String>();
            valSet13.Add("83");
            valSet13.Add("logical");
            valSet13.Add("Boolean");
            //add to tra_table
            Token.Add(valSet13);
            // create list 14 and store values
            List<String> valSet14 = new List<String>();
            valSet14.Add("108");
            valSet14.Add("terminatethis");
            valSet14.Add("Break");
            //add to tra_table
            Token.Add(valSet14);
            // create list 15 and store values
            List<String> valSet15 = new List<String>();
            valSet15.Add("19");
            valSet15.Add("rotatewhen");
            valSet15.Add("Loop");
            //add to tra_table
            Token.Add(valSet15);
            // create list 47 and store values
            List<String> valSet47 = new List<String>();
            valSet47.Add("19");
            valSet47.Add("continuewhen");
            valSet47.Add("Loop");
            Token.Add(valSet47);
            // create list 17 and store values
            List<String> valSet17 = new List<String>();
            valSet17.Add("10");
            valSet17.Add("replywith");
            valSet17.Add("Return");
            //add to tra_table
            Token.Add( valSet17);

            // create list 18 and store values
            List<String> valSet18 = new List<String>();
            valSet18.Add("36");
            valSet18.Add("check");
            valSet18.Add("Switch");
            //add to tra_table
            Token.Add(valSet18);
            // create list 19 and store values
            List<String> valSet19 = new List<String>();
            valSet19.Add("54");
            valSet19.Add("situationof");
            valSet19.Add("Switch");
            //add to tra_table
            Token.Add(valSet19);
            // create list 20 and store values
            List<String> valSet20 = new List<String>();
            valSet20.Add("95");
            valSet20.Add("program");
            valSet20.Add("Stat Statement");
            //add to tra_table
            Token.Add(valSet20);
            // create list 21 and store values
            List<String> valSet21 = new List<String>();
            valSet21.Add("63");
            valSet21.Add("end");
            valSet21.Add("End Statement");
            //add to tra_table
            Token.Add(valSet21);
            // create list 22 and store values
            List<String> valSet22 = new List<String>();
            valSet22.Add("87");
            valSet22.Add("+");
            valSet22.Add("Arithmetic Operation");
 
            //add to tra_table
            Token.Add(valSet22);
            // create list 23 and store values
            List<String> valSet23 = new List<String>();
            valSet23.Add("85");
            valSet23.Add("-");
            valSet23.Add("Arithmetic Operation");

            //add to tra_table
            Token.Add(valSet23);
            // create list 24 and store values
            List<String> valSet24 = new List<String>();
            valSet24.Add("84");
            valSet24.Add("*");
            valSet24.Add("Arithmetic Operation");
            //add to tra_table
            Token.Add(valSet24);
            // create list 25 and store values
            List<String> valSet25 = new List<String>();
            valSet25.Add("86");
            valSet25.Add("/");
            valSet25.Add("Arithmetic Operation");
            //add to tra_table
            Token.Add(valSet25);
            // create list 26 and store values
            List<String> valSet26 = new List<String>();
            valSet26.Add("122");
            valSet26.Add("&&");
            valSet26.Add("Logic operators");
            //add to tra_table
            Token.Add(valSet26);
            // create list 27 and store values
            List<String> valSet27 = new List<String>();
            valSet27.Add("117");
            valSet27.Add("||");
            valSet27.Add("Logic operators");
            //add to tra_table
            Token.Add(valSet27);
            // create list 28 and store values
            List<String> valSet28 = new List<String>();
            valSet28.Add("113");
            valSet28.Add("~");
            valSet28.Add("Logic operators");
            //add to tra_table
            Token.Add(valSet28);

            // create list 30 and store values 
            List<String> valSet30 = new List<String>();
            valSet30.Add("118");
            valSet30.Add("<");
            valSet30.Add("relational operators");
            //add to tra_table
            Token.Add(valSet30);
            List<String> valSet51 = new List<String>();
            valSet51.Add("118");
            valSet51.Add(">");
            valSet51.Add("relational operators");
            //add to tra_table
            Token.Add(valSet51);
            List<String> valSet52= new List<String>();
            valSet52.Add("118");
            valSet52.Add("=");
            valSet52.Add("relational operators");
            //add to tra_table
            Token.Add(valSet52);

        
            // create list 33 and store values
            List<String> valSet33 = new List<String>();
            valSet33.Add("120");
            valSet33.Add("<=");
            valSet33.Add("relational operators");
            Token.Add(valSet33);
            // create list 53 and store values
            List<String> valSet53 = new List<String>();
            valSet53.Add("120");
            valSet53.Add(">=");
            valSet53.Add("relational operators");
            Token.Add(valSet53);
            // create list 33 and store values
            List<String> valSet54 = new List<String>();
            valSet54.Add("120");
            valSet54.Add("==");
            valSet54.Add("relational operators");
            //add to tra_table
            Token.Add(valSet54);

            // create list 35 and store values
            List<String> valSet35 = new List<String>();
            valSet35.Add("124");
            valSet35.Add("!=");
            valSet35.Add("relational operators");
            //add to tra_table
            Token.Add(valSet35);
            // create list 36 and store values
            List<String> valSet36 = new List<String>();
            valSet36.Add("88");
            valSet36.Add(".");
            valSet36.Add("Access Operator");
            //add to tra_table
            Token.Add( valSet36);
            // create list 37 and store values
            List<String> valSet37 = new List<String>();
            valSet37.Add("114");
            valSet37.Add("{");
            valSet37.Add("Braces");
            //add to tra_table
            Token.Add(valSet37);
            // create list 38 and store values
            List<String> valSet38 = new List<String>();
            valSet38.Add("115");
            valSet38.Add("}");
            valSet38.Add("Braces");
            //add to tra_table
            Token.Add( valSet38);
            // create list 39 and store values
            List<String> valSet39 = new List<String>();
            valSet39.Add("111");
            valSet39.Add("[");
            valSet39.Add("Braces");
            //add to tra_table
            Token.Add(valSet39);
            // create list 40 and store values
            List<String> valSet40 = new List<String>();
            valSet40.Add("111");
            valSet40.Add("]");
            valSet40.Add("Braces");
            //add to tra_table
            Token.Add(valSet40);
            // create list 41 and store values
            List<String> valSet41 = new List<String>();
            valSet41.Add("131");
            valSet41.Add("Constant");
            //add to tra_table
            Token.Add(valSet41);
            // create list 42 and store values
            List<String> valSet42 = new List<String>();
            valSet42.Add("109");
            valSet42.Add("\"");
            valSet42.Add("Quotation Mark");
            //add to tra_table
            Token.Add(valSet42);
            // create list 43 and store values
            List<String> valSet43 = new List<String>();
            valSet43.Add("110");
            valSet43.Add("\'");
            valSet43.Add("Quotation Mark");
            //add to tra_table
            Token.Add(valSet43);
            // create list 44 and store values
            List<String> valSet44 = new List<String>();
            valSet44.Add("129");
            valSet44.Add("using");
            valSet44.Add("Inclusion");
            //add to tra_table
            Token.Add(valSet44);
            // create list 46   and store values
            List<String> valSet46 = new List<String>();
            valSet46.Add("130");
            valSet46.Add("Identifier");
            //add to tra_table
            Token.Add(valSet46);




            // add values into map



        }
        static public void transition_table()
        {
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {

                    tran_table[i, j] = "0";

                }
            }


            tran_table[0, 1] = "a";
            tran_table[0, 2] = "c";
            tran_table[0, 3] = "d";
            tran_table[0, 4] = "e";
            tran_table[0, 5] = "f";
            tran_table[0, 6] = "g";
            tran_table[0, 7] = "h";
            tran_table[0, 8] = "i";
            tran_table[0, 9] = "k";
            tran_table[0, 10] = "l";
            tran_table[0, 11] = "m";
            tran_table[0, 12] = "n";
            tran_table[0, 13] = "o";
            tran_table[0, 14] = "p";
            tran_table[0, 15] = "r";
            tran_table[0, 16] = "s";
            tran_table[0, 17] = "t";
            tran_table[0, 18] = "u";
            tran_table[0, 19] = "v";
            tran_table[0, 20] = "w";
            tran_table[0, 21] = "y";
            tran_table[0, 22] = "{";
            tran_table[0, 23] = "}";
            tran_table[0, 24] = "[";
            tran_table[0, 25] = "]";
            tran_table[0, 26] = "\"";
            tran_table[0, 27] = "\'";
            tran_table[0, 28] = ".";
            tran_table[0, 29] = "=";
            tran_table[0, 30] = ">";
            tran_table[0, 31] = "<";
            tran_table[0, 32] = "!";
            tran_table[0, 33] = "&";
            tran_table[0, 34] = "|";
            tran_table[0, 35] = "~";
            tran_table[0, 36] = "+";
            tran_table[0, 37] = "-";
            tran_table[0, 38] = "*";
            tran_table[0, 39] = "/";
            tran_table[12, 1] = "13";
            tran_table[20, 1] = "26";
            tran_table[47, 1] = "48";
            tran_table[56, 1] = "57";
            tran_table[81, 1] = "82";
            tran_table[93, 1] = "94";
            tran_table[101, 1] = "102";
            tran_table[1, 2] = "20";
            tran_table[34, 2] = "35";
            tran_table[80, 2] = "81";
            tran_table[1, 3] = "67";
            tran_table[62, 3] = "63";
            tran_table[1, 4] = "61";
            tran_table[2, 4] = "3";
            tran_table[14, 4] = "15";
            tran_table[17, 4] = "18";
            tran_table[27, 4] = "28";
            tran_table[33, 4] = "34";
            tran_table[37, 4] = "38";
            tran_table[42, 4] = "43";
            tran_table[65, 4] = "66";
            tran_table[67, 4] = "68";
            tran_table[71, 4] = "72";
            tran_table[75, 4] = "76";
            tran_table[96, 4] = "97";
            tran_table[103, 4] = "104";
            tran_table[53, 5] = "54";
            tran_table[55, 5] = "60";
            tran_table[58, 5] = "59";
            tran_table[28, 6] = "29";
            tran_table[78, 6] = "79";
            tran_table[91, 6] = "92";
            tran_table[128, 6] = "129";
            tran_table[9, 7] = "10";
            tran_table[16, 7] = "17";
            tran_table[20, 7] = "33";
            tran_table[105, 7] = "106";
            tran_table[105, 7] = "106";
            tran_table[1, 8] = "55";
            tran_table[7, 8] = "8";
            tran_table[23, 8] = "24";
            tran_table[37, 8] = "45";
            tran_table[41, 8] = "42";
            tran_table[49, 8] = "50";
            tran_table[69, 8] = "70";
            tran_table[79, 8] = "80";
            tran_table[82, 8] = "83";
            tran_table[99, 8] = "100";
            tran_table[106, 8] = "107";
            tran_table[126, 8] = "127";
            tran_table[35, 9] = "36";
            tran_table[1, 10] = "77";
            tran_table[4, 10] = "5";
            tran_table[20, 10] = "38";
            tran_table[45, 10] = "56";
            tran_table[55, 10] = "56";
            tran_table[61, 10] = "64";
            tran_table[94, 11] = "95";
            tran_table[98, 11] = "99";
            tran_table[1, 12] = "73";
            tran_table[18, 12] = "19";
            tran_table[21, 12] = "22";
            tran_table[24, 12] = "25";
            tran_table[51, 12] = "52";
            tran_table[61, 12] = "62";
            tran_table[74, 12] = "75";
            tran_table[100, 12] = "101";
            tran_table[127, 12] = "128";
            tran_table[2, 13] = "11";
            tran_table[20, 13] = "21";
            tran_table[29, 13] = "30";
            tran_table[38, 13] = "39";
            tran_table[50, 13] = "51";
            tran_table[52, 13] = "53";
            tran_table[73, 13] = "74";
            tran_table[77, 13] = "78";
            tran_table[90, 13] = "91";
            tran_table[1, 14] = "89";
            tran_table[3, 14] = "4";
            tran_table[39, 14] = "40";
            tran_table[57, 14] = "58";
            tran_table[1, 15] = "2";
            tran_table[30, 15] = "31";
            tran_table[38, 15] = "41";
            tran_table[68, 15] = "69";
            tran_table[89, 15] = "90";
            tran_table[92, 15] = "93";
            tran_table[97, 15] = "98";
            tran_table[1, 16] = "37";
            tran_table[43, 16] = "44";
            tran_table[64, 16] = "65";
            tran_table[107, 16] = "108";
            tran_table[125, 16] = "126";
            tran_table[1, 17] = "96";
            tran_table[8, 17] = "9";
            tran_table[11, 17] = "12";
            tran_table[13, 17] = "14";
            tran_table[22, 17] = "23";
            tran_table[26, 17] = "27";
            tran_table[45, 17] = "46";
            tran_table[48, 17] = "49";
            tran_table[102, 17] = "103";
            tran_table[104, 17] = "105";
            tran_table[1, 18] = "125";
            tran_table[25, 18] = "14";
            tran_table[46, 18] = "47";
            tran_table[70, 19] = "71";
            tran_table[6, 20] = "7";
            tran_table[15, 20] = "16";
            tran_table[5, 21] = "6";
            tran_table[31, 21] = "32";
            tran_table[1, 22] = "114";
            tran_table[1, 23] = "115";
            tran_table[1, 24] = "112";
            tran_table[1, 25] = "111";
            tran_table[1, 26] = "109";
            tran_table[1, 27] = "110";
            tran_table[1, 28] = "88";
            tran_table[1, 29] = "118";
            tran_table[118, 29] = "120";
            tran_table[123, 29] = "124";
            tran_table[1, 30] = "118";
            tran_table[1, 31] = "118";
            tran_table[1, 32] = "123";
            tran_table[1, 33] = "121";
            tran_table[121, 33] = "122";
            tran_table[1, 34] = "116";
            tran_table[116, 34] = "117";
            tran_table[1, 35] = "113";
            tran_table[1, 36] = "87";
            tran_table[1, 37] = "85";
            tran_table[1, 38] = "84";
            tran_table[1, 39] = "86";
        }

        static public bool IsDigit(List<char> str)
        {
            char[] s = str.ToArray();
            int flag = 0;
            bool isDigit = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    flag++;
                }

            }
            if (flag == s.Length)
            {
                isDigit = true;
            }
            return isDigit;

        }
        static public bool IsIdentifier(List<char> str)
        {
            bool IsIdentifier = false;

            char[] s = str.ToArray();
            if (((s[0] >= 'a' && s[0] <= 'z')
                  || (s[0] >= 'A' && s[0] <= 'Z')
                  || s[0] == '_')&& !(s[0] >= '0' && s[0] <= '9') )
            {
                IsIdentifier = true;

                for (int i = 1; i < s.Length; i++)
                {
                    if (((s[i] >= 'a' && s[i] <= 'z')
                          || (s[i] >= 'A' && s[i] <= 'Z')
                          || (s[i] >= '0' && s[i] <= '9')
                          || s[i] == '_'))
                    {
                        IsIdentifier = true;
                    }
                    else
                    {
                        IsIdentifier = false;
                        break;
                    }

                }
            }


            return IsIdentifier;

        }
        static public bool Contains(int acceptant_state)
        {
            bool there = false;
            foreach (List<string> myList in Token)
            {
             
                if (Convert.ToInt32( myList[0]) == acceptant_state)
                {
                    there=true;
                }
            }
                return there;
        }

        static public int IndexOfToken(char ch)
        {
            int flag = -1;
            for (int i = 1; i < colLength; i++)
            {
                if (ch == Convert.ToChar(tran_table[0, i]))
                {
                    flag = 1;
                    return i;
                }

            }
            if (flag == -1)
            {
                return flag;
            }
            return 0;
        }

        public static int check(string text)
        {
            int line = 1;
            char[] charArr = text.ToCharArray();
            int next_state = 1, x, errorCount = 0, temp = 0, j = 0,temp2=0;
            List<char> s = new List<char>();
            char next_ch, curr_ch, prev_ch;
            int comment_flag = 0;
            for (int i = 0; i < charArr.Length && temp < charArr.Length; i++)
            {
                temp = i; temp++;
                temp = i; temp--;
                curr_ch = charArr[i];
                s.Add(curr_ch);
                if (curr_ch == '\n')
                {

                    line++;
                }

                if (i == charArr.Length - 1)
                {

                    if (curr_ch == '\n' || curr_ch == '\t' || curr_ch == ' ')
                    {

                        break;
                    }

                    else
                    {

                        if (IndexOfToken(curr_ch) != -1 && Contains(Convert.ToInt32(tran_table[next_state, IndexOfToken(curr_ch)])))
                        {

                            string str_line = line.ToString();
                            var myString = string.Join("", s);
                            next_state = Convert.ToInt32(tran_table[next_state, IndexOfToken(curr_ch)]);
                            Entered_token.Add(new List<string> { next_state.ToString(), myString, str_line });
                            next_state = 1;

                        }
                        else if ((comment_flag == 1 && curr_ch == '>')|| comment_flag == 1)
                        {
                            next_state = 1;
                            s.Clear();
                            continue;
                        }
                        else if (IsDigit(s))
                        {
                            string str_line = line.ToString();
                            var myString = string.Join("", s);

                            Entered_token.Add(new List<string> { "131", myString, str_line });
                            next_state = 1;
                        }
                        else if (IsIdentifier(s))
                        {
                            string str_line = line.ToString();
                            var myString = string.Join("", s);
                            Entered_token.Add(new List<string> { "130", myString, str_line });
                            next_state = 1;
                        }


                        else
                        {
                            errorCount++;
                        }



                    }

                }

                else
                {

                    next_ch = charArr[temp];

                    if (curr_ch == '\n' || curr_ch == '\t' || curr_ch == ' ')
                    {
                        next_state = 1;
                        s.Clear();
                        continue;
                    }

                    else if ((curr_ch == '<' && next_ch == '*') ||(curr_ch == '-' && next_ch == '-'))
                    {
                        comment_flag = 1;
                    }
                    else if (next_ch == '\n' || next_ch == '\t' || next_ch == ' ')
                    {

                        if (IndexOfToken(curr_ch) != -1 && Contains(Convert.ToInt32(tran_table[next_state, IndexOfToken(curr_ch)])))
                        {


                            string str_line = line.ToString();
                            var myString = string.Join("", s);
                            next_state = Convert.ToInt32(tran_table[next_state, IndexOfToken(curr_ch)]);
                            Entered_token.Add(new List<string> { next_state.ToString(), myString, str_line });
                            next_state = 1;

                        }
                        
                        else if ((comment_flag == 1 && curr_ch == '>') || comment_flag == 1)
                        {

                            next_state = 1;
                            s.Clear();
                            continue;
                        }
                        else if (IsDigit(s))
                        {

                            string str_line = line.ToString();
                            var myString = string.Join("", s);

                            Entered_token.Add(new List<string> { "131", myString, str_line });
                            next_state = 1;
                        }
                        else if (IsIdentifier(s))
                        {

                            string str_line = line.ToString();
                            var myString = string.Join("", s);
                            Entered_token.Add(new List<string> { "130", myString, str_line });
                            next_state = 1;
                        }
                        else
                        {

                            next_state = 1;
                            errorCount++;
                        }
                    }
                    else if (IndexOfToken(curr_ch) != -1)
                    {
                        x = IndexOfToken(curr_ch);
                        next_state = Convert.ToInt32(tran_table[next_state, x]);
                       
                    }
                    if (next_state == 0)
                    {
                        next_state = 1;
                        continue;
                    }

                }
            }
            return errorCount;
        }

        static void Main(string[] args)
        {

            transition_table();
            File.WriteAllText("program5.txt", "<*dfa>");
            string s = File.ReadAllText("program5.txt");




            Dictionary();
            int counter = 0, error_count, line = 0;


            error_count = check(s);
            foreach (List<string> myList in Entered_token)
            {
                foreach (List<string> token_type in Token)
                {
                    line = Convert.ToInt32(myList[2]);
                    String Text_Token_Value = myList[1];
                    int key = Convert.ToInt32(myList[0]);
                    int token_type_Key = Convert.ToInt32(token_type[0]);
                    if (token_type_Key == key && (Text_Token_Value == token_type[1]))
                    {

                        Console.WriteLine("Line : {0} Token Text: {1} Token Type: {2}", line, Text_Token_Value, token_type[2]);
                        break;
                    }
                    else if (token_type_Key == key && key == 130)
                    {
                        Console.WriteLine("Line : {0} Token Text: {1} Token Type: {2}", line, Text_Token_Value, token_type[1]);
                        break;
                    }
                    else if (token_type_Key == key && key == 131)
                    {
                        Console.WriteLine("Line : {0} Token Text: {1} Token Type: {2}", line, Text_Token_Value, token_type[1]);
                        break;
                    }

                }
            }

                Console.WriteLine("Total NO of errors: {0}", error_count);

                Console.ReadKey();
                // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
            }
        }
    }

