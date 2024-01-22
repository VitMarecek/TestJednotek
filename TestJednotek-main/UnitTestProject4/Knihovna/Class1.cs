using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovna
{

    public class HerniPostava
    {
        public void ZmenaPozice(int novaX, int novaY)
        {
           
        }

        public override string ToString()
        {
            return "";
        }
    }

    public class Hráč : HerniPostava
    {
        public Specializace Specializace;
        private Oblicej obličej;
        private Vlasy vlasy;
        private BarvaVlasu barvaVlasu;
        public int XP;


        public void PřidejXP(int hodnota)
        {

        }

        public override string ToString()
        {
            return "";
        }
    }

    public class NPC : HerniPostava
    {
        public Prace Prace;
        public bool JeBoss;


        public override void ZmenaPozice(int novaX, int novaY)
        {

        }

        public override string ToString()
        {
            return "";
        }
    }
}
