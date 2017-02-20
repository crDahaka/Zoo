namespace ZooSystem.DAL
{
    using BLL.Entities.Keepers;

    using System.Collections.Generic;
    using System.Linq;

    public class KeeperRepository : IRepository<Keeper>
    {

        private IList<Keeper> keepers;

        public KeeperRepository()
        {
            this.keepers = new List<Keeper>();
        }

        public IList<Keeper> GetAll()
        {
            return this.keepers.ToList();
        }

        public void Add(Keeper entity)
        {
            this.keepers.Add(entity);
        }

        public void Delete(Keeper entity)
        {
            this.keepers.Remove(entity);
        }
        
    }
}
