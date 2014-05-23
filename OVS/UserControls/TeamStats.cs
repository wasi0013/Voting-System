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
    public partial class TeamStats : UserControl
    {
        Form activeform;
        Boolean loggedin = false;
        string voterid, password;

        static string connstr = "Data Source=LEO\\SQLEXPRESS;Initial Catalog=ovs;Integrated Security=True";
        static SqlConnection con = new SqlConnection(connstr);

        public TeamStats(Form form,Boolean log,string vid,string pass)
        {
            InitializeComponent();
            activeform = form;
            activeform.Controls.Clear();
            activeform.Controls.Add(this);
            activeform.Height = this.Height;
            activeform.Width = this.Width;
            activeform.Text = "Team Stats";
            //get data
            loggedin = log;
            voterid = vid;
            password = pass;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("team");
            comboBox1.Items.Add("Seat");
            label2.Text = "বাছাই করুন";
            label2.Show();
            button2.Hide();
          
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //collect all the user information from the database
            if (comboBox1.Text == "team")
            {
                SqlDataAdapter mda;
                dt = new DataTable();
                mda = new SqlDataAdapter("select teamname as Team_Name , votecount as Vote_Count,SeatCount from team order by seatcount ", con);
                mda.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count > 0) {
                    DataRow dr = dt.Rows[dt.Rows.Count-1];
                    label1.Show();
                    label1.Text = ("বিজয়ী দলঃ "+dr.ItemArray[0].ToString());
                
                }
            }
            else if (comboBox1.Text == "Seat")
            {
                comboBox1.Items.Clear();

                label2.Text="আসনের নাম";
                SqlDataAdapter mda;
                dt = new DataTable();
                mda = new SqlDataAdapter("select seatname from seatvote", con);
                mda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    int i = dt.Rows.Count;

                    while (i-- > 0)
                    {
                        DataRow dr = dt.Rows[i];
                        comboBox1.Items.Add(dr.ItemArray[0].ToString().Trim());
                           
                    }
                }
            }
            else {
                SqlDataAdapter mda;
                dt = new DataTable();
                mda = new SqlDataAdapter("select userinfo.Uname as Candidate, teammember.teamname as Team_Name , teammember.votecount as Vote_Count from teammember INNER JOIN userinfo ON teammember.voterid=userinfo.voterid where teammember.seatid=(select seatid from seatvote where seatname='"+comboBox1.Text+"')", con);
                mda.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[dt.Rows.Count-1];
                    label1.Show();
                    label1.Text = ("বিজয়ীঃ " + dr.ItemArray[0].ToString());

                }
         
            
            
            
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Show();
        }
    }
}
