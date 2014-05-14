using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace OVS
{
    public partial class Signup : UserControl
    {
        //active form holder
        Form activeform;
        // checks whether user logged in or not default is not logged in
        Boolean loggedin=false;
        //holds voterid and password
        string voterid, password;
        Boolean alright = true;
        DateTime dob=DateTime.Now;
        static string connstr = "Data Source=LEO\\SQLEXPRESS;Initial Catalog=ovs;Integrated Security=True";
        static SqlConnection con = new SqlConnection(connstr);
                
        public Signup()
        {
            InitializeComponent();
        }
        public Signup(Form form,Boolean log,string vid,string pass)
        {
            //overloaded constructor
            InitializeComponent();
            activeform = form;
            activeform.Controls.Clear();
            activeform.Controls.Add(this);
            activeform.Height = this.Height;
            activeform.Width = this.Width;
            activeform.Text = "Signup";
            //takes login states and userinfo supplied
            loggedin = log;
            voterid = vid;
            password = pass;
            agebox.ReadOnly = true;

            comboBox1.Items.Clear();
            con.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT votearea FROM standardvote where votename ='pourashavavote';", con);
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

            dataadapter = new SqlDataAdapter("SELECT votearea FROM standardvote where votename ='upojelavote';", con);
            dt = new DataTable();
            dataadapter.Fill(dt);
            i = dt.Rows.Count;
            dr = dt.Rows[0];
            comboBox2.Items.Add(dr.ItemArray[0].ToString());
            while (i-- > 1)
            {
                dr = dt.Rows[i];

                comboBox2.Items.Add(dr.ItemArray[0].ToString());
            }


            dataadapter = new SqlDataAdapter("SELECT votearea FROM standardvote where votename ='citycorporationvote';", con);
            dt = new DataTable();
            dataadapter.Fill(dt);
            i = dt.Rows.Count;
            dr = dt.Rows[0];
            comboBox3.Items.Add(dr.ItemArray[0].ToString());
            while (i-- > 1)
            {
                dr = dt.Rows[i];

                comboBox3.Items.Add(dr.ItemArray[0].ToString());
            }



            con.Close();



        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Home hm = new Home(activeform,loggedin,voterid,password);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //progress bar magic

            progressBar1.Maximum = 180;
            progressBar1.Value=passbox.Text.Distinct().ToArray().Length*10;
            
            if (progressBar1.Value > 119)
            {
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

        private void ok_button_Click(object sender, EventArgs e)
        {
            
            voterid = vidbox.Text.Trim();
            password = passbox.Text.Trim();

            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter mda = new SqlDataAdapter("select * from userinfo where (voterid=@voterid)", con);
            mda.SelectCommand.Parameters.Add(new SqlParameter("voterid", voterid));
            mda.Fill(dt);
            if (voterid == "" || password == "") {
                MessageBox.Show(voterid==""?"Invalid voterid":"Invalid Password");
                alright = false;
            }
            
            if (dt.Rows.Count >0)
            {
                
                alright = false;
                MessageBox.Show("You are already registered. Please Login or choose a different voterid");

                
            }
            if (comboBox1.Text.Trim() == "" || comboBox2.Text.Trim() == "" || comboBox3.Text.Trim() == "") {
                MessageBox.Show("please select upojela citycorporation and pourashava");
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
                agebox.Text = ages;

            }
            catch
            {

                agebox.Text = "?";
                alright = false;
                MessageBox.Show("Invalid date");

            }

            if (alright)
            {

                //only gets executed when everything is alright

                //This connection string should be changed if necessary

                //update userinfo according to the change

                SqlCommand insert = new SqlCommand("Insert into userinfo(uname,password,voterid,fname,mname,email,contact,dob,bloodgroup,address,doreg,upojela,pourashava,citycorporation)values(@uname,@password,@voterid,@fname,@mname,@email,@contact,@dob,@bloodgroup,@address,@doreg,@upojela,@pourashava,@citycorporation);", con);

                insert.Parameters.AddWithValue("uname", namebox.Text.Trim());
                insert.Parameters.AddWithValue("password", password);
                insert.Parameters.AddWithValue("voterid", vidbox.Text.Trim());
                insert.Parameters.AddWithValue("fname", fnamebox.Text.Trim());
                insert.Parameters.AddWithValue("mname", mnamebox.Text.Trim());
                insert.Parameters.AddWithValue("upojela",comboBox1.Text.Trim());
                insert.Parameters.AddWithValue("pourashava", comboBox2.Text.Trim());
                insert.Parameters.AddWithValue("citycorporation", comboBox3.Text.Trim());
                insert.Parameters.AddWithValue("email", ms);

                insert.Parameters.AddWithValue("contact", phonebox.Text.Trim());
                insert.Parameters.AddWithValue("dob", dob.ToShortDateString());
                insert.Parameters.AddWithValue("bloodgroup", bloodbox.Text.Trim());
                insert.Parameters.AddWithValue("address", addressbox.Text.Trim());
                insert.Parameters.AddWithValue("doreg",DateTime.Now.ToShortDateString());



                // Execute query 
                insert.ExecuteNonQuery();



                //Fix warning color
                mailbox.BackColor = agebox.BackColor = mailbox.BackColor = System.Drawing.Color.White;

                MessageBox.Show("Signing up Succeeded Please log in ");

                Home hm = new Home(activeform, true, voterid, password);
            }
            else {

                MessageBox.Show("Password empty or don't match");
            
            }




        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {
            if (repassbox.Text == passbox.Text)
            {
                repassbox.BackColor = System.Drawing.Color.LightGreen;
                alright = true;

            }
            else {

                repassbox.BackColor = System.Drawing.Color.White;
                alright = false;
            }
        }
        public static Int32 GetAge( DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }

        private void DOBbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dob=dateTimePicker1.Value;
            try
            {
                agebox.Text = GetAge(dob).ToString();
            }
            catch
            {

            }
        }
    }
}
