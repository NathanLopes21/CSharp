using System;

namespace Urna
{
    class Program
    {
        static void Main(string[] args)
        {
            int vtsMSDN = 0;
            int vtsTechNet = 0;
            int vtsSpoke = 0;
            int vtsBranco = 0;
            int vtsNulo = 0;
            int totalVotos = 0;

            string continua = "sim";

           
            Console.WriteLine("Data e Hora: " + DateTime.Now);
            Console.WriteLine("Vote certo!");
            

            while (continua.ToLower() == "sim")
            {
                Console.WriteLine ("Escolha sua opção de voto:");
                Console.WriteLine ("1 - MSDN");
                Console.WriteLine ("2 - TechNet");
                Console.WriteLine ("3 - The Spoke.Net");
                Console.WriteLine ("4 - Voto branco");
                Console.WriteLine ("5 - Voto nulado ");
                Console.Write("Faça sua escolha, brasileiro: ");

                string entrar = Console.ReadLine();
                int opcoes;


                if (int.TryParse(entrar, out opcoes))


                {
                    switch (opcoes)
                    {
                        case 1:
                            vtsMSDN ++;
                            break;
                        
                        case 2:
                            vtsTechNet ++;
                            break;
                        
                        case 3:
                            vtsSpoke ++;
                            break;
                        
                        case 4:
                            vtsBranco ++;
                            break;
                        
                        case 5:
                            vtsNulo ++;
                            break;
         
                    }

                  
                }
               

                Console.Write("Tem certeza que deseja continuar? (sim/nao):");
                continua = Console.ReadLine().ToLower();
                Console.Clear();
            }

            Console.Clear();

            Console.WriteLine($"MSDN Brasil: {vtsMSDN} votos");
            Console.WriteLine($"TechNet Brasil: {vtsTechNet} votos");
            Console.WriteLine($"The Spoke .Net: {vtsSpoke} votos");
            Console.WriteLine($"Votos em branco: {vtsBranco}");
            Console.WriteLine($"Votos nulos: {vtsNulo}");
            Console.WriteLine($"Total de eleitores: {totalVotos}");


            int maiorVoto = Math.Max(Math.Max(Math.Max(Math.Max(vtsMSDN, vtsTechNet), vtsSpoke), vtsBranco), vtsNulo);
            string vencedor = "";

            if (maiorVoto == vtsMSDN) vencedor = "MSDN Brasil";
            else if (maiorVoto == vtsTechNet) vencedor = "TechNet Brasil";
            else if (maiorVoto == vtsSpoke) vencedor = "The Spoke .Net";
            else if (maiorVoto == vtsBranco) vencedor = "Voto em branco";
            else if (maiorVoto == vtsNulo) vencedor = "Voto nulo";

            Console.WriteLine($" O ganhador foi o: {vencedor} com {maiorVoto} votos!");
        }
    }
}