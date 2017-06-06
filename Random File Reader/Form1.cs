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

namespace Random_File_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile; // Declare StreamReader Object: "inputFile"

                if (openFile.ShowDialog() == DialogResult.OK) // if the user clicks "OK" or "Open" in the open file dialog box, run the code inside this block
                {
                    // Declare variables for the sum and quantity of the random numbers, as well as a variable to act as a vehicle to carry the random numbers to the listBox.
                    int sumOfNumbers = 0;
                    int qtyOfNumbers = 0;
                    int randomNumber;


                    inputFile = File.OpenText(openFile.FileName); //assign the file being opened to the inputFile object

                    //Clear the ListBox and display labels so that reloading a file will load all new values.
                    randNumListBox.Items.Clear();
                    qtyDisplayLabel.Text = "";
                    sumDisplayLabel.Text = "";

                    // At this point the selected file is assigned to the "inputFile" object and the display fields are clear

                    while (!inputFile.EndOfStream) // this loop reads a line (a random number) from the file, assigns it to the variable "randomNumber" and adds it to the listbox as an item.
                    {
                        randomNumber = int.Parse(inputFile.ReadLine());
                        randNumListBox.Items.Add(randomNumber);
                        sumOfNumbers = sumOfNumbers + randomNumber;
                    } // end of loop

                    inputFile.Close(); // close the file

                    // Display the number of random numbers contained in the file:
                    qtyOfNumbers = randNumListBox.Items.Count;
                    qtyDisplayLabel.Text = qtyOfNumbers.ToString();

                    // Display the sum of the numbers in the file:
                    sumDisplayLabel.Text = sumOfNumbers.ToString("#,##0"); // format number with comma separated thousands place

                } // end of code block for if statement validating that "Open" was clicked.
            } // End of try block

            catch (Exception ex) // if anything fails in the above block, this will display appropriate message boxes. 
            {
                MessageBox.Show(ex.Message);
            }

        }// End openFileButton_Click block

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
