using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DAplicacoes
{
	public partial class GerirClientes : Form
	{
		private CRSMContainer bd;

		public GerirClientes()
		{
			InitializeComponent();
		}

		private void GerirClientes_Load(object sender, EventArgs e)
		{
			bd = new CRSMContainer();
			LerDados();
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

		private void btAdicionarCliente_Click(object sender, EventArgs e)
		{
			Cliente cliente = new Cliente();
			int x;
			if (tbNomeClienteAdd.Text == "")
			{
				tbNomeClienteAdd.Text = "Este campo não pode estar vazio";
				return;
			}
			else if (int.TryParse(tbNomeClienteAdd.Text, out x))
			{
				tbNomeClienteAdd.Text = "Este campo não pode conter números";
				return;
			}
			else
			{
				cliente.Nome = tbNomeClienteAdd.Text;
			}

			if (tbMoradaClienteAdd.Text == "")
			{
				tbMoradaClienteAdd.Text = "Este campo não pode estar vazio";
				return;
			}
			else
			{
				cliente.Morada = tbMoradaClienteAdd.Text;
			}
			
			if(tbLocalidadeClienteAdd.Text == "")
			{
				tbLocalidadeClienteAdd.Text = "Este campo não pode estar vazio";
				return;
			}
			else
			{
				cliente.Localidade = tbLocalidadeClienteAdd.Text;
			}
			
			if(tbCodPostalAdd.Text == "")
			{
				tbCodPostalAdd.Text = "Este campo não pode estar vazio";
				return;
			}
			else
			{
				cliente.Codigo_Postal = tbCodPostalAdd.Text;
			}

			if(tbNifClienteAdd.Text.Length < 9)
			{
				tbNifClienteAdd.Text = "Este campo tem que ter 9 numeros";
				return;
			}
			else
			{
				cliente.Nif = tbNifClienteAdd.Text;
			}

			if (tbTelefoneClienteAdd.Text.Length < 9)
			{
				tbTelefoneClienteAdd.Text = "Este campo tem que ter 9 numeros";
				return;
			}
			else
			{
				cliente.Telefone_Contacto = tbTelefoneClienteAdd.Text;
			}

			
			bd.ClienteSet.Add(cliente);
			bd.SaveChanges();
			LerDados();

			LimpaTbAdicionarCliente();

		}

		private void btApagarCliente_Click(object sender, EventArgs e)
		{
			if (lboxClientes.SelectedIndex == -1)
			{
				MessageBox.Show("Não selecionou Cliente nenhum");
			}
			else
			{
				bd.ClienteSet.Remove((Cliente)lboxClientes.SelectedItem);
				bd.SaveChanges();
				LerDados();

				if (lboxClientes.SelectedIndex == -1)
				{
					LimpaTbClienteSelecionado();
				}
			}
		}

		private void btAtualizarCliente_Click(object sender, EventArgs e)
		{
			if (lboxClientes.SelectedIndex == -1)
			{
				MessageBox.Show("Não selecionou Cliente nenhum");
			}
			else
			{
				Cliente selecionado = (Cliente)lboxClientes.SelectedItem;
				selecionado.Nome = tbNomeClienteSelecionado.Text;
				selecionado.Morada = tbMoradaClienteSelecionado.Text;
				selecionado.Localidade = tbLocalidadeClienteSelecionado.Text;
				selecionado.Codigo_Postal = tbCodPostalClienteSelecionado.Text;
				selecionado.Nif = tbNifClienteSelecionado.Text;
				selecionado.Telefone_Contacto = tbTelefoneClienteSelecionado.Text;
				bd.SaveChanges();
				LerDados();
			}
		}

		private void lboxClientes_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cliente selecionado = (Cliente)lboxClientes.SelectedItem;
			
			tbNomeClienteSelecionado.Text = selecionado.Nome;
			tbMoradaClienteSelecionado.Text = selecionado.Morada;
			tbLocalidadeClienteSelecionado.Text = selecionado.Localidade;
			tbCodPostalClienteSelecionado.Text = selecionado.Codigo_Postal;
			tbNifClienteSelecionado.Text = selecionado.Nif;
			tbTelefoneClienteSelecionado.Text = selecionado.Telefone_Contacto;
		}

		private void LerDados()
		{
			lboxClientes.DataSource = bd.ClienteSet.ToList<Cliente>();
		}

		private void LimpaTbAdicionarCliente()
		{
			tbNomeClienteAdd.Text = "";
			tbMoradaClienteAdd.Text = "";
			tbLocalidadeClienteAdd.Text = "";
			tbCodPostalAdd.Text = "";
			tbNifClienteAdd.Text = "";
			tbTelefoneClienteAdd.Text = "";
		}

		private void LimpaTbClienteSelecionado()
		{
			tbNomeClienteSelecionado.Text = "";
			tbMoradaClienteSelecionado.Text = "";
			tbLocalidadeClienteSelecionado.Text = "";
			tbCodPostalClienteSelecionado.Text = "";
			tbNifClienteSelecionado.Text = "";
			tbTelefoneClienteSelecionado.Text = "";
		}

		
	}
}
