namespace bilisimprojesi2
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cariİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cariEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cariDüzenleSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cariListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapDefteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borçEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tahsilatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBorcEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cariİşlemleriToolStripMenuItem,
            this.hesapDefteriToolStripMenuItem,
            this.kapatToolStripMenuItem,
            this.kapatToolStripMenuItem1,
            this.kapatToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cariİşlemleriToolStripMenuItem
            // 
            this.cariİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cariEkleToolStripMenuItem,
            this.cariDüzenleSilToolStripMenuItem,
            this.cariListeleToolStripMenuItem});
            this.cariİşlemleriToolStripMenuItem.Image = global::bilisimprojesi2.Properties.Resources._1481140383_Accept_Male_User;
            this.cariİşlemleriToolStripMenuItem.Name = "cariİşlemleriToolStripMenuItem";
            this.cariİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.cariİşlemleriToolStripMenuItem.Text = "Cari İşlemleri";
            // 
            // cariEkleToolStripMenuItem
            // 
            this.cariEkleToolStripMenuItem.Name = "cariEkleToolStripMenuItem";
            this.cariEkleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cariEkleToolStripMenuItem.Text = "Cari Ekle";
            this.cariEkleToolStripMenuItem.Click += new System.EventHandler(this.cariEkleToolStripMenuItem_Click);
            // 
            // cariDüzenleSilToolStripMenuItem
            // 
            this.cariDüzenleSilToolStripMenuItem.Name = "cariDüzenleSilToolStripMenuItem";
            this.cariDüzenleSilToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cariDüzenleSilToolStripMenuItem.Text = "Cari Düzenle/Sil";
            this.cariDüzenleSilToolStripMenuItem.Click += new System.EventHandler(this.cariDüzenleSilToolStripMenuItem_Click);
            // 
            // cariListeleToolStripMenuItem
            // 
            this.cariListeleToolStripMenuItem.Name = "cariListeleToolStripMenuItem";
            this.cariListeleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cariListeleToolStripMenuItem.Text = "Cari Listele";
            this.cariListeleToolStripMenuItem.Click += new System.EventHandler(this.cariListeleToolStripMenuItem_Click);
            // 
            // hesapDefteriToolStripMenuItem
            // 
            this.hesapDefteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borçEkleToolStripMenuItem,
            this.tahsilatToolStripMenuItem});
            this.hesapDefteriToolStripMenuItem.Image = global::bilisimprojesi2.Properties.Resources._1481140421_reports;
            this.hesapDefteriToolStripMenuItem.Name = "hesapDefteriToolStripMenuItem";
            this.hesapDefteriToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.hesapDefteriToolStripMenuItem.Text = "Hesap Defteri";
            // 
            // borçEkleToolStripMenuItem
            // 
            this.borçEkleToolStripMenuItem.Name = "borçEkleToolStripMenuItem";
            this.borçEkleToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.borçEkleToolStripMenuItem.Text = "Borç Ekle";
            this.borçEkleToolStripMenuItem.Click += new System.EventHandler(this.borçEkleToolStripMenuItem_Click);
            // 
            // tahsilatToolStripMenuItem
            // 
            this.tahsilatToolStripMenuItem.Name = "tahsilatToolStripMenuItem";
            this.tahsilatToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.tahsilatToolStripMenuItem.Text = "Tahsilat";
            this.tahsilatToolStripMenuItem.Click += new System.EventHandler(this.tahsilatToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Image = global::bilisimprojesi2.Properties.Resources._1481140471_search_database;
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.kapatToolStripMenuItem.Text = "Raporlar";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem1
            // 
            this.kapatToolStripMenuItem1.Image = global::bilisimprojesi2.Properties.Resources._1481140545_wheel;
            this.kapatToolStripMenuItem1.Name = "kapatToolStripMenuItem1";
            this.kapatToolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.kapatToolStripMenuItem1.Text = "Ayarlar";
            this.kapatToolStripMenuItem1.Click += new System.EventHandler(this.kapatToolStripMenuItem1_Click);
            // 
            // kapatToolStripMenuItem2
            // 
            this.kapatToolStripMenuItem2.Image = global::bilisimprojesi2.Properties.Resources._1491916287_Close;
            this.kapatToolStripMenuItem2.Name = "kapatToolStripMenuItem2";
            this.kapatToolStripMenuItem2.Size = new System.Drawing.Size(65, 20);
            this.kapatToolStripMenuItem2.Text = "Kapat";
            this.kapatToolStripMenuItem2.Click += new System.EventHandler(this.kapatToolStripMenuItem2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(6, 34);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(695, 327);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Düzenle";
            this.Column1.Image = global::bilisimprojesi2.Properties.Resources._1492202528_circle_edit_article;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 367);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Son İşlemler";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(87)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnBorcEkle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 450);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(59, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Saat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(59, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Saat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tarih :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Saat :";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(143, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 329);
            this.panel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(117)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::bilisimprojesi2.Properties.Resources.musteri_ekle;
            this.button2.Location = new System.Drawing.Point(2, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cari Ekle";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(117)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::bilisimprojesi2.Properties.Resources.tahsilat;
            this.button1.Location = new System.Drawing.Point(2, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tahsilat (F2)";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorcEkle
            // 
            this.btnBorcEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnBorcEkle.FlatAppearance.BorderSize = 0;
            this.btnBorcEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(117)))));
            this.btnBorcEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorcEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBorcEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBorcEkle.Image = global::bilisimprojesi2.Properties.Resources.borc_ekle;
            this.btnBorcEkle.Location = new System.Drawing.Point(2, 68);
            this.btnBorcEkle.Name = "btnBorcEkle";
            this.btnBorcEkle.Size = new System.Drawing.Size(137, 45);
            this.btnBorcEkle.TabIndex = 1;
            this.btnBorcEkle.Text = "Borç Ekle (F1)";
            this.btnBorcEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorcEkle.UseVisualStyleBackColor = false;
            this.btnBorcEkle.Click += new System.EventHandler(this.btnBorcEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bilisimprojesi2.Properties.Resources.hizliislemler;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(146, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 447);
            this.panel3.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "Düzenle";
            this.dataGridViewImageColumn1.Image = global::bilisimprojesi2.Properties.Resources._1492202528_circle_edit_article;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 461;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 25F;
            this.dataGridViewImageColumn2.HeaderText = "Sil";
            this.dataGridViewImageColumn2.Image = global::bilisimprojesi2.Properties.Resources._1491916287_Close;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 231;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(868, 472);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " - Veresiye Defteri";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cariİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cariEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cariDüzenleSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cariListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapDefteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borçEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tahsilatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem2;
        private System.Windows.Forms.Button btnBorcEkle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}

