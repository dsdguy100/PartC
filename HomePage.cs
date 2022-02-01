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
using System.Net.Mail;


namespace PartC
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();

        }

        private int usePop = 0;
        private int useSysPop = 0;

        private string[,] dueDates = new string [8, 2]; 
        private String dueDate = "";
        

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
            
            
            this.label1.Text = DateTime.Now.ToString("dd:hh:mm:ss");//remove seconds in final build
            for (int i = 0; i < 8; i++)
            {
                if (!dueDates[i, 1].Equals(""))
                {
                    if (DateTime.Now.ToString("dd:hh:mm:ss").Equals(dueDates[i, 1]))
                    {
                        dueDate = dueDates[i, 0];
                        lblTester.Text = dueDate;
                        //this.timer1.Stop();
                        if (usePop == 1)
                        {
                            PopUp();
                        }
                        if (useSysPop == 1)
                        {
                            MessageBox.Show(dueDate, "You have an assignment due");
                        }

                    }
                }
            }
            

        }


        private void btnPull_Click(object sender, EventArgs e)
        {

            dueDates = CustomAssignments.getAssignments();
        }


        private void Homepage_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    dueDates[i, j] = "";

                }
            }
        }
        

        private void PopUp()
        {
            lblTester.Text = "it Worked";
            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("icon.ico"));
            notifyIcon1.Text = "Based";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "You have a due Assignment";
            notifyIcon1.BalloonTipText = dueDate;
            notifyIcon1.ShowBalloonTip(100);
        }


        private void RecievePop_CheckedChanged(object sender, EventArgs e)
        {
            usePop = 1;
        }


        private void btnEmailForm_Click(object sender, EventArgs e)
        {
            Email jerry = new Email();
            jerry.Show();
        }

        private void recieveBox_CheckedChanged(object sender, EventArgs e)
        {
            useSysPop = 1;
        }
    }
}
