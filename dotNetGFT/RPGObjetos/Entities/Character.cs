namespace RPGObjetos.Entities
{
    public class Character
    {
        
        public Character(string Name)
        {
            this.Name = Name;
        }
        public string Name {get; set;}
        public int Level {get; set;} = 1;
        public string Class {get; set;} = "Villager";
        public string AttackText {get; set;} = "attacked with the";
        public string Weapon {get; set;} = "Fist";

        public Points Hp = new Points();
        public Points Mp = new Points();

        public override string ToString()
        {
            return ($"{this.Name} Lv. {this.Level} {this.Class}\n{this.Hp}\n{this.Mp}");
        }

        public virtual string Attack()
        {
            return ($"{this.Name} {AttackText} {Weapon}");
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return ($"{this.Name} {AttackText} {Weapon}, critical bonus of {bonus}");
            }
            else if(bonus < 0)
            {
                return ($"{this.Name} {AttackText} {Weapon}, minus damage of {bonus}");
            }
            return ($"{this.Name} {AttackText} {Weapon}, small bonus of {bonus}");
        }
    }

    public class Points 
    {
        public int Max {get; set;} = 10;
        public int Current {get; set;} = 10;

        public override string ToString()
        {
            return ($"{this.Current}/{this.Max}");
        }

    }
    
}