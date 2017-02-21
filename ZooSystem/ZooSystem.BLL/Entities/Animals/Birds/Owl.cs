namespace ZooSystem.BLL.Entities.Animals.Birds
{
    using System;

    public class Owl : Animal
    {
        private const sbyte averageLifeSpan = 10;

        private const string DuckSpeech = "hhhhrrrroarr!";

        /// <summary>
        /// Initializes a new instance of the <see cref="Owl"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Owl(int id, string name, int age)
            : base(id, name, age, averageLifeSpan)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Owl"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="birthDay"></param>
        public Owl(int id, string name, int age, DateTime birthDay)
            : base(id, name, age, averageLifeSpan, birthDay)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Owl"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="stamina"></param>
        /// <param name="birthDay"></param>
        public Owl(int id, string name, int age, int stamina, DateTime birthDay)
            : base(id, name, age, stamina, averageLifeSpan, birthDay)
        {

        }

        public override Species Specie
        {
            get { return Species.Bird; }
        }

        /// <summary>
        /// Feeds the owl.
        /// </summary>
        /// <param name="food"></param>
        public override void Eat(AnimalFood food)
        {
            if (food.Type != FoodType.Crumbs)
            {
                Console.WriteLine("Give crackers to the owl!");
                return;

            }

            Console.WriteLine(
                    "Owl {0} eated tasty crackers and increased its stamina with {1}.",
                    this.Name, food.RegenerateStamina());

            this.IncreaseStamina(food.RegenerateStamina());
        }

        /// <summary>
        /// Introduces owl.
        /// </summary>
        /// <returns></returns>
        public override string Speak()
        {
            return string.Format("Owl {0} says {1}:", this.Name, DuckSpeech);
        }
    }
}
