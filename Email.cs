using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;

namespace PartC
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void Email_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            MailMessage mail = new MailMessage("wackwavydisposableemail@gmail.com", "dsdguy100@gmail.com", "Name and stuff", "Name and stuff");
            //mail.Attachments.Add(new Attachment("text goes here"));
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("wackwavydisposableemail@gmail.com", "123456789!");
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Mail Sent!");
            
        }

        protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)
        {
            
        }
    }
}
