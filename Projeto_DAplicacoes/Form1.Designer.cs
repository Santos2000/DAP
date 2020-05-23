namespace Projeto_DAplicacoes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gerirClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gerirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gerirArranjosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gerirFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGray;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 449);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(892, 38);
			this.panel1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(45, 38);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.Color.LightGray;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(892, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirClientesToolStripMenuItem,
            this.gerirToolStripMenuItem,
            this.gerirArranjosToolStripMenuItem,
            this.gerirFornecedoresToolStripMenuItem,
            this.sairToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// gerirClientesToolStripMenuItem
			// 
			this.gerirClientesToolStripMenuItem.Name = "gerirClientesToolStripMenuItem";
			this.gerirClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.gerirClientesToolStripMenuItem.Text = "Gerir Clientes";
			this.gerirClientesToolStripMenuItem.Click += new System.EventHandler(this.gerirClientesToolStripMenuItem_Click);
			// 
			// gerirToolStripMenuItem
			// 
			this.gerirToolStripMenuItem.Name = "gerirToolStripMenuItem";
			this.gerirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.gerirToolStripMenuItem.Text = "Gerir Pedidos";
			this.gerirToolStripMenuItem.Click += new System.EventHandler(this.gerirToolStripMenuItem_Click);
			// 
			// gerirArranjosToolStripMenuItem
			// 
			this.gerirArranjosToolStripMenuItem.Name = "gerirArranjosToolStripMenuItem";
			this.gerirArranjosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.gerirArranjosToolStripMenuItem.Text = "Gerir Arranjos";
			// 
			// gerirFornecedoresToolStripMenuItem
			// 
			this.gerirFornecedoresToolStripMenuItem.Name = "gerirFornecedoresToolStripMenuItem";
			this.gerirFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.gerirFornecedoresToolStripMenuItem.Text = "Gerir Fornecedores";
			this.gerirFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.gerirFornecedoresToolStripMenuItem_Click);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(892, 487);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gerirClientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gerirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gerirArranjosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gerirFornecedoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
	}
}

