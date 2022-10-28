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
    public partial class DetailedFeesForm : Form
    {
        private IFeesRepository _feesRepository;
        public DetailedFeesForm()
        {
            InitializeComponent();
            _feesRepository = new FeesRepository();
            studentsFeesDataGridView.AutoGenerateColumns = false;
            studentsFeesDataGridView.addColumn(0, "StudentName", "StudentName")
        .addColumn(1, "Username", "Username").addColumn(2, "Value", "Value")
        .addColumn(3, "Subject", "Subject")
        .addColumn(4, "IsPayed", "IsPayed");
            studentsFeesDataGridView.DataSource = _feesRepository.GetAllWithDetails();

        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            var addsubjectform = new AddSubjectForm();
            addsubjectform.ShowDialog();
        }
    }
}

