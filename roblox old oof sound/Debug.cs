using System;
using System.Threading;

namespace roblox_old_oof_sound
{
    class Debug
    {
        public static void Log(string message, ConsoleColor color = ConsoleColor.Gray)
        {
            ConsoleColor old = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = old;
        }

        public static void Success(string message)
        {
            Log($"[+] {message}", ConsoleColor.Green);
        }

        public static void Error(string message)
        {
            Log($"[-] {message}", ConsoleColor.Red);
        }

        public static void Info(string message)
        {
            Log($"[!] {message}", ConsoleColor.Cyan);
        }

        public static void Input(string message)
        {
            Log($"[?] {message}", ConsoleColor.Blue);
        }

        public static void Typewriter(string message, ConsoleColor color = ConsoleColor.Gray)
        {
            ConsoleColor old = Console.ForegroundColor;
            Console.ForegroundColor = color;
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(50);
            }
            Console.ForegroundColor = old;
        }
    }
}
