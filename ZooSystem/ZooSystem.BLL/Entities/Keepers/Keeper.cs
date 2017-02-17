namespace ZooSystem.BLL.Entities.Keepers
{
    using Animals;
    using System;
    using System.Collections.Generic;

    public sealed class Keeper
    {
        private string name;
        private IList<Animal> animalsToGuard;

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
        /// Feed an animal.
        /// </summary>
        /// <param name="animal"></param>
        public void FeedAnimal(Animal animal)
        {

        }

    }
}
