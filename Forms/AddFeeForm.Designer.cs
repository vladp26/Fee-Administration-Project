
namespace Proiect_v2
{
    partial class AddFeeForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFeeButton = new System.Windows.Forms.Button();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.addFeeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addFeeErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value";
            // 
            // saveFeeButton
            // 
            this.saveFeeButton.Location = new System.Drawing.Point(139, 162);
            this.saveFeeButton.Name = "saveFeeButton";
            this.saveFeeButton.Size = new System.Drawing.Size(100, 55);
            this.saveFeeButton.TabIndex = 6;
            this.saveFeeButton.Text = "Save Fee";
            this.saveFeeButton.UseVisualStyleBackColor = true;
            this.saveFeeButton.Click += new System.EventHandler(this.saveFeeButton_Click);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(139, 94);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(194, 22);
            this.valueTextBox.TabIndex = 7;
            this.valueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.valueTextBox_Validating);
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(139, 47);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(468, 24);
            this.subjectComboBox.TabIndex = 9;
            // 
            // addFeeErrorProvider
            // 
            this.addFeeErrorProvider.ContainerControl = this;
            // 
            // AddFeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 306);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.saveFeeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddFeeForm";
            this.Text = "AddFeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.addFeeErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveFeeButton;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.ErrorProvider addFeeErrorProvider;
    }
}