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
    public partial class StandardVote : UserControl
    {

        static string connstr = "Data Source=LEO\\SQLEXPRESS;Initial Catalog=ovs;Integrated Security=True";
        static SqlConnection con = new SqlConnection(connstr);

        Form activeform;
        Boolean loggedin = false;
        string voterid, password, votename,votearea,ets;
        Boolean switche = true;

        int hours = 0, mins = 0, secs = 0;
        // vote running?
        Boolean time = false;
        //start and endtime of the vote
        DateTime starttimes = DateTime.Now;
        DateTime endtimes = DateTime.Now;

        public void hideaLL() {

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
        
        
        }
        public StandardVote()
        {
            InitializeComponent();
        }

        public StandardVote(Form form, Boolean log, string vid, string pass, string voten,string votea) {
            InitializeComponent();
            activeform = form;
            activeform.Controls.Clear();
            activeform.Controls.Add(this);
            activeform.Height = this.Height;
            activeform.Width = this.Width;
            votename = voten;
            votearea = votea;
            activeform.Text = votename+" ("+votearea+")";
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
            //works!
            SqlDataAdapter mda = new SqlDataAdapter("select startdate,enddate from standardvote where (votename=@votename AND votearea=@votearea);", con);
            mda.SelectCommand.Parameters.Add(new SqlParameter("votename", votename));
            mda.SelectCommand.Parameters.Add(new SqlParameter("votearea", votearea));
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

                try
                {
                    ///watch out NEED FIXING!
                    //try updating admin page if fails then there is multiple winners!
                    con.Open();
                    SqlCommand insert = new SqlCommand("Update standardvote set voterid=(select voterid from " + votename + " where votecount=(select max(votecount) from " + votename + " where votearea='"+votearea+"')) where (votename=@votename AND votearea=@votearea);", con);
                    insert.Parameters.AddWithValue("votename", votename);
                    insert.Parameters.AddWithValue("votearea", votearea);
                    insert.ExecuteNonQuery();
                    con.Close();

                }
                catch
                {
                    //multiple winners! set admin id as winner
                    con.Open();
                    SqlCommand insert = new SqlCommand("Update standardvote set voterid=13 where (votename=@votename AND votearea= @votearea);", con);
                    insert.Parameters.AddWithValue("votename", votename);
                    insert.Parameters.AddWithValue("votearea", votearea);
                    insert.ExecuteNonQuery();
                    con.Close();
                }



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
                    SqlCommand insert = new SqlCommand("Update standardvote set voterid=(select voterid from " + votename + " where votecount=(select max(votecount) from " + votename + " where votearea='" + votearea + "')) where (votename=@votename AND votearea=@votearea);", con);
                    insert.Parameters.AddWithValue("votename", votename);
                    insert.Parameters.AddWithValue("votearea", votearea);
                    insert.ExecuteNonQuery();
                    SqlDataAdapter mda = new SqlDataAdapter(@"SELECT uname FROM userinfo WHERE (voterid =(SELECT voterid FROM standardvote WHERE(votename = '" + votename + "' AND votearea='"+votearea+"')))", con);
                    DataTable dt = new DataTable();
                    mda.Fill(dt);
                    con.Close();
                    DataRow dr = dt.Rows[0];
                    MessageBox.Show("Congrats! " + dr.ItemArray[0].ToString() + " for winning this Vote!");


                }
                catch
                {
                    //multiple winners!
                    MessageBox.Show("We got tie!");
                    con.Open();
                    SqlCommand insert = new SqlCommand("Update standardvote set voterid=13 where (votename=@votename AND votearea= @votearea);", con);
                    insert.Parameters.AddWithValue("votename", votename);
                    insert.Parameters.AddWithValue("votearea", votearea);
                    insert.ExecuteNonQuery();
                    SqlDataAdapter mda = new SqlDataAdapter(@"select voterid from " + votename + " where votecount=(select max(votecount) from " + votename + " where votearea='"+votearea+"')", con);
                    DataTable dt = new DataTable();
                    mda.Fill(dt);
                    con.Close();
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
            //fixed and ran successfully

            DialogResult dr = MessageBox.Show("Are You sure? It can't be undone", "Warning!", MessageBoxButtons.YesNo,
        MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                con.Open();
                
                SqlCommand insert = new SqlCommand("delete  from "+votename+" where votearea='"+votearea+"'", con);
                
                insert.ExecuteNonQuery();

                insert = new SqlCommand("delete from "+votename+"r where votearea='"+votearea+"'", con);
                
                insert.ExecuteNonQuery();
                insert = new SqlCommand("Update standardvote set startdate=NULL, enddate = NULL,voterid=NULL where(votename=@votename AND votearea=@votearea);", con);
                insert.Parameters.AddWithValue("votename", votename);
                insert.Parameters.AddWithValue("votearea", votearea);
                insert.ExecuteNonQuery();
                con.Close();
                MessageBox.Show( votename+" is reseted to default!");
            }



        
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            //done
            hideaLL();
            if (voterid == "13")
            {
                
                con.Open();
                SqlCommand insert = new SqlCommand("Update standardvote set startdate=@startdate, enddate = @enddate where(votename=@votename AND votearea=@votearea);", con);
                insert.Parameters.AddWithValue("votename", votename);
                insert.Parameters.AddWithValue("votearea", votearea);
                
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
                    con.Close(); 
                    MessageBox.Show("The vote has begun");
                    StandardVote st = new StandardVote(activeform, loggedin, voterid, password, votename, votearea);
                    

                }
                catch
                {
                    MessageBox.Show("Invalid Date");
                    con.Close();
                }
                
            
            }
            else if (time)
            {
                if (textBox1.Text.Trim() == password)
                {

                    con.Open();
                    string votedfor = comboBox1.Text.Trim();
                    SqlCommand insert = new SqlCommand("Update " + votename + " set votecount= votecount+1 where ((voterid=(select voterid from userinfo where uname ='" + votedfor + "')) and votearea=@votearea);", con);
                    insert.Parameters.AddWithValue("votearea",votearea);
                    insert.ExecuteNonQuery();
                    insert = new SqlCommand("insert into " + votename + "r(voterid,votearea) values(" + voterid + ",'"+votearea+"');", con);
                    insert.ExecuteNonQuery();
                    con.Close();
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

       
        private void regbutton_Click(object sender, EventArgs e)
        {
            //done
            hideaLL();
            

            if (passbox.Text.Trim() == password)
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter mda = new SqlDataAdapter("select * from " + votename + " where (voterid=@voterid and votearea=@votearea)", con);
                mda.SelectCommand.Parameters.Add(new SqlParameter("voterid", voterid));
                mda.SelectCommand.Parameters.Add(new SqlParameter("votearea", votearea));
                mda.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {


                    MessageBox.Show("You are already registered");

                }
                else
                {
                    con.Open();
                    SqlCommand insert = new SqlCommand("Insert into " + votename + "(voterid,votecount,votearea)values(@voterid,@votecount,@votearea);", con);

                    insert.Parameters.AddWithValue("voterid", voterid);
                    insert.Parameters.AddWithValue("votecount", 0);
                    insert.Parameters.AddWithValue("votearea", votearea);
                    insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thanks for registering");

                }

            }
            else
            {
                MessageBox.Show("Wrong password");
            }

        }

       
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home hm = new Home(activeform, loggedin, voterid, password);
        }

        

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //done
            hideaLL();
            if (time || voterid == "13")
            {
                if (switche)
                {
                    
                    if (voterid == "13")
                    {
                        if (time) {
                            MessageBox.Show("Vote is in progress");
                        }
                        else
                        {
                            label1.Show();
                            //textBox1 is not necessary anymore as we are using datetime picker
                            button1.Show();
                            //textBox1.Show();
                            dateTimePicker1.Show();
                        }






                    }
                    else
                    {
                        //check already voted?

                        con.Open();
                        DataTable dk = new DataTable();
                        SqlDataAdapter mda = new SqlDataAdapter("select * from " + votename + "r where (voterid=@voterid and votearea=@votearea)", con);
                        mda.SelectCommand.Parameters.Add(new SqlParameter("voterid", voterid));
                        mda.SelectCommand.Parameters.Add(new SqlParameter("votearea", votearea));
                        mda.Fill(dk);
                        con.Close();


                        if (dk.Rows.Count > 0)
                        {

                            MessageBox.Show("You already voted once so can't vote again!");
                            StandardVote hm = new StandardVote(activeform, loggedin, voterid, password, votename,votearea);

                        }
                        else
                        {


                            button1.Text = "ভোট দিন";
                            textBox1.Show();
                            button1.Show();
                            comboBox1.Show();
                            con.Open();
                            SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT uname as Name , voterid as Voter_Id FROM userinfo where voterid in (SELECT voterid from " + votename + " where votearea='"+votearea+"');", con);
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
              //voter shomoikal
            //done
            hideaLL();
            if (switche)
            {
                con.Open();
                SqlDataAdapter mda = new SqlDataAdapter("select startdate,enddate from StandardVote where (votename=@votename AND votearea=@votearea);", con);
                mda.SelectCommand.Parameters.Add(new SqlParameter("votename", votename));
                mda.SelectCommand.Parameters.Add(new SqlParameter("votearea", votearea));
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //done!
            //something i should deal about :P
            //what the hell am i doing 
            if (voterid == "13")
            {
                con.Open();
                SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT uname as Name , voterid as Voter_Id FROM userinfo where voterid in (SELECT voterid from " + votename + " where votearea='"+votearea+"');", con);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
                DataView dv = new DataView(dt);

                hideaLL();
                if (switche) dataGridView1.Show();
                switche = !switche;


            }
            else if (endtimes > DateTime.Now || ets == "")
            {
                hideaLL();

                if (switche)
                {
                    passbox.Show();
                    regbutton.Show();
                    passlabel.Show();



                }
                switche = !switche;
            }
            else
            {

                MessageBox.Show("Vote already Finished!");
            }
            
        }

        private void Title_label_Click(object sender, EventArgs e)
        {

        }

        private void starttimebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
