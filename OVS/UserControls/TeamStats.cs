using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OVS
{
    public partial class TeamStats : UserControl
    {
        Form activeform;
        Boolean loggedin = false;
        string voterid, password;
        
        public TeamStats(Form form,Boolean log,string vid,string pass)
        {
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
          
        
        
        }
    }
}
