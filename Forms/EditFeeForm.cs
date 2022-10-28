using Proiect_v2.Database;
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
    public partial class EditFeeForm : Form
    {
        IFeesRepository _feesRepository;
        Guid _feeId;
        public EditFeeForm(Guid Id)
        {
            InitializeComponent();
            _feeId = Id;
            _feesRepository = new FeesRepository();
            var fee = _feesRepository.GetById(_feeId);
            valueTextBox.Text = fee.Value.ToString();
            subjectComboBox.DataSource = FakeDB.subjects.Select(x => x.Name).ToList();
            subjectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            isPayedComboBox.Text=fee.IsPayed?"true" : "false";
            isPayedComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            subjectComboBox.Text = FakeDB.subjects.FirstOrDefault(x => x.Id == fee.SubjectId).Name;

        }

        private void saveFeeButton_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {
                var fee = _feesRepository.GetById(_feeId);
                fee.Value = Convert.ToInt32(valueTextBox.Text);
                fee.IsPayed = isPayedComboBox.Text == "true" ? true : false;
                fee.SubjectId = FakeDB.subjects.FirstOrDefault(x => x.Name == subjectComboBox.Text).Id;
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
                editFeeErrorProvider.SetError(control, string.Empty);
            }
            catch (Exception ex)
            {
                editFeeErrorProvider.SetError(control, "This field is an integer!");
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
