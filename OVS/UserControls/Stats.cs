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
    public partial class Stats : UserControl
    {
        Form activeform;
        //combobox viewer for standard votes
        Boolean loggedin = false,combovote;
        
        string voterid, password,votename,votearea;

        //click toggler check wheather link label is clicked or not
        Boolean clicked = true;

        //static sql connections
        //fixed connection open and close issues
        static string connstr = "Data Source=LEO\\SQLEXPRESS;Initial Catalog=ovs;Integrated Security=True";
        static  SqlConnection con = new SqlConnection(connstr);

        public Stats()
        {
            //default constructor

            InitializeComponent();
        }
        public Stats(Form form,Boolean log,string vid,string pass)
        {
           //overloaded constructor

            InitializeComponent();
            activeform = form;
            activeform.Controls.Clear();
            activeform.Controls.Add(this);
            activeform.Height = this.Height;
            activeform.Width = this.Width;
            activeform.Text = "Stats";
            //get data
            loggedin = log;
            voterid = vid;
            password = pass;
            votename = "quickvote";
        }
        private void stats_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
        private void Stats_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        
            Home hm = new Home(activeform,loggedin,voterid,password);
        
        }

        private void On_going_vote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideAll();
            combovote = true;
            if (clicked)
            {
                chart1.Show();
                label1.Show();
                comboBox1.Show();
                comboBox1.Enabled = true;
                button2.Show();
                comboBox1.Items.Clear();
                comboBox1.Items.Add("quickvote");
                comboBox1.Items.Add("ctgvote");
                comboBox1.Items.Add("localvote");
                
            
            }
            
            
                clicked = !clicked;
            
            
        }

        public void hideAll()
        {
            chart1.Hide();
            label1.Hide();
            comboBox2.Hide();
            button2.Hide();
            comboBox1.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combovote) votename = comboBox1.Text;
            else { 
                votearea = comboBox1.Text; 
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                chart1.Series["Vote Result"].Points.Clear();
                con.Open();
                
                DataTable dt = new DataTable();
                //collect all the user information from the database table userinfo
                SqlDataAdapter mda;
                if (combovote)
                {
                    mda = new SqlDataAdapter("select * from " + votename, con);
                }
                else {
                    mda = new SqlDataAdapter("select voterid,votecount from " + votename+" where votearea='"+votearea+"'", con);
                }

                mda.Fill(dt);

                int i = dt.Rows.Count;
                while (i-- > 0)
                {
                    DataRow dr = dt.Rows[i];
                    chart1.Series["Vote Result"].Points.AddXY(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString());

                }

                SqlDataAdapter mdas;
                if (combovote)
                {
                    mdas = new SqlDataAdapter(@"select uname,voterid from userinfo where voterid in(select voterid from " + votename + " where votecount=(select max(votecount) from " + votename + "))", con);
                }
                else {
                    mdas = new SqlDataAdapter(@"select uname,voterid from userinfo where voterid in(select voterid from " + votename + " where (votecount=(select max(votecount) from " + votename + ") and votearea='"+votearea+"'))", con);
                
                }
                
                DataTable dts = new DataTable();
                mdas.Fill(dts);
                DataRow drs;
                int iss = dts.Rows.Count;
                string winner = "";
                while (iss-- > 0)
                {
                    drs = dts.Rows[iss];
                    winner += " " + drs.ItemArray[0].ToString() + " (" + drs.ItemArray[1].ToString() + ")";
                }
                label1.Text = "বিজয়ীঃ " + (winner == "" ? "No one yet! " : winner);
                con.Close();
            }


        }

        private void nationalvoteresult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideAll();
            if (clicked)
            {
                combovote = false;
                chart1.Show();
                label1.Show();
                button2.Show();
                comboBox2.Show();
                comboBox1.Show();
                comboBox1.Enabled = false;

            }


            clicked = !clicked;
            


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            votename = comboBox2.Text;
            comboBox1.Enabled = true;
            comboBox1.Items.Clear();
            con.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT votearea FROM standardvote where votename ='" + votename + "';", con);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            con.Close();
            int i = dt.Rows.Count;
            DataRow dr = dt.Rows[0];
            comboBox1.Items.Add(dr.ItemArray[0].ToString());
            while (i-- > 1)
            {
                dr = dt.Rows[i];

                comboBox1.Items.Add(dr.ItemArray[0].ToString());
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TeamStats ts = new TeamStats(activeform,loggedin,voterid,password);
        }

    }
}
