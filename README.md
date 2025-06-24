# 🛠️ Command-Line Tool

A lightweight, object-oriented command-line utility built as an interview task. It showcases clean design, modular architecture, and the ability to parse and process various parameters — all **without external libraries or frameworks**.

---

## 📌 Overview

This project demonstrates a basic but extendable **command-line tool** that performs parsing operations based on provided flags. The implementation emphasizes:

- 🧱 Object-Oriented Design Principles
- 📦 Clean Code Practices
- ♻️ Extensibility Without Dependencies

---

## 📋 Task Description

Create a program that:

- Accepts **command-line input**
- Parses dynamic parameters
- Performs specific operations
- Follows a **modular, maintainable design**

---

## ✅ Requirements

- 🔧 **Dynamic Parameter Handling** – No hard-coded inputs  
- 🧠 **OOP Principles** – Encapsulation, abstraction, modularity  
- 📝 **Meaningful Comments** – Explain logic where needed  
- 🧩 **Extensible Architecture** – Easy to add new features  
- 🚫 **No External Libraries** – Pure standard language features

---

## ⚙️ Supported Operations

### ➕ `-a [Value 1] [Value 2]`
**Add two numbers.**

- **Input:** Two numeric values  
- **Example:**  
  ```bash
  -a 5 6
- **Output:**
  ```bash
  The sum of 5 and 6 is 11.

### ✂️ `-b [Value 1] [Value 2]`
**Remove a specific character from a string.**

- **Input:**
  Value 1: A string
  Value 2: A single character

- **Example:**
  ```bash
  -b "Microsoft" "t"
- **Output:**
  ```bash
  "Microsoft" without "t" results in "Microsf."
  
### 🧮 -c `[Value 1] [Value 2]`
**Exponentiation: Raise Value 1 to the power of Value 2.**

- **Input:**
  Value 1: Base (number)
  Value 2: Exponent (natural number)

- **Example:**
  ```bash
  -c 2 3
- **Output:**
  ```bash
  2 raised to the power of 3 is 8.

### 🚀 How to Run the Program
1. Clone the repository to your local machine.
2. Compile the code using an appropriate compiler or interpreter based on the programming language used.
3. Execute the program by running the following commands:

```bash
<program_name> -a 5 6
<program_name> -b "Microsoft" "t"
<program_name> -c 2 3
```
The appropriate output will be printed to the console based on the input provided.

### ➕ Extending the Tool
To add support for new operations (e.g., -d), follow these simple steps:

1. Create a new method to handle the operation in a modular class.
2. Update the parameter-operation mapping to include the new command-line argument (-d).
3. Ensure proper input validation and error handling for the new operation.
4. This modular approach ensures the tool remains scalable and maintainable for future requirements.

### 💡 Notes
This program has been designed as a basic interview task to showcase:

1. Coding fundamentals: Clarity, modularity, and object-oriented principles.
2. Problem-solving skills: Building extensible systems from scratch.
3. Practical design: Scalability for future changes.
4. While simplistic in scope, it aims to demonstrate clean design, readability, and flexibility.
