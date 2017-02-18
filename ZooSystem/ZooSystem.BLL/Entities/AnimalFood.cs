namespace ZooSystem.BLL.Entities
{
    using System;

    public class AnimalFood
    {
        public FoodType Type { get; set; }
        public byte Quantity { get; set; }

        public AnimalFood(FoodType type, byte quantity)
        {
            this.Type = type;
            this.Quantity = quantity;
        }
    }
}
