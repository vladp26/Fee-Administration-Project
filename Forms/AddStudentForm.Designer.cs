
namespace Proiect_v2
{
    partial class AddStudentForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addStudentFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.addStudentLastNameTextBox = new System.Windows.Forms.TextBox();
            this.addStudentGroupTextBox = new System.Windows.Forms.TextBox();
            this.addStudentUsernameTextBox = new System.Windows.Forms.TextBox();
            this.addStudentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveStudentButton = new System.Windows.Forms.Button();
            this.addStudentErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addStudentErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // addStudentFirstNameTextBox
            // 
            this.addStudentFirstNameTextBox.Location = new System.Drawing.Point(209, 49);
            this.addStudentFirstNameTextBox.Name = "addStudentFirstNameTextBox";
            this.addStudentFirstNameTextBox.Size = new System.Drawing.Size(238, 22);
            this.addStudentFirstNameTextBox.TabIndex = 5;
            this.addStudentFirstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.addStudentFirstNameTextBox_Validating);
            // 
            // addStudentLastNameTextBox
            // 
            this.addStudentLastNameTextBox.Location = new System.Drawing.Point(209, 99);
            this.addStudentLastNameTextBox.Name = "addStudentLastNameTextBox";
            this.addStudentLastNameTextBox.Size = new System.Drawing.Size(238, 22);
            this.addStudentLastNameTextBox.TabIndex = 6;
            this.addStudentLastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.addStudentLastNameTextBox_Validating);
            // 
            // addStudentGroupTextBox
            // 
            this.addStudentGroupTextBox.Location = new System.Drawing.Point(209, 152);
            this.addStudentGroupTextBox.Name = "addStudentGroupTextBox";
            this.addStudentGroupTextBox.Size = new System.Drawing.Size(238, 22);
            this.addStudentGroupTextBox.TabIndex = 7;
            this.addStudentGroupTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.addStudentGroupTextBox_Validating);
            // 
            // addStudentUsernameTextBox
            // 
            this.addStudentUsernameTextBox.Location = new System.Drawing.Point(209, 240);
            this.addStudentUsernameTextBox.Name = "addStudentUsernameTextBox";
            this.addStudentUsernameTextBox.Size = new System.Drawing.Size(238, 22);
            this.addStudentUsernameTextBox.TabIndex = 8;
            this.addStudentUsernameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.addStudentUsernameTextBox_Validating);
            // 
            // addStudentPasswordTextBox
            // 
            this.addStudentPasswordTextBox.Location = new System.Drawing.Point(209, 287);
            this.addStudentPasswordTextBox.Name = "addStudentPasswordTextBox";
            this.addStudentPasswordTextBox.Size = new System.Drawing.Size(238, 22);
            this.addStudentPasswordTextBox.TabIndex = 9;
            this.addStudentPasswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.addStudentPasswordTextBox_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Identification:";
            // 
            // saveStudentButton
            // 
            this.saveStudentButton.Location = new System.Drawing.Point(308, 348);
            this.saveStudentButton.Name = "saveStudentButton";
            this.saveStudentButton.Size = new System.Drawing.Size(139, 53);
            this.saveStudentButton.TabIndex = 11;
            this.saveStudentButton.Text = "Save Student";
            this.saveStudentButton.UseVisualStyleBackColor = true;
            this.saveStudentButton.Click += new System.EventHandler(this.saveStudentButton_Click);
            // 
            // addStudentErrorProvider
            // 
            this.addStudentErrorProvider.ContainerControl = this;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveStudentButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addStudentPasswordTextBox);
            this.Controls.Add(this.addStudentUsernameTextBox);
            this.Controls.Add(this.addStudentGroupTextBox);
            this.Controls.Add(this.addStudentLastNameTextBox);
            this.Controls.Add(this.addStudentFirstNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStudentForm";
            this.Text = "addStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.addStudentErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addStudentFirstNameTextBox;
        private System.Windows.Forms.TextBox addStudentLastNameTextBox;
        private System.Windows.Forms.TextBox addStudentGroupTextBox;
        private System.Windows.Forms.TextBox addStudentUsernameTextBox;
        private System.Windows.Forms.TextBox addStudentPasswordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveStudentButton;
        private System.Windows.Forms.ErrorProvider addStudentErrorProvider;
    }
}