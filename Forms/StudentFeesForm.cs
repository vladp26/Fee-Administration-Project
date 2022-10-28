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
using Proiect_v2.Extensions;
using Proiect_v2.Entities;
using Proiect_v2.Database;

namespace Proiect_v2
{
    public partial class StudentFeesForm : Form
    {
        private IFeesRepository _feesRepository;
        private IStudentRepository _studentRepository;
        private Guid _id;
        public StudentFeesForm(Guid Id)
        {
            
            InitializeComponent();
            _feesRepository = new FeesRepository();
            _studentRepository = new StudentRepository();
            var student = _studentRepository.GetById(Id);
            feesDataGridView.AutoGenerateColumns = false;
            studentFirstNameTextBox.Enabled = false;
            studentLastNameTextBox.Enabled = false;
            studentUsernameTextBox.Enabled = false;
            studentGroupTextBox.Enabled = false;
            studentFirstNameTextBox.Text = student.FirstName;
            studentLastNameTextBox.Text = student.LastName;
            studentUsernameTextBox.Text = student.Username;
            studentGroupTextBox.Text = student.Group.ToString();
            feesDataGridView.addColumn(0, "Value", "Value")
                .addColumn(1, "Subject", "Subject")
                .addColumn(2, "IsPayed", "IsPayed")
                .addButtonColumn("updateFee", "Update Fee", string.Empty)
                .addButtonColumn("deleteFee", "Delete Fee", string.Empty);
            feesDataGridView.DataSource = _feesRepository.GetAllByStudentId(Id);
            _id = Id;
            feesDataGridView.CellClick += FeesDataGridView_CellClick;
        }

        private void FeesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == feesDataGridView.Columns["updateFee"].Index)
            {
                var currentObject = (SubjectFee)feesDataGridView.CurrentRow.DataBoundItem;
                var editfeeform = new EditFeeForm(currentObject.Id);
                editfeeform.ShowDialog();
                var data = _feesRepository.GetAllByStudentId(_id);
                feesDataGridView.refreshDataGridView(data);
            }
            if (e.ColumnIndex == feesDataGridView.Columns["deleteFee"].Index)
            {
                var currentObject = (SubjectFee)feesDataGridView.CurrentRow.DataBoundItem;
                //initial am dorit sa creez un obiect Fee cu datele din currentObject, dar am realizat ca se poate sa sterg
                //direct bazat pe currentObject.Id
                //var fee = new Fee();
                //fee.Id = currentObject.Id;
                //fee.Value = currentObject.Value;
                //fee.IsPayed = currentObject.IsPayed;
                //fee.StudentId = _id;
                //fee.SubjectId = FakeDB.subjects.FirstOrDefault(x => x.Name == currentObject.Subject).Id;
                _feesRepository.Delete(FakeDB.fees.FirstOrDefault(x=>x.Id== currentObject.Id));
                var data = _feesRepository.GetAllByStudentId(_id);
                feesDataGridView.refreshDataGridView(data);
            }
        }

        private void addFeeButton_Click(object sender, EventArgs e)
        {
            var addfeeform = new AddFeeForm(_id);
            addfeeform.ShowDialog();
            var data = _feesRepository.GetAllByStudentId(_id);
            feesDataGridView.refreshDataGridView(data);
        }
    }
}
