
namespace persnalPG
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cboteam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboplayst = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btserch = new System.Windows.Forms.Button();
            this.Gridshow = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTname = new System.Windows.Forms.Label();
            this.lbFname = new System.Windows.Forms.Label();
            this.lbFaddress = new System.Windows.Forms.Label();
            this.linkTpage = new System.Windows.Forms.LinkLabel();
            this.picball = new System.Windows.Forms.PictureBox();
            this.lbTetc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btNew = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Gridshow)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼엑스포", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "KBO선수조회";
            // 
            // cboteam
            // 
            this.cboteam.FormattingEnabled = true;
            this.cboteam.Items.AddRange(new object[] {
            "NC 다이노스",
            "두산 베어스",
            "KT 위즈",
            "LG 트윈스",
            "키움 히어로즈",
            "KIA 타이거즈",
            "롯데 자이언츠",
            "삼성 라이온즈",
            "SSG 랜더스",
            "한화 이글스"});
            this.cboteam.Location = new System.Drawing.Point(12, 48);
            this.cboteam.Name = "cboteam";
            this.cboteam.Size = new System.Drawing.Size(154, 23);
            this.cboteam.TabIndex = 1;
            this.cboteam.Text = "구단 선택";
            this.cboteam.TextChanged += new System.EventHandler(this.cboteam_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "구단 선택";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "선수 유형";
            // 
            // cboplayst
            // 
            this.cboplayst.FormattingEnabled = true;
            this.cboplayst.Items.AddRange(new object[] {
            "투수",
            "포수",
            "야수"});
            this.cboplayst.Location = new System.Drawing.Point(12, 127);
            this.cboplayst.Name = "cboplayst";
            this.cboplayst.Size = new System.Drawing.Size(154, 23);
            this.cboplayst.TabIndex = 1;
            this.cboplayst.Text = "선수 유형 선택";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "선수 이름";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(12, 205);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(174, 23);
            this.txtname.TabIndex = 3;
            this.txtname.Text = "외국인선수는 선수명(성) 입력";
            this.txtname.Click += new System.EventHandler(this.txtname_Click);
            // 
            // btserch
            // 
            this.btserch.Location = new System.Drawing.Point(794, 276);
            this.btserch.Name = "btserch";
            this.btserch.Size = new System.Drawing.Size(82, 26);
            this.btserch.TabIndex = 4;
            this.btserch.Text = "검색";
            this.btserch.UseVisualStyleBackColor = true;
            this.btserch.Click += new System.EventHandler(this.btserch_Click);
            // 
            // Gridshow
            // 
            this.Gridshow.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Gridshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridshow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Gridshow.Location = new System.Drawing.Point(3, 16);
            this.Gridshow.Name = "Gridshow";
            this.Gridshow.RowTemplate.Height = 23;
            this.Gridshow.Size = new System.Drawing.Size(882, 185);
            this.Gridshow.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTname);
            this.groupBox1.Controls.Add(this.lbFname);
            this.groupBox1.Controls.Add(this.lbFaddress);
            this.groupBox1.Controls.Add(this.linkTpage);
            this.groupBox1.Controls.Add(this.picball);
            this.groupBox1.Controls.Add(this.lbTetc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbname);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btNew);
            this.groupBox1.Controls.Add(this.btreset);
            this.groupBox1.Controls.Add(this.btserch);
            this.groupBox1.Controls.Add(this.cboteam);
            this.groupBox1.Controls.Add(this.cboplayst);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 317);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lbTname
            // 
            this.lbTname.AutoSize = true;
            this.lbTname.Location = new System.Drawing.Point(521, 19);
            this.lbTname.Name = "lbTname";
            this.lbTname.Size = new System.Drawing.Size(83, 15);
            this.lbTname.TabIndex = 10;
            this.lbTname.Text = "어쩌고 저쩌고";
            // 
            // lbFname
            // 
            this.lbFname.AutoSize = true;
            this.lbFname.Location = new System.Drawing.Point(521, 48);
            this.lbFname.Name = "lbFname";
            this.lbFname.Size = new System.Drawing.Size(99, 15);
            this.lbFname.TabIndex = 10;
            this.lbFname.Text = "겁나 대단한 구장";
            // 
            // lbFaddress
            // 
            this.lbFaddress.AutoSize = true;
            this.lbFaddress.Location = new System.Drawing.Point(521, 78);
            this.lbFaddress.Name = "lbFaddress";
            this.lbFaddress.Size = new System.Drawing.Size(101, 15);
            this.lbFaddress.TabIndex = 10;
            this.lbFaddress.Text = "무슨시 ㅇㅇ길 11";
            // 
            // linkTpage
            // 
            this.linkTpage.AutoSize = true;
            this.linkTpage.Location = new System.Drawing.Point(532, 109);
            this.linkTpage.Name = "linkTpage";
            this.linkTpage.Size = new System.Drawing.Size(31, 15);
            this.linkTpage.TabIndex = 9;
            this.linkTpage.TabStop = true;
            this.linkTpage.Text = "클릭";
            // 
            // picball
            // 
            this.picball.Image = ((System.Drawing.Image)(resources.GetObject("picball.Image")));
            this.picball.Location = new System.Drawing.Point(398, 22);
            this.picball.Name = "picball";
            this.picball.Size = new System.Drawing.Size(27, 26);
            this.picball.TabIndex = 8;
            this.picball.TabStop = false;
            // 
            // lbTetc
            // 
            this.lbTetc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbTetc.AutoEllipsis = true;
            this.lbTetc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTetc.Location = new System.Drawing.Point(458, 150);
            this.lbTetc.Name = "lbTetc";
            this.lbTetc.Size = new System.Drawing.Size(418, 118);
            this.lbTetc.TabIndex = 7;
            this.lbTetc.Text = "팀 설명 내용 주절주절";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "팀 설명";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "팀 홈페이지";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "구장 주소";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "구장명";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(455, 19);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(43, 15);
            this.lbname.TabIndex = 6;
            this.lbname.Text = "구단명";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(232, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 303);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(12, 276);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(82, 26);
            this.btNew.TabIndex = 4;
            this.btNew.Text = "신규입력";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(118, 276);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(82, 26);
            this.btreset.TabIndex = 4;
            this.btreset.Text = "내용지우기";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Gridshow);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(888, 204);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "선수DATA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(888, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gridshow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboteam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboplayst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btserch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Label lbTname;
        private System.Windows.Forms.Label lbFname;
        private System.Windows.Forms.Label lbFaddress;
        private System.Windows.Forms.LinkLabel linkTpage;
        private System.Windows.Forms.PictureBox picball;
        private System.Windows.Forms.Label lbTetc;
        private System.Windows.Forms.Button btNew;
        public System.Windows.Forms.DataGridView Gridshow;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

