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

        private DateTime birthDate;

        private const sbyte DefaultStamina = 100;


        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="lifeExpectancy"></param>
        public Animal(string name, int age, int lifeExpectancy)
            :this(name, age, DefaultStamina, lifeExpectancy, new DateTime())
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="lifeExpectancy"></param>
        /// <param name="birthDay"></param>
        public Animal(string name, int age, int lifeExpectancy, DateTime birthDay)
            :this(name, age, DefaultStamina, lifeExpectancy, birthDay)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="stamina"></param>
        /// <param name="lifeExpectancy"></param>
        /// <param name="birthDate"></param>
        public Animal(string name, int age, int stamina, int lifeExpectancy, DateTime birthDate)
        {
            this.Name = name;
            this.Age = age;
            this.Stamina = stamina;
            this.lifeExpectancy = lifeExpectancy;
            this.BirthDate = birthDate;
        }

        public string Name
        {
            get { return this.Name; }
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
            get { return this.Age; }
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

        public DateTime BirthDate
        {
            get { return this.birthDate; }
            set
            {
                this.birthDate = value;
            }

        }

        public int Stamina
        {
            get { return this.stamina; }
            set
            {
                this.stamina = value;
                if (stamina <= 0)
                {
                    Console.WriteLine("{0} is dead.", this.Name);
                }
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


        public abstract string Speak();

        public abstract string Eat();

        public abstract Species Specie { get; }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decreaseStaminaPoints"></param>
        public void DecreaseStamina(int decreaseStaminaPoints)
        {
            this.Stamina -= decreaseStaminaPoints;
            if (Stamina < 0)
            {
                this.Stamina = 0;
            }
        }

        /// <summary>
        /// Increases animal stamina
        /// </summary>
        /// <param name="increaseStaminaPoints"></param>
        public void IncreaseStamina(int increaseStaminaPoints)
        {
            this.Stamina += increaseStaminaPoints;
            if (Stamina > DefaultStamina)
            {
                this.Stamina = 100;
            }
        }
    }
}
