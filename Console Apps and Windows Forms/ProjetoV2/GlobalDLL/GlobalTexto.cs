using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalDLL
{
    public class GlobalTexto
    {

        public static string Format(string text, params object[] parameters)
        {
            string result = text;

            if (parameters != null && parameters.Count() > 0)
            {
                int index = 0;
                foreach (var parameter in parameters)
                {
                    if (parameter != null)
                    {
                        string indexText = "{" + index.ToString() + "}";

                        if (result.Contains(indexText))
                        {
                            result = result.Replace(indexText, parameter.ToString());
                        }
                    }
                    index++;
                }
            }

            return result;
        }

    }
}
