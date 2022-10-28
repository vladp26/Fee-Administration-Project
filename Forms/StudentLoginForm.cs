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
    public partial class StudentLoginForm : Form
    {
        IStudentRepository _studentRepository;
        public StudentLoginForm()
        {
            InitializeComponent();
            _studentRepository = new StudentRepository();
            passwordTextBox.PasswordChar = '*';
        }


        private void studentLoginButton_Click(object sender, EventArgs e)
        {
            if(_studentRepository.GetByUsername(usernameTextBox.Text)==null)
            {
                MessageBox.Show("Wrong credentials");
            }
            else
            {
                var student = new Student(passwordTextBox.Text);
                student.Username = usernameTextBox.Text;

                if (_studentRepository.verifyPassword(student, passwordTextBox.Text) == false)
                {
                    MessageBox.Show("Wrong credentials");
                }
                else
                {
                    Hide();
                    var form = new PersonalFeesForm(_studentRepository.GetByUsername(usernameTextBox.Text).Id);
                    form.ShowDialog();
                }
            }
        }
    }
}
