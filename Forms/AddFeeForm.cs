using Proiect_v2.Database;
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
    public partial class AddFeeForm : Form
    {
        Guid _studid;
        IFeesRepository _feesRepository;
        public AddFeeForm(Guid studentId)
        {
            InitializeComponent();
            subjectComboBox.DataSource = FakeDB.subjects.Select(x => x.Name).ToList();
            subjectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _studid = studentId;
            _feesRepository = new FeesRepository();
        }

        private void saveFeeButton_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {
                var fee = new Fee();
                fee.IsPayed = false;
                fee.StudentId = _studid;
                fee.SubjectId = FakeDB.subjects.FirstOrDefault(x => x.Name == (String)subjectComboBox.SelectedItem).Id;
                fee.Value = Convert.ToInt32(valueTextBox.Text);
                _feesRepository.Add(fee);
                Hide();
            }
            else
            {
                MessageBox.Show("Something went wrong... Please check the provided info!");
            }
        }
        private void SetErrorForNumericField(Control control)
        {
            try
            {
                var number = Convert.ToInt32(control.Text);
                addFeeErrorProvider.SetError(control, string.Empty);
            }
            catch (Exception ex)
            {
                addFeeErrorProvider.SetError(control, "This field is an integer!");
            }
        }
        private bool FormIsValid()
        {
            try
            {
                var number = Convert.ToInt32(valueTextBox.Text);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        private void valueTextBox_Validating(object sender, CancelEventArgs e)
        {
            SetErrorForNumericField(valueTextBox);
        }
    }
}
