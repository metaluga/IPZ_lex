using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPZ_lex
{
    class programReader
    {
        public static List<string> programWords = new List<string>(); // all words in my program

        public static void reader (string programText)
        {
            bool halfComent = false , coment = false;
            string expression = "";
            bool declarationSymbol = true;
            foreach (char i in programText)
            {

                //----coment deleted start -----
              /*  if (coment && !halfComent)
                    if (i==')')
                    {
                        coment = false;
                        continue;
                    }
                    else
                    {
                        halfComent = true;
                    }



                if (coment)
                {
                    if (i != '*')
                        continue;
                    else
                        halfComent = false;
                }

                if ((i=='*') && halfComent)
                {
                    coment = true;
                    continue;
                }
                else
                {
                    expression += '(';
                }

                if (i == '(')
                {
                    halfComent = true;
                    continue;
                }
                */
                //-------coment del finish------

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
                        programWords.Add("Error");
                        expression = "";
                        declarationSymbol = true;
                    }
                }
                else if ((i == ',') || (i == '.') || (i == ';') || (i == ' '))
                {
                    if (declarationSymbol)
                    {
                        programWords.Add(expression);
                        expression = "";
                    }
                    else
                    {
                        programWords.Add("Error");
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
