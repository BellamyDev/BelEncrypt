# BelEncrypt

BelEncrypt is a command-line encryption tool written in C#. It converts text into a series of encrypted codes based on a custom letter-to-code mapping. The program supports both uppercase and lowercase letters by converting all letters to lowercase before encryption. It also offers a verbose mode for detailed operation logging.

---

## Features

- **Custom Encryption Mapping:**  
  Each letter is replaced by its corresponding encryption code as defined below.

- **Case Support:**  
  BelEncrypt accepts both uppercase and lowercase letters. All letters are converted to lowercase prior to encryption.

- **Verbose Mode:**  
  Enable verbose mode to see detailed processing information and encryption steps.

- **CLI Application:**  
  Designed for use in the terminal or command prompt.

---

## Encryption Mapping

The encryption mapping for the English alphabet is as follows (all letters are converted to lowercase prior to encryption):

| Letter | Encrypted Code |
| ------ | -------------- |
| a | `0x13r` |
| b | `0x24y` |
| c | `0x35x` |
| d | `0x46w` |
| e | `0x57v` |
| f | `0x68u` |
| g | `0x79t` |
| h | `0x80s` |
| i | `0x91r` |
| j | `0x02q` |
| k | `0x13p` |
| l | `0x24o` |
| m | `0x35n` |
| n | `0x46m` |
| o | `0x57l` |
| p | `0x68k` |
| q | `0x79j` |
| r | `0x80i` |
| s | `0x91h` |
| t | `0x02g` |
| u | `0x13f` |
| v | `0x24e` |
| w | `0x35d` |
| x | `0x46c` |
| y | `0x57b` |
| z | `0x68a` |

---

## How It Works

1. **Input:**  
   The program accepts a string of text via command-line arguments.

2. **Encryption:**  
   All alphabetic characters are converted to lowercase. Each letter is then replaced with its corresponding encryption code from the mapping. Non-alphabetic characters are typically left unchanged unless otherwise specified.

3. **Output:**  
   The result is printed to the console as a concatenation of encrypted codes. In verbose mode, additional processing details are provided.

---

## Installation

1. **Prerequisites:**  
   - [.NET SDK](https://dotnet.microsoft.com/download) (version 5.0 or later)

2. **Building the Project:**
   - Clone or download the BelEncrypt source code.
   - Open a terminal in the project directory.
   - Build the project using the following command:
     ```bash
     dotnet build
     ```

---

## Usage

After building the project, you can run BelEncrypt from the command line.

