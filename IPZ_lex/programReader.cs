using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPZ_lex
{
    class programReader
    {
        List<string> programWords = new List<string>(); // all words in my program

        public void reader (string programText)
        {
            string expression = "";
            bool declarationSymbol = true;
            foreach (char i in programText)
            {
                if (!((((int)i >= 48) && ((int)i <= 90)) || (((int)i == 32) || ((int)i >= 9) && (int)i <= 13)))
                    declarationSymbol = false;

                if (((int)i == 32) || ((int)i >= 9) && (int)i <= 13)
                {
                    if (declarationSymbol)
                    {
                        programWords.Add(expression);
                        expression = "";
                    }
                    else
                    {
                        programWords.Add("Error! Unknown symbol");
                        expression = "";
                        declarationSymbol = true;
                    }
                }
                else if ((i == ',') || (i == '.') || (i == ';'))
                {
                    if (declarationSymbol)
                    {
                        programWords.Add(expression);
                        expression = "";
                    }
                    else
                    {
                        programWords.Add("Error! Unknown symbol");
                        expression = "";
                        declarationSymbol = true;
                    }
                        programWords.Add(i+"");
                }
                else
                {

                    expression += i; 
                }
            }
        }


    }
}
