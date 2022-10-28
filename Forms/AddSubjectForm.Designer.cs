
namespace Proiect_v2
{
    partial class AddSubjectForm
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
            this.subjectNameTextBox = new System.Windows.Forms.TextBox();
            this.degreeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveSubjectButton = new System.Windows.Forms.Button();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.addSubjectErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addSubjectErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectNameTextBox
            // 
            this.subjectNameTextBox.Location = new System.Drawing.Point(260, 103);
            this.subjectNameTextBox.Name = "subjectNameTextBox";
            this.subjectNameTextBox.Size = new System.Drawing.Size(255, 22);
            this.subjectNameTextBox.TabIndex = 0;
            this.subjectNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.subjectNameTextBox_Validating);
            // 
            // degreeTypeComboBox
            // 
            this.degreeTypeComboBox.FormattingEnabled = true;
            this.degreeTypeComboBox.Location = new System.Drawing.Point(260, 152);
            this.degreeTypeComboBox.Name = "degreeTypeComboBox";
            this.degreeTypeComboBox.Size = new System.Drawing.Size(255, 24);
            this.degreeTypeComboBox.TabIndex = 1;
            this.degreeTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.degreeTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Degree Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Semester";
            // 
            // saveSubjectButton
            // 
            this.saveSubjectButton.Location = new System.Drawing.Point(440, 272);
            this.saveSubjectButton.Name = "saveSubjectButton";
            this.saveSubjectButton.Size = new System.Drawing.Size(75, 58);
            this.saveSubjectButton.TabIndex = 6;
            this.saveSubjectButton.Text = "Save Subject";
            this.saveSubjectButton.UseVisualStyleBackColor = true;
            this.saveSubjectButton.Click += new System.EventHandler(this.saveSubjectButton_Click);
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Location = new System.Drawing.Point(260, 204);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(255, 24);
            this.semesterComboBox.TabIndex = 7;
            // 
            // addSubjectErrorProvider
            // 
            this.addSubjectErrorProvider.ContainerControl = this;
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.semesterComboBox);
            this.Controls.Add(this.saveSubjectButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.degreeTypeComboBox);
            this.Controls.Add(this.subjectNameTextBox);
            this.Name = "AddSubjectForm";
            this.Text = "AddSubjectForm";
            ((System.ComponentModel.ISupportInitialize)(this.addSubjectErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subjectNameTextBox;
        private System.Windows.Forms.ComboBox degreeTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveSubjectButton;
        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.ErrorProvider addSubjectErrorProvider;
    }
}