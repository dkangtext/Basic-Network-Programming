# Basic Network Programming

A comprehensive collection of C# Windows Forms applications demonstrating fundamental network programming concepts, file I/O operations, and email handling.

## 📖 Overview

This repository contains practical exercises and assignments for learning basic network programming concepts using C#. The projects cover various aspects of network programming including socket programming, web servers, email handling, and file operations.

## 📁 Folder Structure

```
Basic-Network-Programming/
├── 📁 practice/
│   ├── 📁 lab1/
│   ├── 📁 lab2/
│   ├── 📁 lab3/
│   ├── 📁 lab4/
│   ├── 📁 lab5/
│   └── 📁 lab6/
├── 📁 assignment/
│   ├── 📁 assignment1/
│   └── 📁 assignment2/
│   └── 📁 assignment3/
│   └── 📁 firebase-webservices/
│   └── 📁 roadmap/
├── 📁 slides/
│   ├── 📄 Lab 01 - Introduction to C# and Windows Forms.pdf
│   ├── 📄 Lab 02 - File and Stream IO in C# - V2019.pdf
│   ├── 📄 Lab 03 - Working with Sockets in C# - 2019.pdf
│   ├── 📄 Lab 04 - Working with Web Server in C.pdf
│   ├── 📄 Lab 05 - Sending Receiving Email in C# - v2021.pdf
│   └── 📄 Lab 06 - Comprehensive Exercises.pdf
└── 📄 README.md
```

## 🗂️ Project Structure

### Practice Labs (`practice/`)
- **Lab 1**: Introduction to C# and Windows Forms
- **Lab 2**: File and Stream I/O in C#
- **Lab 3**: Working with Sockets in C#
- **Lab 4**: Working with Web Servers in C#
- **Lab 5**: Sending & Receiving Email in C#
- **Lab 6**: Comprehensive Exercises

### Documentation (`slides/`)
- Complete PDF guides for each lab session
- Step-by-step instructions and theoretical materials

## 🚀 Features

### File Operations
- Read and write text files with proper encoding
- File statistics calculation (lines, words, characters)  
- Excel file generation and data export
- Stream handling and file manipulation

### Email Functionality
- Connect to IMAP servers (Gmail, MDaemon)
- Retrieve email lists with subject, sender, and date
- Filter emails by date range (last 3 days)
- Display email statistics (total count, recent messages)

### Web Operations
- Download web page content
- View HTML source code
- Save web pages to local files

### Form Controls
- Rich text editors for content display
- Data grid views for structured data
- File dialogs for file operations
- Progress indicators and status updates

## 🛠️ Technologies Used

- **Language**: C#
- **Framework**: .NET Windows Forms (.NET 9.0 / .NET Framework 4.x)
- **Email Library**: MailKit for IMAP/SMTP operations
- **Excel Operations**: DocumentFormat.OpenXml
- **File I/O**: System.IO namespace
- **Network**: System.Net namespace

## 📋 Requirements

- Visual Studio 2019 or later
- .NET Framework 4.7.2+ or .NET 6.0+
- NuGet packages:
  - MailKit (for email operations)
  - DocumentFormat.OpenXml (for Excel operations)

## 🔧 Setup and Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/Basic-Network-Programming.git
   ```

2. Open the solution files in Visual Studio

3. Restore NuGet packages:
   ```bash
   dotnet restore
   ```

4. Build and run the desired project

## 💡 Usage Examples

### Email Client ([`Lab5_Bai4.cs`](practice/lab5/Project5/Lab5_Bai4.cs))
```csharp
// Connect to Gmail and retrieve emails from last 3 days
private void ReadGmailWithMailKit(string email, string password)
{
    DateTime threeDaysAgo = DateTime.Now.AddDays(-3);
    var query = SearchQuery.DeliveredAfter(threeDaysAgo);
    var results = inbox.Search(query);
    // Display results in DataGridView
}
```

### File Operations ([`Lab2_Bai1.cs`](practice/lab2/Project2/Lab2_Bai1.cs))
```csharp
// Read file content and display
OpenFileDialog ofd = new OpenFileDialog();
ofd.ShowDialog();
StreamReader sr = new StreamReader(ofd.FileName);
string content = sr.ReadToEnd();
richTextBox1.Text = content;
```

### File Writing ([`Lab2_Bai3.cs`](practice/lab2/Project2/Lab2_Bai3.cs))
```csharp
// Write content to file with UTF-8 encoding
SaveFileDialog sfd = new SaveFileDialog();
sfd.Filter = "Text (*.txt) | *.txt";
FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
byte[] ct = Encoding.UTF8.GetBytes(richTextBox2.Text);
fs.Write(ct, 0, ct.Length);
```

## 🎯 Learning Objectives

- Understand Windows Forms application development
- Master file I/O operations and stream handling
- Learn socket programming fundamentals
- Implement email clients using IMAP/SMTP protocols
- Work with web servers and HTTP requests
- Handle data serialization and file formats

## 📚 Course Materials

Each lab includes PDF documentation with detailed instructions:
- Lab 01 - Introduction to C# and Windows Forms.pdf
- Lab 02 - File and Stream IO in C# - V2019.pdf
- Lab 03 - Working with Sockets in C# - 2019.pdf
- Lab 04 - Working with Web Server in C.pdf
- Lab 05 - Sending Receiving Email in C# - v2021.pdf
- Lab 06 - Comprehensive Exercises.pdf

## 🤝 Contributing

This is an educational project. Feel free to:
- Report bugs or issues
- Suggest improvements
- Add new features or examples
- Enhance documentation

## 📄 License

This project is for educational purposes. Please check with your institution regarding usage and distribution policies.

## 📞 Support

For questions or issues related to the exercises, please refer to the course materials or contact your instructor.

---

**Note**: This repository contains coursework for Basic Network Programming. All implementations are for learning purposes and may require additional security considerations for production use.