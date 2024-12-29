namespace spooferzao
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.SidePanel = new Guna.UI.WinForms.GunaPanel();
            this.ValorantButton = new Guna.UI.WinForms.GunaButton();
            this.csgoButton = new Guna.UI.WinForms.GunaButton();
            this.FivemButton = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Fechar = new Guna.UI.WinForms.GunaButton();
            this.valorant1 = new spooferzao.valorant();
            this.csgo2201 = new spooferzao.csgo220();
            this.fivem2201 = new spooferzao.fivem220();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.gunaPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel2.Controls.Add(this.SidePanel);
            this.gunaPanel2.Controls.Add(this.ValorantButton);
            this.gunaPanel2.Controls.Add(this.csgoButton);
            this.gunaPanel2.Controls.Add(this.FivemButton);
            this.gunaPanel2.Location = new System.Drawing.Point(0, -5);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(74, 456);
            this.gunaPanel2.TabIndex = 20;
            this.gunaPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaPanel2_MouseDown);
            this.gunaPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gunaPanel2_MouseMove);
            this.gunaPanel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gunaPanel2_MouseUp);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(194)))));
            this.SidePanel.Location = new System.Drawing.Point(-2, 61);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(5, 72);
            this.SidePanel.TabIndex = 22;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // ValorantButton
            // 
            this.ValorantButton.AnimationHoverSpeed = 0.07F;
            this.ValorantButton.AnimationSpeed = 0.03F;
            this.ValorantButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ValorantButton.BorderColor = System.Drawing.Color.Black;
            this.ValorantButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ValorantButton.FocusedColor = System.Drawing.Color.Empty;
            this.ValorantButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ValorantButton.ForeColor = System.Drawing.Color.White;
            this.ValorantButton.Image = ((System.Drawing.Image)(resources.GetObject("ValorantButton.Image")));
            this.ValorantButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ValorantButton.ImageSize = new System.Drawing.Size(60, 60);
            this.ValorantButton.Location = new System.Drawing.Point(-1, 203);
            this.ValorantButton.Name = "ValorantButton";
            this.ValorantButton.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.ValorantButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ValorantButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ValorantButton.OnHoverImage = null;
            this.ValorantButton.OnPressedColor = System.Drawing.Color.Black;
            this.ValorantButton.Size = new System.Drawing.Size(72, 71);
            this.ValorantButton.TabIndex = 2;
            this.ValorantButton.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // csgoButton
            // 
            this.csgoButton.AnimationHoverSpeed = 0.07F;
            this.csgoButton.AnimationSpeed = 0.03F;
            this.csgoButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.csgoButton.BorderColor = System.Drawing.Color.Black;
            this.csgoButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.csgoButton.FocusedColor = System.Drawing.Color.Empty;
            this.csgoButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.csgoButton.ForeColor = System.Drawing.Color.White;
            this.csgoButton.Image = global::spooferzao.Properties.Resources.Inserir_um_título__16_;
            this.csgoButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.csgoButton.ImageSize = new System.Drawing.Size(50, 50);
            this.csgoButton.Location = new System.Drawing.Point(0, 132);
            this.csgoButton.Name = "csgoButton";
            this.csgoButton.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.csgoButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.csgoButton.OnHoverForeColor = System.Drawing.Color.White;
            this.csgoButton.OnHoverImage = null;
            this.csgoButton.OnPressedColor = System.Drawing.Color.Black;
            this.csgoButton.Size = new System.Drawing.Size(72, 71);
            this.csgoButton.TabIndex = 1;
            this.csgoButton.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // FivemButton
            // 
            this.FivemButton.AnimationHoverSpeed = 0.07F;
            this.FivemButton.AnimationSpeed = 0.03F;
            this.FivemButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.FivemButton.BorderColor = System.Drawing.Color.Black;
            this.FivemButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FivemButton.FocusedColor = System.Drawing.Color.Empty;
            this.FivemButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FivemButton.ForeColor = System.Drawing.Color.White;
            this.FivemButton.Image = global::spooferzao.Properties.Resources.Design_sem_nome__1_;
            this.FivemButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FivemButton.ImageSize = new System.Drawing.Size(50, 50);
            this.FivemButton.Location = new System.Drawing.Point(0, 61);
            this.FivemButton.Name = "FivemButton";
            this.FivemButton.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.FivemButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.FivemButton.OnHoverForeColor = System.Drawing.Color.White;
            this.FivemButton.OnHoverImage = null;
            this.FivemButton.OnPressedColor = System.Drawing.Color.Black;
            this.FivemButton.Size = new System.Drawing.Size(72, 71);
            this.FivemButton.TabIndex = 0;
            this.FivemButton.Click += new System.EventHandler(this.gunaButton1_Click_1);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.gunaPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.Fechar);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(503, 57);
            this.gunaPanel1.TabIndex = 21;
            this.gunaPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaPanel1_MouseDown);
            this.gunaPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gunaPanel1_MouseMove);
            this.gunaPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gunaPanel1_MouseUp);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.gunaLabel1.Location = new System.Drawing.Point(80, 4);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(343, 48);
            this.gunaLabel1.TabIndex = 20;
            this.gunaLabel1.Text = "HYDRA SPOOFER";
            this.gunaLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaLabel1_MouseDown);
            this.gunaLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gunaLabel1_MouseMove);
            this.gunaLabel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gunaLabel1_MouseUp);
            // 
            // Fechar
            // 
            this.Fechar.AnimationHoverSpeed = 0.07F;
            this.Fechar.AnimationSpeed = 0.03F;
            this.Fechar.BackgroundImage = global::spooferzao.Properties.Resources.Inserir_um_título__6_;
            this.Fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fechar.BaseColor = System.Drawing.Color.Transparent;
            this.Fechar.BorderColor = System.Drawing.Color.Black;
            this.Fechar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Fechar.FocusedColor = System.Drawing.Color.Empty;
            this.Fechar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Fechar.ForeColor = System.Drawing.Color.White;
            this.Fechar.Image = null;
            this.Fechar.ImageSize = new System.Drawing.Size(20, 20);
            this.Fechar.Location = new System.Drawing.Point(467, 20);
            this.Fechar.Name = "Fechar";
            this.Fechar.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Fechar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Fechar.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.Fechar.OnHoverImage = null;
            this.Fechar.OnPressedColor = System.Drawing.Color.Transparent;
            this.Fechar.Size = new System.Drawing.Size(16, 15);
            this.Fechar.TabIndex = 19;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click_2);
            // 
            // valorant1
            // 
            this.valorant1.Location = new System.Drawing.Point(75, 57);
            this.valorant1.Name = "valorant1";
            this.valorant1.Size = new System.Drawing.Size(428, 402);
            this.valorant1.TabIndex = 24;
            // 
            // csgo2201
            // 
            this.csgo2201.Location = new System.Drawing.Point(75, 57);
            this.csgo2201.Name = "csgo2201";
            this.csgo2201.Size = new System.Drawing.Size(428, 402);
            this.csgo2201.TabIndex = 23;
            // 
            // fivem2201
            // 
            this.fivem2201.Location = new System.Drawing.Point(75, 57);
            this.fivem2201.Name = "fivem2201";
            this.fivem2201.Size = new System.Drawing.Size(428, 402);
            this.fivem2201.TabIndex = 22;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.valorant1);
            this.Controls.Add(this.csgo2201);
            this.Controls.Add(this.fivem2201);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaButton FivemButton;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton Fechar;
        private Guna.UI.WinForms.GunaButton csgoButton;
        private Guna.UI.WinForms.GunaButton ValorantButton;
        private Guna.UI.WinForms.GunaPanel SidePanel;
        private fivem220 fivem2201;
        private csgo220 csgo2201;
        private valorant valorant1;
    }
}