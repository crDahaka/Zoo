namespace ZooSystem.BLL.Entities.Animals.Mammals
{
    using System;

    public class Goat : Animal
    {

        private const byte averageLifeSpan = 13;

        private const string GoatSpeech = "BEEEEEEE!";

        /// <summary>
        /// Initializes a new instance of the <see cref="Goat"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Goat(int id, string name, int age)
            :base(id, name, age, averageLifeSpan)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Goat"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="birthDay"></param>
        public Goat(int id, string name, int age, DateTime birthDay)
            :base(id, name, age, averageLifeSpan, birthDay)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Goat"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="stamina"></param>
        /// <param name="birthDay"></param>
        public Goat(int id, string name, int age, int stamina, DateTime birthDay)
            :base(id, name, age, stamina, averageLifeSpan, birthDay)
        {

        }

        public override Species Specie
        {
            get { return Species.Mammal; }
        }

        /// <summary>
        /// Feeds the goat.
        /// </summary>
        /// <param name="food"></param>
        public override void Eat(AnimalFood food)
        {
            if (food.Type != FoodType.Milk)
            {
                Console.WriteLine("Feed the goats only with milk.");
                return;

            }

            Console.WriteLine(
                    "Goat {0} drunk milk and increased its stamina with {1}.",
                    this.Name, food.RegenerateStamina());

            this.IncreaseStamina(food.RegenerateStamina());
        }

        /// <summary>
        /// Introduces goat.
        /// </summary>
        /// <returns></returns>
        public override string Speak()
        {
            return string.Format("Goat {0} says {1}:", this.Name, GoatSpeech);
        }
    }
}
