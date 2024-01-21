using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject4
{
    internal class HerniPostava
    {
        private string jmeno;
        private int level;
        private double poziceX;
        private double poziceY;
        public HerniPostava(string jmeno, int level, double poziceX, double poziceY)
        {
            this.jmeno = jmeno;
            this.level = level;
            this.poziceX = poziceX;
            this.poziceY = poziceY;
        }
        public int LVL()
        {
            return 1;
        }
        public string Name()
        {
            return "";
        }
        public void ZmenaPozice(double x, double y)
        {

        }
        public double PoziceX()
        {
            return 0;
        }
        public double PoziceY()
        {
            return 0;
        }

    }

    internal class Hrac
    {
        private string jmeno;
        private int level;
        private double poziceX;
        private double poziceY;
        public Hrac(string jmeno, int level, double poziceX, double poziceY)
        {
            this.jmeno = jmeno;
            this.level = level;
            this.poziceX = poziceX;
            this.poziceY = poziceY;
        }
        public double PoziceX()
        {
            return 0;
        }
        public double PoziceY()
        {
            return 0;
        }
    }
    internal class NPC
    {
        private string jmeno;
        private int level;
        private double poziceX;
        private double poziceY;
        private string profese;
        private bool sila;
        public NPC(string jmeno, int level, double poziceX, double poziceY, string profese, bool sila)
        {
            this.jmeno = jmeno;
            this.level = level;
            this.poziceX = poziceX;
            this.poziceY = poziceY;
            this.profese = profese;
            this.sila = sila;
        }
        public double PoziceX()
        {
            return 0;
        }
        public double PoziceY()
        {
            return 0;
        }
    }

}
