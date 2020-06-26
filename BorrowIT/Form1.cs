using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowIT
{
    public partial class BorrowIT : Form
    {
        public BorrowIT()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string item = itemName_txtb.Text;
            string who = who_txtb.Text;
            Item newItem = new Item(item, who);
            items_list.Items.Add(item + " : " + who);
        }
    }
}
