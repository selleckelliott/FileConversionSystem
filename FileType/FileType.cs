using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileConversionSystem.Converter;

namespace FileConversionSystem.FileType
{
  public abstract class FileType
  {
    protected readonly IConverter _converter;
    protected FileType(IConverter converter)
    {
      _converter = converter;
    }
    public abstract string ConvertFile(string content);
  }
}
