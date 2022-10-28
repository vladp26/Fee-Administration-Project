using Proiect_v2.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_v2
{
    public partial class EditStudentForm : Form
    {
        private readonly IStudentRepository _studentrepository;
        private readonly Guid _id;
        public EditStudentForm(Guid Id)
        {
            InitializeComponent();
            _studentrepository = new StudentRepository();
            var student = _studentrepository.GetById(Id);
            _id = Id;
            editStudentFirstNameTextBox.Text = student.FirstName;
            editStudentLastNameTextBox.Text = student.LastName;
            editStudentGroupTextBox.Text = student.Group.ToString();
        }

        private void saveStudentButton_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {
                var student = _studentrepository.GetById(_id);
                student.FirstName = editStudentFirstNameTextBox.Text;
                student.LastName = editStudentLastNameTextBox.Text;
                student.Group = Convert.ToInt32(editStudentGroupTextBox.Text);
                Hide();
            }
            else
            {
                MessageBox.Show("Something went wrong... Please check the provided info!");
            }
        }

        private void editStudentFirstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            SetErrorForEmptyField(editStudentFirstNameTextBox);
        }

        private void editStudentLastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            SetErrorForEmptyField(editStudentLastNameTextBox);
        }

        private void editStudentGroupTextBox_Validating(object sender, CancelEventArgs e)
        {
            SetErrorForNumericField(editStudentGroupTextBox);
        }
        private void SetErrorForEmptyField(Control control)
        {
            editStudentErrorProvider.SetError(control, string.IsNullOrEmpty(control.Text) ? "This field is required!" : string.Empty);
        }
        private void SetErrorForNumericField(Control control)
        {
            try
            {
                var number = Convert.ToInt32(control.Text);
                editStudentErrorProvider.SetError(control, string.Empty);
            }
            catch (Exception ex)
            {
                editStudentErrorProvider.SetError(control, "This field is an integer!");
            }
        }
        private bool FormIsValid()
        {
            if (string.IsNullOrEmpty(editStudentFirstNameTextBox.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(editStudentLastNameTextBox.Text))
            {
                return false;
            }
            try
            {
                var number = Convert.ToInt32(editStudentGroupTextBox.Text);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
