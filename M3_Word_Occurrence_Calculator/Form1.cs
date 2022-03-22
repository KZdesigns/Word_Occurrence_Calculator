using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_Word_Occurrence_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            // start of try catch block.
            try
            {
                // get users input from the text box.
                string inputString = inputTextBox.Text;

                // establish output string.
                string output = "";

                // check if input is blank.
                if(inputString == "")
                {
                    throw new ArgumentException("Invalid input.");
                }

                // create a list using the input string.
                List<string> words = new List<string>(inputString.Split(' '));

                // create a list of WordOccurrence.
                List<WordOccurrence> result = WordCalculator.CalculateOccurrences(words);

                // loop through the list of WordOccurrences and Word and Count of each occurrence to the output string.
                foreach (WordOccurrence word in result)
                {
                    output += word.Word + " = " + word.Count + "\n";
                }

                // display output string in label.
                resultLabel.Text = output;
            } 
            catch(Exception ex)
            {
                // if an exception is thrown display a messagebox. 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
