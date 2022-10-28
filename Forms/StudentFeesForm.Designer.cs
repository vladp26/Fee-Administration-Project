
namespace Proiect_v2
{
    partial class StudentFeesForm
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
            this.feesDataGridView = new System.Windows.Forms.DataGridView();
            this.addFeeButton = new System.Windows.Forms.Button();
            this.studentFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.studentLastNameTextBox = new System.Windows.Forms.TextBox();
            this.studentGroupTextBox = new System.Windows.Forms.TextBox();
            this.studentUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.feesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // feesDataGridView
            // 
            this.feesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.feesDataGridView.Location = new System.Drawing.Point(0, 178);
            this.feesDataGridView.Name = "feesDataGridView";
            this.feesDataGridView.RowHeadersWidth = 51;
            this.feesDataGridView.RowTemplate.Height = 24;
            this.feesDataGridView.Size = new System.Drawing.Size(800, 272);
            this.feesDataGridView.TabIndex = 0;
            // 
            // addFeeButton
            // 
            this.addFeeButton.Location = new System.Drawing.Point(0, 115);
            this.addFeeButton.Name = "addFeeButton";
            this.addFeeButton.Size = new System.Drawing.Size(118, 57);
            this.addFeeButton.TabIndex = 1;
            this.addFeeButton.Text = "Add Fee";
            this.addFeeButton.UseVisualStyleBackColor = true;
            this.addFeeButton.Click += new System.EventHandler(this.addFeeButton_Click);
            // 
            // studentFirstNameTextBox
            // 
            this.studentFirstNameTextBox.Location = new System.Drawing.Point(13, 43);
            this.studentFirstNameTextBox.Name = "studentFirstNameTextBox";
            this.studentFirstNameTextBox.Size = new System.Drawing.Size(126, 22);
            this.studentFirstNameTextBox.TabIndex = 2;
            // 
            // studentLastNameTextBox
            // 
            this.studentLastNameTextBox.Location = new System.Drawing.Point(166, 42);
            this.studentLastNameTextBox.Name = "studentLastNameTextBox";
            this.studentLastNameTextBox.Size = new System.Drawing.Size(147, 22);
            this.studentLastNameTextBox.TabIndex = 3;
            // 
            // studentGroupTextBox
            // 
            this.studentGroupTextBox.Location = new System.Drawing.Point(507, 43);
            this.studentGroupTextBox.Name = "studentGroupTextBox";
            this.studentGroupTextBox.Size = new System.Drawing.Size(154, 22);
            this.studentGroupTextBox.TabIndex = 4;
            // 
            // studentUsernameTextBox
            // 
            this.studentUsernameTextBox.Location = new System.Drawing.Point(341, 42);
            this.studentUsernameTextBox.Name = "studentUsernameTextBox";
            this.studentUsernameTextBox.Size = new System.Drawing.Size(142, 22);
            this.studentUsernameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Group";
            // 
            // StudentFeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentUsernameTextBox);
            this.Controls.Add(this.studentGroupTextBox);
            this.Controls.Add(this.studentLastNameTextBox);
            this.Controls.Add(this.studentFirstNameTextBox);
            this.Controls.Add(this.addFeeButton);
            this.Controls.Add(this.feesDataGridView);
            this.Name = "StudentFeesForm";
            this.Text = "StudentFeesForm";
            ((System.ComponentModel.ISupportInitialize)(this.feesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView feesDataGridView;
        private System.Windows.Forms.Button addFeeButton;
        private System.Windows.Forms.TextBox studentFirstNameTextBox;
        private System.Windows.Forms.TextBox studentLastNameTextBox;
        private System.Windows.Forms.TextBox studentGroupTextBox;
        private System.Windows.Forms.TextBox studentUsernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}