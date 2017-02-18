namespace ZooSystem.BLL.Entities.Animals.Mammals
{
    using System;

    public class Goat : Animal
    {

        private const sbyte averageLifeSpan = 13;

        public Goat(string name, int age)
            :base(name, age, averageLifeSpan)
        {

        }

        public override Species Specie
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Eat(AnimalFood food)
        {
            throw new NotImplementedException();
        }

        public override string Speak()
        {
            return string.Format("MEEEEEEEEE");
        }
    }
}
