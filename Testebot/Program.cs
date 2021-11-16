using System;
using System.IO;

namespace Testebot
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = (@"C:\Users\Downloads");
            string path2 = (@"C:\Users\\OneDrive\Imagens\BotFolder\");

            string[] typeFile = new string[3]{ "*.jpg", "*.png", "*.jpeg" };

            for (int i = 0; i < typeFile.Length; i++)
            {
                foreach (string file in Directory.EnumerateFiles(path1, typeFile[i]))
                {
                    string contents = File.ReadAllText(file);
                    File.Copy(file, path2 + Path.GetFileName(file));
                    File.Delete(file);

                }
            }

        }
    }
}
