﻿using ReadEMail.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ReadEMail
{
    /// <summary>
    /// EMail - << This Class is the Object Relational Mapper(ORM) of EntityFramework Code First Architecture >>
    /// </summary>
    public class EMail
    {
        /// <summary>
        /// Contains the Sequence Numbers of mails - [Key] annotation is for primary key field, [Required] annotation is for NotNull field, [DatabaseGenerated] is for AutoGenerated Field
        /// </summary>
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EMailSequenceNumber { get; set; }

        /// <summary>
        /// Contains the Name of the Email Sender
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// Contains the Mail ID of the Email Sender
        /// </summary>
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
        public List<EmailAttachment> Attachments { get; set; }

    }
}
