using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace BorrowIT
{
    public partial class BorrowIT : Form
    {
        int amountOfItems = 0;

        List<Item> Items;
        List<int> ListItemsIndex;

        public BorrowIT()
        {
            InitializeComponent();
            Items = new List<Item>();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            amountOfItems++;
            string item = itemName_txtb.Text;
            string who = who_txtb.Text;
            Item newItem = new Item(item, who);
            Items.Add(newItem);
            //items_list.Items.Add(item + " : " + who);

            RenderItems();
        }

        public void DeleteItemEvent(object sender,EventArgs e)
        {
            
        }

        public Panel MakeItem(string item, string who)
        {
            //New Panel
            Panel p = new Panel();
            p.Width = 377;
            p.Height = 60;
            p.Top = amountOfItems * 60;
            p.Left = 13;
            //Items In Panel
            TextBox ItemName = new TextBox();
            TextBox Who_txtb = new TextBox();
            Button Delete_btn = new Button();
            //Add Items to Panel
            p.Controls.Add(ItemName);
            p.Controls.Add(Who_txtb);
            p.Controls.Add(Delete_btn);
            //Item Settings
            //ItemName
            ItemName.Multiline = true;
            ItemName.Width = 167;
            ItemName.Height = 39;
            ItemName.Text = item;
            ItemName.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            ItemName.TextAlign = HorizontalAlignment.Center;
            ItemName.ReadOnly = true;
            //WhoTxtb
            Who_txtb.Multiline = true;
            Who_txtb.Width = 138;
            Who_txtb.Height = 39;
            Who_txtb.Text = who;
            Who_txtb.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            Who_txtb.TextAlign = HorizontalAlignment.Center;
            Who_txtb.ReadOnly = true;
            //X_Btn
            Delete_btn.Width = 50;
            Delete_btn.Height = 39;
            Delete_btn.Text = "X";
            Delete_btn.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            Delete_btn.ForeColor = Color.Red;
            Delete_btn.Click += DeleteItemEvent();
            //Set Position In Panel
            ItemName.Location = new System.Drawing.Point(5, 4);
            Who_txtb.Location = new System.Drawing.Point(178, 4);
            Delete_btn.Location = new System.Drawing.Point(322, 4);

            return p;
        }

        public void RenderItems()
        {
            ListItemsIndex = new List<int>();

            for (int x = 0; x < Items.Count; x++)
            {
                Controls.Add(MakeItem(Items[x].GetItemName(), Items[x].GetWho()));
            }
        }
    }
}
