# Scanner Component in C#

This is a scanner component implemented in C# for lexical analysis in compilers. The scanner recognizes tokens in the input source code and categorizes them based on predefined patterns.

## Overview

The scanner component consists of two main parts:
1. **Transition Table:** A transition table implemented as a two-dimensional array to define the state transitions for recognizing tokens.
2. **Dictionary:** A dictionary that maps token types to their respective values.

## Implementation Details

### Transition Table
The transition table defines the state transitions for recognizing tokens. It is implemented as a two-dimensional array where each cell represents a transition from one state to another based on the input character.

### Dictionary
The dictionary maps token types to their respective values. Each token type is associated with a unique identifier and a category.

## How to Use

1. **Input File:** Provide the input source code file (`program5.txt`) to the scanner component.
2. **Execution:** Run the `Main` method in the `Program` class. The scanner will process the input file and output the recognized tokens along with their types.
3. **Output:** The scanner will display the recognized tokens with their corresponding types and line numbers. Additionally, it will report the total number of errors encountered during scanning.

## Usage Example

```csharp
// Example usage:
// Initialize the scanner
transition_table();
Dictionary();

// Read input source code file
string inputCode = File.ReadAllText("program5.txt");

// Perform lexical analysis
int errorCount = check(inputCode);

// Display recognized tokens
foreach (List<string> token in Entered_token)
{
    // Display token information
    Console.WriteLine($"Line: {token[2]} Token Text: {token[1]} Token Type: {GetTokenType(token)}");
}

// Display total number of errors
Console.WriteLine($"Total Number of Errors: {errorCount}");
