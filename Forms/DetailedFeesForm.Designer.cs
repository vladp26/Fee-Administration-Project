
namespace Proiect_v2
{
    partial class DetailedFeesForm
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
            this.studentsFeesDataGridView = new System.Windows.Forms.DataGridView();
            this.addSubjectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsFeesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsFeesDataGridView
            // 
            this.studentsFeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsFeesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.studentsFeesDataGridView.Location = new System.Drawing.Point(0, 142);
            this.studentsFeesDataGridView.Name = "studentsFeesDataGridView";
            this.studentsFeesDataGridView.RowHeadersWidth = 51;
            this.studentsFeesDataGridView.RowTemplate.Height = 24;
            this.studentsFeesDataGridView.Size = new System.Drawing.Size(1207, 308);
            this.studentsFeesDataGridView.TabIndex = 0;
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Location = new System.Drawing.Point(1057, 60);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(138, 60);
            this.addSubjectButton.TabIndex = 1;
            this.addSubjectButton.Text = "Add a Subject";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // DetailedFeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 450);
            this.Controls.Add(this.addSubjectButton);
            this.Controls.Add(this.studentsFeesDataGridView);
            this.Name = "DetailedFeesForm";
            this.Text = "DetailedFeesForm";
            ((System.ComponentModel.ISupportInitialize)(this.studentsFeesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsFeesDataGridView;
        private System.Windows.Forms.Button addSubjectButton;
    }
}