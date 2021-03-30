using System;
namespace WarriorWars
{
    class EntryPoint{
        static Random rng = new Random();

        static void Main(){
            Warrior goodGuy = new Warrior("Jojo", Enum.Faction.Good);
            Warrior badGuy = new Warrior("Dio", Faction.Bad);
        
            while(goodGuy.IsAlive && badGuy.IsAlive){
                if(rng.Next(0, 10) < 5){
                    goodGuy.Attack(badGuy);
                }    
                else{
                    badGuy.Attack(goodGuy);
                }
            }
            if(goodGuy.IsAlive){
                System.WriteLine("Good guy wins!");
            }
            else
                System.Console.WriteLine("Bad guy wins!");

        }
    }
}