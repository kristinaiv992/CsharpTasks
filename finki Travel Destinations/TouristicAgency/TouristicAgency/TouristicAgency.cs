using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristicAgency
{
    public class TouristicAgency
    {
        private string ime;
        private List<Salter> salters;

        public TouristicAgency(string name)
        {
            ime = name;
            salters = new List<Salter>();
        }
        public string getIme()
        {
            return ime;
        }

        public void AddShalter(Salter s)
        {
            salters.Add(s);
        }

        public void ProdadeniKartiOdAgencijata()
        {
            int vkupnoKarti = 0;
            int vkupnoPoSalter = 0;

            foreach (var item in salters)
            {
                vkupnoPoSalter += item.getKartiOdSalter();
                vkupnoKarti += vkupnoPoSalter;
                Console.WriteLine($"Vkupno prodadeni karti od salterot {item.getBrojNaSalter()} ima {vkupnoPoSalter}");
                vkupnoPoSalter = 0;
            }

            Console.WriteLine("Vkupno karti prodadeni od celata agencija ima: " + vkupnoKarti);
        }

        public void VkupenPrometOdAgencijata()
        {
            int vkupenPrometAgenc =0;

            foreach (var item in salters)
            {
                vkupenPrometAgenc += item.getPrometOdProdadeniKartiPoSalter();
            }
            Console.WriteLine("Vkupen promet od cela agencija: " + vkupenPrometAgenc);
        }

        public void UspeshnostnaAgencijata()
        {
            int brNaUslKlientiOdSiteShalteri = 0;
            int brNaSiteKlienti = 0;

            foreach (var item in salters)
            {
                brNaUslKlientiOdSiteShalteri += item.getUsluzeniKlientiOdSalter();
                brNaSiteKlienti += item.getVkupnoKlienti();

            }
            Console.WriteLine($"Uspeshnosta na agencijata e: {(float)brNaUslKlientiOdSiteShalteri/ brNaSiteKlienti}");
        }

    }
}
