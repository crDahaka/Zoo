namespace ZooSystem.BLL.Entities.Animals
{
    using System;

    public abstract class Animal
    {
        private int id;

        private string name;

        private int age;

        private int stamina;

        private int lifeExpectancy;

        private Species specie;

        private DateTime birthDate;

        private const byte DefaultStamina = 100;

        private Random staminaDecreasePointsGenerator;


        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="lifeExpectancy"></param>
        public Animal(int id, string name, int age, int lifeExpectancy)
            :this(id, name, age, DefaultStamina, lifeExpectancy, new DateTime())
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="lifeExpectancy"></param>
        /// <param name="birthDay"></param>
        public Animal(int id, string name, int age, int lifeExpectancy, DateTime birthDay)
            :this(id, name, age, DefaultStamina, lifeExpectancy, birthDay)
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
        public Animal(int id, string name, int age, int stamina, int lifeExpectancy, DateTime birthDate)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Stamina = stamina;
            this.lifeExpectancy = lifeExpectancy;
            this.BirthDate = birthDate;
            this.staminaDecreasePointsGenerator = new Random();
        }

        public virtual string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null.");
                }

                this.name = value;
            }
        }

        public virtual int Age
        {
            get { return this.age; }
            private set
            {
                if (age >= 0)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Please enter a valid age.");
                }
            }
        }

        public virtual DateTime BirthDate
        {
            get { return this.birthDate; }
            private set
            {
                this.birthDate = value;
            }

        }

        public virtual int Stamina
        {
            get { return this.stamina; }
            private set
            {
                this.stamina = value;
                if (stamina <= 0)
                {
                    Console.WriteLine("{0} is dead.", this.Name);
                }
            }
        }

        public abstract string Speak();

        public abstract void Eat(AnimalFood food);

        public abstract Species Specie { get; }

        public virtual int KeeperId { get; set; }

        

        public int Id
        {
            get { return this.id; }
            private set { this.id = value; }
        }

        /// <summary>
        /// Calculates the life span of an animal.
        /// </summary>
        /// <returns></returns>
        public virtual int CalculateLifeExpectancy()
        {
            var expectancy = lifeExpectancy - age;
            return expectancy;
        }

        /// <summary>
        /// Returns bool.
        /// </summary>
        /// <returns></returns>
        public virtual bool IsActive()
        {
            return Stamina > 0;
        }

        /// <summary>
        /// Returns bool.
        /// </summary>
        /// <returns></returns>
        public virtual bool IsAlive()
        {
            if (lifeExpectancy - this.age > 0)
            {
                return true;
            }
            return false;
        }
        
       
        /// <summary>
        /// Increase animal stamina.
        /// </summary>
        /// <param name="increaseStaminaPoints"></param>
        public virtual void IncreaseStamina(int increaseStaminaPoints)
        {
            this.Stamina += increaseStaminaPoints;
            if (Stamina > DefaultStamina)
            {
                this.Stamina = 100;
            }
        }

        /// <summary>
        /// Decrease animal stamina.
        /// </summary>
        public virtual void DecreaseStamina()
        {
            var decreasePoints = this.staminaDecreasePointsGenerator.Next(1, 20);
            Console.WriteLine(string.Format("{0}'s stamina has been decreased by {1}",
                this.Name, decreasePoints));

            this.Stamina -= decreasePoints;
            if (Stamina < 0)
            {
                this.Stamina = 0;
            }
        }

        /// <summary>
        /// Forces animal to get tired.
        /// </summary>
        public virtual void ForceAnimalToGetTired()
        {
            var decreasePoints = this.staminaDecreasePointsGenerator.Next(1, 20);

            Console.WriteLine(
                "Animal {0} enjoyed the numerous visitors and he got tired. Stamina decreased by: {1}",
                this.Name, decreasePoints);
            this.Stamina -= decreasePoints;
        }

    }
}
