using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace OVS
{
    public partial class UserInformation : UserControl
    {
        public UserInformation()
        {
            InitializeComponent();
        }
        
        Form activeform;
        Boolean loggedin = false;
        string voterid, password;
        Boolean alright = true;
        DateTime dob;
        public static Int32 GetAge( DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }
        
        public UserInformation(Form form, Boolean log, string vid, string pass)
        {
            InitializeComponent();
            activeform = form;
            activeform.Controls.Clear();
            activeform.Controls.Add(this);
            activeform.Height = this.Height;
            activeform.Width = this.Width;
            activeform.Text = "User Information";
            voterid = vid;
            password = pass;
            loggedin = log;

            label7.Hide();
            label9.Hide();
            progressBar1.Hide();
            repassbox.Hide();
            vidbox.Text = vid;
            passbox.Text = pass;

            string connstr = "Data Source=LEO\\SQLEXPRESS;Initial Catalog=ovs;Integrated Security=True";

            SqlConnection con = new SqlConnection(connstr);
            DataTable dt = new DataTable();

            //collect all the user information from the database table userinfo
            SqlDataAdapter mda = new SqlDataAdapter("select * from userinfo where (voterid=@voterid) AND (password=@password)", con);
            mda.SelectCommand.Parameters.Add(new SqlParameter("voterid", voterid));
            mda.SelectCommand.Parameters.Add(new SqlParameter("password", password));
            mda.Fill(dt);
            DataRow dr = dt.Rows[0];
            dob =DateTime.Parse(dr.ItemArray[7].ToString()); 
            namebox.Text= dr.ItemArray[0].ToString();
            fnamebox.Text = dr.ItemArray[3].ToString();
            mnamebox.Text = dr.ItemArray[4].ToString();
            mailbox.Text = dr.ItemArray[5].ToString();
            phonebox.Text = dr.ItemArray[6].ToString();
            dateTimePicker1.Value = dob;
            bloodbox.Text = dr.ItemArray[9].ToString();
            addressbox.Text = dr.ItemArray[10].ToString();
            agebox.Text= GetAge(dob).ToString();
            vidbox.ReadOnly = true;
            agebox.ReadOnly = true;
            passbox.ReadOnly = true;
            namebox.ReadOnly = true;
            fnamebox.ReadOnly = true;
            mnamebox.ReadOnly = true;
            mailbox.ReadOnly = true;
            phonebox.ReadOnly = true;
            bloodbox.ReadOnly = true;
            addressbox.ReadOnly = true;
           
         }
        private void User_info_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserInformation userinformation = new UserInformation(activeform,loggedin,voterid,password);
        }
        private void UserInformation_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home hm = new Home(activeform, loggedin, voterid, password);
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            label7.Show();
            label9.Show();
            progressBar1.Show();
            repassbox.Show();
            //make all field except voterid editable
            passbox.ReadOnly = false;
            namebox.ReadOnly = false;
            fnamebox.ReadOnly = false;
            mnamebox.ReadOnly = false;
            mailbox.ReadOnly = false;
            phonebox.ReadOnly = false;
            bloodbox.ReadOnly = false;
            addressbox.ReadOnly = false;

        }

        private void reload_button_Click(object sender, EventArgs e)
        {
            //make everything read only
            label7.Hide();
            label9.Hide();
            progressBar1.Hide();
            repassbox.Hide();
            passbox.ReadOnly = true;
            namebox.ReadOnly = true;
            fnamebox.ReadOnly = true;
            mnamebox.ReadOnly = true;
            mailbox.ReadOnly = true;
            phonebox.ReadOnly = true;
            bloodbox.ReadOnly = true;
            addressbox.ReadOnly = true;

            //And reload last saved data from the database

            string connstr = "Data Source=LEO\\SQLEXPRESS;Initial Catalog=ovs;Integrated Security=True";

            SqlConnection con = new SqlConnection(connstr);
            DataTable dt = new DataTable();

            //collect all the user information from the database table userinfo
            SqlDataAdapter mda = new SqlDataAdapter("select * from userinfo where (voterid=@voterid) AND (password=@password)", con);
            mda.SelectCommand.Parameters.Add(new SqlParameter("voterid", voterid));
            mda.SelectCommand.Parameters.Add(new SqlParameter("password", password));
            mda.Fill(dt);
            DataRow dr = dt.Rows[0];
            namebox.Text = dr.ItemArray[0].ToString();
            fnamebox.Text = dr.ItemArray[3].ToString();
            mnamebox.Text = dr.ItemArray[4].ToString();
            mailbox.Text = dr.ItemArray[5].ToString();
            phonebox.Text = dr.ItemArray[6].ToString();
            dob = DateTime.Parse(dr.ItemArray[7].ToString());
            bloodbox.Text = dr.ItemArray[9].ToString();
            addressbox.Text = dr.ItemArray[10].ToString();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
             
            
            //ongoing task
            string connstr = "Data Source=LEO\\SQLEXPRESS;Initial Catalog=ovs;Integrated Security=True";
            SqlConnection con = new SqlConnection(connstr);
            con.Open();

            if (passbox.Text == "")
            {
                MessageBox.Show("Invalid Password");
                alright = false;
            }
            

            mailbox.BackColor = System.Drawing.Color.White;
            string ms = mailbox.Text.Trim();
            try
            {

                //mail address validity
                if (ms != "") { MailAddress m = new MailAddress(ms); }

            }
            catch (FormatException)
            {

                mailbox.Text = "Invalid Mail address!";
                mailbox.BackColor = System.Drawing.Color.LightSalmon;
                alright = false;
                MessageBox.Show("Invalid Mail Address!");
            }
            
            try
            {

                //detect invalid ages 
                string ages = GetAge(dob).ToString();
                int asd = Int32.Parse(ages);
                if (asd < 18) {
                    Exception m = new ArithmeticException();
                }

            }
            catch
            {

                agebox.Text = "?";
                alright = false;
                MessageBox.Show("Invalid date");

            }

            if (alright)
            {

                //only gets executed when everything is allright

                //This connection string should be changed if necessary
                
                //update tbl_userinfo according to the change
                SqlCommand insert = new SqlCommand("Update userinfo set uname = @uname,password=@password,fname = @fname,mname = @mname,email = @email,contact = @contact,dob= @dob, bloodgroup= @bloodgroup,address= @address where voterid=@voterid", con);
                voterid = vidbox.Text.Trim();
                password = passbox.Text.Trim();
                insert.Parameters.AddWithValue("uname", namebox.Text.Trim());
                insert.Parameters.AddWithValue("password", password);
                insert.Parameters.AddWithValue("voterid", voterid);
                insert.Parameters.AddWithValue("fname", fnamebox.Text.Trim());
                insert.Parameters.AddWithValue("mname", mnamebox.Text.Trim());
                
                insert.Parameters.AddWithValue("email", ms);
                insert.Parameters.AddWithValue("contact", phonebox.Text.Trim());
                insert.Parameters.AddWithValue("dob", dob.ToShortDateString());
                insert.Parameters.AddWithValue("bloodgroup", bloodbox.Text.Trim());
                insert.Parameters.AddWithValue("address", addressbox.Text.Trim());

               

                // Execute query 
                insert.ExecuteNonQuery();


                
                //Fix warning color
                mailbox.BackColor = agebox.BackColor = mailbox.BackColor = System.Drawing.Color.White;
                label7.Hide();
                label9.Hide();
                progressBar1.Hide();
                repassbox.Hide();
        
            
            }
            else
            {

                MessageBox.Show("Password empty or don't match");

            }
            
        
        }

        private void repassbox_TextChanged(object sender, EventArgs e)
        {
            if (repassbox.Text == passbox.Text)
            {
                repassbox.BackColor = System.Drawing.Color.LightGreen;
                alright = true;


            }
            else
            {

                repassbox.BackColor = System.Drawing.Color.White;
                alright = false;
            }
        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {
            if(passbox.Text.Trim()!=password)label3.Text="নতুন পাসওয়ার্ড";
            //progress bar magic
            progressBar1.Maximum = 180;
            progressBar1.Value=passbox.Text.Distinct().ToArray().Length*10;
            if (progressBar1.Value > 119)
            {
                //label9 is for showing password strength text
                label9.Text = "Strong!"; 
            
            }
            else if (progressBar1.Value > 55)
            {

                label9.Text = "Medium";
            }
            else {
                label9.Text = "Poor!";
            }
        
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dob = dateTimePicker1.Value;
                agebox.Text = GetAge(dob).ToString();
            }
            catch
            {

            }


        }

    }
}
