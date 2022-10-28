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
    public partial class AddSubjectForm : Form
    {
        ISubjectRepository _subjectRepository;
        public AddSubjectForm()
        {
            InitializeComponent();
            _subjectRepository = new SubjectRepository();
            degreeTypeComboBox.DataSource = Enum.GetValues(typeof(DegreeType));
            degreeTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            semesterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void saveSubjectButton_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {
                var subject = new Subject();
                subject.Name = subjectNameTextBox.Text;
                subject.Degree = (DegreeType)degreeTypeComboBox.SelectedItem;
                subject.Semester = (int)semesterComboBox.SelectedItem;
                _subjectRepository.Add(subject);
                Hide();
            }
            else
            {
                MessageBox.Show("Something went wrong... Please check the provided info!");
            }
        }

        private void degreeTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (degreeTypeComboBox.Text == "Bachelor" || degreeTypeComboBox.Text == "PhD")
            {
                int[] v = new int[6] { 1, 2, 3, 4, 5, 6 };
                semesterComboBox.DataSource = v;
            }
            else
            {
                int[] v = new int[4] { 1, 2, 3, 4 };
                semesterComboBox.DataSource = v;
            }
        }
        private void SetErrorForEmptyField(Control control)
        {
            addSubjectErrorProvider.SetError(control, string.IsNullOrEmpty(control.Text) ? "This field is required!" : string.Empty);
        }
        private void subjectNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            SetErrorForEmptyField(subjectNameTextBox);
        }
        private bool FormIsValid()
        {
            if (string.IsNullOrEmpty(subjectNameTextBox.Text))
            {
                return false;
            }
            return true;
        }

    }
}

