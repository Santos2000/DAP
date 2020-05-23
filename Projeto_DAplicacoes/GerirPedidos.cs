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
	public partial class GerirPedidos : Form
	{
		private CRSMContainer bd;
		public GerirPedidos()
		{
			InitializeComponent();
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

		private void gerirFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			GerirFornecedorMaterial form = new GerirFornecedorMaterial();
			form.Show();
		}

		private void GerirPedidos_Load(object sender, EventArgs e)
		{
			bd = new CRSMContainer();
			LerDados();
			cbCliente.SelectedItem = -1;
		}

		private void LerDados()
		{
			cbCliente.DataSource = bd.ClienteSet.ToList<Cliente>();
			cbPeca.DataSource = bd.PecaSet.ToList<Peca>();
			cbTipoPedido.DataSource = bd.ArranjoSet.ToList<Arranjo>();
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}
	}
}
