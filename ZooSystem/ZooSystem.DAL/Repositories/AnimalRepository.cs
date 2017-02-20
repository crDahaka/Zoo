namespace ZooSystem.DAL
{

    using System.Collections.Generic;
    using BLL.Entities.Animals;
    using System.Linq;

    public class AnimalRepository : IRepository<Animal>
    {

        private IList<Animal> animals;

        public AnimalRepository()
        {
            this.animals = new List<Animal>();
        }

        public IList<Animal> GetAll()
        {
            return this.animals.ToList();
        }

        public void Add(Animal entity)
        {
            this.animals.Add(entity);
        }
        

        public void Delete(Animal entity)
        {
            this.animals.Remove(entity);
        }
    }
}
