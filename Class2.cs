using System;
using Sytem.Threading.Tasks;
using Refit;


namespace ExemploRefit
{
    class Mainclass
    {
       public static async Task Main(string[] args)
        {
            try
            {
                var cepClient = RestService.For<IcepApiService>("http://viacep.com.br");
                console.WriteLine("Informe seu cep");

                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultando informacoes do CEP:" + cepInformado);

                var address = await cepClient.GetAddressAssync(cepInformado);

                Console.Write($"\nLougradouro: {address.Lougradouro}, \nBairro:{address.Bairro}, \nCidade:{address.Localidade}");
                Console.Readkey();
            }
            catch (Exemplo e)

            {
                Console.WriteLine("Erro na colsulta de cep" + e.Message);
            }
        }
    }
}
