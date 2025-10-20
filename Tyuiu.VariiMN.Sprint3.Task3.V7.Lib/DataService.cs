using System.IO.Compression;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VariiMN.Sprint3.Task3.V7.Lib
{
    public class DataService : ISprint3Task3V7
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            foreach (char iz in value)
            {
                if (iz == replaceable)
                {
                    value = value.Replace(iz, replacement);
                }
            }
            return value;
        }
    }
}
