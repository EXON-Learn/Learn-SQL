using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace sql_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static MySqlConnection connection = new MySqlConnection("Server=localhost;Database=data1;Uid=root;Pwd=1exonhappy1234;");

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void start_Click_1(object sender, EventArgs e)
        {
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "SELECT *";
            query.CommandText += "FROM new_table";

            try
            {
                connection.Open();

                MySqlDataReader reader = query.ExecuteReader();
                dataGridView1.Rows.Clear();

                for (int i = 0; reader.Read(); i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells["name"].Value = reader["name"].ToString();
                    dataGridView1.Rows[i].Cells["age"].Value = reader["age"].ToString();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            string insertQuery = $"DELETE FROM data1.new_table WHERE name = \"{txt_name.Text}\" AND age = {txt_age.Text};";


            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("삭제됬습니다");
                }
                else
                {
                    MessageBox.Show("오류가 났습니다. \n 다시 한번 시도해주세요");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            connection.Close();
        }

        private void but_add_Click(object sender, EventArgs e)
        {

            string insertQuery = "INSERT INTO data1.new_table(name,age) VALUES('" + txt_name.Text + "'," + txt_age.Text + ")";


            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("추가됬습니다");
                }
                else
                {
                    MessageBox.Show("오류가 났습니다. \n 다시 한번 시도해주세요");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            connection.Close();
        }
    }
}
