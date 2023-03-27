using System;

namespace PW41
{
    class Spell
    {
        public string Name { get; set; }
        public int Mana { get; private set; }
        private string Effect { get; set; }

        public Spell(string name, int mana, string effect)
        {
            Name = name;
            Mana = mana;
            Effect = effect;
        }

        public string Use()
        {
            return Effect;
        }
    }

    class Magician
    {
        public string Name { get; }
        public int Mana { get; private set; }

        public Magician(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }

        public void CastSpell(Spell spell)
        {
            if (Mana < spell.Mana)
            {
                int manaNeed = spell.Mana - Mana;
                Console.WriteLine($"Не хватает {manaNeed} единиц маны для использования заклинания '{spell.Name}'. Хлебните зелья!");
            }
            else
            {
                Mana -= spell.Mana;
                Console.WriteLine($"Колдун {Name} колдует заклинание '{spell.Name}'! {spell.Use()}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Spell fireBall = new Spell("Огненный шар", 49, "Огненный шар использован.");
            Spell parseTwoString = new Spell("Молния", 50, "Молния использована");

            Magician Alex = new Magician("АЛЕКС", 50);
            Magician Bob = new Magician("БОБ", 49);

            Alex.CastSpell(fireBall);
            Bob.CastSpell(parseTwoString);
        }
    }
}
