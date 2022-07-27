using System.Web.Mvc;
using ATSGeeks.Models;
using System.Net.Mail;

namespace ATSGeeks.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            string name = contact.name;
            string email = contact.email;
            string phone = contact.phone;
            string message = contact.message;

            MailMessage usermail = new MailMessage();
            usermail.To.Add("bpatton@advancedtecsolutions.com");
            usermail.CC.Add("wpatton@advancedtecsolutions.com");
            usermail.Bcc.Add("admin@ats360lms.com");
            usermail.From = new MailAddress("info@advancedtecsolutions.com");
            usermail.Subject = $"ATS Support (Contact Us)";
            usermail.Body = $"New message from {name}. <br/>Email: {email} <br/>Phone Number: {phone} <br/>Message: {message}";
            usermail.IsBodyHtml = true;

        
            SmtpClient smtp = new SmtpClient
            {
                Port = 587,
                Host = "smtp.gmail.com",
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential
                 ("info@advancedtecsolutions.com", "Advanced-1"),
                EnableSsl = true
            };
            
            smtp.Send(usermail);
            return View();
        }
    }
}