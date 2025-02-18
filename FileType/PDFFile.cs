using FileConversionSystem.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConversionSystem.FileType
{
  public class PDFFile : FileType
  {
    public PDFFile(IConverter converter) : base(converter) { }

    public override string ConvertFile(string content)
    {
      return _converter.Convert(content);
    }
  }
}
