using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace After
{
    internal class EmailService
    {
        public void SendEmail()
        {
            SmtpClient client = new SmtpClient("smtp.myhost.com");
            client.Send(new MailMessage());
        }
    }
}
