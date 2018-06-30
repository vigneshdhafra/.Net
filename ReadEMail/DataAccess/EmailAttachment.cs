using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadEMail.DataAccess
{
    public class EmailAttachment
    {
        //Contains ID number of the attachment record   
        [Key]
        public int Id { get; set; }
       
        //Contains the attachments Displayable name
        public string DisplayName { get; set; }
        
        //Contains the attachments File name
        public string FileName { get; set; }
       
        //Contains File Path Location
        public string PathName { get; set; }
        
        // Contains File Size
        public int Size { get; set; }
        
        //Contains the files in Byte format
        public byte[] Attachments { get; set; }
        
        //[ForeignKey("EMailSequenceNumber")]
        public int EMailSequenceNumber { get; set; }
    }
}
