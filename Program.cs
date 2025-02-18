using FileConversionSystem.FileType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Spire.Doc;
using Document = Spire.Doc.Document;
using Microsoft.VisualBasic;
using FileConversionSystem.Converter;
using Spire.Additions.Chrome;

namespace FileConversionSystem
{
  public class Program
  {
    public static void Main()
    {
      LocalConverter localConverter = new LocalConverter();
      
      //Note: When entering the file patch, be sure to remove the quotations (" ").
      Console.WriteLine("Enter the full path of the file you want to convert:");
      string inputFile = Console.ReadLine();

      if (!File.Exists(inputFile))
      {
        Console.WriteLine("Error: File not found. Please check the path and try again.");
        return;
      }

      try
      {
        string outputFile = localConverter.Convert(inputFile);
        Console.WriteLine($"Conversion successful! Output file: {outputFile}");
      }
      catch (NotSupportedException ex)
      {
        Console.WriteLine($"File Not Supported Error: {ex.Message}");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
    }
  }
}