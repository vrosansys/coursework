using System;
using System.Windows.Forms;
using SharedModels;

namespace coursework
{
    public partial class CompanyForm : Form
    {
        public Company Company
        {
            get;
            set;
        }

        public CompanyForm()
        {
            InitializeComponent();
            btAdd.Click += OnApplyClick;
            btCancel.Click += OnCancelClick;
        }

        private void OnCancelClick(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnApplyClick(object? sender, EventArgs e)
        {
            Company = new Company();
            Company.Name = textBox1.Text;
            Company.Budget = (int) numericUpDown1.Value;
            Company.EmployersNumber = (int) numericUpDown2.Value;
            Company.ProjectsNumber = (int) numericUpDown3.Value;
            
            DialogResult = DialogResult.OK;
            Close();
        }
        
    }
}