using System;

namespace Program
{
    public class Program
    {
        public static void ClearTerminal()
        {
            Console.Clear();
        }

        public static void Pause()
        {
            Console.WriteLine("Enter para continuar.");
            Console.ReadLine();
        }

        public static int Control()
        {
            Console.WriteLine("========================");
            Console.WriteLine("||      Controle      ||");
            Console.WriteLine("========================");
            Console.WriteLine("|| 1 - Ligar/Desligar ||");
            Console.WriteLine("========================");
            Console.WriteLine("|| 2 - +Volume        ||");
            Console.WriteLine("========================");
            Console.WriteLine("|| 3 - -Volume        ||");
            Console.WriteLine("========================");
            Console.WriteLine("|| 4 - +Canal         ||");
            Console.WriteLine("========================");
            Console.WriteLine("|| 5 - -Canal         ||");
            Console.WriteLine("========================");
            Console.WriteLine("|| 0 - Sair           ||");
            Console.WriteLine("========================");
            Console.WriteLine("||                    ||");
            Console.WriteLine("========================");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }

        public static void Main(string[] args)
        {
            Television television = new Television();

            int option = -1;

            do
            {
                ClearTerminal();
                Console.WriteLine(television.ToString());
                option = Control();

                switch (option)
                {
                    case 0:
                        break;

                    case 1:
                        television.ToggleIsOn();
                        break;

                    case 2:
                        bool hasIncreasedVolume = television.IncreaseVolumeByOne();
                        if (!hasIncreasedVolume)
                        {
                            ClearTerminal();
                            Console.WriteLine(
                                                        "------------------------------------------------------------------------------------");
                            Console.WriteLine(
                                    "||           Não é possível aumentar o volume com a televisão desligada.          ||");
                            Console.WriteLine(
                                    "------------------------------------------------------------------------------------");
                            Pause();
                        }
                        break;
                    case 3:
                        bool hasDecreasedVolume = television.DecreaseChannelByOne();

                        if (!hasDecreasedVolume)
                        {
                            ClearTerminal();
                            Console.WriteLine(
                                "------------------------------------------------------------------------------------");
                            Console.WriteLine(
                                    "||           Não é possível diminuir o volume com a televisão desligada.          ||");
                            Console.WriteLine(
                                    "------------------------------------------------------------------------------------");
                            Pause();
                        }
                        break;

                    case 4:
                        bool hasIncreasedChannel = television.IncreaseChannelByOne();

                        if (!hasIncreasedChannel)
                        {
                            ClearTerminal();
                            Console.WriteLine(
                                                           "------------------------------------------------------------------------------------");
                            Console.WriteLine(
                                    "||            Não é possível mudar de canal com a televisão desligada.            ||");
                            Console.WriteLine(
                                    "------------------------------------------------------------------------------------");
                            Pause();
                        }
                        break;
                    case 5:
                        bool hasDecreasedChannel = television.DecreaseChannelByOne();

                        if (!hasDecreasedChannel)
                        {
                            ClearTerminal();
                            Console.WriteLine("------------------------------------------------------------------------------------");
                            Console.WriteLine("||            Não é possível mudar de canal com a televisão desligada.            ||");
                            Console.WriteLine("------------------------------------------------------------------------------------");
                            Pause();
                        }
                        break;
                    default:
                        ClearTerminal();
                        Console.WriteLine("------------------------------------------------------------------------------------");
                        Console.WriteLine("||                                 Opção inválida.                                ||");
                        Console.WriteLine("------------------------------------------------------------------------------------");
                        Pause();
                        break;

                }

            } while (option != 0);




        }

    }
}
