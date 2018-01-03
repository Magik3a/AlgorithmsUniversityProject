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

        private List<int> nElements;
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
            if (!ValidateAndSetValues())
                return;

            //Here is our method to show some results
            WriteCombination();

        }
        // Here we check if the entered values are actually numbers and we set the global variables for this class scope
        private bool ValidateAndSetValues()
        {

            nElements = new List<int>();
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

            var nElementsTemp = txtNValue.Text.Split(',');
            foreach (var nElement in nElementsTemp)
            {
                // We validate that entered value is int
                if (!int.TryParse(nElement.Trim(), out var intValue))
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
                    nElements.Add(intValue);
                }
            }
            nValue = nElements.Count;
            //If we reach here both of our values are numbers
            if (nElements.Count < kValue)
            {
                lblErrorKBiggerThanN.Show();
                return false;
            }
            else
                lblErrorKBiggerThanN.Hide();

            return true;
        }

        static IEnumerable<IEnumerable<T>>  GetCombination<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });
            return GetCombination(list, length - 1)
                .SelectMany(t => list.Where(o => !t.Contains(o)),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }

        private void WriteCombination()
        {
            int[] comb = new int[kValue];
            for (int i = 0; i < kValue; i++)
                comb[i] = nElements[i];

            txtResult.AppendText($"N = {nElements.Count}; K = {kValue}" + Environment.NewLine);
            
            var result = GetCombination(nElements.ToList(), kValue);
            foreach (var item in result)
            {
                foreach (int v in item)
                    txtResult.AppendText(v.ToString() + ' ');
                txtResult.AppendText(Environment.NewLine);
            }
            txtResult.AppendText("***********************");
            txtResult.AppendText(Environment.NewLine);
        }
        
        //This is called after the user clicks clean and just sets the text value to none
        private void btnCleanResult_Click(object sender, EventArgs e)
        {
            txtResult.Text = null;
        }
     
    }


}
