namespace ZooSystem.BLL.Entities.Animals.Mammals
{
    using System;

    public class Monkey : Animal
    {
        private const sbyte averageLifeSpan = 35;

        private const string MonkeySpeech = "HuhahuHhuahua!";

        /// <summary>
        /// Initializes a new instance of the <see cref="Monkey"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Monkey(int id, string name, int age)
            :base(id, name, age, averageLifeSpan)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Monkey"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="birthDay"></param>
        public Monkey(int id, string name, int age, DateTime birthDay)
            :base(id, name, age, averageLifeSpan, birthDay)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Monkey"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="stamina"></param>
        /// <param name="birthDay"></param>
        public Monkey(int id, string name, int age, int stamina, DateTime birthDay)
            :base(id, name, age, stamina, averageLifeSpan, birthDay)
        {

        }

        public override Species Specie
        {
            get { return Species.Mammal; }
        }

        /// <summary>
        /// Feeds the monkey.
        /// </summary>
        /// <param name="food"></param>
        public override void Eat(AnimalFood food)
        {
            if (food.Type != FoodType.Crumbs)
            {
                Console.WriteLine("Give milk to the monkeys!");
                return;

            }

            Console.WriteLine(
                    "Monkey {0} got some fresh milk and increased its stamina with {1}.",
                    this.Name, food.RegenerateStamina());

            this.IncreaseStamina(food.RegenerateStamina());
        }

        /// <summary>
        /// Introduces monkey.
        /// </summary>
        /// <returns></returns>
        public override string Speak()
        {
            return string.Format("Monkey {0} says {1}:", this.Name, MonkeySpeech);
        }
    }
}
