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

        private int cycle = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zoo"/> class.
        /// </summary>
        public Zoo()
        {
            this.animals = new List<Animal>();
            this.keepers = new List<Keeper>();
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
        /// Forces animals to get tired.
        /// </summary>
        public void ForceAnimalsToGetTired()
        {
            foreach (Animal animal in this.animals)
            {
                animal.DecreaseStamina(15);
            }

            this.cycle += 1;
        }

        /// <summary>
        /// Triggers cycle.
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Welcome to the best Zoo!");
            Console.WriteLine("Cycle : {0}", this.cycle + 1);

            ForceAnimalsToGetTired();
        }
    }
}
