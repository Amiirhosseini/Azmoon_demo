using System;
using System.Windows.Forms;

namespace azmoun
{
    public partial class Form_Login : Form
    {

        public Form_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formAdmin = new Form_main_Admin();
            formAdmin.Closed += (s, args) => this.Show();
            formAdmin.Show();
        }

        private void loginFrom_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString(new System.Globalization.CultureInfo("Fa-ir")).ToString();
            var newSplit = date.Split(' ');
            label_time.Text = newSplit[1];
            label_date.Text = newSplit[0];
        }

        
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sender == timer1)
            {
                string date = DateTime.Now.ToString(new System.Globalization.CultureInfo("Fa-ir")).ToString();
                var newSplit = date.Split(' ');
                label_time.Text = newSplit[1];
                label_date.Text = newSplit[0];
            }
        }
    }
}
