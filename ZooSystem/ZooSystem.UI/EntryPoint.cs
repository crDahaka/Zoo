namespace ZooSystem.UI
{

    using System;

    using BLL.Entities.Animals;
    using BLL.Entities.Animals.Birds;
    using BLL.Entities.Keepers;
    using BLL.Entities.Zoo;
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

            Animal parrot = new Parrot(1,"Jerome", 1);
            Animal duck = new Duck(2, "Austin", 2);
            Animal owl = new Owl(3, "Braxton", 1);
            animalRepository.Add(parrot);
            animalRepository.Add(duck);
            animalRepository.Add(owl);
            
            // Mammals

            Animal lion = new Lion(3, "Connor", 7);
            Animal goat = new Goat(4, "Sly", 4);
            Animal monkey = new Monkey(5, "Gorilaz", 3);
            animalRepository.Add(lion);
            animalRepository.Add(goat);
            animalRepository.Add(monkey);

            // Herbivore

            Animal deer = new Deer(7,"Lora", 2);
            Animal muleDeer = new MuleDeer(8, "Ann", 4);
            Animal zebra = new Zebra(9, "Jane", 9);
            animalRepository.Add(deer);
            animalRepository.Add(muleDeer);
            animalRepository.Add(zebra);
            
            // Keepers

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

            noviceKeeper.ProtectAnimal(parrot);
            noviceKeeper.ProtectAnimal(zebra);

            intermediateKeeper.ProtectAnimal(duck);
            intermediateKeeper.ProtectAnimal(lion);

            advancedKeeper.ProtectAnimal(muleDeer);
            advancedKeeper.ProtectAnimal(owl);

            expertKeeper.ProtectAnimal(deer);
            expertKeeper.ProtectAnimal(monkey);

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
