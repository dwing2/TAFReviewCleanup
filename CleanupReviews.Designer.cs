namespace TAFReviewCleanupWindowsForms
{
    partial class CleanupReviews
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
            this.Delete = new System.Windows.Forms.Button();
            this.TitleTextLabel = new System.Windows.Forms.Label();
            this.TitleText = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LDAPText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.EnvLabel = new System.Windows.Forms.Label();
            this.CaidsLabel = new System.Windows.Forms.Label();
            this.CaidsText = new System.Windows.Forms.TextBox();
            this.EnvCombo = new System.Windows.Forms.ComboBox();
            this.Resultlabel = new System.Windows.Forms.Label();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Location = new System.Drawing.Point(42, 226);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // TitleTextLabel
            // 
            this.TitleTextLabel.AutoSize = true;
            this.TitleTextLabel.Location = new System.Drawing.Point(42, 179);
            this.TitleTextLabel.Name = "TitleTextLabel";
            this.TitleTextLabel.Size = new System.Drawing.Size(50, 13);
            this.TitleTextLabel.TabIndex = 1;
            this.TitleTextLabel.Text = "Title text:";
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(110, 179);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(334, 20);
            this.TitleText.TabIndex = 4;
            this.TitleText.TextChanged += new System.EventHandler(this.TitleText_TextChanged);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(48, 5);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(38, 13);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "LDAP:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(48, 26);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password:";
            // 
            // LDAPText
            // 
            this.LDAPText.Location = new System.Drawing.Point(110, 5);
            this.LDAPText.Name = "LDAPText";
            this.LDAPText.Size = new System.Drawing.Size(111, 20);
            this.LDAPText.TabIndex = 0;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(110, 26);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(127, 20);
            this.PasswordText.TabIndex = 1;
            // 
            // EnvLabel
            // 
            this.EnvLabel.AutoSize = true;
            this.EnvLabel.Location = new System.Drawing.Point(48, 74);
            this.EnvLabel.Name = "EnvLabel";
            this.EnvLabel.Size = new System.Drawing.Size(29, 13);
            this.EnvLabel.TabIndex = 7;
            this.EnvLabel.Text = "Env:";
            // 
            // CaidsLabel
            // 
            this.CaidsLabel.AutoSize = true;
            this.CaidsLabel.Location = new System.Drawing.Point(48, 99);
            this.CaidsLabel.Name = "CaidsLabel";
            this.CaidsLabel.Size = new System.Drawing.Size(35, 13);
            this.CaidsLabel.TabIndex = 8;
            this.CaidsLabel.Text = "caids:";
            // 
            // CaidsText
            // 
            this.CaidsText.Location = new System.Drawing.Point(110, 99);
            this.CaidsText.Multiline = true;
            this.CaidsText.Name = "CaidsText";
            this.CaidsText.Size = new System.Drawing.Size(334, 74);
            this.CaidsText.TabIndex = 3;
            this.CaidsText.TextChanged += new System.EventHandler(this.CaidsText_TextChanged);
            // 
            // EnvCombo
            // 
            this.EnvCombo.FormattingEnabled = true;
            this.EnvCombo.Items.AddRange(new object[] {
            "n2a",
            "n1",
            "perf",
            "n0"});
            this.EnvCombo.Location = new System.Drawing.Point(110, 74);
            this.EnvCombo.Name = "EnvCombo";
            this.EnvCombo.Size = new System.Drawing.Size(92, 21);
            this.EnvCombo.TabIndex = 9;
            this.EnvCombo.Text = "n2a";
            // 
            // Resultlabel
            // 
            this.Resultlabel.AutoSize = true;
            this.Resultlabel.Location = new System.Drawing.Point(42, 274);
            this.Resultlabel.Name = "Resultlabel";
            this.Resultlabel.Size = new System.Drawing.Size(40, 13);
            this.Resultlabel.TabIndex = 10;
            this.Resultlabel.Text = "Result:";
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(45, 291);
            this.ResultText.Multiline = true;
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(761, 258);
            this.ResultText.TabIndex = 11;
            // 
            // CleanupReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 561);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.Resultlabel);
            this.Controls.Add(this.EnvCombo);
            this.Controls.Add(this.CaidsText);
            this.Controls.Add(this.CaidsLabel);
            this.Controls.Add(this.EnvLabel);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LDAPText);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.TitleTextLabel);
            this.Controls.Add(this.Delete);
            this.Name = "CleanupReviews";
            this.Text = "CleanupReviews";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label TitleTextLabel;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LDAPText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label EnvLabel;
        private System.Windows.Forms.Label CaidsLabel;
        private System.Windows.Forms.TextBox CaidsText;
        private System.Windows.Forms.ComboBox EnvCombo;
        private System.Windows.Forms.Label Resultlabel;
        private System.Windows.Forms.TextBox ResultText;
    }
}