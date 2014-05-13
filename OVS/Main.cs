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
        public Main()
        {
            InitializeComponent();
            Home h = new Home(this);
            
        }
    }
}
