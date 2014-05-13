namespace OVS
{
    partial class Stats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.voteresult = new System.Windows.Forms.LinkLabel();
            this.nationalvoteresult = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Title_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // voteresult
            // 
            this.voteresult.AutoSize = true;
            this.voteresult.BackColor = System.Drawing.Color.Transparent;
            this.voteresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.voteresult.LinkColor = System.Drawing.Color.White;
            this.voteresult.Location = new System.Drawing.Point(198, 139);
            this.voteresult.Name = "voteresult";
            this.voteresult.Size = new System.Drawing.Size(117, 26);
            this.voteresult.TabIndex = 0;
            this.voteresult.TabStop = true;
            this.voteresult.Text = "ভোট ফলাফল";
            this.voteresult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.On_going_vote_LinkClicked);
            // 
            // nationalvoteresult
            // 
            this.nationalvoteresult.AutoSize = true;
            this.nationalvoteresult.BackColor = System.Drawing.Color.Transparent;
            this.nationalvoteresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nationalvoteresult.LinkColor = System.Drawing.Color.White;
            this.nationalvoteresult.Location = new System.Drawing.Point(372, 139);
            this.nationalvoteresult.Name = "nationalvoteresult";
            this.nationalvoteresult.Size = new System.Drawing.Size(175, 26);
            this.nationalvoteresult.TabIndex = 1;
            this.nationalvoteresult.TabStop = true;
            this.nationalvoteresult.Text = "জাতীয় ভোট ফলাফল";
            this.nationalvoteresult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nationalvoteresult_LinkClicked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(553, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(27, 228);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.Name = "Vote Result";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1285, 458);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.BackColor = System.Drawing.Color.Transparent;
            this.Title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title_label.Location = new System.Drawing.Point(193, 60);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(606, 55);
            this.Title_label.TabIndex = 23;
            this.Title_label.Text = "ডিজিটাল অনলাইন ভোটিং সিস্টেম";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(632, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "বিজয়ীঃ ";
            this.label1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::OVS.Properties.Resources.Bangladesh_election_commission_logo;
            this.pictureBox1.Location = new System.Drawing.Point(27, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "quickvote",
            "localvote",
            "ctgvote"});
            this.comboBox1.Location = new System.Drawing.Point(203, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 28);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 28);
            this.button2.TabIndex = 27;
            this.button2.Text = "go";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "upojelavote",
            "pourashavavote",
            "citycorporationvote"});
            this.comboBox2.Location = new System.Drawing.Point(27, 189);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 28);
            this.comboBox2.TabIndex = 28;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::OVS.Properties.Resources._3d_488;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nationalvoteresult);
            this.Controls.Add(this.voteresult);
            this.DoubleBuffered = true;
            this.Name = "Stats";
            this.Size = new System.Drawing.Size(1375, 768);
            this.Load += new System.EventHandler(this.Stats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel voteresult;
        private System.Windows.Forms.LinkLabel nationalvoteresult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
