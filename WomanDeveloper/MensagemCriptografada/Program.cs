using System;

namespace MensagemCriptografada
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine ("Bem-vindo ao DIOShopping! Qual o seu nome?");
            string nome = Console.ReadLine();

            string str = "Olá " + nome + ". Você poderia nos informar com qual sexo você se identifica?";
            Console.WriteLine (str);
            string sexo = Console.ReadLine();
            string[] sexoPermitido = {"feminino", "Feminino"};
            Console.WriteLine ("\n");
            
            if (sexoPermitido.Any(sexo.Contains))
            // Entra na seção do site destinada a ajudar as mulheres e LGBTQIA+
            {
                Console.WriteLine ("Seja bem-vinda à nossa seção de Produtos Especiais. Faremos o que pudermos para poder te ajudar, fique tranquila e siga as instruções para que possamos entender e te ajudar da melhor forma possível. A seguir você encontrará algumas opções de produto, cada produto significa diferentes situações em que você pode se encontrar, são elas:\nFogão = Estou machucada e preciso de ajuda.\nGeladeira = Ele me ameaçou, mas não me bateu. \nMicroondas = Estou presa. \nCama = Ele tem sido muito grosseiro e estou com medo. \nEscolha a que melhor se identifica.\n");

                foreach (int i in Enum.GetValues(typeof(ProdutosEspeciais)))
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(ProdutosEspeciais), i));
                }

                Console.WriteLine ("Digite o produto que você deseja de acordo com as opções mostradas acima:");
                int ProdutoEspecial = int.Parse(Console.ReadLine());
                Console.WriteLine ("\n");

                if (ProdutoEspecial != 5)
                {
                    Console.WriteLine ("Vamos te ajudar! Nos informe o endereço de entrega:");
                    string endereco = Console.ReadLine();
                    Console.WriteLine ("\n");

                    Console.WriteLine ("Beleza! Com qual urgência você precisa desse pedido?");
                    foreach (int i in Enum.GetValues(typeof(Prazos)))
                    {
                        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Prazos), i));
                    }

                    int Prazos = int.Parse(Console.ReadLine());
                    Console.WriteLine ("\n");
                    if (Prazos == 1)
                    {
                        Console.WriteLine("A polícia já foi informada e está a caminho! Se proteja.");
                    }
                    else if (Prazos == 2)
                    {
                        Console.WriteLine("Nossas ONGs parceiras já estão cientes do seu problema e entrarão em contato.");
                    }
                    else
                    {
                        Console.WriteLine("Tudo bem, quando você se sentir mais segura e preparada, estaremos aqui pra te ajudar.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                    {
                        Console.WriteLine ("Tudo bem, quando você se sentir mais segura e preparada, estaremos aqui pra te ajudar.");
                        Console.ReadKey();
                        Console.Clear();
                    }
            }
            else 
                {
                    Console.WriteLine ("Obrigada pelas informações, logo você será encaminhado ao site da DIOShopping.");
                    Console.ReadKey();
                    Console.Clear();
                }
        }  
    }
}