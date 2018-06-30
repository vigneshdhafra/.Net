using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadEMail.DataAccess
{
    public class EMailRepository
    {
        /// <summary>
        /// This class is the Repository of the EMailModel that manages the DB Actions
        /// </summary>
        /// <param name="emailModels"></param>
        /// <returns></returns>
        public bool InsertNewEMails(List<EMailModel> emailModels)
        {
            using (var db = new EMailDBContext())
            {
                //Loop through each Email model List items in the DB Context
                foreach(var em in emailModels)
                {
                    //Assigns Each Records of Email to the DB Context object
                    db.EMails.Add(new EMail
                    {
                        Body = em.Body,
                        Date = em.Date,
                        SenderEmailAddress = em.SenderEmailAddress,
                        SenderName = em.SenderName,
                        Subject = em.Subject
                    });

                    //Loop through each attachment
                    foreach (var att in em.Attachment)
                    {
                        //Assign 
                        db.EmailAttachments.Add(new EmailAttachment
                        {
                            Id = att.Id,
                            DisplayName = att.DisplayName,
                            FileName = att.FileName,
                            PathName = att.PathName,
                            Size = att.Size,
                            Attachments = att.Attachments,
                            EMailSequenceNumber = em.EMailSequenceNumber
                        });

                    }

                    //Inserts the Mail records into the DB and Commits the Action
                    db.SaveChanges();
                }                

                //Returns true after the recod is successfully inserted
                return true;
            }
        }

        public bool InsertAttachments(List<EmailAttachment> emailAttachments)
        {
            using (var db = new EMailDBContext())
            {
                foreach (var att in emailAttachments)
                {
                    //todo
                    db.EmailAttachments.Add(new EmailAttachment
                    {
                        Id = att.Id,
                        DisplayName = att.DisplayName,
                        FileName = att.FileName,
                        PathName = att.PathName,
                        Size = att.Size,
                        Attachments = att.Attachments,
                       // EMailSequenceNumber = att.EMailSequenceNumber
                    });

                }

                db.SaveChanges();
                
                //Returns true after the recod is successfully inserted
                return true;
            }
                
        }
    }
}
