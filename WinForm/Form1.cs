using System.Windows.Forms;
using SharedModels;

namespace coursework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AppData.CreateRandomData();
            dataGridView1.DataSource = AppData.Companies;
        }
        
    }
}