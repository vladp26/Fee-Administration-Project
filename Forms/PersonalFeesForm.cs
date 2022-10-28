using Proiect_v2.Entities;
using Proiect_v2.Extensions;
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
    public partial class PersonalFeesForm : Form
    {
        private IFeesRepository _feesRepository;
        private IStudentRepository _studentRepository;
        private Guid _id;
        public PersonalFeesForm(Guid Id)
        {
            InitializeComponent();
            _feesRepository = new FeesRepository();
            _studentRepository = new StudentRepository();
            var student = _studentRepository.GetById(Id);
            personalFeesDataGridView.AutoGenerateColumns = false;
            studentFirstNameTextBox.Enabled = false;
            studentLastNameTextBox.Enabled = false;
            studentUsernameTextBox.Enabled = false;
            studentGroupTextBox.Enabled = false;
            studentFirstNameTextBox.Text = student.FirstName;
            studentLastNameTextBox.Text = student.LastName;
            studentUsernameTextBox.Text = student.Username;
            studentGroupTextBox.Text = student.Group.ToString();
            personalFeesDataGridView.addColumn(0, "Value", "Value")
            .addColumn(1, "Subject", "Subject")
            .addColumn(2, "IsPayed", "IsPayed")
            .addButtonColumn("payFee", "Pay Fee", string.Empty);
            personalFeesDataGridView.DataSource = _feesRepository.GetAllByStudentId(Id);
            _id = Id;
            personalFeesDataGridView.CellClick += personalFeesDataGridView_CellClick;
        }

        private void personalFeesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == personalFeesDataGridView.Columns["payFee"].Index)
            {
                var CurrentObject = (SubjectFee)personalFeesDataGridView.CurrentRow.DataBoundItem;
                if (CurrentObject.IsPayed == false)
                {
                    var paymentForm = new PaymentForm(CurrentObject.Id);
                    paymentForm.ShowDialog();
                    var data = _feesRepository.GetAllByStudentId(_id);
                    personalFeesDataGridView.refreshDataGridView(data);
                }
                else
                {
                    MessageBox.Show("This fee has already been paid!");
                }
            }
        }

      
    }
}



