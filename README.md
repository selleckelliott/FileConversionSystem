# File Conversion System

## Overview
This **File Conversion System** is implemented using the **Bridge Pattern**, allowing file types and conversion methods to vary independently. The system currently supports:

- **DOCX to PDF Conversion**
- **PDF to DOCX Conversion**
- **Exception Handling for Unsupported File Types**

## Features
✔ Implements the **Bridge Pattern** to decouple file types from conversion methods.  
✔ Uses **Spire.Doc** for real file conversion.  
✔ Provides **robust error handling** for unsupported file formats.  
✔ Accepts **user input** for file paths and ensures files exist before conversion.  

## Installation

### Prerequisites
- **.NET 6.0 or later**
- **NuGet Packages:**
  - [Spire.Doc](https://www.nuget.org/packages/Spire.Doc/)

### Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/YourUsername/FileConversionSystem.git
   cd FileConversionSystem
   ```
2. Install dependencies:
   ```bash
   dotnet add package Spire.Doc
   ```
3. Build and run the program:
   ```bash
   dotnet run
   ```

## Usage

1. Run the application.
2. When prompted, enter the full path of the file you want to convert.
3. The system will determine the file type and convert it to the appropriate format.
4. If the file type is not supported, an error message will be displayed.

### **Example Output**
```
Enter the full path of the file you want to convert:
C:\Users\selliott\Documents\example.docx
Conversion successful! Output file: C:\Users\selliott\Documents\example.pdf
```

## Project Structure
```
FileConversionSystem
├── Program.cs
├── Converter
│   ├── IConverter.cs (Interface for conversion methods)
│   ├── LocalConverter.cs (Concrete implementation using Spire.Doc)
├── FileType
│   ├── FileType.cs (Abstract class representing file types)
│   ├── PdfFile.cs (Represents a PDF file)
│   ├── DocxFile.cs (Represents a DOCX file)
```

## Error Handling
- If the user provides an invalid file path, the program displays: `Error: File not found.`
- If the file format is not supported, the program throws a `NotSupportedException`.

## Future Enhancements
🔹 Support for more file formats (e.g., TXT, PPTX)  
🔹 Integration with **cloud-based file conversion APIs**  
🔹 GUI interface for better user experience  

## License
This project is licensed under the MIT License. See `LICENSE` for details.
