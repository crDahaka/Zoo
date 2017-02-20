namespace ZooSystem.BLL.Entities
{
    using System;

    public class AnimalFood
    {
        public FoodType Type { get; set; }

        public uint Quantity { get; set; }

        private Random staminaPointsGenerator;


        /// <summary>
        /// Initializes a new instance of the <see cref="AnimalFood"/> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="quantity"></param>
        public AnimalFood(FoodType type, uint quantity)
        {
            this.Type = type;
            this.Quantity = quantity;
            this.staminaPointsGenerator = new Random();
        }

        /// <summary>
        /// Increases animal stamina.
        /// </summary>
        /// <returns></returns>
        public int RegenerateStamina()
        {
            var generatedPoints = this.staminaPointsGenerator.Next(10, 20);

            return generatedPoints;

        }
    }
}
