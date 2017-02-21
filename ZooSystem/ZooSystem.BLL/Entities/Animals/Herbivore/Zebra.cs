namespace ZooSystem.BLL.Entities.Animals.Mammals
{
    using System;

    public class Zebra : Animal
    {

        private const byte averageLifeSpan = 40;

        private const string ZebraSpeech = "Auuauuauuau!";

        /// <summary>
        /// Initializes a new instance of the <see cref="Zebra"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Zebra(int id, string name, int age)
            : base(id, name, age, averageLifeSpan)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zebra"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="birthDay"></param>
        public Zebra(int id, string name, int age, DateTime birthDay)
            : base(id, name, age, averageLifeSpan, birthDay)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zebra"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="stamina"></param>
        /// <param name="birthDay"></param>
        public Zebra(int id, string name, int age, int stamina, DateTime birthDay)
            : base(id, name, age, stamina, averageLifeSpan, birthDay)
        {

        }

        public override Species Specie
        {
            get { return Species.Herbivore; }
        }

        /// <summary>
        /// Feeds the zebra.
        /// </summary>
        /// <param name="food"></param>
        public override void Eat(AnimalFood food)
        {
            if (food.Type != FoodType.Milk)
            {
                Console.WriteLine("Throw some grass to the zebras!");
                return;

            }

            Console.WriteLine(
                    "Zebra {0} got fresh grass and increased its stamina with {1}.",
                    this.Name, food.RegenerateStamina());

            this.IncreaseStamina(food.RegenerateStamina());
        }

        /// <summary>
        /// Introduces zebra.
        /// </summary>
        /// <returns></returns>
        public override string Speak()
        {
            return string.Format("Zebra {0} says {1}:", this.Name, ZebraSpeech);
        }
    }
}
