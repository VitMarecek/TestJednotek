using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Reflection.Emit;

namespace UnitTestProject4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HerniPostavaLevel()
        {
            /*level u nove postavy je jedna*/
            HerniPostava tonda = new HerniPostava();
            Assert.AreEqual(tonda.LVL(), 1);
        }
        [TestMethod]
        public void HerniPostavaZmenaPozice()
        {
            HerniPostava postava = new HerniPostava();
            postava.ZmenaPozice(5, 10);
            Assert.AreEqual(5, postava.PoziceX());
            Assert.AreEqual(10, postava.PoziceY());
        }
        [TestMethod]
        public void HerniPostavaMetodaToString() 
        {
            HerniPostava postava = new HerniPostava("Testovaci", 3, 2, 7);
            Assert.AreEqual("Jméno: Testovaci, Level: 3, Pozice: (2, 7)", postava.ToString());
        }
        [TestMethod]
        public void HracPridaníXP()
        {
            Hrac hrac = new Hrac();
            hrac.PridejXP(150);
            Assert.AreEqual(150, hrac.XP);
            Assert.AreEqual(2, hrac.level);
        }
        [TestMethod]
        public void HracMetodaToString()
        {
            Hrac hrac = new Hrac("Hrac1", 5, 3, 5, "Kouzelník", 250);
            Assert.AreEqual("Jméno: Hrac1, Level: 5, Pozice: (3, 5), Specializace: Kouzelník, XP: 250", hrac.ToString());
        }
        [TestMethod]
        public void NPCZmenapozice()
        {
            NPC npc = new NPC();
            npc.ZmenaPozice(8, 4);
            Assert.AreEqual(0, npc.PoziceX());
            Assert.AreEqual(0, npc.PoziceY());
        }
        [TestMethod]
        public void NPCMetodaToString()
        {
            NPC npc = new NPC("Obchodnik", 2, 1, 3, "obchodník", true);
            Assert.AreEqual("Jméno: Obchodnik, Level: 2, Pozice: (1, 3), Práce: obchodník, Síla: True", npc.ToString());
        }
        [TestMethod]
        public void NPCInstancovanibezsilyneniBOSS()
        {
            NPC npc = new NPC("Obyvatel", 1, "obyvatel");
            Assert.IsFalse(npc.Síla);
        }
        [TestMethod]
        public void InstancovanissiloujeBOSS() 
        {
            NPC npc = new NPC("NepřítelBOSS", 10, "nepřítel", true);
            Assert.IsTrue(npc.Síla);
        }
        [TestMethod]
        public void HracvsNPC()
        {
            Hrac hrac = new Hrac("Hrac1", 5, 200);
            NPC npc = new NPC("Nepřítel", 5, false);

            Assert.AreNotEqual(hrac.ToString(), npc.ToString());
        }

    }
}
