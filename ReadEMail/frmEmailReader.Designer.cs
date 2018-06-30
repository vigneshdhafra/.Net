namespace ReadEMail
{
    partial class frmEmailReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetEmails = new System.Windows.Forms.Button();
            this.btnUpdateDatabase = new System.Windows.Forms.Button();
            this.gvDisplayEmails = new System.Windows.Forms.DataGridView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.gvDisplayEmails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetEmails
            // 
            this.btnGetEmails.Location = new System.Drawing.Point(44, 12);
            this.btnGetEmails.Name = "btnGetEmails";
            this.btnGetEmails.Size = new System.Drawing.Size(107, 31);
            this.btnGetEmails.TabIndex = 0;
            this.btnGetEmails.Text = "Get Emails";
            this.btnGetEmails.UseVisualStyleBackColor = true;
            this.btnGetEmails.Click += new System.EventHandler(this.btnGetEmails_Click);
            // 
            // btnUpdateDatabase
            // 
            this.btnUpdateDatabase.Location = new System.Drawing.Point(157, 12);
            this.btnUpdateDatabase.Name = "btnUpdateDatabase";
            this.btnUpdateDatabase.Size = new System.Drawing.Size(107, 31);
            this.btnUpdateDatabase.TabIndex = 1;
            this.btnUpdateDatabase.Text = "Update Database";
            this.btnUpdateDatabase.UseVisualStyleBackColor = true;
            this.btnUpdateDatabase.Click += new System.EventHandler(this.btnUpdateDatabase_Click);
            // 
            // gvDisplayEmails
            // 
            this.gvDisplayEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDisplayEmails.Location = new System.Drawing.Point(44, 49);
            this.gvDisplayEmails.Name = "gvDisplayEmails";
            this.gvDisplayEmails.Size = new System.Drawing.Size(539, 238);
            this.gvDisplayEmails.TabIndex = 2;
            this.gvDisplayEmails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDisplayEmails_CellContentClick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(44, 303);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(539, 114);
            this.webBrowser1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 487);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.gvDisplayEmails);
            this.Controls.Add(this.btnUpdateDatabase);
            this.Controls.Add(this.btnGetEmails);
            this.Name = "Form1";
            this.Text = "Email Reader";
            ((System.ComponentModel.ISupportInitialize)(this.gvDisplayEmails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetEmails;
        private System.Windows.Forms.Button btnUpdateDatabase;
        private System.Windows.Forms.DataGridView gvDisplayEmails;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

