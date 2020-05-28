using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryLists
{
    public partial class Form1 : Form
    {
        #region global variables
        List<int> numbers = new List<int>();
        Random randGen = new Random();
        int temp;
        int input = 6;
        const int LIMIT = 50;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        #region enrichement
        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                input = Convert.ToInt16(inputBox.Text);
            }
            catch
            {
                outputLabel.Text = "You must enter an integer";
            }
            
        }
        #endregion

        #region numButton
        private void numButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            for (int i = 0; i < input; i++)
            {
                temp = randGen.Next(1, LIMIT);
                

                while (numbers.Contains(temp))
                {
                    temp = randGen.Next(1, LIMIT);
                }
                numbers.Add(temp);
            }

            

            for (int i = 0; i < input; i++)
            {
                numbers.Sort();
                outputLabel.Text += Convert.ToString(numbers[i]) + " ";
            }
             

            
            


        }
        #endregion


    }
}
