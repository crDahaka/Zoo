﻿namespace ZooSystem.BLL.Entities.Animals.Mammals
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
        public Deer(int id, string name, int age)
            : base(id, name, age, averageLifeSpan)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Deer"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="birthDay"></param>
        public Deer(int id, string name, int age, DateTime birthDay)
            : base(id, name, age, averageLifeSpan, birthDay)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Deer"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="stamina"></param>
        /// <param name="birthDay"></param>
        public Deer(int id, string name, int age, int stamina, DateTime birthDay)
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
                Console.WriteLine("Throw some grass to the deers!");
                return;

            }

            Console.WriteLine(
                    "Deer {0} got fresh grass and increased its stamina with {1}.",
                    this.Name, food.RegenerateStamina());

            this.IncreaseStamina(food.RegenerateStamina());
        }

        /// <summary>
        /// Introduces deer.
        /// </summary>
        /// <returns></returns>
        public override string Speak()
        {
            return string.Format("Deer {0} says {1}:", this.Name, DeerSpeech);
        }
    }
}
