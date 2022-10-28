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
using Proiect_v2.Database;
using Proiect_v2.Extensions;

namespace Proiect_v2
{
    public partial class AdminLoginForm : Form
    {
        IAdminRepository _adminRepository;
        public AdminLoginForm()
        {
            InitializeComponent();
            _adminRepository = new AdminRepository();
            adminPasswordTextBox.PasswordChar = '*';
        }

        private void loginAdminButton_Click(object sender, EventArgs e)
        {
            if (_adminRepository.GetByUsername(adminUsernameTextBox.Text) == null)
            {
                MessageBox.Show("Wrong credentials");
            }
            else
            {
                var admin = new Admin(adminPasswordTextBox.Text);
                admin.Username = adminUsernameTextBox.Text;
                
                if (_adminRepository.verifyPassword(admin,adminPasswordTextBox.Text)==false)
                {
                    MessageBox.Show("Wrong credentials");
                }
                else
                {
                    Hide();
                   var studentsform = new AdminOptionsForm(adminUsernameTextBox.Text);
                   studentsform.ShowDialog();
                }
            }
            
        }
        
    }
}
