using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompra
{
    internal class Program
    {

        static void Main(string[] args)
        {

            List<string> produto = new List<string>();
            List<double> preco = new List<double>();

            
            Console.WriteLine(": : : : Lista de Compras : : : :");

            while (true)
            {
                
                Console.WriteLine("Digite um item para adicionar à sua comprar (ou 'parar' para sair)");
                string item = Console.ReadLine();
                Console.WriteLine("--------------");

                if (item.ToLower() == "parar")
                {
                    break;
                }

                Console.WriteLine("Digite o preço do prodduto");
                string valor = Console.ReadLine();
                Console.WriteLine("-----------------");


                double valorConvertido = Convert.ToDouble(valor.ToString());

                produto.Add(item);
                preco.Add(valorConvertido);
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("  Cupom Fiscal  ");
            Console.WriteLine("-----------------");

            if (produto.Count == 0 && preco.Count == 0)
            {
                Console.WriteLine("Sua lista de compras está vazia");
            }
            else
            {
                for(int i = 0; i < produto.Count; i++)
                {

                    Console.WriteLine($"   {produto[i]}   {preco[i]}   "); 
                }

                double total = preco.Sum();


                Console.WriteLine("-----------------");
                Console.WriteLine("Total:     {0}", total);
            }
        }
    }
}
