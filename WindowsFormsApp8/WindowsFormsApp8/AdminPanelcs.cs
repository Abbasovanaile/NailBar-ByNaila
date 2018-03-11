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
    public partial class AdminPanelcs : Form
    {
        public AdminPanelcs()
        {
            InitializeComponent();
        }
        public  int MasterCounter = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            master_del.Items.Clear();
            cmb1.Items.Clear();
            MasterCounter++;
            var name = master_add.Text;
            var masters = new Masters(MasterCounter, name);
            master_add.Text = "";
            cmb1.Text = " ";
           
                foreach (var masters1 in Masters.master_List)
                 {
                   
                    cmb1.Items.Add(masters1.Id + "-" + masters1.Name);
                    master_del.Items.Add(masters1.Id);

                 }



        }

        private void AdminPanelcs_Load(object sender, EventArgs e)
        {
            int[] days = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
           
            string[] hourses = new string[] { "12:00", "12:30", "13:00", "14:00", "14:20", "15:00", "16:00", };
           
            foreach (var item1 in days)
            {
                day_box.Items.Add(item1);
            }
            foreach (var item2 in months)
            {
                month_box.Items.Add(item2);
            }
            foreach (var item3 in hourses)
            {
                hours_box.Items.Add(item3);
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            var SelectedItem = cmb1.SelectedIndex;
            string Vaxt = month_box.Text + day_box.Text + hours_box.Text;
            foreach (var item in Masters.master_List)
            {
                if (SelectedItem == item.Id)
                {
                    
                }
            }
        }
    }
    public class Masters
    {
        public static List<Masters> master_List = new List<Masters>();
        public int Id;
        public string Name;
        public List<string> Date = new List<string>(); 
        public Masters(int _id, string _name)
        {
            Id = _id;
            Name = _name;
            master_List.Add(this);
        }
            
        
           
    }
   
    
}
