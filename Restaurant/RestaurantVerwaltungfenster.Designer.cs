namespace Restaurant
{
    partial class RestaurantVerwaltungfenster
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontoInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.persönlicheInfomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auslogenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvRechnung = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbTischWechseln = new System.Windows.Forms.ComboBox();
            this.btnTischWechseln = new System.Windows.Forms.Button();
            this.btnRabatt = new System.Windows.Forms.Button();
            this.btnZahlung = new System.Windows.Forms.Button();
            this.tbGesammterPreis = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudSpeisenAnzahl = new System.Windows.Forms.NumericUpDown();
            this.btnSpeisenHinzufuegen = new System.Windows.Forms.Button();
            this.cbSpeisen = new System.Windows.Forms.ComboBox();
            this.cbKatagorie = new System.Windows.Forms.ComboBox();
            this.flpTische = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nudRabatt = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeisenAnzahl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRabatt)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.kontoInformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1811, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(92, 34);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // kontoInformationToolStripMenuItem
            // 
            this.kontoInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.persönlicheInfomationToolStripMenuItem,
            this.auslogenToolStripMenuItem});
            this.kontoInformationToolStripMenuItem.Name = "kontoInformationToolStripMenuItem";
            this.kontoInformationToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.kontoInformationToolStripMenuItem.Text = "Konto Information";
            // 
            // persönlicheInfomationToolStripMenuItem
            // 
            this.persönlicheInfomationToolStripMenuItem.Name = "persönlicheInfomationToolStripMenuItem";
            this.persönlicheInfomationToolStripMenuItem.Size = new System.Drawing.Size(352, 40);
            this.persönlicheInfomationToolStripMenuItem.Text = "persönliche Information";
            this.persönlicheInfomationToolStripMenuItem.Click += new System.EventHandler(this.persönlicheInfomationToolStripMenuItem_Click);
            // 
            // auslogenToolStripMenuItem
            // 
            this.auslogenToolStripMenuItem.Name = "auslogenToolStripMenuItem";
            this.auslogenToolStripMenuItem.Size = new System.Drawing.Size(352, 40);
            this.auslogenToolStripMenuItem.Text = "Auslogen";
            this.auslogenToolStripMenuItem.Click += new System.EventHandler(this.auslogenToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvRechnung);
            this.panel2.Location = new System.Drawing.Point(929, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 913);
            this.panel2.TabIndex = 3;
            // 
            // lvRechnung
            // 
            this.lvRechnung.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvRechnung.GridLines = true;
            this.lvRechnung.HideSelection = false;
            this.lvRechnung.HoverSelection = true;
            this.lvRechnung.Location = new System.Drawing.Point(3, 3);
            this.lvRechnung.Name = "lvRechnung";
            this.lvRechnung.Size = new System.Drawing.Size(864, 904);
            this.lvRechnung.TabIndex = 0;
            this.lvRechnung.UseCompatibleStateImageBehavior = false;
            this.lvRechnung.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Speisen";
            this.columnHeader1.Width = 244;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Anzahl";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 234;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Preis";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 212;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "gesammter Preis";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 207;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nudRabatt);
            this.panel3.Controls.Add(this.cbTischWechseln);
            this.panel3.Controls.Add(this.btnTischWechseln);
            this.panel3.Controls.Add(this.btnRabatt);
            this.panel3.Controls.Add(this.btnZahlung);
            this.panel3.Controls.Add(this.tbGesammterPreis);
            this.panel3.Location = new System.Drawing.Point(929, 1082);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(870, 110);
            this.panel3.TabIndex = 4;
            // 
            // cbTischWechseln
            // 
            this.cbTischWechseln.FormattingEnabled = true;
            this.cbTischWechseln.Location = new System.Drawing.Point(58, 64);
            this.cbTischWechseln.Name = "cbTischWechseln";
            this.cbTischWechseln.Size = new System.Drawing.Size(135, 32);
            this.cbTischWechseln.TabIndex = 8;
            // 
            // btnTischWechseln
            // 
            this.btnTischWechseln.Location = new System.Drawing.Point(58, 14);
            this.btnTischWechseln.Name = "btnTischWechseln";
            this.btnTischWechseln.Size = new System.Drawing.Size(135, 42);
            this.btnTischWechseln.TabIndex = 6;
            this.btnTischWechseln.Text = "Wechseln";
            this.btnTischWechseln.UseVisualStyleBackColor = true;
            // 
            // btnRabatt
            // 
            this.btnRabatt.Location = new System.Drawing.Point(223, 14);
            this.btnRabatt.Name = "btnRabatt";
            this.btnRabatt.Size = new System.Drawing.Size(135, 42);
            this.btnRabatt.TabIndex = 5;
            this.btnRabatt.Text = "Rabatt";
            this.btnRabatt.UseVisualStyleBackColor = true;
            // 
            // btnZahlung
            // 
            this.btnZahlung.Location = new System.Drawing.Point(668, 14);
            this.btnZahlung.Name = "btnZahlung";
            this.btnZahlung.Size = new System.Drawing.Size(196, 82);
            this.btnZahlung.TabIndex = 4;
            this.btnZahlung.Text = "Zahlung";
            this.btnZahlung.UseVisualStyleBackColor = true;
            this.btnZahlung.Click += new System.EventHandler(this.btnZahlung_Click);
            // 
            // tbGesammterPreis
            // 
            this.tbGesammterPreis.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGesammterPreis.Location = new System.Drawing.Point(393, 20);
            this.tbGesammterPreis.Name = "tbGesammterPreis";
            this.tbGesammterPreis.ReadOnly = true;
            this.tbGesammterPreis.Size = new System.Drawing.Size(240, 56);
            this.tbGesammterPreis.TabIndex = 9;
            this.tbGesammterPreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nudSpeisenAnzahl);
            this.panel4.Controls.Add(this.btnSpeisenHinzufuegen);
            this.panel4.Controls.Add(this.cbSpeisen);
            this.panel4.Controls.Add(this.cbKatagorie);
            this.panel4.Location = new System.Drawing.Point(929, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(864, 113);
            this.panel4.TabIndex = 5;
            // 
            // nudSpeisenAnzahl
            // 
            this.nudSpeisenAnzahl.Location = new System.Drawing.Point(741, 44);
            this.nudSpeisenAnzahl.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudSpeisenAnzahl.Name = "nudSpeisenAnzahl";
            this.nudSpeisenAnzahl.Size = new System.Drawing.Size(106, 29);
            this.nudSpeisenAnzahl.TabIndex = 3;
            this.nudSpeisenAnzahl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSpeisenHinzufuegen
            // 
            this.btnSpeisenHinzufuegen.Location = new System.Drawing.Point(530, 17);
            this.btnSpeisenHinzufuegen.Name = "btnSpeisenHinzufuegen";
            this.btnSpeisenHinzufuegen.Size = new System.Drawing.Size(196, 82);
            this.btnSpeisenHinzufuegen.TabIndex = 2;
            this.btnSpeisenHinzufuegen.Text = "Speisen Hinzufügen";
            this.btnSpeisenHinzufuegen.UseVisualStyleBackColor = true;
            this.btnSpeisenHinzufuegen.Click += new System.EventHandler(this.btnSpeisenHinzufuegen_Click);
            // 
            // cbSpeisen
            // 
            this.cbSpeisen.FormattingEnabled = true;
            this.cbSpeisen.Location = new System.Drawing.Point(12, 67);
            this.cbSpeisen.Name = "cbSpeisen";
            this.cbSpeisen.Size = new System.Drawing.Size(501, 32);
            this.cbSpeisen.TabIndex = 1;
            // 
            // cbKatagorie
            // 
            this.cbKatagorie.FormattingEnabled = true;
            this.cbKatagorie.Location = new System.Drawing.Point(12, 17);
            this.cbKatagorie.Name = "cbKatagorie";
            this.cbKatagorie.Size = new System.Drawing.Size(501, 32);
            this.cbKatagorie.TabIndex = 0;
            this.cbKatagorie.SelectedIndexChanged += new System.EventHandler(this.cbKatagorie_SelectedIndexChanged);
            // 
            // flpTische
            // 
            this.flpTische.AutoScroll = true;
            this.flpTische.Location = new System.Drawing.Point(10, 50);
            this.flpTische.Name = "flpTische";
            this.flpTische.Size = new System.Drawing.Size(911, 1142);
            this.flpTische.TabIndex = 6;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // nudRabatt
            // 
            this.nudRabatt.Location = new System.Drawing.Point(223, 67);
            this.nudRabatt.Name = "nudRabatt";
            this.nudRabatt.Size = new System.Drawing.Size(135, 29);
            this.nudRabatt.TabIndex = 10;
            // 
            // RestaurantVerwaltungfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 1196);
            this.Controls.Add(this.flpTische);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RestaurantVerwaltungfenster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Verwaltung";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeisenAnzahl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRabatt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontoInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem persönlicheInfomationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auslogenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSpeisenHinzufuegen;
        private System.Windows.Forms.ComboBox cbSpeisen;
        private System.Windows.Forms.ComboBox cbKatagorie;
        private System.Windows.Forms.NumericUpDown nudSpeisenAnzahl;
        private System.Windows.Forms.Button btnRabatt;
        private System.Windows.Forms.Button btnZahlung;
        private System.Windows.Forms.FlowLayoutPanel flpTische;
        private System.Windows.Forms.ComboBox cbTischWechseln;
        private System.Windows.Forms.Button btnTischWechseln;
        private System.Windows.Forms.ListView lvRechnung;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbGesammterPreis;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.NumericUpDown nudRabatt;
    }
}