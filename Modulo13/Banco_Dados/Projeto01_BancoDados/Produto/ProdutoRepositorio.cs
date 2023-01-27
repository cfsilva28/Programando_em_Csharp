using Dapper.Contrib.Extensions;
using Projeto01_BancoDados.Class.Db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01_BancoDados.Produto
{
    /*
     *  Realizar instruções SQL com Dapper Contrib
     *  
     *  Cadastrar Produto
     *  Listar Produto
     *  Atualizar Produto
     *  Remover Produto
     */
    internal class ProdutoRepositorio
    {
        //Cadastrar Produto
        public static void CadastrarProduto(Produto produto)
        {
            try
            {
                using (var conexao = new SqlConnection(DB.stringConexao))
                {
                    conexao.Insert<Produto>(produto);
                }

                Console.WriteLine();
                Console.WriteLine("Produto cadastrado com sucesso.");

                Console.WriteLine(new string('_', 60));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        //Listar Produto
        public static void ListarProdutos()
        {
            Console.WriteLine("Lista dos produtos: \n");

            try
            {
                using (var conexao = new SqlConnection(DB.stringConexao))
                {
                    IEnumerable<Produto> lista = conexao.GetAll<Produto>();

                    foreach (Produto produto in lista)
                    {
                        Console.WriteLine($"Id: {produto.Id}. Descrição: {produto.Descricao}. Preço: {produto.Preco}");
                    }
                }
                Console.WriteLine();

                Console.WriteLine(new String('_', 60));

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        //Atualizar Produto
        public static void AtualizarProduto(Produto produto)
        {
            try
            {
                using (var conexao = new SqlConnection(DB.stringConexao))
                {
                    conexao.Update<Produto>(produto);
                }

                Console.WriteLine();

                Console.WriteLine("Produto atualizado com sucesso");

                Console.WriteLine(new String('_', 60));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        //Remover Produto

        public static void RemoverProduto(int id)
        {
            try
            {
                using (var conexao = new SqlConnection(DB.stringConexao))
                {
                    conexao.Delete<Produto>(new Produto { Id = id });
                }

                Console.WriteLine();

                Console.WriteLine("Produto removido com sucesso.");

                Console.WriteLine(new String('_', 60));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
