using Proiect_v2.Entities;
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
    public partial class AddStudentForm : Form
    {
        IStudentRepository _studentRepository;
        public AddStudentForm()
        {
            InitializeComponent();
            _studentRepository = new StudentRepository();
        }

        private void saveStudentButton_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {
                try
                {
                    if (_studentRepository.GetAll() != null)
                    {
                        var studentToVerifyUsername = _studentRepository.GetAll().FirstOrDefault(x => x.Username == addStudentUsernameTextBox.Text);
                        if (studentToVerifyUsername != null)
                        {
                            throw new Exception("This username is taken!");
                        }
                    }
                    var student = new Student(addStudentPasswordTextBox.Text);
                    student.FirstName = addStudentFirstNameTextBox.Text;
                    student.LastName = addStudentLastNameTextBox.Text;
                    student.Username = addStudentUsernameTextBox.Text;
                    student.Group = Convert.ToInt32(addStudentGroupTextBox.Text);
                    _studentRepository.Add(student);
                    Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Something went wrong... Please check the provided info!");
            }
            
        }

        private void addStudentFirstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            SetErrorForEmptyField(addStudentFirstNameTextBox);
        }

        private void addStudentLastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            SetErrorForEmptyField(addStudentLastNameTextBox);
        }

        private void addStudentGroupTextBox_Validating(object sender, CancelEventArgs e)
        {
            SetErrorForNumericField(addStudentGroupTextBox);
        }

        private void addStudentUsernameTextBox_Validating(object sender, CancelEventArgs e)
        {
            SetErrorForEmptyField(addStudentUsernameTextBox);
        }

        private void addStudentPasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            SetErrorForEmptyField(addStudentPasswordTextBox);
        }

        private void SetErrorForEmptyField(Control control)
        {
            addStudentErrorProvider.SetError(control, string.IsNullOrEmpty(control.Text) ? "This field is required!" : string.Empty);
        }
        private void SetErrorForNumericField(Control control)
        {
            try
            {
                var number = Convert.ToInt32(control.Text);
                addStudentErrorProvider.SetError(control, string.Empty);
            }
            catch(Exception ex)
            {
                addStudentErrorProvider.SetError(control, "This field is an integer!");
            }
        }
        
        private bool FormIsValid()
        {
            if (string.IsNullOrEmpty(addStudentFirstNameTextBox.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(addStudentLastNameTextBox.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(addStudentUsernameTextBox.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(addStudentPasswordTextBox.Text))
            {
                return false;
            }
            try
            {
                var number = Convert.ToInt32(addStudentGroupTextBox.Text);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        
    }
}

