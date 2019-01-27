using System;

namespace RefactoredGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GameServer gameserver = new GameServer();

            gameserver.RegisterUser("assd12","adasd123@");

            Console.WriteLine("Skill points before the deal.");

            Console.WriteLine(gameserver.characterskillpoints.barbarian.Strength);
            Console.WriteLine(gameserver.characterskillpoints.barbarian.Stamina);

            gameserver.CreateCharacter(new Barbarian());

            Console.WriteLine("Skill points after the deal.");

            Console.WriteLine(gameserver.characterskillpoints.barbarian.Strength);
            Console.WriteLine(gameserver.characterskillpoints.barbarian.Stamina);

            Console.ReadKey();
        }
    }
}
