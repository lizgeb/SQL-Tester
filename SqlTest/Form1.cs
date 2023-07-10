using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SqlTest
{
    public partial class Form1 : Form
    {
        String connectionString;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (sqlText.Text != null)
            {

                string connectionString = "Data Source=DESKTOP-6PAB4RO;Initial Catalog=Dbsql_relationship;User ID=Sa;Password=1";
                /*cmd.Parameters.AddWithValue("@ad",baglan );
                baglan.Open();
                cmd.ExecuteNonQuery();
                baglan.Close();*/
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show(" VeriTabanı bağlantısı gerçekleştirildi. Bekleyiniz...");

                    string sorgu = sqlText.Text;
                    using (SqlCommand command = new SqlCommand(sorgu, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            // StringBuilder stringBuilder = new StringBuilder();

                            while (reader.Read())
                            {
                              
                                StringBuilder stringBuilder = new StringBuilder();

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    string value = reader[i].ToString();
                                    stringBuilder.Append(value + " | ");
                                }

                                selectwrite.Items.Add(stringBuilder.ToString().Trim());
                            }
                        }

                        reader.Close();
                    }

                    connection.Close();
                }


            }
            else
            {
                MessageBox.Show("Lütfen select sorgunuzu giriniz.");
            }
        }
    }
}
    

