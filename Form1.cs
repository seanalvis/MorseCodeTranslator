using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MorseCode_ch8_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] charArray = null;
        string[] morseArray = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            string input = inputTextBox.Text.ToLower();
            StreamReader inputFile; // To read the file
            int count = 0;
            string alphabet;

            inputFile = File.OpenText("alphabet.txt");
            while (!inputFile.EndOfStream)
            {
                // Increment the student counter
                count++;

                // Read a line from the file
                alphabet = inputFile.ReadLine();
            }

            charArray = new char[] { alphabet };
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                string alphabet;
               
                int total;

                // Open the file
               

                foreach (char myChar in input)
                {
                    for (int counter = 0; counter < charArray.Length; counter++)
                    {
                        if (charArray[counter] == myChar)
                        {
                            displayLabel.Text += morseArray[counter] + " ";
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the form
            inputTextBox.Text = "";
            displayLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the app
            this.Close();
        }
        
    }
}
