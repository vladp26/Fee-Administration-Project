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
    public partial class PaymentForm : Form
    {
        IFeesRepository _feesRepository;
        IStudentRepository _studentRepository;
        ISubjectRepository _subjectRepository;
        Guid _feeId;
        public PaymentForm(Guid FeeId)
        {
            InitializeComponent();
            _feesRepository = new FeesRepository();
            _studentRepository = new StudentRepository();
            _subjectRepository = new SubjectRepository();
            _feeId = FeeId;
            nameTextBox.Enabled = false;
            valueTextBox.Enabled = false;
            subjectTextBox.Enabled = false;
            usernameTextBox.Enabled = false;
            nameTextBox.Text = _studentRepository.GetAll().FirstOrDefault(x => x.Id == _feesRepository.GetById(FeeId).StudentId).FirstName
                + " " + _studentRepository.GetAll().FirstOrDefault(x => x.Id == _feesRepository.GetById(FeeId).StudentId).LastName;
            valueTextBox.Text = _feesRepository.GetById(FeeId).Value.ToString();
            subjectTextBox.Text = _subjectRepository.GetSubjectById(_feesRepository.GetById(_feeId).SubjectId).Name;
            usernameTextBox.Text = _studentRepository.GetAll().FirstOrDefault(x => x.Id == _feesRepository.GetById(FeeId).StudentId).Username;
            cardNumberTextBox.KeyPress += CardNumberTextBox_KeyPress;
            cvvTextBox.KeyPress += CvvTextBox_KeyPress;
        }

       

        private void payButton_Click(object sender, EventArgs e)
        {
            try
            {
                var date = DateTime.ParseExact(expiryDateTextBox.Text, "MM/yyyy",
                                           System.Globalization.CultureInfo.InvariantCulture);
                var cvv = Convert.ToInt32(cvvTextBox.Text);
                var cardnumber = Convert.ToInt64(cardNumberTextBox.Text);
                if (cvvTextBox.Text.Length == 3 && !(string.IsNullOrEmpty(ownerTextBox.Text)) && cardNumberTextBox.Text.Length == 16 
                    && (date.Year > DateTime.Now.Year || (date.Year == DateTime.Now.Year && date.Month >= DateTime.Now.Month)))
                {
                    var fee = _feesRepository.GetById(_feeId);
                    fee.IsPayed = true;
                    Hide();
                }
                else
                {
                    MessageBox.Show("I'm afraid something went wrong... Please review the payment info!");
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("I'm afraid something went wrong... Please review the payment info!");
            }
        }

        private void cardNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            SetErrorForEmptyField(cardNumberTextBox);
            if(cardNumberTextBox.Text.Length < 16)
            {
                paymentFormErrorProvider.SetError(cardNumberTextBox, "Card number must consist of 16 digits!");
            }
        }

        private void ownerTextBox_Validating(object sender, CancelEventArgs e)
        {
            SetErrorForEmptyField(ownerTextBox);
        }

        private void expiryDateTextBox_Validating(object sender, CancelEventArgs e)
        {
            SetErrorForEmptyField(expiryDateTextBox);
        }

        private void cvvTextBox_Validating(object sender, CancelEventArgs e)
        {
            SetErrorForEmptyField(cvvTextBox);
            if (cvvTextBox.Text.Length < 3)
            {
                paymentFormErrorProvider.SetError(cvvTextBox, "CVV must consist of 3 digits!");
            }
        }
        private void SetErrorForEmptyField(Control control)
        {
            paymentFormErrorProvider.SetError(control, string.IsNullOrEmpty(control.Text) ? "This field is required!" : string.Empty);
        }
        
        private void CardNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);

            List<char> valid = new List<char>();
            valid.Add('\b');
            for (var i = 0; i < 16; i++)
            {
                valid.Add((char)(i + '0'));
            }

            if (!valid.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
            if (cardNumberTextBox.Text.Length > 15 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void CvvTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);

            List<char> valid = new List<char>();
            valid.Add('\b');
            for (var i = 0; i < 3; i++)
            {
                valid.Add((char)(i + '0'));
            }

            if (!valid.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
            if (cvvTextBox.Text.Length > 2 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }   
}
