
namespace Proiect_v2
{
    partial class AdminLoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminUsernameTextBox = new System.Windows.Forms.TextBox();
            this.adminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginAdminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // adminUsernameTextBox
            // 
            this.adminUsernameTextBox.Location = new System.Drawing.Point(132, 59);
            this.adminUsernameTextBox.Name = "adminUsernameTextBox";
            this.adminUsernameTextBox.Size = new System.Drawing.Size(230, 22);
            this.adminUsernameTextBox.TabIndex = 2;
            // 
            // adminPasswordTextBox
            // 
            this.adminPasswordTextBox.Location = new System.Drawing.Point(132, 129);
            this.adminPasswordTextBox.Name = "adminPasswordTextBox";
            this.adminPasswordTextBox.Size = new System.Drawing.Size(230, 22);
            this.adminPasswordTextBox.TabIndex = 3;
            // 
            // loginAdminButton
            // 
            this.loginAdminButton.Location = new System.Drawing.Point(287, 196);
            this.loginAdminButton.Name = "loginAdminButton";
            this.loginAdminButton.Size = new System.Drawing.Size(75, 29);
            this.loginAdminButton.TabIndex = 4;
            this.loginAdminButton.Text = "Log in";
            this.loginAdminButton.UseVisualStyleBackColor = true;
            this.loginAdminButton.Click += new System.EventHandler(this.loginAdminButton_Click);
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 252);
            this.Controls.Add(this.loginAdminButton);
            this.Controls.Add(this.adminPasswordTextBox);
            this.Controls.Add(this.adminUsernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminLoginForm";
            this.Text = "AdminLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminUsernameTextBox;
        private System.Windows.Forms.TextBox adminPasswordTextBox;
        private System.Windows.Forms.Button loginAdminButton;
    }
}