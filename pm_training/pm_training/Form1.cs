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
    public partial class FormReg : System.Windows.Forms.Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameImput.Text;
            string password1 = passwordInput.Text;
            string password2 = passwordInputRepeat.Text;

            if(password1==password2)
            {
                if(username!="" || password1!="" || password2 !="")
                {
                    string connectionString = "Server=LAPTOP-CPVB148D;Database=Parks;Trusted_Connection=True;";

                    string sqlInsertString = $"INSERT INTO Users (username, password) VALUES ('{username}','{password1}')";


                    try
                    {
                        
                        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                        {
                            sqlConnection.Open(); // Открываем соединение

                            using (SqlCommand command = new SqlCommand(sqlInsertString, sqlConnection))
                            {
                                command.ExecuteNonQuery(); // Выполняем команду

                                Catalog userCatalog = new Catalog();
                                userCatalog.Show();
                                this.Hide();
                            }
                        }

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   

                   
                }
                else
                {
                    MessageBox.Show("есть пустые поля");
                }
            }
            else
            {
                MessageBox.Show("пароль не совпадает");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usernameImput_TextChanged(object sender, EventArgs e)
        {

        }

        private void authButton_Click(object sender, EventArgs e)
        {
            FormAuth formAuth = new FormAuth();
            formAuth.Show();
            this.Hide();
        }
    }
}
