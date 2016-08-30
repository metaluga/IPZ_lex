using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPZ_lex
{
    public partial class Form1 : Form
    {
        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream mySteam = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "..\\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Sig files (*.sig)|*.sig";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (mySteam)
                    {
                        string progs = openFileDialog1.FileName;
                        programBox.Text = File.ReadAllText(progs);
                    }
                }
                catch (Exception ex)
                {
                    programBox.Text = ("Error: Could not read file from disc. Original error: " + ex.Message);
                }
            }
        }

        private void compile_Click(object sender, EventArgs e)
        {
            //variable.Text = programBox.Text;
            programReader.reader(programBox.Text);
            foreach (string i in programReader.programWords)
            {
                variable.Text += i; 
            }
        }

        private void variable_TextChanged(object sender, EventArgs e)
        {

        }

        private void programOut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
