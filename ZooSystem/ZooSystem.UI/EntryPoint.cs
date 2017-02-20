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
    using DAL;

    public class EntryPoint
    {
        static void Main(string[] args)
        {
            
            InitializeZoo();

        }

        /// <summary>
        /// Initialize zoo.
        /// </summary>
        /// <param name="zoo"></param>
        private static void InitializeZoo()
        {
            Console.WriteLine("Welcome to the best Zoo!");

            
            AnimalRepository animalRepository = new AnimalRepository();

            // Birds

            Animal macawParrot = new Parrot("Jerome", 1);
            Animal caiqueParrot = new Parrot("Austin", 2);
            animalRepository.Add(macawParrot);
            animalRepository.Add(caiqueParrot);

            // Carnivore

            Animal africanLion = new Lion("Connor", 7);
            Animal caveLion = new Lion("Sly", 4);
            animalRepository.Add(africanLion);
            animalRepository.Add(caveLion);

            // Herbivore

            Animal reindeer = new Deer("Lora", 2);
            Animal blackTailedDeer = new Deer("Ann", 4);
            animalRepository.Add(reindeer);
            animalRepository.Add(blackTailedDeer);

            // Mammals

            Animal alpineGoat = new Goat("Merry", 1);
            Animal boerGoat = new Goat("Carrie", 6);
            animalRepository.Add(alpineGoat);
            animalRepository.Add(boerGoat);

            // Keepers

            // var keeperLevel = GenerateRandomKeeperLevel.GenerateRandomLevel<Level>();

            KeeperRepository keeperRepository = new KeeperRepository();
            
            Keeper noviceKeeper = new Keeper(1, Level.Novice);
            Keeper intermediateKeeper = new Keeper(2, Level.Intermediate);
            Keeper advancedKeeper = new Keeper(3, Level.Advanced);
            Keeper expertKeeper = new Keeper(4, Level.Expert);
            keeperRepository.Add(noviceKeeper);
            keeperRepository.Add(intermediateKeeper);
            keeperRepository.Add(advancedKeeper);
            keeperRepository.Add(expertKeeper);


            // Assign animals to protect

            noviceKeeper.ProtectAnimal(macawParrot);
            noviceKeeper.ProtectAnimal(blackTailedDeer);

            intermediateKeeper.ProtectAnimal(boerGoat);
            intermediateKeeper.ProtectAnimal(alpineGoat);

            advancedKeeper.ProtectAnimal(caiqueParrot);
            advancedKeeper.ProtectAnimal(reindeer);

            expertKeeper.ProtectAnimal(africanLion);
            expertKeeper.ProtectAnimal(caveLion);

            var animals = animalRepository.GetAll();
            var keepers = keeperRepository.GetAll();

            Zoo zoo = new Zoo(animals, keepers);

            for (int i = 0; i < 10; i++)
            {
                zoo.Run();
                Console.WriteLine("=========================================");
            }
        }
    }
}
