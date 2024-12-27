using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pm_training
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void buttonSignin_Click(object sender, EventArgs e)
        {
            string TextUsername=textUsername.Text;
            string TextPassword=textPassword.Text;
            

            
            
                if (TextUsername != "" || TextPassword != "") 
                {
                    string connectionString = "Server=LAPTOP-CPVB148D;Database=Parks;Trusted_Connection=True;";

                    string sqlInsertString = $"SELECT password FROM Users WHERE username = ('{TextUsername}')";

                    try
                    {

                        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                        {
                            sqlConnection.Open(); // Открываем соединение

                            using (SqlCommand command = new SqlCommand(sqlInsertString, sqlConnection))
                            {
                                SqlDataReader reader = command.ExecuteReader();

                                if (reader.Read())
                                {
                                    string storedPassword = reader["password"].ToString();
                                    if (TextPassword== storedPassword)
                                    {
                                        Catalog userCatalog = new Catalog();
                                        userCatalog.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Неправильный логин или пароль");
                                    }
                                }
                                

                               
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Не все поля заполены");
                }

            
           
        }
    }
}
