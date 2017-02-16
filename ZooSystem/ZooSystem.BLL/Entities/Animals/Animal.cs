namespace ZooSystem.BLL.Entities.Animals
{
    using System;

    public abstract class Animal
    {

        private string name;

        private int age;

        private int stamina;

        private int lifeExpectancy;

        private Species specie;

        private DateTime? birthDate;

        private const int DefaultStamina = 100;
        private const int DefaultStaminaDecrease = 15;

        // private bool isActive = true;
        // private bool isDead = false;


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
                    throw new ArgumentException("Name cannot be null.");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= int.MaxValue && value < int.MaxValue)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Please enter a valid age.");
                }
            }
        }

        public Species Specie
        {
            get
            {
                return this.specie;
            }
            set
            {
                this.specie = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return this.BirthDate;
            }
            set
            {
                this.birthDate = value;
            }
        }
        
        /// <summary>
        /// Calculates the life span of an animal.
        /// </summary>
        /// <returns></returns>
        public int CalculateLifeExpectancy()
        {
            var expectancy = lifeExpectancy - age;
            return expectancy;
        }

        public virtual int Stamina { get; private set; }

        
        public abstract string Speak();
        public abstract string Eat();

        /// <summary>
        /// Decreases stamina. 
        /// </summary>
        public void ReduceStamina()
        {
            this.Stamina -= DefaultStaminaDecrease;
        }

        /// <summary>
        /// Returns bool.
        /// </summary>
        /// <returns></returns>
        public bool IsActive()
        {
            return Stamina > 0;
        }

        /// <summary>
        /// Returns bool.
        /// </summary>
        /// <returns></returns>
        public bool IsAlive()
        {
            return lifeExpectancy > 0;
        } 
    }
}
