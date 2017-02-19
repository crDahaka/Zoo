namespace ZooSystem.Common
{
    using System;

    public class GenerateRandomKeeperLevel
    {
        public static Random random = new Random();

        public static T GenerateRandomLevel<T>()
        {
            Array values = Enum.GetValues(typeof(T));
            Random random = new Random();
            T randomBar = (T)values.GetValue(random.Next(values.Length));

            return randomBar;
        }
    }
}
