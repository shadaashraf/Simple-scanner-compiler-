# Retrieval System

## Overview
This project implements a Document Retrieval System, allowing users to search and analyze documents efficiently. It employs various text processing techniques such as tokenization, stop-word removal, and TF-IDF weighting to enhance document retrieval accuracy.

## Getting Started
Ensure you have Python 3.x installed on your system along with the required dependencies.

## Project Structure
The project is organized as follows:
1. **Main Script (`main.py`):** Contains the core functionality of the Document Retrieval System, including tokenization, stop-word removal, TF-IDF computation, and cosine similarity calculation.
2. **Data Folder (`DocumentCollection/`):** Contains the collection of documents (in .txt format) to be indexed and searched.

## Usage
1. **Indexing Documents:** Place your text documents in the `DocumentCollection` folder. Run the `main.py` script to index these documents and prepare them for retrieval.
2. **Querying Documents:** Once the documents are indexed, users can input search queries. The system will return relevant documents based on the provided query.

## Features
- **Tokenization:** Breaks down documents into individual words or tokens.
- **Stop-word Removal:** Removes common words (e.g., "the," "is") that do not contribute significantly to document relevance.

## Contributing
Contributions to this project are welcome! You can contribute by adding new features, fixing bugs, improving documentation, or enhancing performance. Fork the repository, make your changes, and submit a pull request.
