namespace ZooSystem.BLL.Entities
{
    using System;

    public class AnimalFood
    {
        public FoodType Type { get; set; }

        public uint Quantity { get; set; }

        // public byte DefaultStaminaRegenerate { get; } = 5;

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

        public int RegenerateStamina()
        {
            var generatedPoints = this.staminaPointsGenerator.Next(1, 10);

            return generatedPoints;

        }
    }
}
