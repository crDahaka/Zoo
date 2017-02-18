namespace ZooSystem.BLL.Entities.Animals.Birds
{
    using System;

    public class Parrot : Animal
    {

        private const sbyte averageLifeSpan = 45;

        public Parrot(string name, int age)
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
            return string.Format("Crooooooack");
        }
    }
}
