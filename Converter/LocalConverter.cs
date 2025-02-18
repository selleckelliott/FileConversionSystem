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

namespace FileConversionSystem.Converter
{
  public class LocalConverter : IConverter
  {
    internal static void Convert(string[] args)
    {
      throw new NotImplementedException();
    }

    public string Convert(string inputFilePath)
    {
      string outFile = null;

      if (inputFilePath.EndsWith(".docx", StringComparison.OrdinalIgnoreCase))
      {
        outFile = docxConvertToPdf(inputFilePath);
      }
      else if (inputFilePath.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
      {
        outFile = pdfConvertToDocx(inputFilePath);
      }
      else
      {
        throw new NotSupportedException("Unsupported file type.");
      }
      return outFile;
    }
    private string docxConvertToPdf(string docxFile)
    {
      Document document = new Document();
      document.LoadFromFile(docxFile);
      string outputFilePath = docxFile.Replace(".docx", ".pdf");
      document.SaveToFile(outputFilePath, FileFormat.PDF);
      return outputFilePath;
    }

    private string pdfConvertToDocx(string pdfFile)
    {
      Document document = new Document();
      document.LoadFromFile(pdfFile);
      string outputFilePath = pdfFile.Replace(".pdf", ".docx");
      document.SaveToFile(outputFilePath, FileFormat.Docx);
      return outputFilePath;
    }
  }
}
