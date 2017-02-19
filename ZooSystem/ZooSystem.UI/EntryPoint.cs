namespace ZooSystem.UI
{

    using System;

    using BLL.Entities.Animals;
    using BLL.Entities.Animals.Birds;
    using BLL.Entities.Keepers;
    using BLL.Entities.Zoo;
    using BLL.Entities.Animals.Carnivore;
    using BLL.Entities.Animals.Herbivore;
    using BLL.Entities.Animals.Mammals;
    using Common;

    public class EntryPoint
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            InitializeZoo(zoo);

        }

        /// <summary>
        /// Initialize zoo.
        /// </summary>
        /// <param name="zoo"></param>
        private static void InitializeZoo(Zoo zoo)
        {
            Console.WriteLine("Welcome to the best Zoo!");

            // Birds

            Animal macawParrot = new Parrot("Jerome", 1);
            Animal caiqueParrot = new Parrot("Austin", 2);
            zoo.AddAnimal(macawParrot);
            zoo.AddAnimal(caiqueParrot);

            // Carnivore

            Animal africanLion = new Lion("Connor", 7);
            Animal caveLion = new Lion("Sly", 4);
            zoo.AddAnimal(africanLion);
            zoo.AddAnimal(caveLion);

            // Herbivore

            Animal reindeer = new Deer("Lora", 2);
            Animal blackTailedDeer = new Deer("Ann", 4);
            zoo.AddAnimal(reindeer);
            zoo.AddAnimal(blackTailedDeer);

            // Mammals

            Animal alpineGoat = new Goat("Merry", 1);
            Animal boerGoat = new Goat("Carrie", 6);
            zoo.AddAnimal(alpineGoat);
            zoo.AddAnimal(boerGoat);

            // Keepers

            // var keeperLevel = GenerateRandomKeeperLevel.GenerateRandomLevel<Level>();
            
            Keeper noviceKeeper = new Keeper(1, Level.Novice);
            Keeper intermediateKeeper = new Keeper(2, Level.Intermediate);
            Keeper advancedKeeper = new Keeper(3, Level.Advanced);
            Keeper expertKeeper = new Keeper(4, Level.Expert);
            zoo.AppointKeeper(noviceKeeper);
            zoo.AppointKeeper(intermediateKeeper);
            zoo.AppointKeeper(advancedKeeper);
            zoo.AppointKeeper(expertKeeper);

            
            // Assign animals to protect

            noviceKeeper.ProtectAnimal(macawParrot);
            noviceKeeper.ProtectAnimal(blackTailedDeer);

            intermediateKeeper.ProtectAnimal(boerGoat);
            intermediateKeeper.ProtectAnimal(alpineGoat);

            advancedKeeper.ProtectAnimal(caiqueParrot);
            advancedKeeper.ProtectAnimal(reindeer);

            expertKeeper.ProtectAnimal(africanLion);
            expertKeeper.ProtectAnimal(caveLion);

            zoo.AppointKeeper(noviceKeeper);
            zoo.AppointKeeper(intermediateKeeper);
            
            for (int i = 0; i < 10; i++)
            {
                zoo.Run();
                Console.WriteLine("=========================================");
            }
        }
    }
}
