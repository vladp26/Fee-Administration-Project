
namespace Proiect_v2
{
    partial class EditStudentForm
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
            this.saveStudentButton = new System.Windows.Forms.Button();
            this.editStudentGroupTextBox = new System.Windows.Forms.TextBox();
            this.editStudentLastNameTextBox = new System.Windows.Forms.TextBox();
            this.editStudentFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editStudentErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.editStudentErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // saveStudentButton
            // 
            this.saveStudentButton.Location = new System.Drawing.Point(314, 222);
            this.saveStudentButton.Name = "saveStudentButton";
            this.saveStudentButton.Size = new System.Drawing.Size(139, 53);
            this.saveStudentButton.TabIndex = 23;
            this.saveStudentButton.Text = "Save Student";
            this.saveStudentButton.UseVisualStyleBackColor = true;
            this.saveStudentButton.Click += new System.EventHandler(this.saveStudentButton_Click);
            // 
            // editStudentGroupTextBox
            // 
            this.editStudentGroupTextBox.Location = new System.Drawing.Point(215, 150);
            this.editStudentGroupTextBox.Name = "editStudentGroupTextBox";
            this.editStudentGroupTextBox.Size = new System.Drawing.Size(238, 22);
            this.editStudentGroupTextBox.TabIndex = 19;
            this.editStudentGroupTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.editStudentGroupTextBox_Validating);
            // 
            // editStudentLastNameTextBox
            // 
            this.editStudentLastNameTextBox.Location = new System.Drawing.Point(215, 97);
            this.editStudentLastNameTextBox.Name = "editStudentLastNameTextBox";
            this.editStudentLastNameTextBox.Size = new System.Drawing.Size(238, 22);
            this.editStudentLastNameTextBox.TabIndex = 18;
            this.editStudentLastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.editStudentLastNameTextBox_Validating);
            // 
            // editStudentFirstNameTextBox
            // 
            this.editStudentFirstNameTextBox.Location = new System.Drawing.Point(215, 47);
            this.editStudentFirstNameTextBox.Name = "editStudentFirstNameTextBox";
            this.editStudentFirstNameTextBox.Size = new System.Drawing.Size(238, 22);
            this.editStudentFirstNameTextBox.TabIndex = 17;
            this.editStudentFirstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.editStudentFirstNameTextBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Name";
            // 
            // editStudentErrorProvider
            // 
            this.editStudentErrorProvider.ContainerControl = this;
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 321);
            this.Controls.Add(this.saveStudentButton);
            this.Controls.Add(this.editStudentGroupTextBox);
            this.Controls.Add(this.editStudentLastNameTextBox);
            this.Controls.Add(this.editStudentFirstNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditStudentForm";
            this.Text = "EditStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.editStudentErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveStudentButton;
        private System.Windows.Forms.TextBox editStudentGroupTextBox;
        private System.Windows.Forms.TextBox editStudentLastNameTextBox;
        private System.Windows.Forms.TextBox editStudentFirstNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider editStudentErrorProvider;
    }
}