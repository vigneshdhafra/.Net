using ReadEMail.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadEMail
{
    /// <summary>
    /// EMailModel - <<Contains the Model properties of a mail. Iindependent of the user interface, It directly manages the data of the mail thats travels back and forth with db. >>
    /// </summary>
    public class EMailModel
    {
        /// <summary>
        /// Contains the Sequence Numbers of mails 
        /// </summary>
        public int EMailSequenceNumber { get; set; }
        
        /// <summary>
        /// Contains the Name of the Email Sender
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// Contains the Mail ID of the Email Sender
        public string SenderEmailAddress { get; set; }

        /// <summary>
        /// Contains the Subject string of Mail
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Contins the email Body 
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Contains the Date and Time of the Sent mail
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Contains Mail Attachments
        /// </summary>
        public List<EmailAttachment> Attachment { get; set; }

    }
}
