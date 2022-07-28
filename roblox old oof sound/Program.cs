using System;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.Win32;

namespace roblox_old_oof_sound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!isRobloxInstalled())
            {
                Debug.Error("Roblox is not installed");
            }

            Debug.Log("This tool has been made by $Pieseł$#2035, feel free to use (even copy idc)", ConsoleColor.Blue);

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\roblox-player");

            string path = key.GetValue("InstallLocation").ToString();

            Debug.Typewriter("Roblox found, replacing sound...\n", ConsoleColor.Cyan);

            Thread.Sleep(1000);

            File.WriteAllBytes(path + @"\content\sounds\ouch.ogg", Properties.Resources.ouch);

            Debug.Typewriter("Sound replaced!", ConsoleColor.Cyan);

            Thread.Sleep(1000);
            Environment.Exit(0);
        }

        private static Boolean isRobloxInstalled()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            if (key != null)
            {
                foreach (RegistryKey subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    string name = subkey.Name;
                    if (name != null && name.Contains("roblox-player"))
                    {
                        return true;
                    }
                }
                key.Close();
            }

            return false;
        }
    }
}
