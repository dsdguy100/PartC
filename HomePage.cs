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
        private int five = 0;
        private int ten = 0;
        private int hour = 0;

        private string[,] dueDates = new string [8, 2]; 
        private String dueDate = "";
        private string days;
        private string hours;
        private string minutes;
        private string zeromin;
        private string zerohour;


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


            this.label1.Text = DateTime.Now.ToString("dd:hh:mm");
            for (int i = 0; i < 8; i++)
            {
                if (!dueDates[i, 1].Equals(""))
                {

                    if (DateTime.Now.ToString("dd:hh:mm").Equals(dueDates[i, 1]))
                    {
                        dueDate = dueDates[i, 0];
                        //lblTester.Text = dueDate;

                        if (usePop == 1)
                        {
                            PopUp();
                            dueDates[i, 1] = "";
                        }

                        if (useSysPop == 1)
                        {
                            MessageBox.Show(dueDate, "You have an assignment due");
                            dueDates[i, 1] = "";
                        }
                        
                    }
                }
            }
            

        }

        private void btnPull_Click(object sender, EventArgs e)
        {

            dueDates = CustomAssignments.getAssignments();
            for (int i = 0; i < 8; i++)
            {
                if (dueDates[i, 1].Equals(""))
                {
                    break;
                }
                minutes = Convert.ToString(dueDates[i, 1].Substring(6));
                hours = Convert.ToString(dueDates[i, 1].Substring(3,2));
                days = Convert.ToString(dueDates[i, 1].Substring(0, 2));
                zeromin = ":";
                zerohour = ":";
                Change_Time();

                //dd:hh:mm
                if (five == 1)
                {
                    if (int.Parse(minutes) >= 5)
                    {
                        dueDates[i, 1] = days + zerohour + Convert.ToString(int.Parse(hours)) + zeromin + Convert.ToString(int.Parse(minutes) - 5);
                        label1.Text = dueDates[i, 1];
                    }
                    else
                    {
                        hours = Convert.ToString(int.Parse(hours) - 1);
                        minutes = Convert.ToString(int.Parse(minutes) + 60);
                        Change_Time();
                        dueDates[i, 1] = days + zerohour + Convert.ToString(int.Parse(hours)) + ":" + Convert.ToString(int.Parse(minutes) - 5);
                        label1.Text = dueDates[i, 1];
                    }
                }
                
                if (ten == 1)
                {
                    if (int.Parse(minutes) >= 10)
                    {
                        dueDates[i, 1] = days + zerohour + Convert.ToString(int.Parse(hours)) + zeromin + Convert.ToString(int.Parse(minutes) - 10);
                        label1.Text = dueDates[i, 1];
                    }
                    else
                    {
                        hours = Convert.ToString(int.Parse(hours) - 1);
                        minutes = Convert.ToString(int.Parse(minutes) + 60);
                        Change_Time();
                        dueDates[i, 1] = days + zerohour + Convert.ToString(int.Parse(hours)) + ":" + Convert.ToString(int.Parse(minutes) - 10);
                        label1.Text = dueDates[i, 1];
                    }
                }
                
                if (hour == 1)
                {
                    if (int.Parse(hours) >= 1)
                    {
                        dueDates[i, 1] = days + zerohour + Convert.ToString(int.Parse(hours)-1) + zeromin + Convert.ToString(int.Parse(minutes));
                        label1.Text = dueDates[i, 1];
                    }
                    else
                    {
                        dueDates[i, 1] = days + zerohour + Convert.ToString(12) + ":" + Convert.ToString(int.Parse(minutes) - 5);
                        label1.Text = dueDates[i, 1];
                    }
                }
            }
        }

        public void Change_Time()
        {
            if (int.Parse(minutes) < 10)
            {
                zeromin = ":0";
            }
            if (int.Parse(hours) < 10)
            {
                zerohour = ":0";
            }

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
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        

        private void PopUp()
        {
            //lblTester.Text = "it Worked";
            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("bible2.ico"));
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

        private void FiveBefore_CheckedChanged(object sender, EventArgs e)
        {
            five = 1;
        }

        private void TenBefore_CheckedChanged(object sender, EventArgs e)
        {
            ten = 1;
        }

        private void HourBefore_CheckedChanged(object sender, EventArgs e)
        {
            hour = 1;
        }

        private void lblTester_Click(object sender, EventArgs e)
        {

        }
    }
}
