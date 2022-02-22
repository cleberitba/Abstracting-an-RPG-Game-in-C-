namespace heroes.src.entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string TypeOfHero, int HP, int MP)

        {
            this.Name = Name;
            this.Level = Level;
            this.TypeOfHero = TypeOfHero;
            this.MP = MP;
            this.HP = HP;

        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
                return ($"{this.Name} lançou Magia Super efetiva com bonus de ataque de {Bonus}");
            else
                return ($"{this.Name} lançou Magia força fraca com bonus de ataque de {Bonus}");

        }
    }
}