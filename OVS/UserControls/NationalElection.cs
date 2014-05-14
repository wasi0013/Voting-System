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
    public partial class NationalElection : UserControl
    {
        static string connstr = "Data Source=LEO\\SQLEXPRESS;Initial Catalog=ovs;Integrated Security=True";
        static SqlConnection con = new SqlConnection(connstr);

        Form activeform;
        string voterid, password;//,ets;
        //DateTime starttime, endtimes;
        Boolean loggedin = false,switche=true;

        public NationalElection(Form form, Boolean log, string vid, string pass)
        {
            InitializeComponent();
            activeform = form;
            activeform.Controls.Clear();
            activeform.Controls.Add(this);
            activeform.Height = this.Height;
            activeform.Width = this.Width;
            activeform.Text = "National Election";
            loggedin = log;
            voterid = vid;
            password = pass;
            hideall();
            if (voterid == "13") {
                linkLabel2.Text = "রেজিস্টার্ড প্রার্থী";
                linkLabel1.Text = "রেজিস্টার্ড টিম";
            
            
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home hm = new Home(activeform, loggedin, voterid, password);
        }

        private void NationalElection_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideall();
            if (voterid == "13")
            {
                //completed successfully

                con.Open();
                SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT  teammember.teamname as Team_Name, userinfo.uname as Team_Member, userinfo.voterid FROM teammember INNER JOIN userinfo ON userinfo.voterid = teammember.voterid", con);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                con.Close();
                dataGridView2.DataSource = dt;
                DataView dv = new DataView(dt);


                //show only data grid view 
                if (switche) dataGridView2.Show();
                switche = !switche;


            }
            else
            {
                //For general users
                //if vote is running or not scheduled yet then allow registration
                hideall();

                if (switche)
                {
                    button1.Show();
                    
                    comboBox1.Show();
                    comboBox2.Show();
                    
                    label2.Show();
                    label3.Show();
                    label4.Show();
                    
                    textBox2.Show();

                    comboBox1.Items.Clear();
                    SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT team.teamname, userinfo.uname FROM team INNER JOIN userinfo ON userinfo.voterid=team.voterid ", con);
                    DataTable dt = new DataTable();
                    dataadapter.Fill(dt);
                    int i = -1, j = dt.Rows.Count;
                    DataRow dr;
                    while (++i < j)
                    {
                        dr = dt.Rows[i];

                        comboBox1.Items.Add(dr.ItemArray[0].ToString()+"("+dr.ItemArray[1].ToString()+")");
                    }

                    comboBox2.Items.Clear();
                    dataadapter = new SqlDataAdapter("SELECT seatname,seatid from seatvote", con);
                    dt = new DataTable();
                    dataadapter.Fill(dt);
                    i = -1; j = dt.Rows.Count;

                    while (++i < j)
                    {
                        dr = dt.Rows[i];

                        comboBox2.Items.Add(dr.ItemArray[0].ToString() + "(" + dr.ItemArray[1].ToString() + ")");
                    }




                    
                }
                switche = !switche;
            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideall();
            if (voterid == "13")
            {
                //completed successfully

                con.Open();
                SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT  team.teamname as Team_Name, userinfo.uname as Team_Leader, userinfo.voterid as Voter_Id FROM team INNER JOIN userinfo ON userinfo.voterid = team.voterid", con);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
                DataView dv = new DataView(dt);


                //show only data grid view 
                if (switche) dataGridView1.Show();
                switche = !switche;


            }
            else
            {
                //For general users
                //if vote is running or not scheduled yet then allow registration
                hideall();

                if (switche)
                {
                    passbox.Show();
                    regbutton.Show();
                    passlabel.Show();
                    label1.Show();
                   
                    textBox1.Show();


                }
                switche = !switche;
            }
           
        }

        void hideall()
        {
            dataGridView1.Hide();
            regbutton.Hide();
            passbox.Hide();
            passlabel.Hide();
            textBox1.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            
            textBox2.Hide();
            button1.Hide();
            comboBox1.Hide();
            comboBox2.Hide();
            
            dataGridView2.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            //only visible to users when vote is running or not scheduled

            hideall();
            con.Open();

            if (passbox.Text.Trim() == password)
            {
                //check wheather password is correct and already registered?

                DataTable dt = new DataTable();
                SqlDataAdapter mda = new SqlDataAdapter("select * from team where (voterid=@voterid)", con);
                mda.SelectCommand.Parameters.Add(new SqlParameter("voterid", voterid));
                mda.Fill(dt);
                if (dt.Rows.Count > 0)
                {


                    MessageBox.Show("You are already registered");

                }
                else
                {
                    if (textBox1.Text.Trim() != "")
                    {
                        SqlCommand insert = new SqlCommand("Insert into team(teamname,voterid,votecount) values(@teamname,@voterid,@votecount);", con);
                        insert.Parameters.AddWithValue("teamname", textBox1.Text.Trim());
                        
                        insert.Parameters.AddWithValue("voterid", voterid);
                        insert.Parameters.AddWithValue("votecount", 0);
                        insert.ExecuteNonQuery();
                        insert = new SqlCommand("Insert into teammember(teamname,voterid,seatid) values(@teamname,@voterid,@seatid);", con);
                        insert.Parameters.AddWithValue("teamname", textBox1.Text.Trim());

                        insert.Parameters.AddWithValue("voterid", voterid);
                        insert.Parameters.AddWithValue("seatid", 1);
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Thanks for registering");
                    }
                    else {

                        MessageBox.Show("Team name invalid.");
                    }

                }

            }
            else
            {
                MessageBox.Show("Wrong password");
            }
            con.Close();

        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
