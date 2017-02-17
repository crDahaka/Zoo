namespace ZooSystem.BLL.Entities.Animals.Reptiles
{
    using System;

    public class Crocodile : Animal
    {
        public override string Eat()
        {
            throw new NotImplementedException();
        }

        public override string Speak()
        {
            return string.Format("Crawwwwwwwgrrrrr");
        }
    }
}
