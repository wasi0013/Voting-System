using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OVS
{
    public partial class Election : UserControl
    {
        public Election()
        {
            InitializeComponent();
        }
        Form activeform;
        string voterid, password;
        Boolean loggedin = false;
        Boolean key = true;
        public Election(Form form,Boolean log,string vid,string pass)
        {
            InitializeComponent();
            activeform = form;
            activeform.Controls.Clear();
            activeform.Controls.Add(this);
            activeform.Height = this.Height;
            activeform.Width = this.Width;
            activeform.Text = "Election";
            loggedin = log;
            voterid = vid;
            password = pass;
        }
        public void hideall() {
            button1.Hide();
            comboBox1.Hide();
            button2.Hide();
            comboBox2.Hide();

            button3.Hide();
            comboBox3.Hide();

        
        
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
        private void Election_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Home hm = new Home(activeform, loggedin, voterid, password);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideall();
            if (key)
            {
                comboBox3.Show();
                comboBox3.Items.Clear();
                string connstr = "Data Source=LEO\\SQLEXPRESS;Initial Catalog=ovs;Integrated Security=True";
                SqlConnection con = new SqlConnection(connstr);
                con.Open();
                SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT votearea from Standardvote where votename='upojelavote'", con);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                int i = -1, j = dt.Rows.Count;
                DataRow dr;
                while (++i < j)
                {
                    dr = dt.Rows[i];

                    comboBox3.Items.Add(dr.ItemArray[0].ToString());
                }
            } key = !key;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (loggedin)
            {
                QuickVote local = new QuickVote(activeform, loggedin, voterid, password, "localvote");
            }
            else
            {

                MessageBox.Show("Please log in, and come again");
            }
        }

        private void hill_tracts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //parbotto chittagong votes 
            if (loggedin)
            {
                QuickVote ctg = new QuickVote(activeform, loggedin, voterid, password, "ctgvote");
            }
            else
            {

                MessageBox.Show("Please log in, and come again");
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NationalElection ns = new NationalElection(activeform, loggedin, voterid, password);

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideall();
            if (key)
            {
                comboBox1.Show();
                comboBox1.Items.Clear();
                string connstr = "Data Source=LEO\\SQLEXPRESS;Initial Catalog=ovs;Integrated Security=True";
                SqlConnection con = new SqlConnection(connstr);
                con.Open();
                SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT votearea from Standardvote where votename='citycorporationvote'", con);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                int i = -1, j = dt.Rows.Count;
                DataRow dr;
                while (++i < j)
                {
                    dr = dt.Rows[i];

                    comboBox1.Items.Add(dr.ItemArray[0].ToString());
                }
            } key = !key;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideall();
            StandardVote st = new StandardVote(activeform,loggedin,voterid,password,"citycorporationvote",comboBox1.Text.Trim());
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideall();
            if (key)
            {
                comboBox2.Show();
                comboBox2.Items.Clear();
                string connstr = "Data Source=LEO\\SQLEXPRESS;Initial Catalog=ovs;Integrated Security=True";
                SqlConnection con = new SqlConnection(connstr);
                con.Open();
                SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT votearea from Standardvote where votename='pourashavavote'", con);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                int i = -1, j = dt.Rows.Count;
                DataRow dr;
                while (++i < j)
                {
                    dr = dt.Rows[i];

                    comboBox2.Items.Add(dr.ItemArray[0].ToString());
                }
            } key = !key;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideall();
            StandardVote st = new StandardVote(activeform, loggedin, voterid, password, "upojelavote", comboBox3.Text.Trim());
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideall();
            StandardVote st = new StandardVote(activeform, loggedin, voterid, password, "pourashavavote", comboBox2.Text.Trim());
        }
    }
}
