namespace ZooSystem.UI
{

    using System;

    using BLL.Entities.Animals;
    using BLL.Entities.Animals.Birds;
    using BLL.Entities.Keepers;
    using BLL.Entities.Zoo;

    public class EntryPoint
    {
        static void Main(string[] args)
        {
            

            // Parrots

            Animal macaw = new Parrot("Jerome", 1);
            Animal caique = new Parrot("Austin", 2);
            Animal senegal = new Parrot("Jack", 2);
            Animal parakeet = new Parrot("John", 2);
            Animal consure = new Parrot("Morgan", 2);

            // Keepers

            Keeper noviceKeeper = new Keeper(1, Level.Expert);
            Keeper intermediateKeeper = new Keeper(2, Level.Novice);

            Zoo zoo = new Zoo();

            // Add current animals

            zoo.AddAnimal(macaw);
            zoo.AddAnimal(caique);
            zoo.AddAnimal(senegal);
            zoo.AddAnimal(parakeet);
            zoo.AddAnimal(consure);

            // Assign animals to protect

            noviceKeeper.ProtectAnimal(macaw);
            noviceKeeper.ProtectAnimal(senegal);
            
            intermediateKeeper.ProtectAnimal(caique);
            intermediateKeeper.ProtectAnimal(parakeet);
            intermediateKeeper.ProtectAnimal(consure);

            // Add current keepers

            zoo.AppointKeeper(noviceKeeper);
            zoo.AppointKeeper(intermediateKeeper);

            for (int i = 0; i < 10; i++)
            {
                zoo.Run();
                Console.WriteLine("=========================================");
            }

        }
    }
}
