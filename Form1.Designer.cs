namespace Dll___Fixer___2017
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Timer_Principal = new System.Windows.Forms.Timer(this.components);
            this.clsNeoBuxTheme1 = new CS_ClassLibraryTester.clsNeoBuxTheme();
            this.clsButtonBlue1 = new CS_ClassLibraryTester.clsButtonBlue();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Status = new iTalk.iTalk_Label();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.clsNeoBuxTheme1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_Principal
            // 
            this.Timer_Principal.Tick += new System.EventHandler(this.Timer_Principal_Tick);
            // 
            // clsNeoBuxTheme1
            // 
            this.clsNeoBuxTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.clsNeoBuxTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.clsNeoBuxTheme1.Controls.Add(this.clsButtonBlue1);
            this.clsNeoBuxTheme1.Controls.Add(this.pictureBox1);
            this.clsNeoBuxTheme1.Controls.Add(this.lb_Status);
            this.clsNeoBuxTheme1.Controls.Add(this.iTalk_Label1);
            this.clsNeoBuxTheme1.Customization = "AAAA/w==";
            this.clsNeoBuxTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clsNeoBuxTheme1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clsNeoBuxTheme1.Image = null;
            this.clsNeoBuxTheme1.Location = new System.Drawing.Point(0, 0);
            this.clsNeoBuxTheme1.Movable = true;
            this.clsNeoBuxTheme1.Name = "clsNeoBuxTheme1";
            this.clsNeoBuxTheme1.NoRounding = false;
            this.clsNeoBuxTheme1.Sizable = true;
            this.clsNeoBuxTheme1.Size = new System.Drawing.Size(447, 251);
            this.clsNeoBuxTheme1.SmartBounds = true;
            this.clsNeoBuxTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.clsNeoBuxTheme1.TabIndex = 0;
            this.clsNeoBuxTheme1.Text = "clsNeoBuxTheme1";
            this.clsNeoBuxTheme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.clsNeoBuxTheme1.Transparent = false;
            // 
            // clsButtonBlue1
            // 
            this.clsButtonBlue1.Customization = "9fX1/6mpqf8=";
            this.clsButtonBlue1.Font = new System.Drawing.Font("Verdana", 8F);
            this.clsButtonBlue1.Image = null;
            this.clsButtonBlue1.Location = new System.Drawing.Point(413, 5);
            this.clsButtonBlue1.Name = "clsButtonBlue1";
            this.clsButtonBlue1.NoRounding = false;
            this.clsButtonBlue1.Size = new System.Drawing.Size(31, 23);
            this.clsButtonBlue1.TabIndex = 5;
            this.clsButtonBlue1.Text = "X";
            this.clsButtonBlue1.Transparent = false;
            this.clsButtonBlue1.Click += new System.EventHandler(this.clsButtonBlue1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Dll___Fixer___2017.Properties.Resources.eudigital_agencia_de_marketing_digital_dia_do_programador_piadas_nerds_sobre_a_vida_de_programador;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 190);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.BackColor = System.Drawing.Color.Transparent;
            this.lb_Status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lb_Status.Location = new System.Drawing.Point(55, 228);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(16, 21);
            this.lb_Status.TabIndex = 2;
            this.lb_Status.Text = "-";
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(3, 228);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(55, 21);
            this.iTalk_Label1.TabIndex = 1;
            this.iTalk_Label1.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(447, 251);
            this.Controls.Add(this.clsNeoBuxTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                  DLL - FIXER - GAMES - 2017 - v0.3 - by: Magal";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.clsNeoBuxTheme1.ResumeLayout(false);
            this.clsNeoBuxTheme1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.clsNeoBuxTheme clsNeoBuxTheme1;
        private iTalk.iTalk_Label lb_Status;
        private iTalk.iTalk_Label iTalk_Label1;
        private System.Windows.Forms.Timer Timer_Principal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CS_ClassLibraryTester.clsButtonBlue clsButtonBlue1;
    }
}

