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

namespace Simple_Crud
{
    public partial class form1 : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        string strSQL;

        public form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-GKA8617\SQLEXPRESS;Initial Catalog=Client;Integrated Security=True");

            strSQL = "INSERT INTO REGISTER_CLIENT (FIRSTNAME,LASTNAME,EMAIL,NUMBER) VALUES (@FIRSTNAME,@LASTNAME,@EMAIL,@NUMBER)";

            cmd = new SqlCommand(strSQL, connection);

            cmd.Parameters.AddWithValue("@FIRSTNAME", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LASTNAME", txtLastName.Text);
            cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
            cmd.Parameters.AddWithValue("@NUMBER", txtNumber.Text);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection = null;
                cmd = null;
            }


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-GKA8617\SQLEXPRESS;Initial Catalog=Client;Integrated Security=True");

            strSQL = "SELECT * FROM REGISTER_CLIENT";

            DataSet ds = new DataSet();
            adapter = new SqlDataAdapter(strSQL, connection);

            try
            {
                connection.Open();
                adapter.Fill(ds);
                dgvData.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection = null;
                cmd = null;
            }
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-GKA8617\SQLEXPRESS;Initial Catalog=Client;Integrated Security=True");

            strSQL = "SELECT * FROM REGISTER_CLIENT WHERE ID = @ID";

            cmd = new SqlCommand(strSQL, connection);

            cmd.Parameters.AddWithValue("@ID", txtId.Text);
            
            try
            {
                connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtFirstName.Text = (string)reader["firstname"];
                    txtLastName.Text = (string)reader["lastname"];
                    txtEmail.Text = (string)reader["email"];
                    txtNumber.Text = (string)reader["number"];
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection = null;
                cmd = null;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-GKA8617\SQLEXPRESS;Initial Catalog=Client;Integrated Security=True");

            strSQL = "UPDATE REGISTER_CLIENT SET FIRSTNAME = @FIRSTNAME, LASTNAME = @LASTNAME, EMAIL = @EMAIL, NUMBER = @NUMBER WHERE ID = @ID";

            cmd = new SqlCommand(strSQL, connection);

            cmd.Parameters.AddWithValue("@ID", txtId.Text);
            cmd.Parameters.AddWithValue("@FIRSTNAME", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LASTNAME", txtLastName.Text);
            cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
            cmd.Parameters.AddWithValue("@NUMBER", txtNumber.Text);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection = null;
                cmd = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-GKA8617\SQLEXPRESS;Initial Catalog=Client;Integrated Security=True");

            strSQL = "DELETE REGISTER_CLIENT WHERE ID = @ID";

            cmd = new SqlCommand(strSQL, connection);

            cmd.Parameters.AddWithValue("@ID", txtId.Text);
            

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection = null;
                cmd = null;
            }
        }
    }
}
