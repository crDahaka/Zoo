namespace ZooSystem.BLL.Entities.Animals.Herbivore
{
    using System;

    public class Deer : Animal
    {
        private const byte averageLifeSpan = 13;

        private const string DeerSpeech = "BEEEEEEE!";

        /// <summary>
        /// Initializes a new instance of the <see cref="Deer"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Deer(string name, int age)
            :base(name, age, averageLifeSpan)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Deer"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="birthDay"></param>
        public Deer(string name, int age, DateTime birthDay)
            :base(name, age, averageLifeSpan, birthDay)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Deer"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="stamina"></param>
        /// <param name="birthDay"></param>
        public Deer(string name, int age, int stamina, DateTime birthDay)
            :base(name, age, stamina, averageLifeSpan, birthDay)
        {

        }

        public override Species Specie
        {
            get { return Species.Herbivore; }
        }

        /// <summary>
        /// Feeds the goat.
        /// </summary>
        /// <param name="food"></param>
        public override void Eat(AnimalFood food)
        {
            if (food.Type != FoodType.Grass)
            {
                Console.WriteLine("Deers eat only grass.");
                return;

            }

            Console.WriteLine(
                    "Deer {0} ate some fresh grass and increased its stamina with {1}.",
                    this.Name, food.RegenerateStamina());

            this.IncreaseStamina(food.RegenerateStamina());
        }

        /// <summary>
        /// Introduces goat.
        /// </summary>
        /// <returns></returns>
        public override string Speak()
        {
            return string.Format("Deer {0} says {1}:", this.Name, DeerSpeech);
        }
    }
}
