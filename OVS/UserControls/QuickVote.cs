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
    public partial class QuickVote : UserControl
    {
        static string connstr = "Data Source=LEO\\SQLEXPRESS;Initial Catalog=ovs;Integrated Security=True";
        static SqlConnection con = new SqlConnection(connstr);
            
        Form activeform;
        Boolean loggedin = false;
        string voterid, password,votename,ets="";
        Boolean switche = true;

        int hours = 0, mins = 0, secs = 0;
        // vote running?
        Boolean time = false;
        //start and endtime of the vote
        DateTime starttimes = DateTime.Now;
        DateTime endtimes = DateTime.Now;
        

        public QuickVote()
        {
            InitializeComponent();
        }
        public void hideaLL()
        {

            starttimelabel.Hide();
            starttimebox.Hide();
            endtimebox.Hide();
            endlabel.Hide();
            label1.Hide();
            textBox1.Hide();
            button1.Hide();
            comboBox1.Hide();
            dataGridView1.Hide();
            passbox.Hide();
            regbutton.Hide();
            passlabel.Hide();
            dateTimePicker1.Hide();
            label5.Hide();
        }
        public QuickVote(Form form, Boolean log, string vid, string pass,string voten)
        {
            InitializeComponent();
            activeform = form;
            activeform.Controls.Clear();
            activeform.Controls.Add(this);
            activeform.Height = this.Height;
            activeform.Width = this.Width;
            votename = voten;
            activeform.Text = votename;
            loggedin = log;
            voterid = vid;
            password = pass;
            //set date time picker in custom format for that will be used to start vote
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            if (voterid == "13")
            {
                linkLabel1.Text = "রেজিস্টার্ড প্রার্থী";
                linkLabel3.Text = "ভোট শুরু করুন";
                resetbutton.Show();

            }

            //First check whether vote already finished or not

            con.Open();
            SqlDataAdapter mda = new SqlDataAdapter("select startdate,enddate from admin where votename=@votename;", con);
            mda.SelectCommand.Parameters.Add(new SqlParameter("votename", votename));
            DataTable dt = new DataTable();
            mda.Fill(dt);
            con.Close();
            DataRow dr = dt.Rows[0];
            try
            {
                ets = dr.ItemArray[1].ToString();
               
                starttimes = DateTime.Parse(dr.ItemArray[0].ToString());
                endtimes = DateTime.Parse(dr.ItemArray[1].ToString());
                

            }
            catch
            {
                //vote is not scheduled yet so no running vote
                time = false;

            }
            if (starttimes < DateTime.Now && starttimes < endtimes && endtimes > DateTime.Now)
            {
                //check whether vote is running or finished
                time = true;
                timer1.Start();
                TimeSpan span = (endtimes - DateTime.Now);
                hours = span.Hours;
                mins = span.Minutes;
                secs = span.Seconds;


            }
            else if (endtimes < DateTime.Now)
            {
                //vote already finished update database
                con.Open();
                try
                {
                    //try updating admin page if fails then there is multiple winners!
                    SqlCommand insert = new SqlCommand("Update admin set voterid=(select voterid from "+votename+" where votecount=(select max(votecount) from "+votename+")) where votename=@votename;", con);
                    insert.Parameters.AddWithValue("votename", votename);
                    insert.ExecuteNonQuery();
                    try
                    {
                        insert = new SqlCommand("insert into history(event,dates) values('" + endtimes + " " + votename + " is finished','" + endtimes + "')", con);
                        insert.ExecuteNonQuery();
                    }
                    catch { 
                    
                    }
                        
                }
                catch
                {
                    //multiple winners! set admin id as winner 
                    con.Open();
                    SqlCommand insert = new SqlCommand("Update admin set voterid=13 where votename=@votename;", con);
                    insert.Parameters.AddWithValue("votename", votename);
                    insert.ExecuteNonQuery();
                    
                }
                con.Close();



            }


        }

        public QuickVote(Form form, Boolean log, string vid, string pass, string voten,Boolean National)
        {
            InitializeComponent();
            activeform = form;
            activeform.Controls.Clear();
            activeform.Controls.Add(this);
            activeform.Height = this.Height;
            activeform.Width = this.Width;
            votename = voten;
            activeform.Text = votename;
            loggedin = log;
            voterid = vid;
            password = pass;
            //set date time picker in custom format for that will be used to start vote
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            if (voterid == "13")
            {
                linkLabel1.Text = "রেজিস্টার্ড প্রার্থী";
                linkLabel3.Text = "ভোট শুরু করুন";
                resetbutton.Show();

            }

            //First check whether vote already finished or not

            con.Open();
            SqlDataAdapter mda = new SqlDataAdapter("select startdate,enddate from admin where votename=@votename;", con);
            mda.SelectCommand.Parameters.Add(new SqlParameter("votename", votename));
            DataTable dt = new DataTable();
            mda.Fill(dt);
            con.Close();
            DataRow dr = dt.Rows[0];
            try
            {
                ets = dr.ItemArray[1].ToString();

                starttimes = DateTime.Parse(dr.ItemArray[0].ToString());
                endtimes = DateTime.Parse(dr.ItemArray[1].ToString());


            }
            catch
            {
                //vote is not scheduled yet so no running vote
                time = false;

            }
            if (starttimes < DateTime.Now && starttimes < endtimes && endtimes > DateTime.Now)
            {
                //check whether vote is running or finished
                time = true;
                timer1.Start();
                TimeSpan span = (endtimes - DateTime.Now);
                hours = span.Hours;
                mins = span.Minutes;
                secs = span.Seconds;


            }
            else if (endtimes < DateTime.Now)
            {
                //vote already finished update database
                con.Open();
                try
                {
                    //try updating admin page if fails then there is multiple winners!
                    SqlCommand insert = new SqlCommand("Update admin set voterid=(select voterid from " + votename + " where votecount=(select max(votecount) from " + votename + ")) where votename=@votename;", con);
                    insert.Parameters.AddWithValue("votename", votename);
                    insert.ExecuteNonQuery();

                }
                catch
                {
                    //multiple winners! set admin id as winner 
                    con.Open();
                    SqlCommand insert = new SqlCommand("Update admin set voterid=13 where votename=@votename;", con);
                    insert.Parameters.AddWithValue("votename", votename);
                    insert.ExecuteNonQuery();

                }
                con.Close();



            }
        }

        private void Quick_Vote_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void QuickVote_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //fire jan link

            Home hm = new Home(activeform, loggedin, voterid, password);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (voterid == "13")
            {
                //admin? Show registered candidates for the next vote

                con.Open();
                SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT uname as Name , voterid as Voter_Id FROM userinfo where voterid in (SELECT voterid from "+votename+");", con);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
                DataView dv = new DataView(dt);

                hideaLL();
                //show only data grid view 
                if (switche) dataGridView1.Show();
                switche = !switche;


            }
            else if (endtimes > DateTime.Now || ets=="")
            {
                //For general users
                //if vote is running or not scheduled yet then allow registration
                hideaLL();

                if (switche)
                {
                    passbox.Show();
                    regbutton.Show();
                    passlabel.Show();



                }
                switche = !switche;
            }
            else {

                MessageBox.Show("Vote already Finished!");
            }
        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            //only visible to users when vote is running or not scheduled

            hideaLL();
            con.Open();

            if (passbox.Text.Trim() == password)
            {
                //check wheather password is correct and already registered?

                DataTable dt = new DataTable();
                SqlDataAdapter mda = new SqlDataAdapter("select * from " + votename + " where (voterid=@voterid)", con);
                mda.SelectCommand.Parameters.Add(new SqlParameter("voterid", voterid));
                mda.Fill(dt);
                if (dt.Rows.Count > 0)
                {


                    MessageBox.Show("You are already registered");

                }
                else
                
                {

                    SqlCommand insert = new SqlCommand("Insert into " + votename + "(voterid,votecount)values(@voterid,@votecount);", con);

                    insert.Parameters.AddWithValue("voterid", voterid);
                    insert.Parameters.AddWithValue("votecount", 0);
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Thanks for registering");

                }

            }
            else {
                MessageBox.Show("Wrong password");
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //voter shomoikal
            hideaLL();
            if (switche)
            {
                con.Open();
                SqlDataAdapter mda = new SqlDataAdapter("select startdate,enddate from admin where votename=@votename;", con);
                mda.SelectCommand.Parameters.Add(new SqlParameter("votename", votename));
                DataTable dt = new DataTable();
                mda.Fill(dt);
                con.Close();
                DataRow dr = dt.Rows[0];
                starttimebox.Text = dr.ItemArray[0].ToString();
                endtimebox.Text = dr.ItemArray[1].ToString();
                starttimebox.Show();
                starttimelabel.Show();
                endlabel.Show();
                endtimebox.Show();



            }

            switche = !switche;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideaLL();
            if (time || voterid == "13")
            {
                if (switche)
                {
                    button1.Show();
                    if (voterid == "13")
                    {
                        label1.Show();
                        label1.Text = "শেষ হবে?";

                        //textBox1 is not necessary anymore as we are using datetime picker
                        
                        //textBox1.Show();
                        dateTimePicker1.Show();
                        




                    }
                    else
                    {
                        //check already voted?
                        con.Open();
                        DataTable dk = new DataTable();
                        SqlDataAdapter mda = new SqlDataAdapter("select * from "+votename+"r where (voterid=@voterid)", con);
                        mda.SelectCommand.Parameters.Add(new SqlParameter("voterid", voterid));
                        mda.Fill(dk);
                        con.Close();

                        if (dk.Rows.Count > 0)
                        {

                            MessageBox.Show("You already voted once so can't vote again!");
                            QuickVote hm = new QuickVote(activeform, loggedin, voterid, password,votename);

                        }
                        else
                        {


                            button1.Text = "ভোট দিন";
                            textBox1.Show();
                            label5.Show();
                            label5.Text = "প্রার্থীর নাম";
                            label1.Show();
                            label1.Text = "পাসওয়ার্ড?";
                            comboBox1.Show();
                            con.Open();
                            SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT uname as Name , voterid as Voter_Id FROM userinfo where voterid in (SELECT voterid from "+votename+");", con);
                            DataTable dt = new DataTable();
                            dataadapter.Fill(dt);
                            con.Close();
                            int i = dt.Rows.Count;
                            DataRow dr = dt.Rows[0];
                            comboBox1.Items.Add(dr.ItemArray[0].ToString());
                            comboBox1.Text = dr.ItemArray[0].ToString();
                            while (i-- > 1)
                            {
                                dr = dt.Rows[i];

                                comboBox1.Items.Add(dr.ItemArray[0].ToString());
                            }


                        }
                    }
                }
                switche = !switche;
            }
            else
            {
                MessageBox.Show("No running Vote");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hideaLL();
            if (voterid == "13")
            {
                con.Open();
                SqlCommand insert = new SqlCommand("Update admin set startdate=@startdate, enddate = @enddate where votename=@votename;", con);
                insert.Parameters.AddWithValue("votename", votename);
                try
                {
                    insert.Parameters.AddWithValue("enddate", DateTime.Parse(textBox1.Text.Trim()).ToString());

                    insert.Parameters.AddWithValue("startdate", DateTime.Now.ToString());
                    if (DateTime.Parse(textBox1.Text.Trim()) < DateTime.Now)
                    {
                        //raise error when vote end time is invalid

                        int x = 0, t = 1;
                        t /= x;

                    }
                    insert.ExecuteNonQuery();
                    
                    MessageBox.Show("The vote has begun");
                    con.Close();
                    QuickVote ne = new QuickVote(activeform, loggedin, voterid, password, votename);
                 
            
                }
                catch{
                    MessageBox.Show("Invalid Date");
                    con.Close();
                }
                
                
            
            }
            else if (time)
            {
                if (textBox1.Text.Trim() == password)
                {
                    string votedfor = comboBox1.Text.Trim();
                    con.Open();
                    SqlCommand insert = new SqlCommand("Update "+votename+" set votecount= votecount+1 where voterid=(select voterid from userinfo where uname ='" + votedfor + "');", con);
                    insert.ExecuteNonQuery();
                    insert = new SqlCommand("insert into "+votename+"r(voterid) values(" + voterid + ");", con);
                    insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("আপনার মূল্যবান ভোটটি প্রদান করার জন্য ধন্যবাদ!");
                
                }
                else
                {
                    MessageBox.Show("Wrong Password!");

                }

            }
            else
            {

                MessageBox.Show("No running Vote");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hours == 0 && mins == 0 && secs == 0)
            {
                timer1.Stop();
                time = false;
                lblHr.Text = "00";
                lblMin.Text = "00";
                lblSec.Text = "00";
                con.Open();
                try
                {
                    SqlCommand insert = new SqlCommand("Update admin set voterid=(select voterid from "+votename+" where votecount=(select max(votecount) from "+votename+")) where votename=@votename;", con);
                    insert.Parameters.AddWithValue("votename", votename);
                    insert.ExecuteNonQuery();
                    SqlDataAdapter mda = new SqlDataAdapter(@"SELECT uname FROM userinfo WHERE (voterid =(SELECT voterid FROM admin WHERE(votename = '"+votename+"')))", con);
                    DataTable dt = new DataTable();
                    mda.Fill(dt);
                    DataRow dr = dt.Rows[0];
                    MessageBox.Show("Congrats! " + dr.ItemArray[0].ToString() + " for winning this Vote!");


                }
                catch
                {
                    //multiple winners!
                    MessageBox.Show("We got tie!");
                    SqlCommand insert = new SqlCommand("Update admin set voterid=13 where votename=@votename;", con);
                    insert.Parameters.AddWithValue("votename", votename);
                    insert.ExecuteNonQuery();
                    SqlDataAdapter mda = new SqlDataAdapter(@"select voterid from "+votename+" where votecount=(select max(votecount) from "+votename+")", con);
                    DataTable dt = new DataTable();
                    mda.Fill(dt);
                    DataRow dr = dt.Rows[0];
                    int i = dt.Rows.Count;
                    string winner = "";
                    while (i-- > 0)
                    {
                        dr = dt.Rows[i];
                        winner += " " + dr.ItemArray[0].ToString();
                    }
                    MessageBox.Show("Congrats! " + winner + " You all got highest individual vote");


                }
                con.Close();



            }
            else
            {
                if (secs < 1)
                {
                    secs = 59;
                    if (mins < 1)
                    {
                        mins = 59;
                        if (hours != 0)
                            hours -= 1;
                    }
                    else mins -= 1;

                }
                else secs -= 1;
                if (hours > 9)
                    lblHr.Text = hours.ToString();
                else lblHr.Text = "0" + hours.ToString();
                if (mins > 9)
                    lblMin.Text = mins.ToString();
                else lblMin.Text = "0" + mins.ToString();
                if (secs > 9)
                    lblSec.Text = secs.ToString();
                else lblSec.Text = "0" + secs.ToString();
            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("আপনি কি নিশ্চিত? ভোট সম্পর্কিত সব তথ্য মুছে ফেলা হবে!", "সতর্কবার্তা!", MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                con.Open();
                SqlCommand insert = new SqlCommand("TRUNCATE table "+votename, con);
                
                insert.ExecuteNonQuery();

                insert = new SqlCommand("TRUNCATE table "+votename+"r", con);
                
                insert.ExecuteNonQuery();
                insert = new SqlCommand("Update admin set startdate=NULL, enddate = NULL,voterid=NULL where votename=@votename;", con);
                insert.Parameters.AddWithValue("votename", votename);
                insert.ExecuteNonQuery();
                MessageBox.Show( votename+" is reseted to default!");
                con.Close();
            }



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text =dateTimePicker1.Value.ToString();
        }
    }
}
