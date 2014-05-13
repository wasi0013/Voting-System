namespace OVS
{
    partial class StandardVote
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
            this.resetbutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSec = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.endlabel = new System.Windows.Forms.Label();
            this.endtimebox = new System.Windows.Forms.TextBox();
            this.starttimelabel = new System.Windows.Forms.Label();
            this.starttimebox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.regbutton = new System.Windows.Forms.Button();
            this.passlabel = new System.Windows.Forms.Label();
            this.passbox = new System.Windows.Forms.TextBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.Title_label = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // resetbutton
            // 
            this.resetbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.resetbutton.Location = new System.Drawing.Point(985, 145);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(111, 34);
            this.resetbutton.TabIndex = 69;
            this.resetbutton.Text = "reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Visible = false;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(601, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 68;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.BackColor = System.Drawing.Color.Transparent;
            this.lblSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblSec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSec.Location = new System.Drawing.Point(1187, 69);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(39, 29);
            this.lblSec.TabIndex = 67;
            this.lblSec.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMin.Location = new System.Drawing.Point(1117, 69);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(39, 29);
            this.lblMin.TabIndex = 66;
            this.lblMin.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1162, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 29);
            this.label4.TabIndex = 65;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1092, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 64;
            this.label3.Text = ":";
            // 
            // lblHr
            // 
            this.lblHr.AutoSize = true;
            this.lblHr.BackColor = System.Drawing.Color.Transparent;
            this.lblHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblHr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHr.Location = new System.Drawing.Point(1057, 69);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(39, 29);
            this.lblHr.TabIndex = 63;
            this.lblHr.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(943, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 62;
            this.label2.Text = "Time Left:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 61;
            this.button1.Text = "ভোট আরম্ভ করুন";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(519, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 60;
            this.label1.Text = "শেষ হবে?";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(601, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 59;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.Visible = false;
            // 
            // endlabel
            // 
            this.endlabel.AutoSize = true;
            this.endlabel.BackColor = System.Drawing.Color.Black;
            this.endlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.endlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.endlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.endlabel.Location = new System.Drawing.Point(301, 242);
            this.endlabel.Name = "endlabel";
            this.endlabel.Size = new System.Drawing.Size(39, 24);
            this.endlabel.TabIndex = 58;
            this.endlabel.Text = "শেষ";
            this.endlabel.Visible = false;
            // 
            // endtimebox
            // 
            this.endtimebox.Location = new System.Drawing.Point(389, 242);
            this.endtimebox.Name = "endtimebox";
            this.endtimebox.ReadOnly = true;
            this.endtimebox.Size = new System.Drawing.Size(185, 20);
            this.endtimebox.TabIndex = 57;
            this.endtimebox.Visible = false;
            // 
            // starttimelabel
            // 
            this.starttimelabel.AutoSize = true;
            this.starttimelabel.BackColor = System.Drawing.Color.Black;
            this.starttimelabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.starttimelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.starttimelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.starttimelabel.Location = new System.Drawing.Point(301, 193);
            this.starttimelabel.Name = "starttimelabel";
            this.starttimelabel.Size = new System.Drawing.Size(39, 24);
            this.starttimelabel.TabIndex = 56;
            this.starttimelabel.Text = "শুরু";
            this.starttimelabel.Visible = false;
            // 
            // starttimebox
            // 
            this.starttimebox.Location = new System.Drawing.Point(389, 193);
            this.starttimebox.Name = "starttimebox";
            this.starttimebox.ReadOnly = true;
            this.starttimebox.Size = new System.Drawing.Size(185, 20);
            this.starttimebox.TabIndex = 55;
            this.starttimebox.Visible = false;
            this.starttimebox.TextChanged += new System.EventHandler(this.starttimebox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(308, 244);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.Visible = false;
            // 
            // regbutton
            // 
            this.regbutton.Location = new System.Drawing.Point(104, 241);
            this.regbutton.Name = "regbutton";
            this.regbutton.Size = new System.Drawing.Size(228, 34);
            this.regbutton.TabIndex = 53;
            this.regbutton.Text = "Register as Candidate";
            this.regbutton.UseVisualStyleBackColor = true;
            this.regbutton.Visible = false;
            this.regbutton.Click += new System.EventHandler(this.regbutton_Click);
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.BackColor = System.Drawing.Color.Transparent;
            this.passlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.passlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passlabel.Location = new System.Drawing.Point(100, 193);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(74, 22);
            this.passlabel.TabIndex = 52;
            this.passlabel.Text = "পাসওয়ার্ড";
            this.passlabel.Visible = false;
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(188, 193);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(144, 20);
            this.passbox.TabIndex = 51;
            this.passbox.UseSystemPasswordChar = true;
            this.passbox.Visible = false;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkColor = System.Drawing.Color.White;
            this.linkLabel4.Location = new System.Drawing.Point(782, 142);
            this.linkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(85, 26);
            this.linkLabel4.TabIndex = 50;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "ফিরে যান";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
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
            this.Title_label.TabIndex = 48;
            this.Title_label.Text = "ডিজিটাল অনলাইন ভোটিং সিস্টেম";
            this.Title_label.Click += new System.EventHandler(this.Title_label_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(608, 142);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(83, 26);
            this.linkLabel3.TabIndex = 47;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "ভোট দিন";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(408, 142);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(144, 26);
            this.linkLabel2.TabIndex = 46;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ভোটের সময়কাল";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(185, 142);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(149, 26);
            this.linkLabel1.TabIndex = 45;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "প্রার্থী রেজিস্ট্রেশান";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::OVS.Properties.Resources.Bangladesh_election_commission_logo;
            this.pictureBox1.Location = new System.Drawing.Point(27, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(601, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 70;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // StandardVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::OVS.Properties.Resources._11testParliament_House_at_night;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.endlabel);
            this.Controls.Add(this.endtimebox);
            this.Controls.Add(this.starttimelabel);
            this.Controls.Add(this.starttimebox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.regbutton);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.DoubleBuffered = true;
            this.Name = "StandardVote";
            this.Size = new System.Drawing.Size(1375, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label endlabel;
        private System.Windows.Forms.TextBox endtimebox;
        private System.Windows.Forms.Label starttimelabel;
        private System.Windows.Forms.TextBox starttimebox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button regbutton;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
