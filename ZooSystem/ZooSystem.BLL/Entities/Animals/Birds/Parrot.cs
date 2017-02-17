namespace ZooSystem.BLL.Entities.Animals.Birds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Parrot : Animal
    {
        public override string Eat()
        {
            throw new NotImplementedException();
        }

        public override string Speak()
        {
            return string.Format("Crooooooack");
        }
    }
}
