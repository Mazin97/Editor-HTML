using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static short option { get; set; }

        public static void Show()
        {
            ConfigureConsole();
            DrawSquare();
            WriteOptions();

            if (short.TryParse(Console.ReadLine(), out short selected))
                option = selected;

            HandleMenuOption();
        }

        private static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.Write("Editor HTML");

            Console.SetCursorPosition(2, 3);
            Console.Write("=============================");

            Console.SetCursorPosition(3, 4);
            Console.Write("Selecione uma opção abaixo:");

            Console.SetCursorPosition(3, 5);
            Console.Write("1. Novo Arquivo");

            Console.SetCursorPosition(3, 7);
            Console.Write("0. Sair");

            Console.SetCursorPosition(3, 8);
            Console.Write("Opção:");
        }

        private static void ConfigureConsole()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
        }

        private static void DrawSquare()
        {
            DrawColumn();

            for (int i = 0; i <= 10; i++)
                DrawLine();

            DrawColumn();
        }

        private static void DrawLine()
        {
            Console.Write("|");

            for (int i = 0; i <= 30; i++)
                Console.Write(" ");

            Console.Write("|");
            Console.Write("\n");
        }

        private static void DrawColumn()
        {
            Console.Write("+");

            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        private static void HandleMenuOption()
        {
            switch (option)
            {
                case 1:
                    Editor.Show();
                    break;
                case 2:
                    break;
                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Show();
                    break;
            }
        }
    }
}