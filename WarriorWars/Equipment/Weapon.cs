namespace WarriorWars.Equipment
{
    class Weapon{
        private int damage;
        private int gDamage = 34;
        private int bDamage = 21;

        public int getDamage{
            get{
                return damage;
            }
        }

        //constructor
        public Weapon(Faction faction){
            switch(faction){
                case faction.Good:
                    damage = gDamage;
                    break;
                case faction.Bad:
                    damage = bDamage;
                    break;
                default:
                    break;
            }
        }
    }
}
