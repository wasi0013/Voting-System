using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OVS
{
    public partial class Main : Form
    {
        //This is the only form for this project

        public Main()
        {
            InitializeComponent();
            //transfering this form to the home usercontrol
            Home h = new Home(this);
            
        }
    }
}
