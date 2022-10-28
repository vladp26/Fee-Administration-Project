using Proiect_v2.Repositories;
using Proiect_v2.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_v2.Entities;

namespace Proiect_v2
{
    public partial class StudentsForm : Form
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IFeesRepository _feesRepository;
        public StudentsForm()
        {
            InitializeComponent();
            _studentRepository = new StudentRepository();
            _feesRepository = new FeesRepository();
            studentsDataGridView.AutoGenerateColumns = false;
            studentsDataGridView.ReadOnly = true;
            studentsDataGridView.AllowUserToAddRows = false;
            studentsDataGridView.AllowUserToDeleteRows = false;



            studentsDataGridView
                .addColumn(0, "First Name", "FirstName")
                .addColumn(1, "Last Name", "LastName")
                .addColumn(2, "Username", "Username")
                .addColumn(3, "Group", "Group")
                .addButtonColumn("feesColumn", "View Fees", string.Empty)
                .addButtonColumn("updateColumn", "Update Student", string.Empty)
                .addButtonColumn("deleteColumn", "Delete student", string.Empty);
            studentsDataGridView.DataSource = _studentRepository.GetAll();
            studentsDataGridView.CellClick += studentsDataGridView_cellClick;
        }

        private void studentsDataGridView_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }
            if(e.ColumnIndex==studentsDataGridView.Columns["updateColumn"].Index)
            {
                var currentObject = (Student)studentsDataGridView.CurrentRow.DataBoundItem;
                var editstudentform = new EditStudentForm(currentObject.Id);
                editstudentform.ShowDialog();
                var data = _studentRepository.GetAll();
                studentsDataGridView.refreshDataGridView(data);
                
            }
            if(e.ColumnIndex==studentsDataGridView.Columns["feesColumn"].Index)
            {
                var currentObject = (Student)studentsDataGridView.CurrentRow.DataBoundItem;
                var studentfeesform = new StudentFeesForm(currentObject.Id);
                studentfeesform.ShowDialog();

            }
            if(e.ColumnIndex==studentsDataGridView.Columns["deleteColumn"].Index)
            {
                var currentObject = (Student)studentsDataGridView.CurrentRow.DataBoundItem;
                _feesRepository.DeleteAllByStudentId(currentObject.Id);
                _studentRepository.Delete(currentObject);
                var data = _studentRepository.GetAll();
                studentsDataGridView.refreshDataGridView(data);
            }
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            var addstudentform = new AddStudentForm();
            addstudentform.ShowDialog();
            var data = _studentRepository.GetAll();
            studentsDataGridView.refreshDataGridView(data);
        }
    }
}
