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
using System.IO;

namespace phone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public static string s = "Data Source=LAPTOP-H63PBU3S;Initial Catalog=phone;Integrated Security=True";
        private void start()
        {
            //取消欄位輸入功能
            this.number.Enabled = false;
            this.name.Enabled = false;
            this.phonenumber.Enabled = false;

            try
            {
                sqlDataAdapter1.Fill(phonebookDataSet1.people);
                this.button1.Enabled = true;

            }
            catch
            {
                this.button1.Enabled = false;
            }
            


            //設定顯示元件
            this.save.Visible = false;
            this.cancel.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'phoneDataSet.people' 資料表。您可以視需要進行移動或移除。
            this.peopleTableAdapter.Fill(this.phoneDataSet.people);
            start();
            comboBox1.Items.Add("family");//0
            comboBox1.Items.Add("friend");//1
            comboBox1.Items.Add("菜");//2
            comboBox1.Items.Add("排行榜內");
            comboBox1.Items.Add("排行榜前500名");
            comboBox1.SelectedIndex = 2;

            comboBox2.Items.Add("family");//0
            comboBox2.Items.Add("friend");//1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                {
                    MessageBox.Show("big family 有全部檔案");
                sqlDataAdapter1.Fill(phonebookDataSet1.people);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sqlDataAdapter1.Fill(phonebookDataSet1.people);
            }
            catch
            {
                MessageBox.Show("找不到伺服器檔案");
            }
            
            //新增
            setcan();
           
            setAdd();

            
            

        }

        private void setcan()
        {
            //清除目前顯示狀態
            this.number.Text = "";
            this.name.Text = "";
            this.phonenumber.Text = "";
        }

        private void setAdd()
        {
            //儲存功能
            //恢復欄位輸入功能
            //姓名
            //電話
            this.number.Enabled = true;
            this.name.Enabled = true;
            this.phonenumber.Enabled = true;

            //顯示元件
            //存取,取消
            this.save.Visible = true;
            this.cancel.Visible = true;
        }

        

        

        private void cancel_Click(object sender, EventArgs e)
        {
            //清除元件資料
            setcan();
            //改變狀態ok
            start();
        }

        private void save_Click(object sender, EventArgs e)
        {

            phonebookDataSet.peopleRow dr = phonebookDataSet1.people.NewpeopleRow();

            try
            {
    //            System.Text.RegularExpressions.Regex rx =
    //new System.Text.RegularExpressions.Regex(@"\d");
                dr.ID = number.Text;
                dr.name = name.Text;
                dr.number = phonenumber.Text;
                dr.friendship = comboBox2.Text;
                phonebookDataSet1.people.Rows.Add(dr);
                //上傳
                sqlDataAdapter1.Update(phonebookDataSet1.people);
                MessageBox.Show("新增完成");
            }
            catch
            {
                MessageBox.Show("編號不可重複或空白");
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                string x = search1.Text;
                string s = "Data Source=.\\SQLExpress;Initial Catalog=phone;Integrated Security=True";
                SqlConnection cn = new SqlConnection(s);
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from people where ID='" + x + "'", cn);

                SqlDataReader dr = cmd.ExecuteReader();
                //dr.Read();
                while (dr.Read())
                {
                    string line = string.Format("Name: {0}, number: {1}", dr["name"], dr["number"]);
                    label5.Text = line.ToString();

                }
            }
            catch
            {
                MessageBox.Show("0資料");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Directory.CreateDirectory(@"c:\Lab");
            phonebookDataSet1.WriteXml(@"c:\Lab\nw.xml", XmlWriteMode.DiffGram);
            MessageBox.Show("已將資料儲存在c槽Lab資料夾");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            phonebookDataSet1.ReadXml(@"c:\Lab\nw.xml");
            MessageBox.Show("已讀取資料");
        }

       

        private void delete_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow r1 = this.dataGridView1.CurrentRow;
            //你的Datagridview名稱，CurrentRow指的是你DataGridview畫面中

            //，小三角形所指的位置

            this.dataGridView1.Rows.Remove(r1);

            this.save.Visible = true;
            this.cancel.Visible = true;
            sqlDataAdapter1.Update(phonebookDataSet1.people);
            MessageBox.Show("新增完成");
            //sqlDataAdapter1.Fill(phonebookDataSet1.people);
            ////setcan();
            //this.number.Enabled = true;
            //this.save.Visible = true;
            //this.cancel.Visible = true;
            ////number.Text

            //try
            //{
            //    if (number.Text != "")
            //    {
            //        int numVal = Int32.Parse(number.Text);
            //        phonebookDataSet1.people.Rows[numVal].Delete();
            //    }
            //    MessageBox.Show("OK");

            //}
            //catch
            //{
            //    MessageBox.Show("請輸入ID");
            //}

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = comboBox1.Text;
 
            SqlConnection cn = new SqlConnection(s);

            cn.Open();

            //listbox 清空
            listBox1.Items.Clear();
            //listbox選項
            if (comboBox1.SelectedIndex == 0)
            {
                show(x, cn);
               

            }
            else if (comboBox1.SelectedIndex == 1)
            {

                show(x, cn);
            }
        }

        private void show(string x, SqlConnection cn)
        {
            sqlDataAdapter1.Fill(phonebookDataSet1.people);
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.Fill(phonebookDataSet1.people);


            //SqlCommand cmd = new SqlCommand(
            //    "select * from people where friendship='" + x + "'", cn);

            //DataTable dt = phonebookDataSet1.people;
            
            var query = from o in phonebookDataSet1.people
                        where o.friendship==x
                        select new { id = o["ID"], name = o["name"], number = o["number"], friendship =o["friendship"] };

            dataGridView1.DataSource = query.ToList();

            //SqlDataReader dr = cmd.ExecuteReader();

            //dataGridView1.DataSource = cmd.ExecuteReader();
            //讀取全部
            //while (dr.Read())
            //{
            //    string line = string.Format("ID: {0},Name: {1}\r, number={2}", dr["ID"], dr["name"], dr["number"]);
            //    listBox1.Items.Add(line.ToString());
            //}
        }
    }
}
