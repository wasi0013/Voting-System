namespace OVS
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Title_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Helper = new System.Windows.Forms.ToolTip(this.components);
            this.Login_Label = new System.Windows.Forms.LinkLabel();
            this.User_info_label = new System.Windows.Forms.LinkLabel();
            this.stats_label = new System.Windows.Forms.LinkLabel();
            this.Quick_Vote_label = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pwd_label = new System.Windows.Forms.Label();
            this.Forget_Password_label = new System.Windows.Forms.LinkLabel();
            this.SignUp_label = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.Copyright_label = new System.Windows.Forms.Label();
            this.Voterid_Box = new System.Windows.Forms.TextBox();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.BackColor = System.Drawing.Color.Transparent;
            this.Title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title_label.Location = new System.Drawing.Point(180, 41);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(606, 55);
            this.Title_label.TabIndex = 0;
            this.Title_label.Text = "ডিজিটাল অনলাইন ভোটিং সিস্টেম";
            this.Helper.SetToolTip(this.Title_label, "Digital Online Voting System");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::OVS.Properties.Resources.Bangladesh_election_commission_logo;
            this.pictureBox1.Location = new System.Drawing.Point(14, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Label.LinkColor = System.Drawing.Color.White;
            this.Login_Label.Location = new System.Drawing.Point(1045, 127);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(66, 26);
            this.Login_Label.TabIndex = 3;
            this.Login_Label.TabStop = true;
            this.Login_Label.Text = "লগ ইন";
            this.Helper.SetToolTip(this.Login_Label, "Log in");
            this.Login_Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Login_Label_LinkClicked);
            // 
            // User_info_label
            // 
            this.User_info_label.AutoSize = true;
            this.User_info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_info_label.LinkColor = System.Drawing.Color.White;
            this.User_info_label.Location = new System.Drawing.Point(788, 127);
            this.User_info_label.Name = "User_info_label";
            this.User_info_label.Size = new System.Drawing.Size(152, 26);
            this.User_info_label.TabIndex = 4;
            this.User_info_label.TabStop = true;
            this.User_info_label.Text = "ব্যবহারকারীর তথ্য";
            this.Helper.SetToolTip(this.User_info_label, "User Infomation");
            this.User_info_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.User_info_label_LinkClicked);
            // 
            // stats_label
            // 
            this.stats_label.AutoSize = true;
            this.stats_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stats_label.LinkColor = System.Drawing.Color.White;
            this.stats_label.Location = new System.Drawing.Point(571, 127);
            this.stats_label.Name = "stats_label";
            this.stats_label.Size = new System.Drawing.Size(172, 26);
            this.stats_label.TabIndex = 5;
            this.stats_label.TabStop = true;
            this.stats_label.Text = "ভোট তথ্য ও ফলাফল";
            this.Helper.SetToolTip(this.stats_label, "Vote Stats");
            this.stats_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.stats_label_LinkClicked);
            // 
            // Quick_Vote_label
            // 
            this.Quick_Vote_label.AutoSize = true;
            this.Quick_Vote_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quick_Vote_label.LinkColor = System.Drawing.Color.White;
            this.Quick_Vote_label.Location = new System.Drawing.Point(389, 127);
            this.Quick_Vote_label.Name = "Quick_Vote_label";
            this.Quick_Vote_label.Size = new System.Drawing.Size(98, 26);
            this.Quick_Vote_label.TabIndex = 6;
            this.Quick_Vote_label.TabStop = true;
            this.Quick_Vote_label.Text = "তড়িৎ ভোট";
            this.Helper.SetToolTip(this.Quick_Vote_label, "Quick Vote");
            this.Quick_Vote_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Quick_Vote_label_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(185, 127);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(126, 26);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "জাতীয় নির্বাচন";
            this.Helper.SetToolTip(this.linkLabel1, "National Election");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1046, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ভোটার আইডি";
            this.Helper.SetToolTip(this.label1, "Voter Id");
            // 
            // pwd_label
            // 
            this.pwd_label.AutoSize = true;
            this.pwd_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pwd_label.Location = new System.Drawing.Point(1046, 73);
            this.pwd_label.Name = "pwd_label";
            this.pwd_label.Size = new System.Drawing.Size(60, 20);
            this.pwd_label.TabIndex = 10;
            this.pwd_label.Text = "পাসওয়ার্ড";
            this.Helper.SetToolTip(this.pwd_label, "Password");
            // 
            // Forget_Password_label
            // 
            this.Forget_Password_label.AutoSize = true;
            this.Forget_Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forget_Password_label.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.Forget_Password_label.Location = new System.Drawing.Point(1127, 127);
            this.Forget_Password_label.Name = "Forget_Password_label";
            this.Forget_Password_label.Size = new System.Drawing.Size(194, 26);
            this.Forget_Password_label.TabIndex = 12;
            this.Forget_Password_label.TabStop = true;
            this.Forget_Password_label.Text = "পাসওয়ার্ড ভুলে গেছেন?";
            this.Helper.SetToolTip(this.Forget_Password_label, "Forgot Password?");
            this.Forget_Password_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Forget_Password_label_LinkClicked);
            // 
            // SignUp_label
            // 
            this.SignUp_label.AutoSize = true;
            this.SignUp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_label.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.SignUp_label.Location = new System.Drawing.Point(1045, 172);
            this.SignUp_label.Name = "SignUp_label";
            this.SignUp_label.Size = new System.Drawing.Size(184, 26);
            this.SignUp_label.TabIndex = 13;
            this.SignUp_label.TabStop = true;
            this.SignUp_label.Text = "অ্যাকাউন্ট তৈরি করুন";
            this.Helper.SetToolTip(this.SignUp_label, "Need an Account? Click Here");
            this.SignUp_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUp_label_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1132, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "সাম্প্রতিক কার্যক্রম";
            this.Helper.SetToolTip(this.label2, "Password");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Copyright_label
            // 
            this.Copyright_label.AutoSize = true;
            this.Copyright_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copyright_label.ForeColor = System.Drawing.Color.White;
            this.Copyright_label.Location = new System.Drawing.Point(454, 625);
            this.Copyright_label.Name = "Copyright_label";
            this.Copyright_label.Size = new System.Drawing.Size(274, 26);
            this.Copyright_label.TabIndex = 2;
            this.Copyright_label.Text = "Copyright Protected 2014©";
            // 
            // Voterid_Box
            // 
            this.Voterid_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voterid_Box.Location = new System.Drawing.Point(1132, 41);
            this.Voterid_Box.Name = "Voterid_Box";
            this.Voterid_Box.Size = new System.Drawing.Size(104, 26);
            this.Voterid_Box.TabIndex = 9;
            this.Voterid_Box.TextChanged += new System.EventHandler(this.Voterid_Box_TextChanged);
            // 
            // Password_Box
            // 
            this.Password_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Box.Location = new System.Drawing.Point(1132, 75);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.PasswordChar = '*';
            this.Password_Box.Size = new System.Drawing.Size(104, 26);
            this.Password_Box.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(17, 593);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(1304, 29);
            this.textBox1.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 130;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(1084, 511);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(237, 59);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::OVS.Properties.Resources._11testParliament_House_at_night;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SignUp_label);
            this.Controls.Add(this.Forget_Password_label);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.pwd_label);
            this.Controls.Add(this.Voterid_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Quick_Vote_label);
            this.Controls.Add(this.stats_label);
            this.Controls.Add(this.User_info_label);
            this.Controls.Add(this.Login_Label);
            this.Controls.Add(this.Copyright_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Title_label);
            this.DoubleBuffered = true;
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1375, 768);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip Helper;
        private System.Windows.Forms.Label Copyright_label;
        private System.Windows.Forms.LinkLabel Login_Label;
        private System.Windows.Forms.LinkLabel User_info_label;
        private System.Windows.Forms.LinkLabel stats_label;
        private System.Windows.Forms.LinkLabel Quick_Vote_label;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Voterid_Box;
        private System.Windows.Forms.Label pwd_label;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.LinkLabel Forget_Password_label;
        private System.Windows.Forms.LinkLabel SignUp_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
       
    }
}
