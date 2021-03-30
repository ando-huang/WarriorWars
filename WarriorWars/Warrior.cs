using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
    class Warrior{
        private readonly Faction faction;

        private const int STARTHEALTH = 100; //initial hp
        private int health;
        private string name;
        private bool isAlive;

        /**
            used to check if the warrior is alive
        */
        public bool IsAlive{
            get{
                return this.isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;
    
        /**
            Constructor
        */
        public Warrior(string name, Faction faction){
            this.name = name;
            this.faction = faction;
            isAlive = true;
            switch(faction)
            {
                case Faction.Good:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = STARTHEALTH;
                    break;
                case Faction.Bad:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = STARTHEALTH;
                    break;
                default:
                    break;
            }
        }

        //action move
        public void Attack(Warrior enemy){
            int damage = weapon.getDamage / enemy.armor.getArmorhp;
            enemy.health -= damage;

            if(enemy.health <= 0){
                enemy.isAlive = false;
            }
            else{
                System.Console.WriteLine($"{name} attacked {enemy.name}.\n{damage} inflicted, {enemy.name} has {enemy.health}HP.\n");
            }
        }
    }
}