using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ShopVirtual.Model;

namespace ShopVirtual.BLL
{
	public class ClienteBLL
	{
		//Efetua a conexão com ao BD, não esquecer de colcoar a Sting de conexão no appconfig.
		private LojaEntities _loja = new LojaEntities();

		public void Add(Cliente Entity)
		{
			//Executa o comando CREATE do SQL, com os dados do Objeto informado
			_loja.Cliente.Add(Entity);
			//Salva as alterações no BD
			_loja.SaveChanges();
		}

		public void Delete(Cliente Entity)
		{
			//localiza e Excliu o Objeto informado do DB
			_loja.Cliente.Remove(Entity);
			//Salva as alterações no BD
			_loja.SaveChanges();
		}

		public void Update(Cliente Entity)
		{
			Cliente cli = _loja.Cliente.SingleOrDefault(c => c.ID == Entity.ID);
			if (cli != null)
			{
				_loja.Entry(Entity).CurrentValues.SetValues(Entity);
				//Salva as alterações no BD
				_loja.SaveChanges();
			}
		}

		public Cliente Localiza(string email)
		{
			return Find(c => c.EMAIL.Trim().Equals(email)).FirstOrDefault();
		}

		public IQueryable<Cliente> Find(Expression<Func<Cliente, bool>> where)
		{
			return _loja.Cliente.Where(where);
		}

		public IQueryable<Cliente> GetAll()
		{
			return _loja.Cliente.Take(_loja.Cliente.Count());
		}

		public Cliente Autentica(string email, string senha)
		{
			return Find(c => c.EMAIL.Trim().Equals(email) && c.Senha.Trim().Equals(senha)).FirstOrDefault();
		}

		public Cliente RecuperaSenha(string email)
		{
			return Find(c => c.EMAIL.Trim().Equals(email)).FirstOrDefault();
		}

		public bool VerificarExistencia(string email)
		{
			int qtdCli = 0;
			qtdCli = Find(c => c.EMAIL.Trim().Equals(email)).Count();
			if (qtdCli > 0)
			{
				//Cliente existe
				return true;
			}
			else
			{
				//Cliente não existe
				return false;
			}
		}
	}
}
