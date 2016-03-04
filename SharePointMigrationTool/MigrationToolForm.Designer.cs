namespace SharePointMigrationTool
{
    partial class MigrationToolForm
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
            this.btnImport = new System.Windows.Forms.Button();
            this.lblToUsername = new System.Windows.Forms.Label();
            this.lblToPassword = new System.Windows.Forms.Label();
            this.tbToUsername = new System.Windows.Forms.TextBox();
            this.tbToPassword = new System.Windows.Forms.TextBox();
            this.lblToSiteUrl = new System.Windows.Forms.Label();
            this.tbToSiteUrl = new System.Windows.Forms.TextBox();
            this.gbFrom = new System.Windows.Forms.GroupBox();
            this.lblFromSiteUrl = new System.Windows.Forms.Label();
            this.tbFromSiteUrl = new System.Windows.Forms.TextBox();
            this.lblFromUsername = new System.Windows.Forms.Label();
            this.tbFromPassword = new System.Windows.Forms.TextBox();
            this.tbFromUsername = new System.Windows.Forms.TextBox();
            this.lblFromPassword = new System.Windows.Forms.Label();
            this.gbTo = new System.Windows.Forms.GroupBox();
            this.tbToList = new System.Windows.Forms.TextBox();
            this.lblToList = new System.Windows.Forms.Label();
            this.btnViewList = new System.Windows.Forms.Button();
            this.listGridView = new System.Windows.Forms.DataGridView();
            this.btnGetLists = new System.Windows.Forms.Button();
            this.cbLists = new System.Windows.Forms.ComboBox();
            this.lblAviableLists = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbFrom.SuspendLayout();
            this.gbTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(822, 182);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblToUsername
            // 
            this.lblToUsername.AutoSize = true;
            this.lblToUsername.Location = new System.Drawing.Point(18, 48);
            this.lblToUsername.Name = "lblToUsername";
            this.lblToUsername.Size = new System.Drawing.Size(55, 13);
            this.lblToUsername.TabIndex = 5;
            this.lblToUsername.Text = "Username";
            // 
            // lblToPassword
            // 
            this.lblToPassword.AutoSize = true;
            this.lblToPassword.Location = new System.Drawing.Point(20, 74);
            this.lblToPassword.Name = "lblToPassword";
            this.lblToPassword.Size = new System.Drawing.Size(53, 13);
            this.lblToPassword.TabIndex = 6;
            this.lblToPassword.Text = "Password";
            // 
            // tbToUsername
            // 
            this.tbToUsername.Location = new System.Drawing.Point(122, 45);
            this.tbToUsername.Name = "tbToUsername";
            this.tbToUsername.Size = new System.Drawing.Size(185, 20);
            this.tbToUsername.TabIndex = 9;
            this.tbToUsername.Text = "Administrator";
            // 
            // tbToPassword
            // 
            this.tbToPassword.Location = new System.Drawing.Point(122, 71);
            this.tbToPassword.Name = "tbToPassword";
            this.tbToPassword.Size = new System.Drawing.Size(185, 20);
            this.tbToPassword.TabIndex = 10;
            this.tbToPassword.Text = "Negative112";
            // 
            // lblToSiteUrl
            // 
            this.lblToSiteUrl.AutoSize = true;
            this.lblToSiteUrl.Location = new System.Drawing.Point(20, 22);
            this.lblToSiteUrl.Name = "lblToSiteUrl";
            this.lblToSiteUrl.Size = new System.Drawing.Size(41, 13);
            this.lblToSiteUrl.TabIndex = 12;
            this.lblToSiteUrl.Text = "Site Url";
            // 
            // tbToSiteUrl
            // 
            this.tbToSiteUrl.Location = new System.Drawing.Point(122, 19);
            this.tbToSiteUrl.Name = "tbToSiteUrl";
            this.tbToSiteUrl.Size = new System.Drawing.Size(301, 20);
            this.tbToSiteUrl.TabIndex = 14;
            this.tbToSiteUrl.Text = "http://win-43im0qh4j61/sites/devteam";
            // 
            // gbFrom
            // 
            this.gbFrom.Controls.Add(this.lblFromSiteUrl);
            this.gbFrom.Controls.Add(this.tbFromSiteUrl);
            this.gbFrom.Controls.Add(this.lblFromUsername);
            this.gbFrom.Controls.Add(this.tbFromPassword);
            this.gbFrom.Controls.Add(this.tbFromUsername);
            this.gbFrom.Controls.Add(this.lblFromPassword);
            this.gbFrom.Location = new System.Drawing.Point(12, 31);
            this.gbFrom.Name = "gbFrom";
            this.gbFrom.Size = new System.Drawing.Size(426, 129);
            this.gbFrom.TabIndex = 17;
            this.gbFrom.TabStop = false;
            this.gbFrom.Text = "From";
            // 
            // lblFromSiteUrl
            // 
            this.lblFromSiteUrl.AutoSize = true;
            this.lblFromSiteUrl.Location = new System.Drawing.Point(12, 22);
            this.lblFromSiteUrl.Name = "lblFromSiteUrl";
            this.lblFromSiteUrl.Size = new System.Drawing.Size(50, 13);
            this.lblFromSiteUrl.TabIndex = 11;
            this.lblFromSiteUrl.Text = "Site URL";
            // 
            // tbFromSiteUrl
            // 
            this.tbFromSiteUrl.Location = new System.Drawing.Point(84, 19);
            this.tbFromSiteUrl.Name = "tbFromSiteUrl";
            this.tbFromSiteUrl.Size = new System.Drawing.Size(319, 20);
            this.tbFromSiteUrl.TabIndex = 13;
            this.tbFromSiteUrl.Text = "http://win-43im0qh4j61/sites/teamdev";
            // 
            // lblFromUsername
            // 
            this.lblFromUsername.AutoSize = true;
            this.lblFromUsername.Location = new System.Drawing.Point(9, 48);
            this.lblFromUsername.Name = "lblFromUsername";
            this.lblFromUsername.Size = new System.Drawing.Size(55, 13);
            this.lblFromUsername.TabIndex = 3;
            this.lblFromUsername.Text = "Username";
            // 
            // tbFromPassword
            // 
            this.tbFromPassword.Location = new System.Drawing.Point(84, 71);
            this.tbFromPassword.Name = "tbFromPassword";
            this.tbFromPassword.Size = new System.Drawing.Size(185, 20);
            this.tbFromPassword.TabIndex = 8;
            this.tbFromPassword.Text = "Negative112";
            // 
            // tbFromUsername
            // 
            this.tbFromUsername.Location = new System.Drawing.Point(84, 45);
            this.tbFromUsername.Name = "tbFromUsername";
            this.tbFromUsername.Size = new System.Drawing.Size(185, 20);
            this.tbFromUsername.TabIndex = 7;
            this.tbFromUsername.Text = "Administrator";
            // 
            // lblFromPassword
            // 
            this.lblFromPassword.AutoSize = true;
            this.lblFromPassword.Location = new System.Drawing.Point(9, 72);
            this.lblFromPassword.Name = "lblFromPassword";
            this.lblFromPassword.Size = new System.Drawing.Size(53, 13);
            this.lblFromPassword.TabIndex = 4;
            this.lblFromPassword.Text = "Password";
            // 
            // gbTo
            // 
            this.gbTo.Controls.Add(this.tbToList);
            this.gbTo.Controls.Add(this.lblToList);
            this.gbTo.Controls.Add(this.lblToSiteUrl);
            this.gbTo.Controls.Add(this.lblToUsername);
            this.gbTo.Controls.Add(this.tbToPassword);
            this.gbTo.Controls.Add(this.tbToSiteUrl);
            this.gbTo.Controls.Add(this.tbToUsername);
            this.gbTo.Controls.Add(this.lblToPassword);
            this.gbTo.Location = new System.Drawing.Point(444, 31);
            this.gbTo.Name = "gbTo";
            this.gbTo.Size = new System.Drawing.Size(453, 129);
            this.gbTo.TabIndex = 18;
            this.gbTo.TabStop = false;
            this.gbTo.Text = "To";
            // 
            // tbToList
            // 
            this.tbToList.Location = new System.Drawing.Point(122, 99);
            this.tbToList.Name = "tbToList";
            this.tbToList.Size = new System.Drawing.Size(185, 20);
            this.tbToList.TabIndex = 16;
            this.tbToList.Text = "A new list";
            // 
            // lblToList
            // 
            this.lblToList.AutoSize = true;
            this.lblToList.Location = new System.Drawing.Point(18, 102);
            this.lblToList.Name = "lblToList";
            this.lblToList.Size = new System.Drawing.Size(42, 13);
            this.lblToList.TabIndex = 15;
            this.lblToList.Text = "List title";
            // 
            // btnViewList
            // 
            this.btnViewList.Location = new System.Drawing.Point(465, 182);
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.Size = new System.Drawing.Size(75, 23);
            this.btnViewList.TabIndex = 19;
            this.btnViewList.Text = "View list";
            this.btnViewList.UseVisualStyleBackColor = true;
            this.btnViewList.Click += new System.EventHandler(this.btnViewList_Click);
            // 
            // listGridView
            // 
            this.listGridView.AllowUserToAddRows = false;
            this.listGridView.AllowUserToDeleteRows = false;
            this.listGridView.AllowUserToOrderColumns = true;
            this.listGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listGridView.Location = new System.Drawing.Point(12, 238);
            this.listGridView.Name = "listGridView";
            this.listGridView.ReadOnly = true;
            this.listGridView.Size = new System.Drawing.Size(885, 265);
            this.listGridView.TabIndex = 20;
            // 
            // btnGetLists
            // 
            this.btnGetLists.Location = new System.Drawing.Point(285, 182);
            this.btnGetLists.Name = "btnGetLists";
            this.btnGetLists.Size = new System.Drawing.Size(75, 23);
            this.btnGetLists.TabIndex = 22;
            this.btnGetLists.Text = "Get Lists";
            this.btnGetLists.UseVisualStyleBackColor = true;
            this.btnGetLists.Click += new System.EventHandler(this.btGetLists_Click);
            // 
            // cbLists
            // 
            this.cbLists.FormattingEnabled = true;
            this.cbLists.Location = new System.Drawing.Point(99, 184);
            this.cbLists.Name = "cbLists";
            this.cbLists.Size = new System.Drawing.Size(121, 21);
            this.cbLists.TabIndex = 23;
            // 
            // lblAviableLists
            // 
            this.lblAviableLists.AutoSize = true;
            this.lblAviableLists.Location = new System.Drawing.Point(12, 187);
            this.lblAviableLists.Name = "lblAviableLists";
            this.lblAviableLists.Size = new System.Drawing.Size(28, 13);
            this.lblAviableLists.TabIndex = 24;
            this.lblAviableLists.Text = "Lists";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 26;
            this.button1.Text = "View database list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MigrationToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAviableLists);
            this.Controls.Add(this.cbLists);
            this.Controls.Add(this.btnGetLists);
            this.Controls.Add(this.listGridView);
            this.Controls.Add(this.btnViewList);
            this.Controls.Add(this.gbTo);
            this.Controls.Add(this.gbFrom);
            this.Controls.Add(this.btnImport);
            this.Name = "MigrationToolForm";
            this.Text = "Migration Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbFrom.ResumeLayout(false);
            this.gbFrom.PerformLayout();
            this.gbTo.ResumeLayout(false);
            this.gbTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblToUsername;
        private System.Windows.Forms.Label lblToPassword;
        private System.Windows.Forms.TextBox tbToUsername;
        private System.Windows.Forms.TextBox tbToPassword;
        private System.Windows.Forms.Label lblToSiteUrl;
        private System.Windows.Forms.TextBox tbToSiteUrl;
        private System.Windows.Forms.GroupBox gbFrom;
        private System.Windows.Forms.Label lblFromSiteUrl;
        private System.Windows.Forms.TextBox tbFromSiteUrl;
        private System.Windows.Forms.Label lblFromUsername;
        private System.Windows.Forms.TextBox tbFromPassword;
        private System.Windows.Forms.TextBox tbFromUsername;
        private System.Windows.Forms.Label lblFromPassword;
        private System.Windows.Forms.GroupBox gbTo;
        private System.Windows.Forms.Button btnViewList;
        private System.Windows.Forms.DataGridView listGridView;
        private System.Windows.Forms.Button btnGetLists;
        private System.Windows.Forms.ComboBox cbLists;
        private System.Windows.Forms.Label lblToList;
        private System.Windows.Forms.TextBox tbToList;
        private System.Windows.Forms.Label lblAviableLists;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

