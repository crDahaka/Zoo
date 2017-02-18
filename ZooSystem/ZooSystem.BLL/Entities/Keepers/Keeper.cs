namespace ZooSystem.BLL.Entities.Keepers
{

    using System;
    using System.Collections.Generic;

    using Animals;

    public sealed class Keeper
    {
        private string name;
        private IList<Animal> animalsToGuard;

        /// <summary>
        /// Initializes a new instance of the <see cref="Keeper"/> class.
        /// </summary>
        /// <param name="name"></param>
        public Keeper(string name)
        {
            this.Name = name;
            this.animalsToGuard = new List<Animal>();
        }

        public string Name
        {
            get { return this.Name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name cannot be null.");
                }
                this.name = value;
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
            animal.KeeperName = this.Name;
            this.animalsToGuard?.Add(animal);
        }

        /// <summary>
        /// Feed an animal.
        /// </summary>
        /// <param name="animal"></param>
        public void FeedAnimal(Animal animal)
        {

        }

    }
}
