namespace ZooSystem.BLL.Entities.Keepers
{
    using Animals;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class Keeper
    {
        private string name;
        private ICollection<Animal> animalsToGuard;

        public Keeper(string name)
        {
            this.Name = name;
            this.animalsToGuard = new Collection<Animal>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name cannot be null.");
                }
                this.name = value;
            }
        }
        

        public void FeedAnimal()
        {

        }

    }
}
