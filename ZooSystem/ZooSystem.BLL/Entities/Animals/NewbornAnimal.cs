namespace ZooSystem.BLL.Entities.Animals
{
    using System;

    public class NewbornAnimal : Animal
    {
        private const string NewbornSpeech = "Weeeee!";

        private const sbyte NewbornExpectancy = 50;

        /// <summary>
        /// Initializes a new instance of the <see cref="NewbornAnimal"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public NewbornAnimal(string name, int age)
            :base(name, age, NewbornExpectancy)
        {

        }

        public override Species Specie
        {
            get
            {
                return Species.Newborn;
            }
        }

        /// <summary>
        /// Feeds the newborn animal.
        /// </summary>
        /// <param name="food"></param>
        public override void Eat(AnimalFood food)
        {
            if (food.Type != FoodType.Milk)
            {
                Console.WriteLine("Newborn animals need only milk!");
                return;

            }
            this.IncreaseStamina(food.RegenerateStamina());
        }

        /// <summary>
        /// Introduces newborn aminal.
        /// </summary>
        /// <returns></returns>
        public override string Speak()
        {
            return string.Format("Newborn says : {0}", NewbornSpeech);
        }
    }
}
