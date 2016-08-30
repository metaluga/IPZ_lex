using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPZ_lex
{
    class variable_used
    {
        

        public static List<Colection> program = new List<Colection>
        {
            new Colection() {Name = "PROGRAM", Number = 401 }
        };

        public static List<Colection> declaration = new List<Colection>
        {
            new Colection() {Name = "LABEL", Number = 402 }
        };

        

        public static List<Colection> doubleIndetifer = new List<Colection>
        {
            new Colection() {Name = "LINK", Number = 401 }
        };

        List<Colection> singleIndetifer = new List<Colection>
        {
            new Colection() {Name = "PROGRAM", Number = 402},
            new Colection() {Name = "LABEL", Number = 403},
            new Colection() {Name = "GOTO", Number = 404},
            new Colection() {Name = "LINK", Number = 405},
            new Colection() {Name = "IN", Number = 406},
            new Colection() {Name = "OUT", Number = 407}
        };

        List<Colection> zeroIndetifer = new List<Colection>
        {
            new Colection() {Name = "BEGIN", Number = 408 },
            new Colection() {Name = "END", Number = 409 }
        };

        
        public static List<Colection> myVariable = new List<Colection> { };
        //  {"PROGRAM", "BEGIN", "END", "LABEL", "GOTO", "LINK", "IN", "OUT"}; 


        private string wordTest(string myWord)
        {
            foreach (Colection indef in doubleIndetifer)
            {
                if (myWord == indef.Name)
                    return indef.Name + " - " + indef.Number;
            }

            foreach (Colection indef in singleIndetifer)
            {
                if (myWord == indef.Name)
                    return indef.Name + " - " + indef.Number;
            }

            foreach (Colection indef in zeroIndetifer)
            {
                if (myWord == indef.Name)
                    return indef.Name + " - " + indef.Number;
            }
            return "-1";
        }

        

        //temp
        private void read_char(string programText)
        {
            List<Colection> lineForWord = new List<Colection> { };
            string words = "";
            int number_word = 0;

            bool withLabel = false;

            foreach (char i in programText)
            {
                if (((((int)i >= 40) && (int)i <= 90)) || ((int)i == 32))
                {
                    switch (i)
                    {
                        case ' ':
                        case ';':
                        case ',':
                            if (words.Length > 0)
                            {
                                lineForWord.Add(new Colection() { Name = words });
                                ++number_word;
                            }
                                //lineForWord[number_word++] = words;
                            words = "";
                            //function analizer
                            break;
                        case ':':
                            //work with label;

                            words = "";
                            break;

                        default:
                            words += i;
                            break;
                    }
                }
                else
                {
                    //return "error";
                    overloadedSizeFunc("ERROR");
                    return;
                }
            }
            ++number_word;
            lineForWord.Add(new Colection() { Name = words });
            //lineForWord[number_word++] = words;
            //number_word++;
            //function analizer
        }


        private string overloadedSizeFunc(string stWord)
        {
            if (stWord == "ERROR") return "Undeclaration symbol"; 
            foreach (Colection myWord in zeroIndetifer)
            {
                if (stWord == myWord.Name)
                    return myWord.Name + " - " + myWord.Number;
            }
            return "undeclaration function";
        }

        private string overloadedSizeFunc(string stWord, string secWord)
        {
            string listingText = "";

            foreach (Colection myWord in singleIndetifer)
            {
                if (stWord == myWord.Name)
                    listingText =  stWord + " - " + myWord.Number;
            }


            return "!";
        }

    /*    private string searchVar(string programText)
        {
            int next_word = -2;
            string words = "";
            bool my_wordEnd = false;
            foreach (char i in programText)
            {   if (((((int)i >= 40) && (int)i <= 90)) || ((int)i == 32))
                {
                    switch (i)
                    {
                        case ' ':
                        case ';':
                        case ',':
                            my_wordEnd = true;
                            break;
                        default:
                            words = words + i;
                            break;
                    }
                    if (my_wordEnd)
                    {
                        my_wordEnd = false;

                        if  (next_word == -2)
                            next_word = wordTest(words);

                        words = "";
                        
                    }
                }
                else
                {
                    return "unlegal symbol";
                }
            }
            my_wordEnd = false;
            words = "";

        }
        */

    }
}
