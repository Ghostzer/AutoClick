namespace AutoClick
{
    partial class F_MAIN
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_MAIN));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_x = new System.Windows.Forms.Label();
            this.Lbl_y = new System.Windows.Forms.Label();
            this.Txt_x = new System.Windows.Forms.TextBox();
            this.Txt_y = new System.Windows.Forms.TextBox();
            this.Btn_getPosition = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Lbl_nbClick = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(363, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fichierToolStripMenuItem.Text = "File";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Exit";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(75)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.Lbl_x);
            this.panel1.Controls.Add(this.Lbl_y);
            this.panel1.Controls.Add(this.Txt_x);
            this.panel1.Controls.Add(this.Txt_y);
            this.panel1.Controls.Add(this.Btn_getPosition);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 142);
            this.panel1.TabIndex = 9;
            // 
            // Lbl_x
            // 
            this.Lbl_x.AutoSize = true;
            this.Lbl_x.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_x.ForeColor = System.Drawing.Color.White;
            this.Lbl_x.Location = new System.Drawing.Point(115, 90);
            this.Lbl_x.Name = "Lbl_x";
            this.Lbl_x.Size = new System.Drawing.Size(17, 17);
            this.Lbl_x.TabIndex = 13;
            this.Lbl_x.Text = "X";
            // 
            // Lbl_y
            // 
            this.Lbl_y.AutoSize = true;
            this.Lbl_y.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_y.ForeColor = System.Drawing.Color.White;
            this.Lbl_y.Location = new System.Drawing.Point(115, 62);
            this.Lbl_y.Name = "Lbl_y";
            this.Lbl_y.Size = new System.Drawing.Size(17, 17);
            this.Lbl_y.TabIndex = 12;
            this.Lbl_y.Text = "Y";
            // 
            // Txt_x
            // 
            this.Txt_x.Location = new System.Drawing.Point(138, 89);
            this.Txt_x.Name = "Txt_x";
            this.Txt_x.Size = new System.Drawing.Size(85, 20);
            this.Txt_x.TabIndex = 11;
            // 
            // Txt_y
            // 
            this.Txt_y.BackColor = System.Drawing.Color.White;
            this.Txt_y.Location = new System.Drawing.Point(138, 61);
            this.Txt_y.Name = "Txt_y";
            this.Txt_y.Size = new System.Drawing.Size(85, 20);
            this.Txt_y.TabIndex = 10;
            // 
            // Btn_getPosition
            // 
            this.Btn_getPosition.BackColor = System.Drawing.Color.White;
            this.Btn_getPosition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_getPosition.Location = new System.Drawing.Point(138, 16);
            this.Btn_getPosition.Name = "Btn_getPosition";
            this.Btn_getPosition.Size = new System.Drawing.Size(85, 34);
            this.Btn_getPosition.TabIndex = 9;
            this.Btn_getPosition.Text = "Get Position";
            this.Btn_getPosition.UseVisualStyleBackColor = false;
            this.Btn_getPosition.Click += new System.EventHandler(this.Btn_getPosition_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Lbl_nbClick);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 138);
            this.panel2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(134, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_nbClick
            // 
            this.Lbl_nbClick.AutoSize = true;
            this.Lbl_nbClick.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_nbClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nbClick.Location = new System.Drawing.Point(173, 52);
            this.Lbl_nbClick.Name = "Lbl_nbClick";
            this.Lbl_nbClick.Size = new System.Drawing.Size(16, 17);
            this.Lbl_nbClick.TabIndex = 6;
            this.Lbl_nbClick.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(19, 22);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(325, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // F_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 304);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoClick";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_x;
        private System.Windows.Forms.Label Lbl_y;
        private System.Windows.Forms.TextBox Txt_x;
        private System.Windows.Forms.TextBox Txt_y;
        private System.Windows.Forms.Button Btn_getPosition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_nbClick;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
    }
}

