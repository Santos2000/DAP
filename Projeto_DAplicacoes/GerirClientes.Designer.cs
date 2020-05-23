namespace Projeto_DAplicacoes
{
	partial class GerirClientes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirClientes));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gerirClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gerirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gerirArranjosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gerirFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.lboxClientes = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNomeClienteAdd = new System.Windows.Forms.TextBox();
			this.tbTelefoneClienteAdd = new System.Windows.Forms.TextBox();
			this.btAdicionarCliente = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbMoradaClienteAdd = new System.Windows.Forms.TextBox();
			this.tbNifClienteAdd = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbLocalidadeClienteAdd = new System.Windows.Forms.TextBox();
			this.tbCodPostalAdd = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.gpClientes = new System.Windows.Forms.GroupBox();
			this.btApagarCliente = new System.Windows.Forms.Button();
			this.btAtualizarCliente = new System.Windows.Forms.Button();
			this.tbLocalidadeClienteSelecionado = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tbCodPostalClienteSelecionado = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tbNifClienteSelecionado = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tbTelefoneClienteSelecionado = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tbMoradaClienteSelecionado = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tbNomeClienteSelecionado = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.menuStrip.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gpClientes.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.Color.LightGray;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(892, 24);
			this.menuStrip.TabIndex = 1;
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
			this.gerirClientesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.gerirClientesToolStripMenuItem.Text = "Gerir Clientes";
			this.gerirClientesToolStripMenuItem.Click += new System.EventHandler(this.gerirClientesToolStripMenuItem_Click);
			// 
			// gerirToolStripMenuItem
			// 
			this.gerirToolStripMenuItem.Name = "gerirToolStripMenuItem";
			this.gerirToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.gerirToolStripMenuItem.Text = "Gerir Pedidos";
			this.gerirToolStripMenuItem.Click += new System.EventHandler(this.gerirToolStripMenuItem_Click);
			// 
			// gerirArranjosToolStripMenuItem
			// 
			this.gerirArranjosToolStripMenuItem.Name = "gerirArranjosToolStripMenuItem";
			this.gerirArranjosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.gerirArranjosToolStripMenuItem.Text = "Gerir Arranjos";
			// 
			// gerirFornecedoresToolStripMenuItem
			// 
			this.gerirFornecedoresToolStripMenuItem.Name = "gerirFornecedoresToolStripMenuItem";
			this.gerirFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.gerirFornecedoresToolStripMenuItem.Text = "Gerir Fornecedores";
			this.gerirFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.gerirFornecedoresToolStripMenuItem_Click);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGray;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 449);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(892, 38);
			this.panel1.TabIndex = 2;
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
			// lboxClientes
			// 
			this.lboxClientes.FormattingEnabled = true;
			this.lboxClientes.Location = new System.Drawing.Point(12, 255);
			this.lboxClientes.Name = "lboxClientes";
			this.lboxClientes.Size = new System.Drawing.Size(297, 186);
			this.lboxClientes.TabIndex = 20;
			this.lboxClientes.SelectedIndexChanged += new System.EventHandler(this.lboxClientes_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbNomeClienteAdd);
			this.groupBox1.Controls.Add(this.tbTelefoneClienteAdd);
			this.groupBox1.Controls.Add(this.btAdicionarCliente);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tbMoradaClienteAdd);
			this.groupBox1.Controls.Add(this.tbNifClienteAdd);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tbLocalidadeClienteAdd);
			this.groupBox1.Controls.Add(this.tbCodPostalAdd);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(297, 221);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Novo Cliente";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Telefone Contacto:";
			// 
			// tbNomeClienteAdd
			// 
			this.tbNomeClienteAdd.Location = new System.Drawing.Point(50, 19);
			this.tbNomeClienteAdd.Name = "tbNomeClienteAdd";
			this.tbNomeClienteAdd.Size = new System.Drawing.Size(229, 20);
			this.tbNomeClienteAdd.TabIndex = 1;
			// 
			// tbTelefoneClienteAdd
			// 
			this.tbTelefoneClienteAdd.Location = new System.Drawing.Point(113, 149);
			this.tbTelefoneClienteAdd.MaxLength = 9;
			this.tbTelefoneClienteAdd.Name = "tbTelefoneClienteAdd";
			this.tbTelefoneClienteAdd.Size = new System.Drawing.Size(166, 20);
			this.tbTelefoneClienteAdd.TabIndex = 6;
			// 
			// btAdicionarCliente
			// 
			this.btAdicionarCliente.Location = new System.Drawing.Point(12, 184);
			this.btAdicionarCliente.Name = "btAdicionarCliente";
			this.btAdicionarCliente.Size = new System.Drawing.Size(267, 23);
			this.btAdicionarCliente.TabIndex = 7;
			this.btAdicionarCliente.Text = "Adicionar Cliente";
			this.btAdicionarCliente.UseVisualStyleBackColor = true;
			this.btAdicionarCliente.Click += new System.EventHandler(this.btAdicionarCliente_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Morada:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nome:";
			// 
			// tbMoradaClienteAdd
			// 
			this.tbMoradaClienteAdd.Location = new System.Drawing.Point(58, 45);
			this.tbMoradaClienteAdd.Name = "tbMoradaClienteAdd";
			this.tbMoradaClienteAdd.Size = new System.Drawing.Size(221, 20);
			this.tbMoradaClienteAdd.TabIndex = 2;
			// 
			// tbNifClienteAdd
			// 
			this.tbNifClienteAdd.Location = new System.Drawing.Point(37, 123);
			this.tbNifClienteAdd.MaxLength = 9;
			this.tbNifClienteAdd.Name = "tbNifClienteAdd";
			this.tbNifClienteAdd.Size = new System.Drawing.Size(241, 20);
			this.tbNifClienteAdd.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Localidade:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Nif:";
			// 
			// tbLocalidadeClienteAdd
			// 
			this.tbLocalidadeClienteAdd.Location = new System.Drawing.Point(77, 71);
			this.tbLocalidadeClienteAdd.Name = "tbLocalidadeClienteAdd";
			this.tbLocalidadeClienteAdd.Size = new System.Drawing.Size(202, 20);
			this.tbLocalidadeClienteAdd.TabIndex = 3;
			// 
			// tbCodPostalAdd
			// 
			this.tbCodPostalAdd.Location = new System.Drawing.Point(90, 97);
			this.tbCodPostalAdd.Name = "tbCodPostalAdd";
			this.tbCodPostalAdd.Size = new System.Drawing.Size(189, 20);
			this.tbCodPostalAdd.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Codigo Postal:";
			// 
			// gpClientes
			// 
			this.gpClientes.Controls.Add(this.btApagarCliente);
			this.gpClientes.Controls.Add(this.btAtualizarCliente);
			this.gpClientes.Controls.Add(this.tbLocalidadeClienteSelecionado);
			this.gpClientes.Controls.Add(this.label12);
			this.gpClientes.Controls.Add(this.tbCodPostalClienteSelecionado);
			this.gpClientes.Controls.Add(this.label11);
			this.gpClientes.Controls.Add(this.tbNifClienteSelecionado);
			this.gpClientes.Controls.Add(this.label10);
			this.gpClientes.Controls.Add(this.tbTelefoneClienteSelecionado);
			this.gpClientes.Controls.Add(this.label9);
			this.gpClientes.Controls.Add(this.tbMoradaClienteSelecionado);
			this.gpClientes.Controls.Add(this.label8);
			this.gpClientes.Controls.Add(this.tbNomeClienteSelecionado);
			this.gpClientes.Controls.Add(this.label7);
			this.gpClientes.Location = new System.Drawing.Point(330, 27);
			this.gpClientes.Name = "gpClientes";
			this.gpClientes.Size = new System.Drawing.Size(549, 414);
			this.gpClientes.TabIndex = 21;
			this.gpClientes.TabStop = false;
			this.gpClientes.Text = "Dados do Cliente";
			// 
			// btApagarCliente
			// 
			this.btApagarCliente.Location = new System.Drawing.Point(279, 323);
			this.btApagarCliente.Name = "btApagarCliente";
			this.btApagarCliente.Size = new System.Drawing.Size(135, 73);
			this.btApagarCliente.TabIndex = 15;
			this.btApagarCliente.Text = "Apagar Cliente";
			this.btApagarCliente.UseVisualStyleBackColor = true;
			this.btApagarCliente.Click += new System.EventHandler(this.btApagarCliente_Click);
			// 
			// btAtualizarCliente
			// 
			this.btAtualizarCliente.Location = new System.Drawing.Point(136, 323);
			this.btAtualizarCliente.Name = "btAtualizarCliente";
			this.btAtualizarCliente.Size = new System.Drawing.Size(137, 73);
			this.btAtualizarCliente.TabIndex = 14;
			this.btAtualizarCliente.Text = "Atualizar Cliente";
			this.btAtualizarCliente.UseVisualStyleBackColor = true;
			this.btAtualizarCliente.Click += new System.EventHandler(this.btAtualizarCliente_Click);
			// 
			// tbLocalidadeClienteSelecionado
			// 
			this.tbLocalidadeClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbLocalidadeClienteSelecionado.Location = new System.Drawing.Point(144, 113);
			this.tbLocalidadeClienteSelecionado.Name = "tbLocalidadeClienteSelecionado";
			this.tbLocalidadeClienteSelecionado.Size = new System.Drawing.Size(170, 26);
			this.tbLocalidadeClienteSelecionado.TabIndex = 10;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(15, 112);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(123, 25);
			this.label12.TabIndex = 11;
			this.label12.Text = "Localidade:";
			// 
			// tbCodPostalClienteSelecionado
			// 
			this.tbCodPostalClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCodPostalClienteSelecionado.Location = new System.Drawing.Point(173, 152);
			this.tbCodPostalClienteSelecionado.Name = "tbCodPostalClienteSelecionado";
			this.tbCodPostalClienteSelecionado.Size = new System.Drawing.Size(102, 26);
			this.tbCodPostalClienteSelecionado.TabIndex = 11;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(15, 153);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(152, 25);
			this.label11.TabIndex = 9;
			this.label11.Text = "Codigo Postal:";
			// 
			// tbNifClienteSelecionado
			// 
			this.tbNifClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNifClienteSelecionado.Location = new System.Drawing.Point(65, 193);
			this.tbNifClienteSelecionado.Name = "tbNifClienteSelecionado";
			this.tbNifClienteSelecionado.Size = new System.Drawing.Size(144, 26);
			this.tbNifClienteSelecionado.TabIndex = 12;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(15, 194);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(44, 25);
			this.label10.TabIndex = 7;
			this.label10.Text = "Nif:";
			// 
			// tbTelefoneClienteSelecionado
			// 
			this.tbTelefoneClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTelefoneClienteSelecionado.Location = new System.Drawing.Point(215, 239);
			this.tbTelefoneClienteSelecionado.Name = "tbTelefoneClienteSelecionado";
			this.tbTelefoneClienteSelecionado.Size = new System.Drawing.Size(154, 26);
			this.tbTelefoneClienteSelecionado.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(15, 238);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(194, 25);
			this.label9.TabIndex = 5;
			this.label9.Text = "Telefone Contacto:";
			// 
			// tbMoradaClienteSelecionado
			// 
			this.tbMoradaClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbMoradaClienteSelecionado.Location = new System.Drawing.Point(112, 72);
			this.tbMoradaClienteSelecionado.Name = "tbMoradaClienteSelecionado";
			this.tbMoradaClienteSelecionado.Size = new System.Drawing.Size(431, 26);
			this.tbMoradaClienteSelecionado.TabIndex = 9;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(15, 71);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 25);
			this.label8.TabIndex = 3;
			this.label8.Text = "Morada:";
			// 
			// tbNomeClienteSelecionado
			// 
			this.tbNomeClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNomeClienteSelecionado.Location = new System.Drawing.Point(95, 35);
			this.tbNomeClienteSelecionado.Name = "tbNomeClienteSelecionado";
			this.tbNomeClienteSelecionado.Size = new System.Drawing.Size(448, 26);
			this.tbNomeClienteSelecionado.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(15, 34);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 25);
			this.label7.TabIndex = 0;
			this.label7.Text = "Nome:";
			// 
			// GerirClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(892, 487);
			this.Controls.Add(this.lboxClientes);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gpClientes);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "GerirClientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GerirClientes";
			this.Load += new System.EventHandler(this.GerirClientes_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gpClientes.ResumeLayout(false);
			this.gpClientes.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gerirClientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gerirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gerirArranjosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gerirFornecedoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox lboxClientes;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbNomeClienteAdd;
		private System.Windows.Forms.TextBox tbTelefoneClienteAdd;
		private System.Windows.Forms.Button btAdicionarCliente;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbMoradaClienteAdd;
		private System.Windows.Forms.TextBox tbNifClienteAdd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbLocalidadeClienteAdd;
		private System.Windows.Forms.TextBox tbCodPostalAdd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox gpClientes;
		private System.Windows.Forms.Button btApagarCliente;
		private System.Windows.Forms.Button btAtualizarCliente;
		private System.Windows.Forms.TextBox tbLocalidadeClienteSelecionado;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox tbCodPostalClienteSelecionado;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox tbNifClienteSelecionado;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tbTelefoneClienteSelecionado;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbMoradaClienteSelecionado;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbNomeClienteSelecionado;
		private System.Windows.Forms.Label label7;
	}
}