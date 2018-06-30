using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ReadEMail.DataAccess
{
    /// <summary>
    /// This DbContext permits to define database model with DbSet (specific Set mapped to a table)
    /// </summary>
    public class EMailDBContext : DbContext
    {
        public EMailDBContext() : base("DBConnectionString")
        {
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            Database.CreateIfNotExists();
        }

        //Property to Map the Db Set of Email Object to Retreive and Save
        public DbSet<EMail> EMails { get; set; }
        public DbSet<EmailAttachment> EmailAttachments { get; set; }

    }
}