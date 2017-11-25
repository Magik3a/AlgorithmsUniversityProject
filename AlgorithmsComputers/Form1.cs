using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmsComputers
{
    public partial class Form1 : Form
    {
        private int kValue;
        private int nValue;
        //This is the starting point of all the magic 
        public Form1()
        {
            InitializeComponent();
            //We hide the error labels
            lblErrorK.Hide();
            lblErrorN.Hide();
            lblErrorKBiggerThanN.Hide();
            
        }

        /* You can auto create the method with 2 clicks on the button
         * This is the entry point after the user click the button 
         * btnSubmit is actually the name that appear in designer 
         * Our first text box value is in txtCombinationClass.Text
         * Our second text box value is in txtValueElem.Text
         */
        private void btnSubmit_Click(object sender, EventArgs e)
        {
           if(!ValidateAndSetValues())
                return;
           
           //Here is our method to show some results
           WriteCombination();

        }
        // Here we check if the entered values are actually numbers and we set the global variables for this class scope
        private bool ValidateAndSetValues()
        {
            // We validate that entered value is int
            if (!int.TryParse(txtCombinationClass.Text, out kValue))
            {
                // If the value is not int we make the text box red
                txtCombinationClass.ForeColor = Color.Red;
                // And we show the error label
                lblErrorK.Show();
                return false;
            }
            else
            {
                // IF the value is int we hide the error and the text black again
                lblErrorK.Hide();
                txtCombinationClass.ForeColor = Color.Black;

            }
            // We validate that entered value is int
            if (!int.TryParse(txtNValue.Text, out nValue))
            {
                // If the value is not int we make the text box red
                txtNValue.ForeColor = Color.Red;
                // And we show the error label
                lblErrorN.Show();
                return false;
            }
            else
            {
                // IF the value is int we hide the error and the text black again
                lblErrorN.Hide();
                txtNValue.ForeColor = Color.Black;
            }
            //If we reach here both of our values are numbers
            if (kValue > nValue)
            {
                lblErrorKBiggerThanN.Show();
                return false;
            }
            else
                lblErrorKBiggerThanN.Hide();

            return true;
        }

        private void WriteCombination()
        {
            int[] comb = new int[kValue];
            for (int i = 0; i < kValue; i++)
                comb[i] = i + 1;

            txtResult.AppendText($"N = {nValue}; K = {kValue}" + Environment.NewLine);

            WriteArray(comb);
            while (NextComb(comb, nValue))
            {
                WriteArray(comb);
            }
            txtResult.AppendText("***********************");
            txtResult.AppendText(Environment.NewLine);
        }

        private void WriteArray(int[] ar)
        {
            foreach (int v in ar)
                txtResult.AppendText(v.ToString() + ' ');
            txtResult.AppendText(Environment.NewLine);
        }

        private bool NextComb(int[] cm, int n)
        {
            int i = cm.Length - 1;

            while (i >= 0)
            {
                if (cm[i] < n - cm.Length + i + 1)
                {
                    cm[i]++;
                    for (i++; i < cm.Length; i++)
                    {
                        cm[i] = cm[i - 1] + 1;
                    }
                    return true;
                }
                i--;
            }
            return false;
        }


        //This is called after the user clicks clean and just sets the text value to none
        private void btnCleanResult_Click(object sender, EventArgs e)
        {
            txtResult.Text = null;
        }
    }
}
