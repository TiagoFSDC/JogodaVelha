internal class Program
{
    private static void Main(string[] args)
    {
        char[,] jogo = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        char xouO = 'X';
        int pos = 1, testador = 1;
        bool x = true, y;
        char value;


        Mostrartabuleiro();
        int P = 0;
        EscolherPosicao();



        void Mostrartabuleiro()
        {
            for (int i = 0; i < jogo.GetLength(0); i++)
            {
                for (int j = 0; j < jogo.GetLength(1); j++)
                {
                    Console.Write(jogo[i, j] + " | ");
                }
                if (i < 2)
                {
                    Console.WriteLine();
                    Console.Write("------------");
                }
                Console.WriteLine();
            }
        }



        void VariacaoJogador()
        {
            if (testador % 2 == 0)
            {
                xouO = 'O';
            }
            else
            {
                xouO = 'X';
            }
            testador++;
        }



        void DefinirPosicao()
        {
            Console.WriteLine("Digite a posição que você quer jogar: ");
            value = char.Parse(Console.ReadLine());
            y = false;
            while (y == false)
            {
                switch (value)
                {
                    case '1':
                        if (jogo[0, 0] == 'X' || jogo[0, 0] == 'O')
                        {
                            Console.WriteLine("O local ja tem valor, digite outro.");
                            value = char.Parse(Console.ReadLine());
                        }
                        else
                        {
                            y = true;
                        }
                        break;

                    case '2':
                        if (jogo[0, 1] == 'X' || jogo[0, 1] == 'O')
                        {
                            Console.WriteLine("O local ja tem valor, digite outro.");
                            value = char.Parse(Console.ReadLine());
                        }
                        else
                        {
                            y = true;
                        }
                        break;

                    case '3':
                        if (jogo[0, 2] == 'X' || jogo[0, 2] == 'O')
                        {
                            Console.WriteLine("O local ja tem valor, digite outro.");
                            value = char.Parse(Console.ReadLine());
                        }
                        else
                        {
                            y = true;
                        }
                        break;

                    case '4':
                        if (jogo[1, 0] == 'X' || jogo[1, 0] == 'O')
                        {
                            Console.WriteLine("O local ja tem valor, digite outro.");
                            value = char.Parse(Console.ReadLine());
                        }
                        else
                        {
                            y = true;
                        }
                        break;

                    case '5':
                        if (jogo[1, 1] == 'X' || jogo[1, 1] == 'O')
                        {
                            Console.WriteLine("O local ja tem valor, digite outro.");
                            value = char.Parse(Console.ReadLine());
                        }
                        else
                        {
                            y = true;
                        }
                        break;

                    case '6':
                        if (jogo[1, 2] == 'X' || jogo[1, 2] == 'O')
                        {
                            Console.WriteLine("O local ja tem valor, digite outro.");
                            value = char.Parse(Console.ReadLine());
                        }
                        else
                        {
                            y = true;
                        }
                        break;

                    case '7':
                        if (jogo[2, 0] == 'X' || jogo[2, 0] == 'O')
                        {
                            Console.WriteLine("O local ja tem valor, digite outro.");
                            value = char.Parse(Console.ReadLine());
                        }
                        else
                        {
                            y = true;
                        }
                        break;

                    case '8':
                        if (jogo[2, 1] == 'X' || jogo[2, 1] == 'O')
                        {
                            Console.WriteLine("O local ja tem valor, digite outro.");
                            value = char.Parse(Console.ReadLine());
                        }
                        else
                        {
                            y = true;
                        }
                        break;

                    case '9':
                        if (jogo[2, 2] == 'X' || jogo[2, 2] == 'O')
                        {
                            Console.WriteLine("O local ja tem valor, digite outro.");
                            value = char.Parse(Console.ReadLine());
                        }
                        else
                        {
                            y = true;
                        }
                        break;

                    default:
                        Console.WriteLine("Posição inválida, digite outra");
                        value = char.Parse(Console.ReadLine());
                        break;

                }
            }
        }


        void CompletaTabuleiro()
        {
            if (value == '1')
            {
                jogo[0, 0] = xouO;
            }
            if (value == '2')
            {
                jogo[0, 1] = xouO;
            }
            if (value == '3')
            {
                jogo[0, 2] = xouO;
            }
            if (value == '4')
            {
                jogo[1, 0] = xouO;
            }
            if (value == '5')
            {
                jogo[1, 1] = xouO;
            }
            if (value == '6')
            {
                jogo[1, 2] = xouO;
            }
            if (value == '7')
            {
                jogo[2, 0] = xouO;
            }
            if (value == '8')
            {
                jogo[2, 1] = xouO;
            }
            if (value == '9')
            {
                jogo[2, 2] = xouO;
            }
        }



        char[,] EscolherPosicao()
        {
            while ((P < 9) && x == true)
            {
                DefinirPosicao();

                VariacaoJogador();

                CompletaTabuleiro();

                if (P >= 4)
                {
                    VerificarGanhador();
                }
                Mostrartabuleiro();
                P++;
            }
            if (P == 9)
            {
                Console.WriteLine("O jogo deu velha");
            }
            return jogo;
        }



        bool VerificarGanhador()
        {
            if ((jogo[0, 0] == jogo[0, 1] && jogo[0, 1] == jogo[0, 2]) ||  //vitória na primeira linha
               (jogo[1, 0] == jogo[1, 1] && jogo[1, 1] == jogo[1, 2]) ||   //vitória na segunda linha
               (jogo[2, 0] == jogo[2, 1] && jogo[2, 1] == jogo[2, 2]) ||   //vitória na terceira linha
               (jogo[0, 0] == jogo[1, 0] && jogo[1, 0] == jogo[2, 0]) ||   //vitória na primeira coluna
               (jogo[0, 1] == jogo[1, 1] && jogo[1, 1] == jogo[2, 1]) ||   //vitória na segunda coluna
               (jogo[0, 2] == jogo[1, 2] && jogo[1, 2] == jogo[2, 2]) ||   //vitória na terceira coluna
               (jogo[0, 0] == jogo[1, 1] && jogo[1, 1] == jogo[2, 2]) ||   //vitória na primeira diagonal
               (jogo[0, 2] == jogo[1, 1] && jogo[1, 1] == jogo[2, 0]))     //vitória na segunda diagonal
            {
                x = false;
                Console.WriteLine("O jogador usando " + xouO + " ganhou");
            }
            return x;
        }
    }
}
