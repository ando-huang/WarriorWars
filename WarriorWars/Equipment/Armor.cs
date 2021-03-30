namespace WarriorWars.Equipment
{
    class Armor{
        private int armorhp;
        private int gArmor = 6;
        private int bArmor = 5;

        public int getArmorhp{
            get{
                return armorhp;
            }
        }
        //constructor
        public Armor(Faction faction){
            switch(faction){
                case faction.Good:
                    armor = gArmor;
                    break;
                case faction.Bad:
                    armor = bArmor;
                    break;
                default:
                    break;
            }
        }
    }
}