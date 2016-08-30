using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPZ_lex
{
    class programAnalysis
    {
        int wordsNumber = 0;
        string programResults;


        void oneSybol(string lex, List<string> myProgram)
        {
            if ((lex == ".") || (lex == ",") || (lex == ";"))
            {
                variable_used.myVariable.Add(new Colection()
                { Name = myProgram[wordsNumber], Number =(int)myProgram[wordsNumber++][0] });
            }
        }

        void program(List<string> myProgram)
        {
            foreach (Colection i in variable_used.program)  // search in program indef
            {
                oneSybol(i.Name, myProgram);
                if (i.Name == myProgram[wordsNumber++])
                {
                    programResults += i.Number + " ";
                    break;
                }
            }
            bool used = false;
            foreach (Colection i in variable_used.myVariable) //search in mt indef
            {
                oneSybol(i.Name, myProgram);
                if (i.Name == myProgram[wordsNumber])
                    used = true;
            }
            if (!used)
                variable_used.myVariable.Add(new Colection()
                { Name = myProgram[wordsNumber++], Number = 1001 + variable_used.myVariable.Count });

            declarations(myProgram);
        }



        void declarations(List<string> myProgram)
        {
            
            oneSybol(i.Name, myProgram);

        }


        public static void analysis(List<string> myProgram)
        {
            // programReader.reader(programBox.Text);
            bool block = false, statment = false;

            

           // foreach (string i in myProgram ;

            var index = 0;

            while( index < myProgram.Count)
            {
                if (myProgram[index] == "PROGRAM")
                    block = true;

                if (block)
                {

                }

            }




        }



    }
}
