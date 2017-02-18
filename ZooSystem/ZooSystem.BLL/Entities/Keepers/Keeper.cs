namespace ZooSystem.BLL.Entities.Keepers
{

    using System;
    using System.Collections.Generic;

    using Animals;

    public sealed class Keeper
    {
        private int id;

        private IList<Animal> animalsToGuard;

        private Random generateFoodQuantity;
        
        public Level Level { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Keeper"/> class.
        /// </summary>
        /// <param name="name"></param>
        public Keeper(int id, Level level)
        {
            this.Level = level;
            this.Id = id;
            this.animalsToGuard = new List<Animal>();
            this.generateFoodQuantity = new Random();
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        public IList<Animal> Animals
        {
            get { return new List<Animal>(animalsToGuard); }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The keeper should guard at least two animals.");
                }
                this.animalsToGuard = new List<Animal>(value);
            }
        }
        
        /// <summary>
        /// Adds animal the keeper should protect.
        /// </summary>
        /// <param name="animal"></param>
        public void ProtectAnimal(Animal animal)
        {
            animal.KeeperId = this.id;
            this.animalsToGuard.Add(animal);
        }

        /// <summary>
        /// Feed an animal.
        /// </summary>
        /// <param name="animal"></param>
        public void FeedAnimal(Animal animal)
        {
            if (!animal.IsAlive())
            {
                return;
            }

            switch (animal.Specie)
            {
                case Species.Herbivore:
                    AnimalFood herbivoreFood = 
                        new AnimalFood(FoodType.Grass,(uint)generateFoodQuantity.Next(1, 5));
                    animal.Eat(herbivoreFood);
                    break;

                case Species.Mammal:
                    AnimalFood mammalFood = 
                        new AnimalFood(FoodType.Milk, (uint)generateFoodQuantity.Next(1, 5));
                    animal.Eat(mammalFood);
                    break;

                case Species.Bird:
                    AnimalFood birdFood = 
                        new AnimalFood(FoodType.Crackers, (uint)generateFoodQuantity.Next(1, 5));
                    animal.Eat(birdFood);
                    break;

                case Species.Carnivore:
                    AnimalFood carnivoreFood = 
                        new AnimalFood(FoodType.Meat, (uint)generateFoodQuantity.Next(1, 5));
                    animal.Eat(carnivoreFood);
                    break;

                default:
                    break;
            }
        }

    }
}
