using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_communication
{
    public class Kata5
    {
        public static string ConvertToCipher(string input)
        {
            string inputLowerCase = input.ToLower();

            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in inputLowerCase)
            {
                int code = (int)c;

                if(code >= 97 && code <= 122)
                {
                    code += 13;

                    if (code > 122)
                    {
                        code -= 26;
                    } 
                }
                char charToAppend = (char)code;

                stringBuilder.Append(charToAppend);
            }
            string output = stringBuilder.ToString();

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsUpper(input[i]))
                {
                    output = output.Remove(i, 1).Insert(i, Char.ToUpper(output[i]).ToString());
                }
            }

            return output;
        }
    }
}
