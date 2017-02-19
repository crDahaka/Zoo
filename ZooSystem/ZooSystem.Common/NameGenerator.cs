namespace ZooSystem.Common
{
    using System;
    using System.Linq;

    public class NameGenerator
    {

        private static Random nameGenerate = new Random();

        public static string GenerateAnimalName(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[nameGenerate.Next(s.Length)]).ToArray());
        }

    }
}
