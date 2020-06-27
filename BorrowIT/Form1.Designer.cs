namespace BorrowIT
{
    partial class BorrowIT
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
            this.itemName_txtb = new System.Windows.Forms.TextBox();
            this.who_txtb = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // itemName_txtb
            // 
            this.itemName_txtb.Location = new System.Drawing.Point(13, 31);
            this.itemName_txtb.Name = "itemName_txtb";
            this.itemName_txtb.Size = new System.Drawing.Size(139, 20);
            this.itemName_txtb.TabIndex = 0;
            // 
            // who_txtb
            // 
            this.who_txtb.Location = new System.Drawing.Point(159, 31);
            this.who_txtb.Name = "who_txtb";
            this.who_txtb.Size = new System.Drawing.Size(131, 20);
            this.who_txtb.TabIndex = 1;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(297, 31);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(93, 23);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Who";
            // 
            // itemsPanel
            // 
            this.itemsPanel.Location = new System.Drawing.Point(0, 60);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Size = new System.Drawing.Size(404, 500);
            this.itemsPanel.TabIndex = 5;
            // 
            // BorrowIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 557);
            this.Controls.Add(this.itemsPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.who_txtb);
            this.Controls.Add(this.itemName_txtb);
            this.Name = "BorrowIT";
            this.Text = "BorrowIT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemName_txtb;
        private System.Windows.Forms.TextBox who_txtb;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel itemsPanel;
    }
}

