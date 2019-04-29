namespace Katmanli.Win.UI
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
            this.tanımlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eğitimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unvanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ılToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ılçeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanGrubuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlarToolStripMenuItem,
            this.personelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımlarToolStripMenuItem
            // 
            this.tanımlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eğitimToolStripMenuItem,
            this.unvanToolStripMenuItem,
            this.ılToolStripMenuItem,
            this.ılçeToolStripMenuItem,
            this.kanGrubuToolStripMenuItem});
            this.tanımlarToolStripMenuItem.Name = "tanımlarToolStripMenuItem";
            this.tanımlarToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.tanımlarToolStripMenuItem.Text = "Tanımlar";
            // 
            // eğitimToolStripMenuItem
            // 
            this.eğitimToolStripMenuItem.Name = "eğitimToolStripMenuItem";
            this.eğitimToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eğitimToolStripMenuItem.Text = "Eğitim";
            this.eğitimToolStripMenuItem.Click += new System.EventHandler(this.eğitimToolStripMenuItem_Click);
            // 
            // unvanToolStripMenuItem
            // 
            this.unvanToolStripMenuItem.Name = "unvanToolStripMenuItem";
            this.unvanToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.unvanToolStripMenuItem.Text = "Unvan";
            // 
            // ılToolStripMenuItem
            // 
            this.ılToolStripMenuItem.Name = "ılToolStripMenuItem";
            this.ılToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ılToolStripMenuItem.Text = "Il";
            // 
            // ılçeToolStripMenuItem
            // 
            this.ılçeToolStripMenuItem.Name = "ılçeToolStripMenuItem";
            this.ılçeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ılçeToolStripMenuItem.Text = "Ilçe";
            // 
            // kanGrubuToolStripMenuItem
            // 
            this.kanGrubuToolStripMenuItem.Name = "kanGrubuToolStripMenuItem";
            this.kanGrubuToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.kanGrubuToolStripMenuItem.Text = "KanGrubu";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelİşlemleriToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.personelToolStripMenuItem.Text = "Personel ";
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eğitimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unvanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ılToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ılçeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanGrubuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
    }
}

