using FactoryMethod.ConcreteCreator;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod
{
    class program
    {
        static void Main(string[] args)
        {
            CartaoFactory cartaoFactory = null;
            Console.Write("Digite o tipo do cartão que deseja obter: ");
            var console = Console.ReadLine();

            if(console != null)
            {
                switch (console.ToLower())
                {
                    case "black":
                        cartaoFactory = new BlackFactory(50000, 0);
                        break;
                    case "platinum":
                        cartaoFactory = new PlatinumFactory(100000, 0);
                        break;
                    case "titanium":
                        cartaoFactory = new TitaniumFactory(500000, 500);
                        break;
                    default:
                        break;
                }
            }

            if(cartaoFactory != null)
            {
                CartaoCredito cartaoCredito = cartaoFactory.BuscarCartaoCredito();
                Console.WriteLine("\nOs detalhes do seu cartão estão abaixo:\n");
                Console.WriteLine($"Tipo do cartão: {cartaoCredito.TipoCartao}");
                Console.WriteLine($"Limite: {cartaoCredito.LimiteCredito}");
                Console.WriteLine($"Cobrança anual: {cartaoCredito.CobrancaAnual}");
            }
            else
                Console.WriteLine($"Cartão inválido.");

            Console.WriteLine($"Encerrando o programa...");
        }
    }
}