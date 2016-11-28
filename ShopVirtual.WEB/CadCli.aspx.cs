using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShopVirtual.BLL;
using ShopVirtual.Model;

namespace ShopVirtual.WEB
{
	public partial class CadCli : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Gravar_Click(object sender, EventArgs e)
		{
			Cliente cli = new Cliente();
			ClienteBLL cad = new ClienteBLL();

			cli.Nome = nome.Text;
			cli.EMAIL = email.Text;
			cli.Senha = senha.Text;
			cli.DataCadastro = DateTime.Now;

			cad.Add(cli);
		}

		protected void Alterar_Click(object sender, EventArgs e)
		{
			Cliente cli = new Cliente();
			ClienteBLL cad = new ClienteBLL();

			cli = cad.Localiza(email.Text);

			cli.Nome = nome.Text;
			cli.EMAIL = email.Text;
			cli.Senha = senha.Text;
			cli.DataCadastro = Convert.ToDateTime(data.Text);

			cad.Update(cli);
		}

		protected void Localizar_Click(object sender, EventArgs e)
		{
			Cliente cli = new Cliente();
			ClienteBLL cad = new ClienteBLL();

			cli = cad.Localiza(email.Text);

			nome.Text = cli.Nome;
			email.Text = cli.EMAIL;
			senha.Text = cli.Senha;
			confsenha.Text = cli.Senha;
			data.Text = cli.DataCadastro.ToShortDateString();
		}
	}
}