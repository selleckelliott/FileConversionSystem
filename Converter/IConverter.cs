using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConversionSystem.Converter
{
  public interface IConverter
  {
    string Convert(string content);
  }
}
