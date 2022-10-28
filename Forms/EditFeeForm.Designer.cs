
namespace Proiect_v2
{
    partial class EditFeeForm
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
            this.Subject = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.isPayedComboBox = new System.Windows.Forms.ComboBox();
            this.saveFeeButton = new System.Windows.Forms.Button();
            this.editFeeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.editFeeErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Location = new System.Drawing.Point(70, 76);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(55, 17);
            this.Subject.TabIndex = 0;
            this.Subject.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Is it payed?";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(156, 117);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(287, 22);
            this.valueTextBox.TabIndex = 3;
            this.valueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.valueTextBox_Validating);
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(156, 76);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(287, 24);
            this.subjectComboBox.TabIndex = 4;
            // 
            // isPayedComboBox
            // 
            this.isPayedComboBox.FormattingEnabled = true;
            this.isPayedComboBox.Items.AddRange(new object[] {
            "true",
            "false"});
            this.isPayedComboBox.Location = new System.Drawing.Point(156, 156);
            this.isPayedComboBox.Name = "isPayedComboBox";
            this.isPayedComboBox.Size = new System.Drawing.Size(287, 24);
            this.isPayedComboBox.TabIndex = 5;
            // 
            // saveFeeButton
            // 
            this.saveFeeButton.Location = new System.Drawing.Point(323, 227);
            this.saveFeeButton.Name = "saveFeeButton";
            this.saveFeeButton.Size = new System.Drawing.Size(120, 48);
            this.saveFeeButton.TabIndex = 6;
            this.saveFeeButton.Text = "Save Fee";
            this.saveFeeButton.UseVisualStyleBackColor = true;
            this.saveFeeButton.Click += new System.EventHandler(this.saveFeeButton_Click);
            // 
            // editFeeErrorProvider
            // 
            this.editFeeErrorProvider.ContainerControl = this;
            // 
            // EditFeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveFeeButton);
            this.Controls.Add(this.isPayedComboBox);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Subject);
            this.Name = "EditFeeForm";
            this.Text = "EditFeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.editFeeErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.ComboBox isPayedComboBox;
        private System.Windows.Forms.Button saveFeeButton;
        private System.Windows.Forms.ErrorProvider editFeeErrorProvider;
    }
}