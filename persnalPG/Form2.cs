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
            cmd.CommandText = "INSERT INTO player(TEAM,STYLE,NAME,HIGHT,WEIGHT,THISWAR,WASWAR) VALUES ('"+cboTeam.Text+"','"+cboplayst.Text+"','"+txtname.Text+"',"+txthight.Text+","+txtweight.Text+","+txtWAR.Text+","+txtpastyear.Text+")";

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            cboTeam.Text = "";
            cboplayst.Text = "";
            txtname.Text = "";
            txthight.Text = "";
            txtweight.Text = "";
            txtWAR.Text = "";
            txtpastyear.Text = "";
            MessageBox.Show("저장되었습니다.");
        }
    }
}
