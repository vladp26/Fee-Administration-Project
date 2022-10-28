
namespace Proiect_v2
{
    partial class AdminOptionsForm
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
            this.detailedFeesButton = new System.Windows.Forms.Button();
            this.studentsButton = new System.Windows.Forms.Button();
            this.serializeButton = new System.Windows.Forms.Button();
            this.deserializeData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // detailedFeesButton
            // 
            this.detailedFeesButton.Location = new System.Drawing.Point(66, 279);
            this.detailedFeesButton.Name = "detailedFeesButton";
            this.detailedFeesButton.Size = new System.Drawing.Size(175, 145);
            this.detailedFeesButton.TabIndex = 0;
            this.detailedFeesButton.Text = "Click here to see the detailed fees and/or add Subject";
            this.detailedFeesButton.UseVisualStyleBackColor = true;
            this.detailedFeesButton.Click += new System.EventHandler(this.detailedFeesButton_Click);
            // 
            // studentsButton
            // 
            this.studentsButton.Location = new System.Drawing.Point(289, 279);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(177, 145);
            this.studentsButton.TabIndex = 1;
            this.studentsButton.Text = "Click here to see the students";
            this.studentsButton.UseVisualStyleBackColor = true;
            this.studentsButton.Click += new System.EventHandler(this.studentsButton_Click);
            // 
            // serializeButton
            // 
            this.serializeButton.Location = new System.Drawing.Point(66, 126);
            this.serializeButton.Name = "serializeButton";
            this.serializeButton.Size = new System.Drawing.Size(175, 134);
            this.serializeButton.TabIndex = 2;
            this.serializeButton.Text = "Click here to export data (unless you export all data, changes will not be commit" +
    "ted)";
            this.serializeButton.UseVisualStyleBackColor = true;
            this.serializeButton.Click += new System.EventHandler(this.serializeButton_Click);
            // 
            // deserializeData
            // 
            this.deserializeData.Location = new System.Drawing.Point(289, 126);
            this.deserializeData.Name = "deserializeData";
            this.deserializeData.Size = new System.Drawing.Size(177, 134);
            this.deserializeData.TabIndex = 3;
            this.deserializeData.Text = "Click here to import data";
            this.deserializeData.UseVisualStyleBackColor = true;
            this.deserializeData.Click += new System.EventHandler(this.deserializeData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(66, 67);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(148, 22);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(253, 67);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(145, 22);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(428, 67);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(175, 22);
            this.usernameTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username";
            // 
            // AdminOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deserializeData);
            this.Controls.Add(this.serializeButton);
            this.Controls.Add(this.studentsButton);
            this.Controls.Add(this.detailedFeesButton);
            this.Name = "AdminOptionsForm";
            this.Text = "AdminOptionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button detailedFeesButton;
        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.Button serializeButton;
        private System.Windows.Forms.Button deserializeData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label3;
    }
}