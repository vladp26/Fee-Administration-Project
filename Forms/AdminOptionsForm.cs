using Proiect_v2.Database;
using Proiect_v2.Entities;
using Proiect_v2.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_v2
{
    public partial class AdminOptionsForm : Form
    {
        IStudentRepository _studentRepository;
        IFeesRepository _feesRepository;
        ISubjectRepository _subjectRepository;
        IAdminRepository _adminRepository;
        public AdminOptionsForm(string username)
        {
            InitializeComponent();
            _studentRepository = new StudentRepository();
            _subjectRepository = new SubjectRepository();
            _feesRepository = new FeesRepository();
            _adminRepository = new AdminRepository();
            firstNameTextBox.Enabled = false;
            lastNameTextBox.Enabled = false;
            usernameTextBox.Enabled = false;
            usernameTextBox.Text = username;
            lastNameTextBox.Text=_adminRepository.GetByUsername(username).LastName;
            firstNameTextBox.Text = _adminRepository.GetByUsername(username).FirstName;
        }

        private void detailedFeesButton_Click(object sender, EventArgs e)
        {
            var form = new DetailedFeesForm();
            form.ShowDialog();
        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            var form = new StudentsForm();
            form.ShowDialog();
        }

        private void serializeButton_Click(object sender, EventArgs e)
        {
            int k = 0;
            string path1 = "", path2 = "", path3 = "";
            bool changed1 = false, changed2 = false, changed3 = false;
            try
            {
                SerializeListIntoFile<Student>(_studentRepository.GetAll(), ref path1, k, ref changed1); ;
                k++;
                SerializeListIntoFile<Subject>(_subjectRepository.GetAll(), ref path2,k, ref changed2);
                k++;
                SerializeListIntoFile<Fee>(_feesRepository.GetAll(), ref path3, k, ref changed3);
                var backuppath1 = path1.Remove(path1.Length - 4, 4) + "backup.bin";
                var backuppath2 = path2.Remove(path2.Length - 4, 4) + "backup.bin";
                var backuppath3 = path3.Remove(path3.Length - 4, 4) + "backup.bin";
                try
                {
                    File.Delete(backuppath1);
                    File.Delete(backuppath2);
                    File.Delete(backuppath3);
                }
                catch(Exception exc)
                {

                }
            }
            catch(Exception ex)
            {
                try
                {
                    if (changed1 == false)
                    {
                        File.Delete(path1);
                    }
                    else
                    {
                        var backuppath = path1.Remove(path1.Length - 4, 4) + "backup.bin";
                        FileInfo fi = new FileInfo(path1);
                        File.Delete(path1);
                        File.Move(backuppath, path1);
                        
                    }
                }
                catch (Exception ex1)
                {

                }
                try
                {
                    if (changed2 == false)
                    {
                        File.Delete(path2);
                    }
                    else
                    {
                        var backuppath = path2.Remove(path2.Length - 4, 4) + "backup.bin";
                        FileInfo fi = new FileInfo(path2);
                        File.Delete(path2);
                        File.Move(backuppath, path2);

                    }
                }
                catch (Exception ex2)
                {

                }
                try
                {
                    if (changed3 == false)
                    {
                        File.Delete(path3);
                    }
                    else
                    {
                        var backuppath = path3.Remove(path3.Length - 4, 4) + "backup.bin";
                        FileInfo fi = new FileInfo(path3);
                        File.Delete(path3);
                        File.Move(backuppath, path3);

                    }
                }
                catch (Exception ex3)
                {

                }
                MessageBox.Show(ex.Message);
            }
        }

        private void deserializeData_Click(object sender, EventArgs e)
        {
            try
            {
                int k = 0;
                List<Student> tmpstudents = DeserializeFileIntoList<Student>(k);
                k++;
                List<Subject> tmpsubjects = DeserializeFileIntoList<Subject>(k);
                k++;
                List<Fee> tmpfees = DeserializeFileIntoList<Fee>(k);
                _studentRepository.ModifyList(tmpstudents);
                _subjectRepository.ModifyList(tmpsubjects);
                _feesRepository.ModifyList(tmpfees);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SerializeListIntoFile<T>(List<T> list, ref string filepath, int k, ref bool changed)
        {
            changed = false;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary file|*.bin";
            if (k == 0)
            {
                saveFileDialog.Title = "Choose location to serialize students";
                MessageBox.Show("Preparing to serialize students. Close this box to continue");
            }
            if (k == 1)
            {
                saveFileDialog.Title = "Choose location to serialize subjects";
                MessageBox.Show("Preparing to serialize subjects. Close this box to continue");
            }
            if (k == 2)
            {
                saveFileDialog.Title = "Choose location to serialize fees";
                MessageBox.Show("Preparing to serialize fees. Close this box to continue");
            }
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    var tmp = saveFileDialog.FileName.Clone().ToString();
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        changed = true;
                        FileInfo fi = new FileInfo(saveFileDialog.FileName);
                        var tmppath = fi.FullName;
                        var dst = tmppath.Remove(tmppath.Length-4, 4) + "backup" + fi.Extension;
                        File.Move(saveFileDialog.FileName, dst);
                    }
                    FileStream fileStream =
                        new FileStream(tmp, FileMode.OpenOrCreate);
                    var fileInfo = new FileInfo(tmp);
                    filepath = fileInfo.FullName;
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, list);
                    fileStream.Close();
                }
                else
                {
                    throw new Exception("Something went wrong during export, deleting created files...");
                }
            }
            else
            {
                throw new Exception("Something went wrong during export, deleting created files...");
            }

        }
        private List<T> DeserializeFileIntoList<T>(int k)
        {
            List<T> result = new List<T>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary file|*.bin";
            if (k == 0)
            {
                openFileDialog.Title = "Choose a file that contains STUDENTS";
                MessageBox.Show("Deserializing STUDENTS, please pick a file that contains students");
            }
            if (k == 1)
            {
                openFileDialog.Title = "Choose a file that contains SUBJECTS";
                MessageBox.Show("Deserializing SUBJECTS, please pick a file that contains subjects");
            }
            if (k == 2)
            {
               openFileDialog.Title = "Choose a file that contains FEES";
                MessageBox.Show("Deserializing FEES, please pick a file that contains fees");
            }
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    using (FileStream fileStream =
                        new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        result = formatter.Deserialize(fileStream) as List<T>;
                    }
                }
                else
                {
                    throw new Exception("No file selected, reverting changes");
                }
            }
            else
            {
                throw new Exception("No file selected, reverting changes");
            }
            return result;

        }
    }
}


  
