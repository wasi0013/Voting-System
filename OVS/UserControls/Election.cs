﻿using System;
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
        //Constructor parameters holder
        Form activeform; 
        string voterid, password;
        Boolean loggedin = false;

        Boolean key = true; //toggle
        
        //Static Sql Connection
        static string connstr = "Data Source=.\\SQLEXPRESS;Initial Catalog=ovs;Integrated Security=True";
        static SqlConnection con = new SqlConnection(connstr);
                    

        public Election(Form form,Boolean log,string vid,string pass)
        {
            InitializeComponent();
            //form decoration
            activeform = form;
            activeform.Controls.Clear();
            activeform.Controls.Add(this);
            activeform.Height = this.Height;
            activeform.Width = this.Width;
            activeform.Text = "Election";
            //collect parameters and store them
            loggedin = log;
            voterid = vid;
            password = pass;
            hideall();
        }
        public void hideall() {
            // a hide functions to hide all the buttons,combo box
            button1.Hide();
            comboBox1.Hide();
            button2.Hide();
            comboBox2.Hide();
            button3.Hide();
            comboBox3.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();

        
        
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
            //Upozilla vote link

            hideall();
            if (voterid == "13")
            {
                //admin controls
 
                if (key)
                {
                    //combo box 3 is for upozilla vote
                    comboBox3.Show();
                    label3.Show();
                    comboBox3.Items.Clear();

                    con.Open();
                    SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT votearea from Standardvote where votename='upojelavote'", con);
                    DataTable dt = new DataTable();
                    dataadapter.Fill(dt);
                    con.Close();

                    //populate comboBox3 with name of upozilla
                    int i = -1, j = dt.Rows.Count;
                    DataRow dr;
                    while (++i < j)
                    {
                        dr = dt.Rows[i];

                        comboBox3.Items.Add(dr.ItemArray[0].ToString());
                    }
                }
            }
            else
            {
                //general User controls

                comboBox3.Show();
                label3.Show();
                comboBox3.Items.Clear();
                con.Open();
                SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT upojela from userinfo where voterid='" + voterid + "'", con);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                con.Close();
                //populate the combo box 3 with upozilla name
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
            //local vote link

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
            //National Election link

            NationalElection ns = new NationalElection(activeform, loggedin, voterid, password);

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // City Corporation vote link
            hideall();
            if (voterid == "13")
            {
                //admin control
                if (key)
                {

                    comboBox1.Show();
                    label1.Show();
                    comboBox1.Items.Clear();
                    con.Open();
                    SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT votearea from Standardvote where votename='citycorporationvote'", con);
                    DataTable dt = new DataTable();
                    dataadapter.Fill(dt);
                    con.Close();
                    int i = -1, j = dt.Rows.Count;
                    DataRow dr;
                    while (++i < j)
                    {
                        dr = dt.Rows[i];

                        comboBox1.Items.Add(dr.ItemArray[0].ToString());
                    }
                }
            }
            else
            {

                comboBox1.Show();
                label1.Show();
                comboBox1.Items.Clear();
                con.Open();
                SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT citycorporation from userinfo where voterid='" + voterid + "'", con);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                con.Close();
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
            //only pops up the ok button if anything is selected
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
            if(voterid=="13"){
                if (key)
                {
                    comboBox2.Show();
                    comboBox2.Items.Clear();
                    label2.Show();
                    con.Open();
                    SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT votearea from Standardvote where votename='pourashavavote'", con);
                    DataTable dt = new DataTable();
                    dataadapter.Fill(dt);
                    con.Close();
                    int i = -1, j = dt.Rows.Count;
                    DataRow dr;
                    while (++i < j)
                    {
                        dr = dt.Rows[i];

                        comboBox2.Items.Add(dr.ItemArray[0].ToString());
                    }

                }
            }
                else {

                    comboBox2.Show();
                    comboBox2.Items.Clear();
                    label2.Show();
                    con.Open();
                    SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT pourashava from userinfo where voterid='"+voterid+"'", con);
                    DataTable dt = new DataTable();
                    dataadapter.Fill(dt);
                    con.Close();
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
