namespace ZooSystem.BLL.Entities.Animals.Birds
{
    using System;

    public class Duck : Animal
    {
        private const sbyte averageLifeSpan = 10;

        private const string DuckSpeech = "Quakkk!";

        /// <summary>
        /// Initializes a new instance of the <see cref="Duck"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Duck(int id, string name, int age)
            :base(id, name, age, averageLifeSpan)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Duck"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="birthDay"></param>
        public Duck(int id, string name, int age, DateTime birthDay)
            :base(id, name, age, averageLifeSpan, birthDay)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Duck"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="stamina"></param>
        /// <param name="birthDay"></param>
        public Duck(int id, string name, int age, int stamina, DateTime birthDay)
            :base(id, name, age, stamina, averageLifeSpan, birthDay)
        {

        }

        public override Species Specie
        {
            get { return Species.Mammal; }
        }

        /// <summary>
        /// Feeds the duck.
        /// </summary>
        /// <param name="food"></param>
        public override void Eat(AnimalFood food)
        {
            if (food.Type != FoodType.Crumbs)
            {
                Console.WriteLine("Give crackers to the duck!");
                return;

            }

            Console.WriteLine(
                    "Duck {0} got some fresh crackers and increased its stamina with {1}.",
                    this.Name, food.RegenerateStamina());

            this.IncreaseStamina(food.RegenerateStamina());
        }

        /// <summary>
        /// Introduces duck.
        /// </summary>
        /// <returns></returns>
        public override string Speak()
        {
            return string.Format("Duck {0} says {1}:", this.Name, DuckSpeech);
        }
    }
}
