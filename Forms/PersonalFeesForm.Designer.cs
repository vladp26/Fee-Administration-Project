
namespace Proiect_v2
{
    partial class PersonalFeesForm
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
            this.personalFeesDataGridView = new System.Windows.Forms.DataGridView();
            this.studentUsernameTextBox = new System.Windows.Forms.TextBox();
            this.studentGroupTextBox = new System.Windows.Forms.TextBox();
            this.studentLastNameTextBox = new System.Windows.Forms.TextBox();
            this.studentFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personalFeesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // personalFeesDataGridView
            // 
            this.personalFeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalFeesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.personalFeesDataGridView.Location = new System.Drawing.Point(0, 169);
            this.personalFeesDataGridView.Name = "personalFeesDataGridView";
            this.personalFeesDataGridView.RowHeadersWidth = 51;
            this.personalFeesDataGridView.RowTemplate.Height = 24;
            this.personalFeesDataGridView.Size = new System.Drawing.Size(800, 281);
            this.personalFeesDataGridView.TabIndex = 0;
            // 
            // studentUsernameTextBox
            // 
            this.studentUsernameTextBox.Location = new System.Drawing.Point(359, 64);
            this.studentUsernameTextBox.Name = "studentUsernameTextBox";
            this.studentUsernameTextBox.Size = new System.Drawing.Size(142, 22);
            this.studentUsernameTextBox.TabIndex = 9;
            // 
            // studentGroupTextBox
            // 
            this.studentGroupTextBox.Location = new System.Drawing.Point(525, 65);
            this.studentGroupTextBox.Name = "studentGroupTextBox";
            this.studentGroupTextBox.Size = new System.Drawing.Size(154, 22);
            this.studentGroupTextBox.TabIndex = 8;
            // 
            // studentLastNameTextBox
            // 
            this.studentLastNameTextBox.Location = new System.Drawing.Point(184, 64);
            this.studentLastNameTextBox.Name = "studentLastNameTextBox";
            this.studentLastNameTextBox.Size = new System.Drawing.Size(147, 22);
            this.studentLastNameTextBox.TabIndex = 7;
            // 
            // studentFirstNameTextBox
            // 
            this.studentFirstNameTextBox.Location = new System.Drawing.Point(31, 65);
            this.studentFirstNameTextBox.Name = "studentFirstNameTextBox";
            this.studentFirstNameTextBox.Size = new System.Drawing.Size(126, 22);
            this.studentFirstNameTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "First Name";
            // 
            // PersonalFeesForm
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
            this.Controls.Add(this.personalFeesDataGridView);
            this.Name = "PersonalFeesForm";
            this.Text = "PersonalFeesForm";
            ((System.ComponentModel.ISupportInitialize)(this.personalFeesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView personalFeesDataGridView;
        private System.Windows.Forms.TextBox studentUsernameTextBox;
        private System.Windows.Forms.TextBox studentGroupTextBox;
        private System.Windows.Forms.TextBox studentLastNameTextBox;
        private System.Windows.Forms.TextBox studentFirstNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}