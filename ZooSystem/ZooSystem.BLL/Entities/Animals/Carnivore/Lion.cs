namespace ZooSystem.BLL.Entities.Animals.Carnivore
{
    using System;

    public class Lion : Animal
    {

        private const sbyte averageLifeSpan = 15;

        private const string LionSpeech = "RAWRRRR!";

        /// <summary>
        /// Initializes a new instance of the <see cref="Lion"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Lion(int id, string name, int age)
            :base(id, name, age, averageLifeSpan)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Lion"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="birthDay"></param>
        public Lion(int id, string name, int age, DateTime birthDay)
            :base(id, name, age, averageLifeSpan, birthDay)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Lion"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="stamina"></param>
        /// <param name="birthDay"></param>
        public Lion(int id, string name, int age, int stamina, DateTime birthDay)
            :base(id, name, age, stamina, averageLifeSpan, birthDay)
        {

        }

        public override Species Specie
        {
            get { return Species.Carnivore;}
        }

        /// <summary>
        /// Feeds the lion.
        /// </summary>
        /// <param name="food"></param>
        public override void Eat(AnimalFood food)
        {
            if (food.Type != FoodType.Meat)
            {
                Console.WriteLine("Lion eats only meat!");
                return;
                
            }

            Console.WriteLine(
                    "Lion {0} got some fresh meat and increased its stamina with {1}.",
                    this.Name, food.RegenerateStamina());

            this.IncreaseStamina(food.RegenerateStamina());
        }

        /// <summary>
        /// Introduces lion.
        /// </summary>
        /// <returns></returns>
        public override string Speak()
        {
            return string.Format("Lion {0} says {1}:", this.Name, LionSpeech);
        }
    }
}
