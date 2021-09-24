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
using Microsoft.Azure.Management.Sql.Fluent;
using MySql.Data.MySqlClient;


namespace persnalPG
{



    public partial class Form1 : Form
    {


        private void Gridshow_RowValidated(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        public Form1()
        {
            InitializeComponent();
        }

       

        private void btserch_Click(object sender, EventArgs e)
        {
            //SQL DB연결
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=localhost;database=PlayerPG; uid=sa; pwd=612500";

            //SQl 명령어
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT TEAM,STYLE,NAME,HIGHT,WEIGHT,THISWAR,WASWAR FROM player WHERE TEAM='"+cboteam.Text+"' AND STYLE='" +cboplayst.Text+"' AND NAME='"+txtname.Text+"'";

            //DataAdapter와 Dataset으로 DB table 불러오기
            SqlDataAdapter da = new SqlDataAdapter(cmd);    //select구문 넣기
            DataSet ds = new DataSet();
            da.Fill(ds, "player");

            //DataGridView에 DB에서 가져온 데이터 뿌리기
            Gridshow.DataSource = ds;
            Gridshow.DataMember = "player";
            this.Gridshow.Columns[0].HeaderText = "구단명"; 
            this.Gridshow.Columns[1].HeaderText = "선수 유형";
            this.Gridshow.Columns[2].HeaderText = "이름";
            this.Gridshow.Columns[3].HeaderText = "키";
            this.Gridshow.Columns[4].HeaderText = "몸무게";
            this.Gridshow.Columns[5].HeaderText = "2021년 WAR";
            this.Gridshow.Columns[6].HeaderText = "2020년 WAR";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void txtname_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            cboteam.Text = "";
            cboplayst.Text = "";
            txtname.Text = "";
        }

        private void cboteam_TextChanged(object sender, EventArgs e)
        {
            lbTname.Text = cboteam.Text;
            if (cboteam.SelectedItem.Equals("NC 다이노스"))
            {
                lbFname.Text = "창원 NC 파크";
                lbFaddress.Text = "경남 창원시 마산회원구 삼호로 63";
                linkTpage.Text = "https://ncdinos.com/homepage.do";
                lbTetc.Text = "2011년에 창단하여 경남 창원시를 연고로 둔 KBO리그의 아홉번째 심장.\n" +
                    "2020년 1군진입 7년만에 첫 통합우승을 차지했다.\n" +
                    "마스코드 :  단디, 쎄리 (2021년 현재  FA를 통해 둘리와 또치가 함께 하고있다.)\n"  +
                    "영구결번  :  없음\n";
                picball.Location= new Point(358,229);
            }
            else if(cboteam.SelectedItem.Equals("두산 베어스"))
            {
                lbFname.Text = "서울 종합운동장 야구장(잠실)";
                lbFaddress.Text = "서울 송파구 올림픽로 19-2 서울종합운동장";
                linkTpage.Text = "https://www.doosanbears.com/";
                lbTetc.Text = "1982년에 창단하여 서울특별시에 연고지를 둔 KBO 원년구단\n" +
                    "최초 우승은 1982년이며, 가장 최근 우승한 해는 2019년이다.\n" +
                    "마스코드 :  철웅이\n" +
                    "영구결번  :  21번 박철순(투수), 54번 김영신(포수)\n";
                picball.Location = new Point(274,67);
            }
            else if (cboteam.SelectedItem.Equals("KT 위즈"))
            {
                lbFname.Text = "수원 KT 위즈파크";
                lbFaddress.Text = "경기 수원시 장안구 경수대로 893 수원종합운동장(주경기장)";
                linkTpage.Text = "https://www.ktwiz.co.kr/";
                lbTetc.Text = "2013년에 창단하여 경기도 수원을 연고지로 한 KBO 10번째 구단\n" +
                    "2020년 포스트시즌 진출하여 졍규시즌 2위, 최종순위 3위를 거두었다.\n" +
                    "마스코드 :  빅, 또리\n" +
                    "영구결번  :  없음\n";
                picball.Location = new Point(280,87);
            }
            else if (cboteam.SelectedItem.Equals("LG 트윈스"))
            {
                lbFname.Text = "서울 종합운동장 야구장(잠실)";
                lbFaddress.Text = "서울 송파구 올림픽로 19-2 서울종합운동장";
                linkTpage.Text = "https://www.lgtwins.com/service/html.ncd?view=/pc_twins/twins_main/twins_main";
                lbTetc.Text = "1982년에 창단, 연고지는 서울특별시이다. \n" +
                    "최초 82년 창단시 팀명은 MBC청룡이며 이후 1990년에 럭키금성에 인수되며 LG트윈스가 되었다.\n" +
                    "최초 우승은 1990년이며, 가장 최근 우승한 해는 1994년이다.\n" +
                    "마스코드 :  럭키, 스타\n" +
                    "영구결번  :  41번 김용수(투수), 9번 이병규(야수)\n";
                picball.Location = new Point(274, 67);
            }
            else if (cboteam.SelectedItem.Equals("키움 히어로즈"))
            {
                lbFname.Text = "고척스카이돔";
                lbFaddress.Text = "서울 구로구 경인로 430 고척스카이돔";
                linkTpage.Text = "https://www.heroesbaseball.co.kr/index.do";
                lbTetc.Text = "2008년에 창단하여 서울특별시를 연고지로 두었다.\n" +
                    "역대 최고성적은 한국시리즈에 진출 한 2014,2019년이다.\n" +
                    "마스코드 :  동글이, 돔돔이, 턱돌이\n" +
                    "영구결번  :  없음\n";
                picball.Location = new Point(274, 67);
            }
            else if (cboteam.SelectedItem.Equals("KIA 타이거즈"))
            {
                lbFname.Text = "광주 기아 챔피언스필드";
                lbFaddress.Text = "광주 북구 서림로 10 무등종합경기장";
                linkTpage.Text = "https://tigers.co.kr/";
                lbTetc.Text = "1982년에 창단하여 광주광역시에 연고를 두었다.\n" +
                    "최초 우승은 1983년, 가창 최근 우승한 해는 2017년이다. \n" +
                    "한국시리즈진출 시 우승 100%기록을 보유하고있다.\n" +
                    "마스코드 : 호연이, 호걸이, 호야\n" +
                    "영구결번  :  18번 선동열(투수), 7번 이종범(야수)\n";
                picball.Location = new Point(265,242);
            }
            else if (cboteam.SelectedItem.Equals("롯데 자이언츠"))
            {
                lbFname.Text = "부산 사직야구장";
                lbFaddress.Text = "부산 동래구 사직로 45";
                linkTpage.Text = "http://www.giantsclub.com/html/";
                lbTetc.Text = "부산광역시를 연고로 두고있으며, 1975년에 창단하여 실업야구팀을 운영하다 KBO리그에 진입한 구단.\n" +
                    "최초 우승은 1984년, 최종우승은 1992년이다.\n" +
                    "마스코드 :  누리\n" +
                    "영구결번  :  11변 최동원(투수)\n";
                picball.Location = new Point(390,231);
            }
            else if (cboteam.SelectedItem.Equals("삼성 라이온즈"))
            {
                lbFname.Text = "대구 삼성 라이온즈파크";
                lbFaddress.Text = "대구 수성구 야구전설로 1 대구삼성라이온즈파크";
                linkTpage.Text = "https://ncdinos.com/homepage.do";
                lbTetc.Text = "1982년에 창단하여 대구광역시를 연고지로 두었다.\n" +
                    "최초 우승은 1985년, 가장 최근 우승은 2014년이다.\n" +
                    "마스코드 :  블레오\n" +
                    "영구결번  :  10번 양준혁(야수), 22번 이만수(포수), 36번 이승엽(야수)\n";
                picball.Location = new Point(359,187);
            }
            else if (cboteam.SelectedItem.Equals("SSG 랜더스"))
            {
                lbFname.Text = "인천 SSG 랜더스필드";
                lbFaddress.Text = "인천 미추홀구 매소홀로 618";
                linkTpage.Text = "http://www.ssglanders.com/main";
                lbTetc.Text = "2000년에 창단하여 인천광역시를 연고지로 두었다.\n" +
                    "최초우승은 2007년 가장 최근 우승은 2018년이다.\n" +
                    "마스코드 :  랜디\n" +
                    "영구결번  :  26번 박경완(포수)\n";
                picball.Location = new Point(243, 67);
            }
            else if (cboteam.SelectedItem.Equals("한화 이글스"))
            {
                lbFname.Text = "한화생명 이글스파크";
                lbFaddress.Text = "대전 중구 대종로 373";
                linkTpage.Text = "https://www.hanwhaeagles.co.kr/index.do";
                lbTetc.Text = "1985년에 창단하여 대전광역시를 연고로 두었다.\n" +
                    "최초이자 최종 우승은 1999년이다.\n" +
                    "마스코드 :  위니, 비니, 수리\n" +
                    "영구결번  :  35번 장종훈(야수), 23번 정민철(투수), 21번 송진우(투수), 52번 김태균(야수)\n";
                picball.Location = new Point(295,160);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SQL DB연결
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=localhost;database=PlayerPG; uid=sa; pwd=612500";

            //SQl 명령어
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT TEAM,STYLE,NAME,HIGHT,WEIGHT,THISWAR,WASWAR FROM player";

            //DataAdapter와 Dataset으로 DB table 불러오기
            SqlDataAdapter da = new SqlDataAdapter(cmd);    //select구문 넣기
            DataSet ds = new DataSet();
            da.Fill(ds, "player");

            //DataGridView에 DB에서 가져온 데이터 뿌리기
            Gridshow.DataSource = ds;
            Gridshow.DataMember = "player";
            this.Gridshow.Columns[0].HeaderText = "구단명"; 
            this.Gridshow.Columns[1].HeaderText = "선수 유형";
            this.Gridshow.Columns[2].HeaderText = "이름";
            this.Gridshow.Columns[3].HeaderText = "키";
            this.Gridshow.Columns[4].HeaderText = "몸무게";
            this.Gridshow.Columns[5].HeaderText = "2021년 WAR";
            this.Gridshow.Columns[6].HeaderText = "2020년 WAR";
        }
    }
}
