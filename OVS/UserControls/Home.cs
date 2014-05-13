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
    public partial class Home : UserControl
    {
        //This will hold the active form
        Form activeform;
        string text;
        //login checker default not logged in
        Boolean loggedin = false,key=false;
        int turn = 0;

        
        //voterid and password holder
        string voterid, password;

        static string connstr = "Data Source=LEO\\SQLEXPRESS;Initial Catalog=ovs;Integrated Security=True";
        static SqlConnection con = new SqlConnection(connstr);

        public Home(Form form,Boolean log,string vid,string pass)
        {
            //base constructor 
            InitializeComponent();
            
            //receive the passed form and decorates it
            activeform = form;
            activeform.Controls.Clear();
            activeform.Height = this.Height;
            activeform.Width = this.Width;
            activeform.Controls.Add(this);
            activeform.Text = "Home";
            
            con.Open();
            SqlDataAdapter mda = new SqlDataAdapter("select * from userinfo", con);
            DataTable dt = new DataTable();
            mda.Fill(dt);
            
            mda = new SqlDataAdapter("select event from history", con);
            DataTable dk= new DataTable();
            mda.Fill(dk);
            dataGridView1.DataSource = dk;


            
            con.Close();

            text = " Welcome to digital online voting system. Total users registered as voter so far is " + dt.Rows.Count + "      ";
            timer1.Start();

            //recieves login and account credentials
            loggedin = log;
            voterid = vid;
            password = pass;

            if (loggedin)
            {
                //successful login change the log in text
                Login_Label.Text = "লগ আউট (" + voterid + ")";
 
                //hide log in options
                pwd_label.Hide();
                Voterid_Box.Hide();
                label1.Hide();
                Password_Box.Hide();
                SignUp_label.Hide();
                Forget_Password_label.Hide();
            }
            else
            {
                //logged out? reset everything

                Login_Label.Text = "লগ ইন";
                pwd_label.Show();
                Voterid_Box.Show();
                label1.Show();
                Password_Box.Show();
                SignUp_label.Show();
                Forget_Password_label.Show();
            }

        }
        public Home(Form form)
        {
            //optional constructor
            InitializeComponent();
            activeform = form;
            activeform.Controls.Clear();
            activeform.Height = this.Height;
            activeform.Width = this.Width;
            activeform.Controls.Add(this);
            activeform.Text = "Home";

            con.Open();
            SqlDataAdapter mda = new SqlDataAdapter("select * from userinfo", con);
            DataTable dt=new DataTable();
            mda.Fill(dt);
            mda = new SqlDataAdapter("select event from history", con);
            DataTable dk = new DataTable();
            mda.Fill(dk);
            dataGridView1.DataSource = dk;
           




            con.Close();
            text = " Welcome to digital online voting system. Total users registered as voter so far is "+dt.Rows.Count+"      ";
            timer1.Start();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        
        private void User_info_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //invokes user information page

            if (loggedin)
            {
                //make sure user already logged in and invoke userinformation
                UserInformation userinformation = new UserInformation(activeform,loggedin,voterid,password);
            }
            else {

                MessageBox.Show("You must log in first");
            }
        }

        private void stats_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //invokes stats page
            Stats stats = new Stats(activeform,loggedin,voterid,password);
        }

        private void Quick_Vote_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (loggedin)
            {
                //make sure user logged in and invoke quickvote

                QuickVote quickvote = new QuickVote(activeform, loggedin, voterid, password,"quickvote");
            }
            else
            {
                MessageBox.Show("You must log in first");
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (loggedin)
            {
                Election election = new Election(activeform, loggedin, voterid, password);
            }
            else {

                MessageBox.Show("You must login first");
            }
            
        }

        private void Login_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (!loggedin)
            {
               
                //Voter id and password Field Data
                voterid = Voterid_Box.Text.Trim();
                password = Password_Box.Text.Trim();

                try
                {

                    con.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter mda = new SqlDataAdapter("select * from userinfo where (voterid=@voterid) AND (password=@password)", con);
                    mda.SelectCommand.Parameters.Add(new SqlParameter("voterid", voterid));
                    mda.SelectCommand.Parameters.Add(new SqlParameter("password", password));
                    mda.Fill(dt);
                    con.Close();
                    //Checking whether the user exists
                    if (dt.Rows.Count > 0 && voterid != "")
                    {

                        //login
                        loggedin = true;
                        Login_Label.Text = "লগ আউট ("+voterid+")";
                        
                        
                        pwd_label.Hide();
                        Voterid_Box.Hide();
                        label1.Hide();
                        Password_Box.Hide();
                        SignUp_label.Hide();
                        Forget_Password_label.Hide();

                        if (voterid == "13")
                        {

                            //TODO Show admin Controls
                        

                        }

                        else
                        {

                            //TODO Show general user control
                        }


                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                catch
                {
                    //invalid username or password
                    MessageBox.Show("Invalid voterid or password!");
                }
            }

            else {
                //reset log in 
                loggedin = false;
                Login_Label.Text = "লগ ইন";
                pwd_label.Show();
                Voterid_Box.Show();
                label1.Show();
                Password_Box.Show();
                SignUp_label.Show();
                Forget_Password_label.Show();
            }

        }

        private void SignUp_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //invoke sign up page
            Signup sg = new Signup(activeform,loggedin,voterid,password);
        }

        private void Voterid_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Forget_Password_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //todo implement password recovery
            MessageBox.Show("মনে করার চেষ্টা করুন","নির্মাণাধীন");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

          
                textBox1.Text += text.ElementAt(turn++%text.Length);
                if (turn % 30 == 0) {
                    if (key)
                    {
                        dataGridView1.Hide();
                        label2.Hide();
                    }
                    else {
                        dataGridView1.Show();
                        
                        label2.Show();
                    
                    
                    }
                    key = !key;
                
                
                }
            
            
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Stats st = new Stats(activeform,loggedin,voterid,password);
        }
    
        
    }
}