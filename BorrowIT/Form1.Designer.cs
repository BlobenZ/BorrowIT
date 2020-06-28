namespace BorrowIT
{
    partial class BorrowIT_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowIT_Form));
            this.itemName_txtb = new System.Windows.Forms.TextBox();
            this.who_txtb = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemsPanel = new System.Windows.Forms.Panel();
            this.titleBar_Panel = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleBar_Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemName_txtb
            // 
            this.itemName_txtb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.itemName_txtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemName_txtb.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName_txtb.Location = new System.Drawing.Point(106, 24);
            this.itemName_txtb.Multiline = true;
            this.itemName_txtb.Name = "itemName_txtb";
            this.itemName_txtb.Size = new System.Drawing.Size(139, 20);
            this.itemName_txtb.TabIndex = 0;
            this.itemName_txtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemName_txtb_KeyPress);
            // 
            // who_txtb
            // 
            this.who_txtb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.who_txtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.who_txtb.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.who_txtb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.who_txtb.Location = new System.Drawing.Point(252, 24);
            this.who_txtb.Multiline = true;
            this.who_txtb.Name = "who_txtb";
            this.who_txtb.Size = new System.Drawing.Size(131, 20);
            this.who_txtb.TabIndex = 1;
            this.who_txtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.who_txtb_KeyPress);
            // 
            // add_btn
            // 
            this.add_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_btn.Location = new System.Drawing.Point(390, 19);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(93, 24);
            this.add_btn.TabIndex = 2;
            this.add_btn.TabStop = false;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(138, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(298, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Who";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemsPanel
            // 
            this.itemsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsPanel.AutoScroll = true;
            this.itemsPanel.Location = new System.Drawing.Point(0, 106);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Size = new System.Drawing.Size(503, 487);
            this.itemsPanel.TabIndex = 5;
            // 
            // titleBar_Panel
            // 
            this.titleBar_Panel.BackColor = System.Drawing.Color.SlateGray;
            this.titleBar_Panel.Controls.Add(this.pictureBox1);
            this.titleBar_Panel.Controls.Add(this.label3);
            this.titleBar_Panel.Controls.Add(this.minimize_btn);
            this.titleBar_Panel.Controls.Add(this.exit_btn);
            this.titleBar_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar_Panel.Location = new System.Drawing.Point(0, 0);
            this.titleBar_Panel.Name = "titleBar_Panel";
            this.titleBar_Panel.Size = new System.Drawing.Size(503, 41);
            this.titleBar_Panel.TabIndex = 6;
            this.titleBar_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_Panel_MouseDown);
            this.titleBar_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_Panel_MouseMove);
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.minimize_btn.Location = new System.Drawing.Point(423, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(40, 41);
            this.minimize_btn.TabIndex = 1;
            this.minimize_btn.TabStop = false;
            this.minimize_btn.Text = "-";
            this.minimize_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_btn.Location = new System.Drawing.Point(463, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(40, 41);
            this.exit_btn.TabIndex = 0;
            this.exit_btn.TabStop = false;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(36, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "BORROW IT";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label4.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 60);
            this.label4.TabIndex = 7;
            this.label4.Text = "New";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.itemName_txtb);
            this.panel1.Controls.Add(this.who_txtb);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 60);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 5);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BorrowIT.Properties.Resources.BorrowIT_Icon;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BorrowIT_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(503, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleBar_Panel);
            this.Controls.Add(this.itemsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BorrowIT_Form";
            this.Text = "BorrowIT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BorrowIT_Form_FormClosing);
            this.Load += new System.EventHandler(this.BorrowIT_Form_Load);
            this.titleBar_Panel.ResumeLayout(false);
            this.titleBar_Panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox itemName_txtb;
        private System.Windows.Forms.TextBox who_txtb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel itemsPanel;
        private System.Windows.Forms.Panel titleBar_Panel;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

