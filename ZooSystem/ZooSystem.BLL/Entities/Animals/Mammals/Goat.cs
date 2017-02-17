namespace ZooSystem.BLL.Entities.Animals.Mammals
{
    using System;

    public class Goat : Animal
    {
        public override string Eat()
        {
            throw new NotImplementedException();
        }

        public override string Speak()
        {
            return string.Format("MEEEEEEEEE");
        }
    }
}
