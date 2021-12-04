using System;
using System.Windows.Forms;

namespace FrequenceGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            CenterToScreen();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SettingForm sForm = new SettingForm();
            sForm.Show();
        }
    }
}