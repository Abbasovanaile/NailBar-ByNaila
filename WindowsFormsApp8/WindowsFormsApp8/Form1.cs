using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtbox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(user_box.Text=="admin" && pass_box.Text == "12345")
            {
                AdminPanelcs form = new AdminPanelcs();
                form.Show();
            }
            else
            {

            }

        }
    }
}
