namespace ZooSystem.BLL.Entities.Keepers
{
    using Animals;
    using System;
    using System.Collections.Generic;

    public class Keeper
    {
        private string Name;
        private ICollection<Animal> animalsToGuard;
    }
}
