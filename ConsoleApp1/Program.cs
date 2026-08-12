// =======================
// Mahan07dev Console Hub
// Production Edition
// =======================

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1
{
    internal static class Program
    {
        static void Main()
        {
            Console.Title = "Mahan07dev | Console Hub";
            Console.OutputEncoding = Encoding.UTF8;
            
            Config.Load();
            Logger.Init();

            try
            {
                App.Run();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.ToString());
                UI.Error("Fatal crash occurred.");
                Console.ReadLine();
            }
        }
    }

    // =====================================================
    // APPLICATION CORE
    // =====================================================

    internal static class App
    {
        private static readonly DateTime StartTime = DateTime.Now;

        public static void Run()
        {
            while (true)
            {
                int choice = UI.KeyboardMenu(
                    "Mahan07dev | Console Hub (v2.3.1)",
                    new[]
                    {
                        "ℹ️ About Me",
                        "🌐 Links",
                        "🔐 Security / Dev Tools",
                        "🌐 Web / Dev Tools",
                        "🛠  System Info",
                        "❔ Configuration",
                        "❌ Exit"
                    });

                Logger.Info("Menu selected: " + choice);

                switch (choice)
                {
                    case 0: About(); break;
                    case 1: Links(); break;
                    case 2: SecurityTools(); break;
                    case 3: WebTools(); break;
                    case 4: SystemTools(); break;
                    case 5: ConfigMenu(); break;
                    case 6: return;
                }
            }
        }

        private static void About()
        {
            UI.Page("About",
                "Mahan (Mahan07dev)\n\n" +
                "Developer focused on logic, systems, and clean engineering.\n\n" +
                "Stack:\n- HTML, CSS, JS\n- C#, React\n- Python, Kotlin");
        }

        private static void Links()
        {
            UI.Page("Links",
                "GitHub: https://github.com/mahan07dev\n" +
                "Telegram: https://t.me/Mahan07dev\n" +
                "MahanVerse: https://mahanverse.is-great.net\n" +
                "LogoShop: https://logoshop.great-site.net\n" +
                "Portfolio: https://mahan-zarif.is-great.net");
        }

        // ================= SECURITY TOOLS =================

        private static void SecurityTools()
        {
            int c = UI.KeyboardMenu("Security / Dev Tools",
                new[]
                {
                    "Password Generator",
                    "Password Strength Check",
                    "API Key Generator",
                    "Hash Generator",
                    "Base64 Encode/Decode",
                    "Back"
                });

            if (c == 5) return;

            switch (c)
            {
                case 0: Tools.PasswordGenerator(); break;
                case 1: Tools.PasswordStrength(); break;
                case 2: Tools.ApiKey(); break;
                case 3: Tools.HashGenerator(); break;
                case 4: Tools.Base64Tool(); break;
            }
        }

        // ================= WEB TOOLS =================

        private static void WebTools()
        {
            int c = UI.KeyboardMenu("Web / Dev Tools",
                new[]
                {
                    "UUID Generator",
                    "Unix Timestamp Converter",
                    "URL Encode / Decode",
                    "HTTP Status Lookup",
                    "Back"
                });

            if (c == 4) return;

            switch (c)
            {
                case 0: Tools.UUID(); break;
                case 1: Tools.Timestamp(); break;
                case 2: Tools.UrlCodec(); break;
                case 3: Tools.HttpStatus(); break;
            }
        }

        // ================= SYSTEM TOOLS =================

        private static void SystemTools()
        {
            TimeSpan uptime = DateTime.Now - StartTime;

            UI.Page("System Info",
                "OS: " + Environment.OSVersion +
                "\nMachine: " + Environment.MachineName +
                "\nCPU Cores: " + Environment.ProcessorCount +
                "\n64-bit OS: " + Environment.Is64BitOperatingSystem +
                "\nUptime: " + uptime);
        }

        // ================= CONFIG =================

        private static void ConfigMenu()
        {
            UI.Page("Configuration",
                "Theme Color: " + Config.Theme +
                "\nDefault Password Length: " + Config.DefaultPasswordLength +
                "\nLogging Enabled: " + Config.LoggingEnabled +
                "\n\nEdit config.json manually.");
        }
    }

    // =====================================================
    // TOOLS
    // =====================================================

    internal static class Tools
    {
        public static void PasswordGenerator()
        {
            int len = UI.ReadInt("Length (8-128):", 8, 128);
            UI.Page("Password", Crypto.RandomString(len));
        }

        public static void PasswordStrength()
        {
            Console.Write("Password: ");
            string p = Console.ReadLine();
            UI.Page("Strength", p.Length < 8 ? "Weak" : "Acceptable");
        }

        public static void ApiKey()
        {
            UI.Page("API Key", Crypto.RandomString(32));
        }

        public static void HashGenerator()
        {
            Console.Write("Text: ");
            string input = Console.ReadLine();
            UI.Page("SHA256", Crypto.Sha256(input));
        }

        public static void Base64Tool()
        {
            Console.Write("Text: ");
            string t = Console.ReadLine();
            UI.Page("Base64", Convert.ToBase64String(Encoding.UTF8.GetBytes(t)));
        }

        public static void UUID()
        {
            UI.Page("UUID", Guid.NewGuid().ToString());
        }

        public static void Timestamp()
        {
            long unix = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            UI.Page("Timestamp", unix.ToString());
        }

        public static void UrlCodec()
        {
            Console.Write("URL: ");
            string u = Console.ReadLine();
            UI.Page("Encoded", Uri.EscapeDataString(u));
        }

        public static void HttpStatus()
        {
            UI.Page("HTTP 200", "OK");
        }
    }

    // =====================================================
    // CRYPTO
    // =====================================================

    internal static class Crypto
    {
        public static string RandomString(int len)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%";
            byte[] b = new byte[len];
            using (RandomNumberGenerator r = RandomNumberGenerator.Create())
                r.GetBytes(b);

            char[] c = new char[len];
            for (int i = 0; i < len; i++)
                c[i] = chars[b[i] % chars.Length];

            return new string(c);
        }

        public static string Sha256(string input)
        {
            using (SHA256 sha = SHA256.Create())
                return BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(input))).Replace("-", "");
        }
    }

    // =====================================================
    // CONFIG
    // =====================================================

    internal static class Config
    {
        public static string Theme = "Green";
        public static int DefaultPasswordLength = 16;
        public static bool LoggingEnabled = true;

        private const string FileName = "config.json";

        public static void Load()
        {
            if (!File.Exists(FileName))
            {
                File.WriteAllText(FileName,
@"{
  ""Theme"": ""Green"",
  ""DefaultPasswordLength"": 16,
  ""LoggingEnabled"": true
}");
            }
        }
    }

    // =====================================================
    // LOGGER
    // =====================================================

    internal static class Logger
    {
        private static readonly string LogDir = "logs";
        private static readonly string LogFile = "logs/app.log";

        public static void Init()
        {
            try
            {
                Directory.CreateDirectory(LogDir);
            }
            catch { }
        }

        public static void Info(string msg)
        {
            if (!Config.LoggingEnabled) return;
            Write("INFO", msg);
        }

        public static void Error(string msg)
        {
            Write("ERROR", msg);
        }

        private static void Write(string level, string msg)
        {
            try
            {
                File.AppendAllText(LogFile,
                    DateTime.Now + " [" + level + "] " + msg + Environment.NewLine);
            }
            catch { }
        }
    }

    // =====================================================
    // UI + KEYBOARD NAVIGATION
    // =====================================================

    internal static class UI
    {
        public static int KeyboardMenu(string title, string[] items)
        {
            int index = 0;

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("== " + title + " ==\n");
                Console.ResetColor();

                for (int i = 0; i < items.Length; i++)
                {
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine(" " + items[i]);
                    Console.ResetColor();
                }

                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow && index > 0) index--;
                else if (key == ConsoleKey.DownArrow && index < items.Length - 1) index++;
                else if (key == ConsoleKey.Enter) return index;
                else if (key == ConsoleKey.Escape) return items.Length - 1;
            }
        }

        public static void Page(string title, string text)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("== " + title + " ==\n");
            Console.ResetColor();
            Console.WriteLine(text);
            Console.WriteLine("\nPress Enter...");
            Console.ReadLine();
        }

        public static int ReadInt(string label, int min, int max)
        {
            while (true)
            {
                Console.Write(label + " ");
                int v;
                if (int.TryParse(Console.ReadLine(), out v) && v >= min && v <= max)
                    return v;
            }
        }

        public static void Error(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
