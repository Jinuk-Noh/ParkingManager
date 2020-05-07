using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 주차관리_프로그램_연습
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            Query_Select();

            dataGridView2.Visible = true;
            label9.Text = DateTime.Now.ToString("HH:mm");
        }



        private void button_park_Click(object sender, EventArgs e)
        {
            if (textBox_carNumber.Text.Trim() == "" || textBox_driverName.Text.Trim() == "" || textBox_phoneNumber.Text.Trim() == "")
            {
                MessageBox.Show("차량번호, 성함, 연락처를 입력해주세요");
            }
            else
            {

                try
                {                  
                    Query_Select1(textBox_spotNumber.Text);
                    if (dataGridView2.CurrentRow.Cells[1].Value.ToString() != "")
                    {
                        MessageBox.Show("이미 주차된 공간입니다.");
                    }
                   else
                    {
                        Query_Update();
                        dataGridView1.DataSource = null;
                        Query_Select();
                        Query_Select1(textBox_spotNumber.Text);
                        string content = $"{dataGridView2.CurrentRow.Cells[4].Value.ToString()} 차량 번호{dataGridView2.CurrentRow.Cells[1].Value.ToString()}가 {dataGridView2.CurrentRow.Cells[0].Value.ToString()}에서 주차하였습니다.";
                        listBox1.Items.Insert(0,content);

                        using (StreamWriter writer = new StreamWriter(@"C:\Users\KB\source\repos\c#\주차관리 프로그램 mysql\bin\log\" + DateTime.Now.ToString("yyyy/MM/dd")+".txt", true))
                        {
                            writer.WriteLine(content);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("주차에 실패했습니다.");
                }
            }
        }

        private void button_out_Click(object sender, EventArgs e)
        {
            try
            {
                Query_Select1(textBox_spotNumber.Text);
                string oldcar = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                if (oldcar == "")
                {
                    MessageBox.Show("주차된 공간이 아닙니다.");
                }
                else
                {
                    DialogResult result = MessageBox.Show("출차하는 차가" + textBox_carNumber.Text + "맞습니까?", "확인", MessageBoxButtons.YesNo);
                    if (oldcar == textBox_carNumber.Text && result == DialogResult.Yes)
                    {
                        Query_Delete();
                      

                        string content = $"{dataGridView2.CurrentRow.Cells[4].Value.ToString()} 차량 번호{dataGridView2.CurrentRow.Cells[1].Value.ToString()}가 {dataGridView2.CurrentRow.Cells[0].Value.ToString()}에서 출차하였습니다.";
                        listBox1.Items.Insert(0, content);
                        using (StreamWriter writer = new StreamWriter(@"C:\Users\KB\source\repos\c#\주차관리 프로그램 mysql\bin\log\" + DateTime.Now.ToString("yyyy/MM/dd") + ".txt", true))
                        {
                            writer.WriteLine(content);
                        }

                        dataGridView1.DataSource = null;
                        Query_Select();
                       
                    }
                    else
                    {
                        MessageBox.Show("차량 번호를 다시한번 확인해주세요");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("출차에 실패했습니다.");
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {

                textBox_spotNumber.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox_carNumber.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox_driverName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox_phoneNumber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Query_Select1(textBox_select.Text);
                label5.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                label6.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                label7.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                label8.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("주차공간을 다시 확인해주세요");
            }          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString("HH:mm");
        }


        //---------------------------------------------------
        public SqlConnection conn = new SqlConnection();


        private void ConnetDB()
        {
            conn.ConnectionString = string.Format("Data Source=({0});" +
                "Initial Catalog ={1};" +
                "Integrated Security={2};" +
                "Timeout = 3"
                , "local", "MYDB2", "SSPI");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        public void Query_Select()
        {
            ConnetDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from carpark";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "carpark");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "carpark";
            conn.Close();
        }

        public void Query_Select1(String textBox)
        {
            ConnetDB();
            string sqlcommand = "select * from carpark where parkingspot =@p";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@p", textBox);

            cmd.CommandText = sqlcommand;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "carpark");

            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "carpark";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Query_Update()
        {
            ConnetDB();
            string sqlcommand = "Update carpark set carnumber =@p1, drivername =@p2, phonenumber =@p3, parkingtime=@p4 where parkingspot =@p";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", textBox_carNumber.Text);
            cmd.Parameters.AddWithValue("@p2", textBox_driverName.Text);
            cmd.Parameters.AddWithValue("@p3", textBox_phoneNumber.Text);
            string datetime = DateTime.Now.ToString("yyyy/MM/dd hh:MM:ss");
            cmd.Parameters.AddWithValue("@p4", datetime);
            cmd.Parameters.AddWithValue("@p", textBox_spotNumber.Text);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Query_Delete()
        {
            ConnetDB();
            string sqlcommand = "delete carpark where parkingspot =@p";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p", textBox_spotNumber.Text);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();
            conn.Close();

            Query_insert();

        }

        public void Query_insert()
        {
            ConnetDB();
            string sqlcommand = "insert into carpark (parkingspot) values (@p)";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p", textBox_spotNumber.Text);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();
            conn.Close();

        }

    }
}
