namespace ZooSystem.BLL.Entities.Zoo
{

    using System;
    using System.Collections.Generic;

    using Animals;
    using Keepers;

    public sealed class Zoo
    {
        private IList<Animal> animals;
        private IList<Keeper> keepers;

        private Random staminaDecreasePointsGenerator;

        private uint cycle = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zoo"/> class.
        /// </summary>
        public Zoo()
        {
            this.animals = new List<Animal>();
            this.keepers = new List<Keeper>();
            this.staminaDecreasePointsGenerator = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zoo"/> class.
        /// </summary>
        /// <param name="animals"></param>
        public Zoo(IList<Animal> animals)
        {
            this.Animals = new List<Animal>(animals);
            this.Keepers = new List<Keeper>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zoo"/> class.
        /// </summary>
        /// <param name="animals"></param>
        /// <param name="keepers"></param>
        public Zoo(IList<Animal> animals, IList<Keeper> keepers)
        {
            this.Animals = animals;
            this.Keepers = keepers;
        }

        public IList<Animal> Animals
        {
            get { return new List<Animal>(animals); }
            set
            {
                this.animals = new List<Animal>(value);
            }
        }

        public IList<Keeper> Keepers
        {
            get { return new List<Keeper>(keepers); }
            set
            {
                this.keepers = new List<Keeper>(value);
            }
        }

        /// <summary>
        /// Appoints new keeper.
        /// </summary>
        /// <param name="keeper"></param>
        public void AppointKeeper(Keeper keeper)
        {
            this.keepers?.Add(keeper);
        }

        /// <summary>
        /// Adds new animal in the zoo.
        /// </summary>
        /// <param name="animal"></param>
        public void AddAnimal(Animal animal)
        {
            this.animals?.Add(animal);
        }

        /// <summary>
        /// Forces animals to get tired.
        /// </summary>
        public void ForceAnimalsToGetTired()
        {
            foreach (Animal animal in this.animals)
            {
                var decreasePoints = this.staminaDecreasePointsGenerator.Next(10, 30);

                animal.DecreaseStamina(decreasePoints);
                
            }
            
        }

        /// <summary>
        /// Triggers cycle.
        /// </summary>
        public void Run()
        {
            //TODO:
            // check if animal is dead
            // dont decrease stamina

            Console.WriteLine("Welcome to the best Zoo!");
            Console.WriteLine("Cycle : {0}", this.cycle + 1);

            foreach (Keeper keeper in this.keepers)
            {
                if (keeper.Animals.Count < 2)
                {
                    throw new ArgumentException(
                        "Each keeper should have at least 2 assigned animals to protect.");
                }

                foreach (Animal animal in keeper.Animals)
                {

                    if (keeper.Level == Level.Novice || keeper.Level == Level.Intermediate)
                    {
                        Console.WriteLine(
                            "Keeper with ID:{0} cannot feed animal {1}, due to low level. ",
                            keeper.Id, animal.Name);
                    }
                    
                    animal.Age++;
                    keeper.FeedAnimal(animal);
                }
            }


            ForceAnimalsToGetTired();
            
            this.cycle += 1;
        }
    }
}
