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
	public partial class GerirFornecedorMaterial : Form
	{
		private CRSMContainer bd;

		public GerirFornecedorMaterial()
		{
			InitializeComponent();
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

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Tem a certeza que pretende sair?", "Confirmar saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void GerirFornecedorMaterial_Load(object sender, EventArgs e)
		{
			bd = new CRSMContainer();
			LerDados();
		}

		private void btAdicionarFornecedor_Click(object sender, EventArgs e)
		{
			Fornecedor fornecedor = new Fornecedor();
			int x;
			if (tbNomeFornecedorAdd.Text == "")
			{
				tbNomeFornecedorAdd.Text = "Este campo não pode estar vazio";
				return;
			}
			else if (int.TryParse(tbNomeFornecedorAdd.Text, out x)) //Algoritmo para verificar se existem numeros na textBox
			{
				tbNomeFornecedorAdd.Text = "Este campo não pode conter números";
				return;
			}
			else
			{
				fornecedor.Nome = tbNomeFornecedorAdd.Text;
			}

			if (tbMoradaFornecedorAdd.Text == "")
			{
				tbMoradaFornecedorAdd.Text = "Este campo não pode estar vazio";
				return;
			}
			else
			{
				fornecedor.Morada = tbMoradaFornecedorAdd.Text;
			}

			if (tbLocalidadeFornecedorAdd.Text == "")
			{
				tbLocalidadeFornecedorAdd.Text = "Este campo não pode estar vazio";
				return;
			}
			else
			{
				fornecedor.Localidade = tbLocalidadeFornecedorAdd.Text;
			}

			if (tbCodPostalFornecedorAdd.Text == "")
			{
				tbCodPostalFornecedorAdd.Text = "Este campo não pode estar vazio";
				return;
			}
			else
			{
				fornecedor.CodigoPostal = tbCodPostalFornecedorAdd.Text;
			}

			if (tbNifFornecedorAdd.Text.Length < 9)
			{
				tbNifFornecedorAdd.Text = "Este campo tem que ter 9 numeros";
				return;
			}
			else
			{
				fornecedor.Nif = Convert.ToInt32(tbNifFornecedorAdd.Text);
			}

			if (tbTelefoneFornecedorAdd.Text.Length < 9)
			{
				tbTelefoneFornecedorAdd.Text = "Este campo tem que ter 9 numeros";
				return;
			}
			else
			{
				fornecedor.Telefone = Convert.ToInt32(tbTelefoneFornecedorAdd.Text);
			}
			

			bd.FornecedorSet.Add(fornecedor);
			bd.SaveChanges();
			LerDados();

			LimpaTbAdicionarFornecedor();
		}

		

		private void btAtualizarFornecedor_Click(object sender, EventArgs e)
		{
			if (lboxFornecedores.SelectedIndex == -1)
			{
				MessageBox.Show("Não selecionou Fornecedor nenhum");
			}
			else
			{
				Fornecedor selecionado = (Fornecedor)lboxFornecedores.SelectedItem;
				selecionado.Nome = tbNomeFornecedorSelecionado.Text;
				selecionado.Morada = tbMoradaFornecedorSelecionado.Text;
				selecionado.Localidade = tbLocalidadeFornecedorSelecionado.Text;
				selecionado.CodigoPostal = tbCodPostalFornecedorSelecionado.Text;
				selecionado.Nif = Convert.ToInt32(tbNifFornecedorSelecionado.Text);
				selecionado.Telefone = Convert.ToInt32(tbTelefoneFornecedorSelecionado.Text);
				bd.SaveChanges();
				LerDados();
			}
		}

		private void btApagarFornecedor_Click(object sender, EventArgs e)
		{
			if (lboxFornecedores.SelectedIndex == -1)
			{
				MessageBox.Show("Não selecionou Cliente nenhum");
			}
			else
			{
				bd.ClienteSet.Remove((Cliente)lboxFornecedores.SelectedItem);
				bd.SaveChanges();
				LerDados();

				if (lboxFornecedores.SelectedIndex == -1)
				{
					LimpaTbFornecedorSelecionado();
				}
			}
		}

		private void btAddMaterial_Click(object sender, EventArgs e)
		{
			StockMateriais material = new StockMateriais();
			material.QuantActual = Convert.ToInt32(tbQuantActualMaterialAdd.Text);
			material.StockMinimo = Convert.ToInt32(tbStockMinimoMaterialAdd.Text);
			
			bd.StockMateriaisSet.Add(material);
			bd.SaveChanges();

			Fornece fornecedor_material = new Fornece();
			using (var context = new CRSMContainer())
			{
				var blog = context.StockMateriaisSet.OrderByDescending(b => b.Id).FirstOrDefault();
				fornecedor_material.StockMateriaisId = Convert.ToInt32(blog.Id);
			}
			Fornecedor selecionado = (Fornecedor)cbFornecedoresAdd.SelectedItem;
			fornecedor_material.FornecedorId = selecionado.Id;
			fornecedor_material.PrazoEntrega = DateTime.Now.AddDays(3);
			double y = Convert.ToDouble(tbQuantActualMaterialAdd.Text);
			double x = Convert.ToDouble(tbPrecounitario.Text);
			fornecedor_material.Preco = x * y;
			bd.ForneceSet.Add(fornecedor_material);
			bd.SaveChanges();

			LerDados();
			LimpaTbAdicionarMaterial();
			
		}

		private void btAtualizarMaterial_Click(object sender, EventArgs e)
		{

		}

		private void lboxFornecedores_SelectedIndexChanged(object sender, EventArgs e)
		{

			Fornecedor selecionado = (Fornecedor)lboxFornecedores.SelectedItem;

			tbNomeFornecedorSelecionado.Text = selecionado.Nome;
			tbMoradaFornecedorSelecionado.Text = selecionado.Morada;
			tbLocalidadeFornecedorSelecionado.Text = selecionado.Localidade;
			tbCodPostalFornecedorSelecionado.Text = selecionado.CodigoPostal;
			tbNifFornecedorSelecionado.Text = Convert.ToString(selecionado.Nif);
			tbTelefoneFornecedorSelecionado.Text = Convert.ToString(selecionado.Telefone);
		}

		private void LerDados()
		{
			lboxFornecedores.DataSource = bd.FornecedorSet.ToList<Fornecedor>();
			cbFornecedoresAdd.DataSource = bd.FornecedorSet.ToList<Fornecedor>();
			lboxMateriais.DataSource = bd.ForneceSet.ToList<Fornece>();
		}

		private void LimpaTbAdicionarFornecedor()
		{
			tbNomeFornecedorAdd.Text = "";
			tbMoradaFornecedorAdd.Text = "";
			tbLocalidadeFornecedorAdd.Text = "";
			tbCodPostalFornecedorAdd.Text = "";
			tbNifFornecedorAdd.Text = "";
			tbTelefoneFornecedorAdd.Text = "";
		}

		private void LimpaTbFornecedorSelecionado()
		{
			tbNomeFornecedorSelecionado.Text = "";
			tbMoradaFornecedorSelecionado.Text = "";
			tbLocalidadeFornecedorSelecionado.Text = "";
			tbCodPostalFornecedorSelecionado.Text = "";
			tbNifFornecedorSelecionado.Text = "";
			tbTelefoneFornecedorSelecionado.Text = "";
		}

		private void LimpaTbAdicionarMaterial()
		{
			tbQuantActualMaterialAdd.Text = "";
			tbStockMinimoMaterialAdd.Text = "";
			tbPrecounitario.Text = "";
		}

		private void lboxMateriais_SelectedIndexChanged(object sender, EventArgs e)
		{
			Fornece selecionado = (Fornece)lboxMateriais.SelectedItem;
			tbQuantActualSelecionado.Text = Convert.ToString(selecionado.StockMateriais.QuantActual);
			tbStockMinimoSelecionado.Text = Convert.ToString(selecionado.StockMateriais.StockMinimo);
			tbFornecedorSelecionado.Text = Convert.ToString(selecionado.Fornecedor);
			tbPrecoSelecionado.Text = Convert.ToString(selecionado.Preco);
		}

		
	}
}
