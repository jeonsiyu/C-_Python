using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class OutMember : Form
    {
        public OutMember()
        {
            InitializeComponent();
            comboBox.Items.Add("ID");
            comboBox.Items.Add("이름");
            comboBox.SelectedIndex = 0;

            button1.Click += new EventHandler(button1_Click);
            button_search.Click += new EventHandler(button_search_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "User Id=test;Password=1234;Data Source=localhost:1521/XE";

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT * FROM Users";
                    OracleCommand cmd = new OracleCommand(sql, conn);

                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Users");

                    dataGridView1.DataSource = ds.Tables["Users"];

                    int rowCount = dataGridView1.Rows.Count-1;
                    label_Out.Text = "탈퇴 멤버 수: " + rowCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string userId = textBox_search.Text.Trim();
            string filter = comboBox.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(textBox_search.Text))
            {
                string connectionString = "User Id=test;Password=1234;Data Source=localhost:1521/XE";

                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    try
                    {
                        string sql = "";

                        switch (filter)
                        {
                            case "ID":
                                sql = "SELECT * FROM Users WHERE UserID = :SearchText";
                                break;
                            case "이름":
                                sql = "SELECT * FROM Users WHERE UserName = :SearchText";
                                break;
                        }

                        OracleCommand cmd = new OracleCommand(sql, conn);
                        cmd.Parameters.Add(new OracleParameter("SearchText", textBox_search.Text));

                        OracleDataAdapter da = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Users");

                        dataGridView1.DataSource = ds.Tables["Users"];

                        int rowCount = dataGridView1.Rows.Count-1;
                        label_search.Text = "검색된 회원 수 : " + rowCount.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("일치하는 회원 정보가 없습니다.");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("검색어를 입력하세요.");
            }
        }
    }
}