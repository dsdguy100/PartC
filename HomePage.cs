using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartC
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void AddCustom_Click(object sender, EventArgs e)
        {
            CustomAssignments jimmy = new CustomAssignments();
            jimmy.Show();
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            
            timer1.Start();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            String dueDate = "18:02:45";
            
            this.label1.Text = DateTime.Now.ToString("dd:hh:mm:ss");
            if (DateTime.Now.ToString("dd:hh:mm").Equals(dueDate))
            {
                //btnNotify.Text = "cringe";
                notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("icon.ico"));
                notifyIcon1.Text = "Based";
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "You have a due Assignment";
                notifyIcon1.BalloonTipText = "An assignment is due";
                notifyIcon1.ShowBalloonTip(100);
            }
        }
    }
}
