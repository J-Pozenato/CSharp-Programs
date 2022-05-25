namespace RPGObjetos.Entities
{
    public class NonCombatant : Character
    {
        public NonCombatant(string Name) : base(Name)
        {
            this.Name = Name;
        }

        
                
        public override string Attack()
        {
            return $"{this.Name} can't attack";
        }
    }
}