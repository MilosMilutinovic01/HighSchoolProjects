namespace Kolekcija_knjiga
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brojKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poKategorijamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poAutorimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajRadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unToolStripMenuItem,
            this.brojKnjigaToolStripMenuItem,
            this.krajRadaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unToolStripMenuItem
            // 
            this.unToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knjigeToolStripMenuItem,
            this.autoriToolStripMenuItem});
            this.unToolStripMenuItem.Name = "unToolStripMenuItem";
            this.unToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.unToolStripMenuItem.Text = "Unos";
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            this.knjigeToolStripMenuItem.Click += new System.EventHandler(this.knjigeToolStripMenuItem_Click);
            // 
            // autoriToolStripMenuItem
            // 
            this.autoriToolStripMenuItem.Name = "autoriToolStripMenuItem";
            this.autoriToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.autoriToolStripMenuItem.Text = "Autori";
            // 
            // brojKnjigaToolStripMenuItem
            // 
            this.brojKnjigaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poKategorijamaToolStripMenuItem,
            this.poAutorimaToolStripMenuItem});
            this.brojKnjigaToolStripMenuItem.Name = "brojKnjigaToolStripMenuItem";
            this.brojKnjigaToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.brojKnjigaToolStripMenuItem.Text = "Broj knjiga";
            // 
            // poKategorijamaToolStripMenuItem
            // 
            this.poKategorijamaToolStripMenuItem.Name = "poKategorijamaToolStripMenuItem";
            this.poKategorijamaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.poKategorijamaToolStripMenuItem.Text = "Po kategorijama";
            this.poKategorijamaToolStripMenuItem.Click += new System.EventHandler(this.poKategorijamaToolStripMenuItem_Click);
            // 
            // poAutorimaToolStripMenuItem
            // 
            this.poAutorimaToolStripMenuItem.Name = "poAutorimaToolStripMenuItem";
            this.poAutorimaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.poAutorimaToolStripMenuItem.Text = "Po autorima";
            // 
            // krajRadaToolStripMenuItem
            // 
            this.krajRadaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.krajRadaToolStripMenuItem.Name = "krajRadaToolStripMenuItem";
            this.krajRadaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.krajRadaToolStripMenuItem.Text = "Kraj rada";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 386);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brojKnjigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poKategorijamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poAutorimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajRadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;

    }
}

