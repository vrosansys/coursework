using System;
using System.Drawing;
using System.Windows.Forms;
using SharedModels;

namespace coursework
{
    public partial class MainForm : Form
    {
        private BindingSource _bs;

        public MainForm()
        {
            InitializeComponent();

            AppData.CreateRandomData();

            _bs = new BindingSource {DataSource = AppData.Companies};
            dataGridView1.DataSource = _bs;
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            AppData.AddRandomData();
            _bs.ResetBindings(true);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var dialog = new CompanyForm {StartPosition = FormStartPosition.CenterParent};
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AppData.Add(dialog.Company);
                _bs.ResetBindings(true);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.SelectedRows[0].Index;
            if (index < 0)
                return;
            AppData.RemoveByIndex(index);
            _bs.ResetBindings(true);
        }
    }
}
