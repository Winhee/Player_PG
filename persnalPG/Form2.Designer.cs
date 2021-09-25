
namespace persnalPG
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboTeam = new System.Windows.Forms.ComboBox();
            this.cboplayst = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWAR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpastyear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txthight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboTeam
            // 
            this.cboTeam.FormattingEnabled = true;
            this.cboTeam.Items.AddRange(new object[] {
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
            this.cboTeam.Location = new System.Drawing.Point(29, 97);
            this.cboTeam.Name = "cboTeam";
            this.cboTeam.Size = new System.Drawing.Size(210, 20);
            this.cboTeam.TabIndex = 4;
            this.cboTeam.Text = "구단 선택";
            // 
            // cboplayst
            // 
            this.cboplayst.FormattingEnabled = true;
            this.cboplayst.Items.AddRange(new object[] {
            "투수",
            "포수",
            "야수"});
            this.cboplayst.Location = new System.Drawing.Point(29, 153);
            this.cboplayst.Name = "cboplayst";
            this.cboplayst.Size = new System.Drawing.Size(104, 20);
            this.cboplayst.TabIndex = 5;
            this.cboplayst.Text = "선수 유형 선택";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(29, 207);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(210, 21);
            this.txtname.TabIndex = 9;
            this.txtname.Text = "외국인선수는 선수명(성) 입력";
            this.txtname.Click += new System.EventHandler(this.txtname_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "구단 선택";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "선수 이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "선수 유형";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼엑스포", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "신규입력";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "이번 시즌 WAR";
            // 
            // txtWAR
            // 
            this.txtWAR.Location = new System.Drawing.Point(27, 324);
            this.txtWAR.Name = "txtWAR";
            this.txtWAR.Size = new System.Drawing.Size(88, 21);
            this.txtWAR.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "직전 시즌 WAR";
            // 
            // txtpastyear
            // 
            this.txtpastyear.Location = new System.Drawing.Point(143, 324);
            this.txtpastyear.Name = "txtpastyear";
            this.txtpastyear.Size = new System.Drawing.Size(96, 21);
            this.txtpastyear.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "키";
            // 
            // txthight
            // 
            this.txthight.Location = new System.Drawing.Point(29, 265);
            this.txthight.Name = "txthight";
            this.txthight.Size = new System.Drawing.Size(85, 21);
            this.txthight.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "몸무게";
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(141, 265);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(96, 21);
            this.txtweight.TabIndex = 9;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(140, 366);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(104, 23);
            this.btSave.TabIndex = 11;
            this.btSave.Text = "저장";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "네이버 검색";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "투타 유형";
            // 
            // txtRL
            // 
            this.txtRL.Location = new System.Drawing.Point(143, 153);
            this.txtRL.Name = "txtRL";
            this.txtRL.Size = new System.Drawing.Size(96, 21);
            this.txtRL.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(267, 417);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.cboTeam);
            this.Controls.Add(this.cboplayst);
            this.Controls.Add(this.txtRL);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.txthight);
            this.Controls.Add(this.txtpastyear);
            this.Controls.Add(this.txtWAR);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTeam;
        private System.Windows.Forms.ComboBox cboplayst;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWAR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpastyear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txthight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRL;
    }
}