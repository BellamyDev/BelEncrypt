# BelEncrypt

BelEncrypt is a command-line encryption tool written in C#. It converts text into a series of encrypted codes based on a custom letter-to-code mapping. The program supports both encryption and decryption. It accepts both uppercase and lowercase letters (converting all letters to lowercase before processing) and offers a verbose mode for detailed operation logging.

---

## Features

- **Custom Encryption Mapping:**  
  Each letter is replaced by its corresponding encryption code as defined below.

- **Case Support:**  
  BelEncrypt accepts both uppercase and lowercase letters. All letters are converted to lowercase before processing.

- **Encryption & Decryption:**  
  Users can choose to encrypt or decrypt text.

- **Interactive CLI Menu:**  
  The program presents a main menu to select options, then prompts for the text input, and finally returns to the main menu once the operation is complete.

- **Verbose Mode:**  
  Enable verbose mode to view detailed processing information and encryption/decryption steps.

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

1. **Main Menu Prompt:**  
   When you run BelEncrypt, the program displays an interactive main menu with options such as "Encrypt," "Decrypt," and "Exit."

2. **Option Selection:**  
   Choose the desired operation (encryption or decryption) by entering the corresponding option.

3. **Text Input:**  
   The program then prompts you to enter the text you wish to process. For encryption, all alphabetic characters are converted to lowercase and then each letter is replaced with its corresponding encryption code. For decryption, the program reverses the encryption process based on the mapping.

4. **Result Display:**  
   After processing, the resulting encrypted or decrypted text is displayed on the console. If verbose mode is enabled, additional details about the processing steps are shown.

5. **Return to Main Menu:**  
   Once the operation is complete, the program returns to the main menu, allowing you to perform additional encryptions or decryptions or to exit the application.

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


