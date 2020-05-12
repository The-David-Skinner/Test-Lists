using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Lists
{
    public partial class Form1 : Form
    {

        // Lists<T>
        List<Names> NamesList = new List<Names>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            int[] values = { 10, 12, 14, 15, 17, 19, 20, 1, 9, 67 };
            int intCount = values.Where(x => x >= 12).Count();
            MessageBox.Show(values.Count().ToString()+","+ intCount.ToString());
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtName != null)
            {
                NamesAdd();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                NamesAdd();
            }
        }
        private void NamesAdd()
        {
            Names obj = new Names();
            obj.Name = txtName.Text;
            NamesList.Add(obj);
            lstBox.Items.Clear();
            foreach (Names lstObj in NamesList)
            {
                lstBox.Items.Add(lstObj.Name.ToString());
            }
            txtName.Text = "";
        }
    }
}
