using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using WinForms_Demo.Service;

namespace WinForms_Demo
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }
        #region Registration form with database method
        /// <summary>
        /// creating the submit-button function for inserting the details with database 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {           
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
                errorProvider.SetError(txtPassword, "Password is not valid");
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
                errorProvider.SetError(txtEmail, "Email is not valid");
            else
            {
                UserModel userModel = new UserModel
                {
                    Name = txtName.Text,
                    Email=txtEmail.Text,
                    RollNumber=txtRollNo.Text
                };
                var response = UserManager.Save(userModel);
            }            
        }
        /// <summary>
        /// ClearData function is using for getting new data
        /// </summary>
        private void ClearData()
        {
            txtName.Text = " ";
            txtEmail.Text = " ";
            txtRollNo.Text = " ";
        }




        #endregion
    }
}
