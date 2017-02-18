namespace ZooSystem.BLL.Entities.Animals.Birds
{
    using System;

    public class Parrot : Animal
    {

        private const byte averageLifeSpan = 35;

        private const string ParrotSpeech = "Croackkkk";

        /// <summary>
        /// Initializes a new instance of the <see cref="Parrot"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Parrot(string name, int age)
            :base(name, age, averageLifeSpan)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Parrot"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="birthDay"></param>
        public Parrot(string name, int age, DateTime birthDay)
            :base(name, age, averageLifeSpan, birthDay)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Parrot"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="stamina"></param>
        /// <param name="birthDay"></param>
        public Parrot(string name, int age, int stamina, DateTime birthDay)
            :base(name, age, stamina, averageLifeSpan, birthDay)
        {

        }

        public override Species Specie
        {
            get { return Species.Bird; }
        }

        /// <summary>
        /// Feeds the parrot.
        /// </summary>
        /// <param name="food"></param>
        public override void Eat(AnimalFood food)
        {
            if (food.Type == FoodType.Crackers)
            {
                Console.WriteLine(
                    "{0} ate the best crackers in the world, and increased its stamina with {1}.",
                    this.Name, food.RegenerateStamina());

                this.IncreaseStamina(food.RegenerateStamina());
            }
            else
            {
                Console.WriteLine("The parrot eat only crackers!");
            }
            
        }

        /// <summary>
        /// Return parrot introduction.
        /// </summary>
        /// <returns></returns>
        public override string Speak()
        {
            return string.Format("Parrot {0} says {1}:", this.Name, ParrotSpeech);
        }
    }
}
