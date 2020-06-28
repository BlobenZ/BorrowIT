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
using System.Security.Policy;
using System.IO;

namespace BorrowIT
{
    public partial class BorrowIT_Form : Form
    {
        public System.Drawing.Point mouseLocation;

        List<Item> Items;
        List<Button> ItemsDeletedButtons;

        string AppDataPath;
        string DataDirPath;
        string DataFilePath;

        //Main Init
        public BorrowIT_Form()
        {
            InitializeComponent();
            Items = new List<Item>();
            AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            DataFilePath = AppDataPath + "\\BenZoft\\BorrowIT\\ItemData.txt";
            DataDirPath = AppDataPath + "\\BenZoft\\BorrowIT";

            // Title Bar
            minimize_btn.FlatAppearance.BorderSize = 0;
            minimize_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90, 90);
            exit_btn.FlatAppearance.BorderSize = 0;
            exit_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 153, 0, 0);
        }

        //Add Item
        private void add_btn_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        public void AddItem()
        {
            string item = itemName_txtb.Text;
            string who = who_txtb.Text;
            Item newItem = new Item(item, who);
            Items.Add(newItem);

            itemName_txtb.Text = "";
            who_txtb.Text = "";

            RenderItems();
        }

        //Add / Delete Items
        private void DeleteItemEvent(object sender,EventArgs e)
        {
            Button b = sender as Button;
            for (int i = 0; i < ItemsDeletedButtons.Count; i++)
            {
                if (b == ItemsDeletedButtons[i])
                {
                    ItemsDeletedButtons.RemoveAt(i);
                    Items.RemoveAt(i);
                    RenderItems();
                    break;
                }
            }
        }

        public Panel MakeItem(string item, string who, int positon)
        {
            //New Panel
            Panel p = new Panel();
            p.Width = 470;
            p.Height = 42;
            p.Top = positon * 42;
            p.Left = 16;
            //Items In Panel
            Label ItemName = new Label();
            Label Who_txtb = new Label();
            Button Delete_btn = new Button();
            ItemsDeletedButtons.Add(Delete_btn);
            //Add Items to Panel
            p.Controls.Add(ItemName);
            p.Controls.Add(Who_txtb);
            p.Controls.Add(Delete_btn);
            //Item Settings
            //ItemName
            ItemName.Width = 200;
            ItemName.Height = 30;
            ItemName.Text = item;
            ItemName.Font = new Font("Lucida Sans Unicode", 16, FontStyle.Bold);
            ItemName.TextAlign = ContentAlignment.MiddleCenter;
            ItemName.BorderStyle = BorderStyle.FixedSingle;
            ItemName.BackColor = Color.FromArgb(50, 50, 50);
            ItemName.ForeColor = Color.FromArgb(190, 190, 190);
            //WhoTxtb
            Who_txtb.Width = 200;
            Who_txtb.Height = 30;
            Who_txtb.Text = who;
            Who_txtb.Font = new Font("Lucida Sans Unicode", 16, FontStyle.Bold);
            Who_txtb.TextAlign = ContentAlignment.MiddleCenter;
            Who_txtb.BorderStyle = BorderStyle.FixedSingle;
            Who_txtb.BackColor = Color.FromArgb(50, 50, 50);
            Who_txtb.ForeColor = Color.FromArgb(190, 190, 190);
            //X_Btn
            Delete_btn.Width = 50;
            Delete_btn.Height = 30;
            Delete_btn.Text = "X";
            Delete_btn.Font = new Font("Lucida Sans Unicode", 14, FontStyle.Bold);
            Delete_btn.ForeColor = Color.Red;
            Delete_btn.Click += new EventHandler(DeleteItemEvent);
            Delete_btn.FlatStyle = FlatStyle.Flat;
            Delete_btn.FlatAppearance.BorderSize = 0;
            Delete_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 40, 40, 40);
            Delete_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 10, 10, 10);
            //Set Position In Panel
            ItemName.Location = new System.Drawing.Point(0, 4);
            Who_txtb.Location = new System.Drawing.Point(205, 4);
            Delete_btn.Location = new System.Drawing.Point(410, 4);

            return p;
        }

        public void RenderItems()
        {
            itemsPanel.Controls.Clear();
            ItemsDeletedButtons = new List<Button>();

            for (int x = 0; x < Items.Count; x++)
            {
                itemsPanel.Controls.Add(MakeItem(Items[x].GetItemName(), Items[x].GetWho(), x));
            }
        }

        //Title bar
        private void titleBar_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new System.Drawing.Point(-e.X, -e.Y);
        }

        private void titleBar_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                System.Drawing.Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Enter Add
        private void who_txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                AddItem();
                ActiveControl = null;
            }
        }

        private void itemName_txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                AddItem();
                ActiveControl = null;
            }
        }

        //Save / Load
        private void BorrowIT_Form_Load(object sender, EventArgs e)
        {
            if(File.Exists(DataFilePath))
            {
                string[] lines = File.ReadAllLines(DataFilePath);
                if (lines != null)
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        Item item = new Item(lines[i], lines[i + 1]);
                        Items.Add(item);
                        i++;
                    }
                    RenderItems();
                }
            }
        }

        private void BorrowIT_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!Directory.Exists(DataDirPath))
            {
                Directory.CreateDirectory(DataDirPath);
            }

            TextWriter tw = new StreamWriter(DataFilePath);
            foreach (Item item in Items)
            {
                //var Line = item.GetItemName + ":" + item.GetWho;
                tw.WriteLine(item.GetItemName());
                tw.WriteLine(item.GetWho());
            }
            tw.Close();
        }
    }
}
