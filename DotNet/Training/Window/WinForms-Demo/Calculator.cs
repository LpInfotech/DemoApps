using System;
using System.Windows.Forms;

namespace WinForms_Demo
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        #region Calculator methods

        /// <summary>
        /// Creating the button for adding of Two numbers 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(txtFirstNumber.Text);
            int secondNumber = int.Parse(txtSecondNumber.Text);
            int sum = firstNumber + secondNumber;
            //Using the result label to show the final result
            lblResult.Text = "Result= "+sum.ToString();           
        }      

        /// <summary>
        /// Creating the button for subtraction of 2 numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(txtFirstNumber.Text);
            int secondNumber = int.Parse(txtSecondNumber.Text);
            int subtract = firstNumber - secondNumber;
            //Using the result label to show the subtracted value
            lblResult.Text = "Result= "+subtract.ToString();
        }        
       
        /// <summary>
        /// Creating the button for multipliaction of 2 numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(txtFirstNumber.Text);
            int secondNumber = int.Parse(txtSecondNumber.Text);
            int multiplication = firstNumber * secondNumber;
            //The multiplication of 2 numbers result is showing in Result label            
            lblResult.Text = "Result= "+multiplication.ToString();
        }       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClean_Click(object sender, EventArgs e)
        {
            btnClean.Text = "Enter the new data";
        }
        #endregion

        private void lblFirstNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
