📄 README.md for C# Basics Project
# 🚀 C# Basics Project
Welcome to the **C# Basics Project**! This project demonstrates fundamental C# concepts, including variables, data types, conditions, loops, strings, and user input. It’s perfect for beginners looking to understand the core of C# programming.

---

## 🎯 **Project Overview**
This project covers the following C# basics:
1. **Variables & Data Types:** Store and manipulate data.  
2. **Strings & String Operations:** Access, modify, and search within strings.  
3. **Boolean Expressions:** Evaluate conditions as `true` or `false`.  
4. **Conditional Statements:** Use `if`, `else`, and ternary operators.  
5. **Switch Statements:** Handle multiple conditions efficiently.  
6. **Loops:** Implement `while`, `do-while`, and `for` loops.  
7. **User Input:** Interact with users through the console.  

---


## 📦 **Folder Structure**
📦 CSharpBasics ├─ 📜 Program.cs # Main application file ├─ 📜 README.md # Project documentation └─ 📜 Examples.cs # Code snippets for different concepts


---

## 🖥️ **Key Concepts & Examples**
### 📝 **1. Variables & Data Types**
```csharp
int age = 25;           // Integer
double price = 19.99;   // Decimal number
string name = "John";   // Text
bool isStudent = true;  // Boolean

Console.WriteLine($"Name: {name}, Age: {age}, Price: {price}, Student: {isStudent}");


---

🔡 2. String Operations
string greeting = "Hello, C#!";
Console.WriteLine(greeting[0]);          // Access first character: 'H'
Console.WriteLine(greeting.IndexOf('C'));// Find index of 'C': 7
Console.WriteLine(greeting.Substring(7));// Extract substring: "C#!"

⚖️ 3. Boolean Expressions
int x = 10, y = 5;
Console.WriteLine(x > y);    // True
Console.WriteLine(x == 10);  // True
Console.WriteLine(10 != 5);  // True

❓ 4. If-Else & Ternary Operator
int score = 85;
string result = (score >= 50) ? "Pass" : "Fail";
Console.WriteLine(result);   // Output: Pass

🔀 5. Switch Statement
int day = 3;
switch (day)
{
    case 1: Console.WriteLine("Monday"); break;
    case 2: Console.WriteLine("Tuesday"); break;
    default: Console.WriteLine("Other day"); break;
}

🔄 6. While & Do-While Loops
int i = 0;
while (i < 3)
{
    Console.WriteLine(i);    // Outputs 0, 1, 2
    i++;
}

int j = 5;
do
{
    Console.WriteLine(j);    // Outputs 5 once, even if condition is false
} while (j < 5);

⌨️ 7. User Input
Console.Write("Enter your name: ");
string userName = Console.ReadLine();
Console.WriteLine($"Hello, {userName}!");

⚙️ Setup & Run
Clone the Repository:
git clone https://github.com/your-username/csharp-basics.git

Open in Visual Studio:
Open the .sln file or project folder.
Restore NuGet packages if required.
Run the App:
Press F5 in Visual Studio or use the terminal:
dotnet run

🤝 Contributing
Feel free to contribute by adding more C# examples, improving documentation, or fixing bugs.

Fork the repo.
Create a new branch: git checkout -b feature-new-concept.
Make changes and commit: git commit -m "Add new C# example".
Push the branch and create a PR.

📬 Contact
👤 Developer: Georges
📧 Email: georgeklangat@gmail.com
🌐 GitHub: https://github.com/georgeklangat

Enjoy learning C#! 😊

⭐ If you found this project helpful, please give it a star! 🌟


---

Would you like me to add **advanced C# concepts**, **screenshots**, or **compilation instructions**? 😊






