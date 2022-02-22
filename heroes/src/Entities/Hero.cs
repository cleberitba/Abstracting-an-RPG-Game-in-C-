namespace heroes.src.entities
{
    public abstract class Hero
    {

        public Hero()
        {
            this.Name = "";            
            this.TypeOfHero = "";
        }
        public Hero(string Name, int Level, string TypeOfHero, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.TypeOfHero = TypeOfHero;
            this.MP = MP;
            this.HP = HP;
        }

        public string Name;
        public int Level;
        public string TypeOfHero;
        public int MP;
        public int HP;


        public override string ToString()
        {
            return ($" {this.Name}  {this.Level} {this.TypeOfHero} {this.MP} {this.HP}");
        }

        public virtual string Attack()
        {
            return ($"{this.Name} atacou com sua espada");
        }


    }
}