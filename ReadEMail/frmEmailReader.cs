using ReadEMail.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Outlook = Microsoft.Office.Interop.Outlook;

namespace ReadEMail
{
    public partial class frmEmailReader : Form
    {
        List<EMailModel> newEmails = null;

        public frmEmailReader()
        {
            InitializeComponent();
            newEmails = new List<EMailModel>(); 
        }

        private void btnGetEmails_Click(object sender, EventArgs e)
        {
            //Initialize the Outlook Application Object to its name spaces and Inbox folder and Resticts its action to read the Unread Mails alone.
            Outlook._Application _app = new Outlook.Application();
            Outlook._NameSpace _ns = _app.GetNamespace("MAPI");
            Outlook.MAPIFolder inbox = _ns.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);
            Outlook.Items unReadEmails = inbox.Items.Restrict("[Unread]=true");

            //Show the progress of connection
            _ns.SendAndReceive(false);

            // Variable to initialise the Index to 1st Mail           
            var index = 1;

            
            //Loop through Each mail in the Inbox
            foreach (Outlook.MailItem item in unReadEmails)
            {
                //Object for Email attachments
                var attachments = new List<EmailAttachment>();

                if (item.Attachments.Count > 0)
                {
                    //Loop Through Each Mail to get Attachments
                    for (int i = 1; i <= item.Attachments.Count; i++)
                    {
                        //Filter attached files 
                        var attachment = new EmailAttachment
                        {
                            FileName = item.Attachments[i].FileName,
                            DisplayName = item.Attachments[i].DisplayName,
                            Size = item.Attachments[i].Size,
                            PathName = item.Attachments[i].PathName
                        };

                        // Temp location of the downloaded Attachments
                        var tempFile = @"c:\temp\" + attachment.FileName;
                        item.Attachments[i].SaveAsFile(tempFile);

                        //Read attachments on downlod completion
                        attachment.Attachments = File.ReadAllBytes(tempFile);
                        //Remove Temp Files
                        File.Delete(tempFile);
                        //Attchment Assigned to Model Object
                        attachments.Add(attachment);
                    }
                }

                //Assign the MailModel attributes
                newEmails.Add(new EMailModel
                {
                    EMailSequenceNumber = index++,
                    Subject = item.Subject,
                    Body = item.Body,
                    Date = item.SentOn,
                    SenderName = item.SenderName,
                    SenderEmailAddress = item.SenderEmailAddress,
                    Attachment = attachments
                });               
                
            }

            //Displays the Mail records in the GridView 
            gvDisplayEmails.DataSource = newEmails;

                      
        }

        private void btnUpdateDatabase_Click(object sender, EventArgs e)
        {
            //Instance of the Repository object to be saved into the DB
            var repo = new EMailRepository();
            //Inserts records into the DB
            repo.InsertNewEMails(newEmails);
           
        }

        private void gvDisplayEmails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < gvDisplayEmails.Rows.Count && e.RowIndex >=0)
            {
                webBrowser1.DocumentText = gvDisplayEmails.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
    }
}
