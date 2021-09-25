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

namespace persnalPG
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 _form)
        {
            InitializeComponent();
            f1 = _form;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void txtname_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://search.naver.com/search.naver?where=nexearch&sm=top_hty&fbm=1&ie=utf8&query=" + txtname.Text);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //SQL DB연결
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=localhost;database=PlayerPG; uid=sa; pwd=612500";

            //SQl 명령어
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO player(TEAM,STYLE,RLSTYLE,NAME,HIGHT,WEIGHT,THISWAR,WASWAR) VALUES ('"+cboTeam.Text+"','"+cboplayst.Text+"','"+txtRL.Text+"','"+txtname.Text+"',"+txthight.Text+","+txtweight.Text+","+txtWAR.Text+","+txtpastyear.Text+")";
            bool ok = true;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                if(ex.Message==null)
                { ok = true; }
                else { ok = false; }
            }
            finally
            {
                conn.Close();
            }
            cboTeam.Text = "";
            cboplayst.Text = "";
            txtRL.Text = "";
            txtname.Text = "";
            txthight.Text = "";
            txtweight.Text = "";
            txtWAR.Text = "";
            txtpastyear.Text = "";
            if (ok == true)
            {
                MessageBox.Show("저장되었습니다.");
            }
            else { MessageBox.Show("저장불가 : 저장되지 않았습니다."); }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //SQL DB연결
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=localhost;database=PlayerPG; uid=sa; pwd=612500";

            //SQl 명령어
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT TEAM,STYLE,RLSTYLE,NAME,HIGHT,WEIGHT,THISWAR,WASWAR FROM player";

            //DataAdapter와 Dataset으로 DB table 불러오기
            SqlDataAdapter da = new SqlDataAdapter(cmd);    //select구문 넣기
            DataSet ds = new DataSet();
            da.Fill(ds, "player");

            //DataGridView에 DB에서 가져온 데이터 뿌리기
            f1.Gridshow.DataSource = ds;
            f1.Gridshow.DataMember = "player";
            f1.Gridshow.Columns[0].HeaderText = "구단명";
            f1.Gridshow.Columns[1].HeaderText = "선수 유형";
            f1.Gridshow.Columns[2].HeaderText = "투타 유형";
            f1.Gridshow.Columns[3].HeaderText = "이름";
            f1.Gridshow.Columns[4].HeaderText = "키";
            f1.Gridshow.Columns[5].HeaderText = "몸무게";
            f1.Gridshow.Columns[6].HeaderText = "2021년 WAR";
            f1.Gridshow.Columns[7].HeaderText = "2020년 WAR";
        }
    }
}
