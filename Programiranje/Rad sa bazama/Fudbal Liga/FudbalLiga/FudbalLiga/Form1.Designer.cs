namespace FudbalLiga
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
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spisakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izadjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosIgracaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosMecevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poPozicijamaITimovimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mecevaPoTimovimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.spisakToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(357, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosIgracaToolStripMenuItem,
            this.unosMecevaToolStripMenuItem});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.unosToolStripMenuItem.Text = "Unos";
            // 
            // spisakToolStripMenuItem
            // 
            this.spisakToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poPozicijamaITimovimaToolStripMenuItem,
            this.mecevaPoTimovimaToolStripMenuItem});
            this.spisakToolStripMenuItem.Name = "spisakToolStripMenuItem";
            this.spisakToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.spisakToolStripMenuItem.Text = "Spisak";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izadjiToolStripMenuItem});
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            // 
            // izadjiToolStripMenuItem
            // 
            this.izadjiToolStripMenuItem.Name = "izadjiToolStripMenuItem";
            this.izadjiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.izadjiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izadjiToolStripMenuItem.Text = "Izadji";
            this.izadjiToolStripMenuItem.Click += new System.EventHandler(this.izadjiToolStripMenuItem_Click);
            // 
            // unosIgracaToolStripMenuItem
            // 
            this.unosIgracaToolStripMenuItem.Name = "unosIgracaToolStripMenuItem";
            this.unosIgracaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unosIgracaToolStripMenuItem.Text = "Unos igraca";
            // 
            // unosMecevaToolStripMenuItem
            // 
            this.unosMecevaToolStripMenuItem.Name = "unosMecevaToolStripMenuItem";
            this.unosMecevaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unosMecevaToolStripMenuItem.Text = "Unos meceva";
            this.unosMecevaToolStripMenuItem.Click += new System.EventHandler(this.unosMecevaToolStripMenuItem_Click);
            // 
            // poPozicijamaITimovimaToolStripMenuItem
            // 
            this.poPozicijamaITimovimaToolStripMenuItem.Name = "poPozicijamaITimovimaToolStripMenuItem";
            this.poPozicijamaITimovimaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.poPozicijamaITimovimaToolStripMenuItem.Text = "Po pozicijama i timovima";
            // 
            // mecevaPoTimovimaToolStripMenuItem
            // 
            this.mecevaPoTimovimaToolStripMenuItem.Name = "mecevaPoTimovimaToolStripMenuItem";
            this.mecevaPoTimovimaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.mecevaPoTimovimaToolStripMenuItem.Text = "Meceva po timovima";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 317);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spisakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izadjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosIgracaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosMecevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poPozicijamaITimovimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mecevaPoTimovimaToolStripMenuItem;
    }
}

