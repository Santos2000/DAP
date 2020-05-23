using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DAplicacoes
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			 
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Tem a certeza que pretende sair?", "Confirmar saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void gerirClientesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			GerirClientes form = new GerirClientes();
			form.Show();
		}

		private void gerirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			GerirPedidos form = new GerirPedidos();
			form.Show();
		}

		private void gerirFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			GerirFornecedorMaterial form = new GerirFornecedorMaterial();
			form.Show();
		}
	}
}
