using System;

namespace Knihovnicka
{
    public enum Specializace { Kouzelník, Berserker, Inženýr, Cizák }
    public enum Oblicej { VelkýNos, Ušoplesk, MakeUp }
    public enum Vlasy { Drdol, Culík, Pleška }
    public enum BarvaVlasu { Kaštanová, Blond, Červená }

    public class HerniPostava
    {
        private string jmeno;
        public int level = 1;
        public int poziceX = 0;
        public int poziceY = 0;

        public string Jmeno
        {
            get { return jmeno; }
            set
            {
                if (value.Length > 10)
                    Console.WriteLine("Příliš dlouhé jméno!");
                else
                    jmeno = value;
            }
        }

        public HerniPostava(string jmeno)
        {
            Jmeno = jmeno;
        }

        public virtual void ZmenaPozice(int x, int y)
        {
            poziceX = x;
            poziceY = y;
        }

        public override string ToString()
        {
            return $"Jmeno: {Jmeno}, Level: {level}, Pozice X: {poziceX}, Pozice Y: {poziceY}";
        }
    }

    public class Hrac : HerniPostava
    {
        private Specializace specializace;
        private Oblicej oblicej;
        private Vlasy vlasy;
        private BarvaVlasu barvaVlasu;
        private int xp = 0;

        public int XP
        {
            get { return xp; }
        }

        public int Level
        {
            get { return level; }
        }

        public Specializace Specializace
        {
            get { return specializace; }
            set
            {
                string[] validSpecializations = { "Kouzelník", "Berserker", "Inženýr", "Cizák" };
                if (Array.IndexOf(validSpecializations, value.ToString()) != -1)
                    specializace = value;
                else
                    Console.WriteLine("Neplatná specializace!");
            }
        }

        public Hrac(string jmeno, Specializace specializace, Oblicej oblicej, Vlasy vlasy, BarvaVlasu barvaVlasu)
            : base(jmeno)
        {
            this.specializace = specializace;
            this.oblicej = oblicej;
            this.vlasy = vlasy;
            this.barvaVlasu = barvaVlasu;
        }

        public void PridaniXP(int pridaneXP)
        {
            xp += pridaneXP;
            while (xp >= 100 * Level)
            {
                xp -= 100 * Level;
                level++;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nSpecializace: {specializace}\nOblicej: {oblicej}\nVlasy: {vlasy}\nBarva vlasu: {barvaVlasu}\nXP: {xp}";
        }
    }

    public enum Prace { Obchodník, Nepřítel, Obyvatel }

    public class NPC : HerniPostava
    {
        private Prace prace;
        private bool jeBoss;

        public Prace Prace
        {
            get { return prace; }
            set { prace = value; }
        }

        public bool JeBoss
        {
            get { return jeBoss; }
        }

        public NPC(string jmeno, Prace prace, bool jeBoss = false)
            : base(jmeno)
        {
            this.prace = prace;
            this.jeBoss = jeBoss;
        }

        public override void ZmenaPozice(int x, int y)
        {
            // Tato metoda je přepsána a nemůže být změněna v odvozených třídách
            Console.WriteLine("NPC nelze přesunout.");
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nPráce: {prace}\nJe BOSS: {jeBoss}";
        }
    }
}
