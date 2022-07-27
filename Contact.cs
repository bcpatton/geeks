using Microsoft.AspNet.Identity.EntityFramework;


namespace ATSGeeks.Models
{
    public class Contact
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string message { get; set; }

    }
}