using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    public class Jvelha
    {
        private char[,] tab = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
        private int lin, col;               
        public void Menu()
        {
            LayoutMenu();
            Console.WriteLine("Escolha dentre as opções de jogo");          
            int menu=int.Parse(Console.ReadLine());


            switch (menu)
            {
                case 1:
                    HxH();
                    break;           
                case 2:
                    break;
                case 3:
                    break;

            }
        }
                   
        
        private void Tabuleiro()
        {
            Linha();
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + tab[0, 0] + "|" + tab[0, 1] + "|" + tab[0, 2]);
            Console.WriteLine("  - - -");
            Console.WriteLine("1 " + tab[1, 0] + "|" + tab[1, 1] + "|" + tab[1, 2]);
            Console.WriteLine("  - - -");
            Console.WriteLine("2 " + tab[2, 0] + "|" + tab[2, 1] + "|" + tab[2, 2]);

        }

        private void HxH()
        {
            int player=1;
            char escolha;
            Tabuleiro();
            for (int i = 0; i < 3 ; i++)
            {
                for(int j = 0; j < 3 ; j++)
                {
                    Linha();
                    //Definir a posição e a escolha
                    Console.WriteLine($"jogador numero {player} joga : ");
                    Console.Write("Escolha a posição" +
                    $"\n\nLinha: ");
                    lin = int.Parse(Console.ReadLine());
                    Console.Write("Coluna: ");
                    col = int.Parse(Console.ReadLine());    
                    Console.Write("Escolha entre x ou o:  ");
                    escolha=char.Parse(Console.ReadLine());  
                    //

                    //validar a escolha
                    while (escolha!='x' &&  escolha != 'o')
                    {                       
                        Console.Write("Digite um valor valido x ou o : ");
                        escolha = char.Parse(Console.ReadLine());
                    }
                    //verificar se o espaço tá preenchido 
                    if (tab[lin, col]==' ')
                    {
                        
                        tab[lin, col] = escolha;

                    }
                    //
                    else
                    {
                        Console.WriteLine("Espaço já preenchido\n\n\n" +
                            "\nEscolha outra posição: ");
                        
                    }
                    // Condições d vitoria 
                    //[linha,coluna]
                    if (tab[0, 0] == 'x' && tab[0, 1] == 'x' && tab[0, 2] == 'x')
                    {
                        Console.WriteLine($"\n\nJogador numero{player} ganhou !!!!");
                        goto final;
                        break;
                    }
                    else if (tab[0, 0] == 'o' && tab[0, 1] == 'o' && tab[0, 2] == 'o')
                    {
                        Console.WriteLine($"\n\nJogador numero{player} ganhou !!!!");
                        goto final;
                        break;
                    }

                    else if (tab[0, 0] == 'x' && tab[1, 0] == 'x' && tab[2, 0] == 'x')
                    {
                        Console.WriteLine($"\n\nJogador numero{player} ganhou !!!!");
                        goto final;
                        break;
                    }
                    else if (tab[0, 0] == 'o' && tab[1, 0] == 'o' && tab[2, 0] == 'o')
                    {
                        Console.WriteLine($"\n\nJogador numero{player} ganhou !!!!");
                        goto final;
                        break;
                    }

                    else if (tab[0, 0] == 'x' && tab[1, 1] == 'x' && tab[2, 2] == 'x')
                    {
                        Console.WriteLine($"\n\nJogador numero{player} ganhou !!!!");
                        goto final;
                        break;
                    }
                    else if (tab[0, 0] == 'o' && tab[1, 1] == 'o' && tab[2, 2] == 'o')
                    {
                        Console.WriteLine($"\n\nJogador numero{player} ganhou !!!!");
                        goto final;
                        break;
                    }

                    else if (tab[0, 2] == 'x' && tab[1, 1] == 'x' && tab[2, 0] == 'x')
                    {
                        Console.WriteLine($"\n\nJogador numero{player} ganhou !!!!");
                        goto final;
                        break;
                    }
                    else if (tab[0, 2] == 'o' && tab[1, 1] == 'o' && tab[2, 0] == 'o')
                    {
                        Console.WriteLine($"\n\nJogador numero{player} ganhou !!!!");
                        goto final;
                        break;
                    }

                    else if (tab[0, 1] == 'x' && tab[1, 1] == 'x' && tab[2, 1] == 'x')
                    {
                        Console.WriteLine($"\n\nJogador numero{player} ganhou !!!!");
                        goto final;
                        break;
                    }
                    else if (tab[0, 1] == 'o' && tab[1, 1] == 'o' && tab[2, 1] == 'o')
                    {
                        Console.WriteLine($"\n\nJogador numero{player} ganhou !!!!");
                        goto final;
                        break;
                    }

                    else if (tab[1,0] == 'x' && tab[1, 1] == 'x' && tab[1, 2] == 'x')
                    {
                        Console.WriteLine($"\n\nJogador numero{player} ganhou !!!!");
                        goto final;
                        break;
                    }
                    else if (tab[1, 0] == 'o' && tab[1, 1] == 'o' && tab[1, 2] == 'o')
                    {
                        Console.WriteLine($"\n\nJogador numero{player} ganhou !!!!");
                        goto final;
                        break;
                    }

                    else if (tab[2, 0] == 'x' && tab[2, 1] == 'x' && tab[2, 2] == 'x')
                    {
                        Console.WriteLine($"\n\nJogador numero{player} ganhou !!!!");
                        goto final;
                        break;
                    }
                    else if (tab[2, 0] == 'o' && tab[2, 1] == 'o' && tab[2, 2] == 'o')
                    {
                        Console.WriteLine($"\n\nJogador numero{player} ganhou !!!!");
                        goto final;
                        break;
                    }

                    else if (tab[0, 2] == 'x' && tab[1, 2] == 'x' && tab[2, 2] == 'x')
                    {
                        Console.WriteLine($"\n\nJogador numero{player} ganhou !!!!");
                        goto final;
                        break;
                    }
                    else if (tab[0, 2] == 'o' && tab[1, 2] == 'o' && tab[2, 2] == 'o')
                    {
                        Console.WriteLine($"\n\nJogador numero{player} ganhou !!!!");
                        goto final;
                        break;
                    }
                    else if (tab[0,0]!=' '&& tab[0, 0] != ' ' && tab[0, 1] != ' ' && tab[0, 2] != ' ' && tab[1, 0] != ' ' && tab[1, 1] != ' ' && tab[1, 2] != ' ' && tab[2, 0] != ' ' && tab[2, 1] != ' '&& tab[2, 2] != ' ')
                    {
                        Console.WriteLine($"\n\nEmpatou !!!!");
                        goto final;
                        break;
                    }



                    //

                    Tabuleiro();
                    Linha();


                    player++;
                    if (player>2)
                    {
                        player=player-2;
                        
                    }
                }
                
            }
            final:
            Tabuleiro();
        }
        
      
        private void Linha()
        {
            Console.WriteLine("---------------------------------------");
        }

        private void LayoutMenu()
        {
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 - Jogar PvP");
            Console.WriteLine("2 - Jogar PvM");
            Console.WriteLine("3 - Sair");
        }
        
    }
}
