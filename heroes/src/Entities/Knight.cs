namespace heroes.src.entities
{
    public class Knight : Hero
    {
        public Knight()
        {
        }

        public Knight(string Name, int Level, string TypeOfHero, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.TypeOfHero = TypeOfHero;
            this.MP = MP;
            this.HP = HP;
        }
    }
}