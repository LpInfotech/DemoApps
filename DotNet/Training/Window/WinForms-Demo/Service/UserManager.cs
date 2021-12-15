using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Demo.Service
{
    /// <summary>
    /// sckelton architecture 
    /// </summary>
    public class UserManager
    {
        public static Tuple<bool, string> Save(UserModel userModel)
        {
            string mesage = ""; bool successs = true;


            //using connecting string to connect to the database
            string connection = @"Server=LATA\SQLEXPRESS;Database=Demo;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            //try is using for initialize the value of data 
            try
            {
                string query = "insert into Users(Name,Email,RollNumber) values('" + userModel.Name + "','" + userModel.Email + "','" + userModel.RollNumber + "')";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                da.SelectCommand.ExecuteNonQuery();
                //MessageBox.Show("The data has successfully submitted");
                // ClearData();
            }
            //using catch to find the exception
            catch (Exception ex)
            {
                mesage = ex.Message;

                // MessageBox.Show("not valid ");
            }
            finally
            {

                con.Close();
            }
            //return 
            return Tuple.Create(successs, mesage);

        }

        //public 
    }
}
