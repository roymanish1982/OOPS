using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts.SOLID
{
    /*
	
		This means that every class, or similar structure, in your code should have only one job to do. 
		Everything in that class should be related to a single purpose. Our class should not be like a Swiss knife 
		wherein if one of them needs to be changed then the entire tool needs to be altered. 
		It does not mean that your classes should only contain one method or property. 
		There may be many members as long as they relate to the single responsibility.
	*/

    public class UserService
    {
        EmailService _emailService;
        DbContext _dbContext;
        public UserService(EmailService aEmailService, DbContext aDbContext)
        {
            _emailService = aEmailService;
            _dbContext = aDbContext;
        }
        public void Register(string email, string password)
        {
            if (!_emailService.ValidateEmail(email))
                throw new ValidationException("Email is not an email");
            var user = new User(email, password);
            _dbContext.Save(user);
            _emailService.SendEmail(new MailMessage("myname@mydomain.com", email) { Subject = "Hi. How are you!" });
        }
    }    

    public class EmailService
    {
        SmtpClient _smtpClient;
        public EmailService(SmtpClient aSmtpClient)
        {
            _smtpClient = aSmtpClient;
        }
        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public void SendEmail(MailMessage message)
        {
            _smtpClient.Send(message);
        }
    }

    public class DbContext
    {
        internal void Save(User user)
        {
            throw new NotImplementedException();
        }
    }

    internal class User
    {
        private string email;
        private string password;

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
    }

}
