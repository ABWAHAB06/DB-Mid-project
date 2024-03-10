using MidprojectDB.usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace MidprojectDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Home_Click(object sender, EventArgs e)
        {
            setusercontrol(new Home_Control());
        }
        public void setusercontrol(UserControl control)
        {
            panelholder.Controls.Clear();
            panelholder.Controls.Add(control);
        }

        private void Student_Click(object sender, EventArgs e)
        {
            setusercontrol(new StudentControl());
        }

       

       
    }
}
