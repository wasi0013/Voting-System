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
            comboBox2.Items.Clear();
            comboBox2.Items.Add("team");

          
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //collect all the user information from the database
            SqlDataAdapter mda;
            mda = new SqlDataAdapter("select teamname as Team_Name , votecount as Vote_Count from team order by votecount ", con);
            mda.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
