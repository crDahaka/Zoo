namespace ZooSystem.BLL.Entities.Animals.Mammals
{
    using System;

    public class MuleDeer : Animal
    {
        private const sbyte averageLifeSpan = 8;

        private const string MuleDeerSpeech = "Auuuauuauuauu!";

        /// <summary>
        /// Initializes a new instance of the <see cref="MuleDeer"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public MuleDeer(int id, string name, int age)
            : base(id, name, age, averageLifeSpan)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MuleDeer"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="birthDay"></param>
        public MuleDeer(int id, string name, int age, DateTime birthDay)
            : base(id, name, age, averageLifeSpan, birthDay)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MuleDeer"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="stamina"></param>
        /// <param name="birthDay"></param>
        public MuleDeer(int id, string name, int age, int stamina, DateTime birthDay)
            : base(id, name, age, stamina, averageLifeSpan, birthDay)
        {

        }

        public override Species Specie
        {
            get { return Species.Herbivore; }
        }

        /// <summary>
        /// Feeds the mule deer.
        /// </summary>
        /// <param name="food"></param>
        public override void Eat(AnimalFood food)
        {
            if (food.Type != FoodType.Crumbs)
            {
                Console.WriteLine("Give milk to the deers!");
                return;

            }

            Console.WriteLine(
                    "Mule Deer {0} got some fresh milk and increased its stamina with {1}.",
                    this.Name, food.RegenerateStamina());

            this.IncreaseStamina(food.RegenerateStamina());
        }

        /// <summary>
        /// Introduces mule deer.
        /// </summary>
        /// <returns></returns>
        public override string Speak()
        {
            return string.Format("Monkey {0} says {1}:", this.Name, MuleDeerSpeech);
        }
    }
}
