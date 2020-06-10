using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace 주차관리_프로그램_연습
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = DataManager.Cars;
            label9.Text = DateTime.Now.ToString("HH:mm");
            metroComboBox1.Text = "선택";
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Car car = dataGridView1.CurrentRow.DataBoundItem as Car;
                textBox_spotNumber.Text = car.parkingSpot.ToString();
                textBox_carNumber.Text = car.carNumber;
                textBox_driverName.Text = car.driverName;
                textBox_phoneNumber.Text = car.phoneNumber;
            }
            catch (Exception)
            {

            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString("HH:mm");
        }

        private void metroPanel_search_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text.Equals("")|| metroComboBox1.Text.Equals("선택"))
            {
                label5.Text = "공간번호";
                label6.Text = "차량번호";
                label7.Text = "차주이름";
                label8.Text = "전화번호";
            }
            else if (metroComboBox1.Text.Equals("공간번호"))
            {
                String a = DataManager.Cars.Where((x) => x.parkingSpot.ToString() == textBox_select.Text).Count().ToString();
                if (int.Parse(a) == 0)
                {
                    MessageBox.Show("존재하지 않는 주차공간입니다.");
                }
                else if (int.Parse(a) == 1)
                {
                    foreach (var item in DataManager.Cars)
                    {
                        if (textBox_select.Text.Equals(item.parkingSpot.ToString()))
                        {
                            label5.Text = item.parkingSpot.ToString();
                            label6.Text = item.carNumber;
                            label7.Text = item.driverName;
                            label8.Text = item.phoneNumber;

                            break;
                        }
                    }
                }             
            }
            else if (metroComboBox1.Text.Equals("차량번호"))
            {
                String a = DataManager.Cars.Where((x) => x.carNumber == textBox_select.Text).Count().ToString();
                if (int.Parse(a) == 0)
                {
                    MessageBox.Show("주차하지 않은 차량입니다.");
                }
                else if (int.Parse(a) == 1)
                {
                    foreach (var item in DataManager.Cars)
                    {
                        if (textBox_select.Text.Equals(item.carNumber))
                        {
                            label5.Text = item.parkingSpot.ToString();
                            label6.Text = item.carNumber;
                            label7.Text = item.driverName;
                            label8.Text = item.phoneNumber;
                            break;
                        }
                    }
                }
            }
            else if (metroComboBox1.Text.Equals("차주이름"))
            {
                String a = DataManager.Cars.Where((x) => x.driverName == textBox_select.Text).Count().ToString();
                if (int.Parse(a) == 0)
                {
                    MessageBox.Show("해당 차주분의 차량이 주차되지 않았습니다.");
                }
                else if (int.Parse(a) == 1)
                {
                    foreach (var item in DataManager.Cars)
                    {
                        if (textBox_select.Text.Equals(item.driverName))
                        {
                            label5.Text = item.parkingSpot.ToString();
                            label6.Text = item.carNumber;
                            label7.Text = item.driverName;
                            label8.Text = item.phoneNumber;
                            break;
                        }
                    }
                }
            }
            else if (metroComboBox1.Text.Equals("전화번호"))
            {
                String a = DataManager.Cars.Where((x) => x.phoneNumber == textBox_select.Text).Count().ToString();
                if (int.Parse(a) == 0)
                {
                    MessageBox.Show("입력하신 전화번호로 조회할 수 없습니다.");
                }
                else if (int.Parse(a) == 1)
                {
                    foreach (var item in DataManager.Cars)
                    {
                        if (textBox_select.Text.Equals(item.phoneNumber))
                        {
                            label5.Text = item.parkingSpot.ToString();
                            label6.Text = item.carNumber;
                            label7.Text = item.driverName;
                            label8.Text = item.phoneNumber;
                            break;
                        }
                    }
                }
            }
        }  

        private void metroTile_addParkingSpot_Click(object sender, EventArgs e)
        {
            DataManager.addParkingSpot();
            dataGridView1.DataSource = DataManager.Cars;
        }

        private void metroTile_deleteSpot_Click(object sender, EventArgs e)
        {
            int idx = dataGridView1.Rows.Count;
            if (dataGridView1.Rows[idx-1].Cells[1].Value.ToString().Equals(""))
            {
                DataManager.deleteParkingSpot();
                dataGridView1.DataSource = DataManager.Cars;
            }
            else
            {
                MessageBox.Show("주차된 차량이 있습니다. 다시 한번 확인해 주세요");
            }
        }

        private void metroTile_park_Click(object sender, EventArgs e)
        {
            if (textBox_carNumber.Text.Trim() == "" || textBox_driverName.Text.Trim() == "" || textBox_phoneNumber.Text.Trim() == "")
            {
                MessageBox.Show("차량번호, 성함, 연락처를 입력해주세요");
            }
            else
            {
                try
                {
                    Car car = DataManager.Cars.Single((x) => x.parkingSpot == int.Parse(textBox_spotNumber.Text));
                    if (car.carNumber != "")
                    {
                        MessageBox.Show("이미 주차된 공간입니다.");
                    }
                    else
                    {
                        car.parkingSpot = int.Parse(textBox_spotNumber.Text);
                        car.carNumber = textBox_carNumber.Text;
                        car.driverName = textBox_driverName.Text;
                        car.phoneNumber = textBox_phoneNumber.Text;
                        car.parkingTime = DateTime.Now;

                        string content = $"{car.parkingTime.ToString("yyyy-MM-dd hh: mm:ss")}  {car.driverName}님의 차량 번호{car.carNumber}가{car.parkingSpot}에 주차되었습니다.";
                        listBox1.Items.Insert(0, content);


                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Cars;
                        DataManager.Save();
                        using (StreamWriter writer = new StreamWriter(@"..\log\" + DateTime.Now.ToString("yyyy/MM/dd") + ".txt", true))
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

        private void metroTile_out_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = DataManager.Cars.Single((x) => x.parkingSpot == int.Parse(textBox_spotNumber.Text));
                string oldcar = car.carNumber;
                if (car.carNumber == "")
                {
                    MessageBox.Show("주차된 공간이 아닙니다.");
                }
                else
                {
                    DialogResult result = MessageBox.Show("출차하는 차가" + textBox_carNumber.Text + "맞습니까?", "확인", MessageBoxButtons.YesNo);
                    if (oldcar == textBox_carNumber.Text && result == DialogResult.Yes)
                    {
                        car.carNumber = "";
                        car.driverName = "";
                        car.phoneNumber = "";
                        car.parkingTime = DateTime.Now;
                        MessageBox.Show(car.carNumber + "차량이 출차했습니다.");

                        string content = $"{car.parkingTime.ToString("yyyy-MM-dd hh: mm:ss")}  {textBox_driverName.Text}님의 차량 번호{textBox_carNumber.Text}가{textBox_spotNumber.Text}에서 출차하였습니다.";
                        listBox1.Items.Insert(0, content);
                        using (StreamWriter writer = new StreamWriter(@"..\log\" + DateTime.Now.ToString("yyyy/MM/dd") + ".txt", true))
                        {
                            writer.WriteLine(content);
                        }

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Cars;
                        DataManager.Save();
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
    }
}
