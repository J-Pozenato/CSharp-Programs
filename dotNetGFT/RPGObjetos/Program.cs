using RPGObjetos.Entities;

namespace RPGObjetos
{
    public class Program
    {
        public static void Main()
        {
            Character p1 = new Character("Hero");
            p1.Class = "Hero";
            p1.Weapon = "Legendary Sword";

            

            Character p2 = new Character("Vilão");
            p2.Class = "Villain";
            p2.Weapon = "Evil Eye";
            p2.Hp.Max = 200;
            p2.Hp.Current = 200;
            p2.Mp.Max = 200;
            p2.Mp.Current = 200;
            p2.Level = 20;
 

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p1.Attack(2));
            Console.WriteLine(p2.Attack(-2));


            Character p3 = new Character("Wizard");
            p3.Class = "Wizard";
            p3.Weapon = "staff";

            Console.WriteLine(p3);
            Console.WriteLine(p3.Attack());

            NonCombatant p4 = new NonCombatant("Child");

            Console.WriteLine(p4);
            Console.WriteLine(p4.Attack());
        }
    }
}