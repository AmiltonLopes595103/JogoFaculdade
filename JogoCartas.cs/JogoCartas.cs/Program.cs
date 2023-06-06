using System.Collections;
using classes;


namespace ProjetoJogo

{
    public class Jogo
    {

        public static void Main(string[] args)
        {
            string Opcao;
            int vez = 1;
            string[] cartas =  new string[3] { "Copas","Espada", "Ouros" };
            ArrayList arr = new ArrayList();
            do
            {
                Console.WriteLine("Olá, vamos jogar cartas ");
                Console.WriteLine("Digite o nome do jogador " + vez);

                Classes Jogador = new Classes();

                var Jogador1 = Jogador.Nome();

                arr.Add(Jogador1);
                if (arr.Count == 2) break;
                Console.WriteLine("Deseja Adicionar mais jogadores?");
                
                Opcao = Console.ReadLine().ToUpper();
                

                vez++;


            } while (Opcao != "NAO");

     

            for (int i  = 0; i <= 3;  i++ )
            {
              Console.WriteLine ( new Random().Next(1, 3));
               
            }

            if (arr.Count == 1)
            {
             
            }
            


        }


    }

}