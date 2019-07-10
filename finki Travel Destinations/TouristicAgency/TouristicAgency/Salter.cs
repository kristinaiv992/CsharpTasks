using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristicAgency
{
    public class Salter
    {
        private int BrojNaSalter { get; set; }
        private int VkupenBrojNaKlienti { get; set; }
        private int BrojNaUsluzeniKlientiOdSalter { get; set; }
        private int BrojNaProdadeniKarti{ get; set; }
        private int VkupenPromet { get; set; }
        private string[] Destinacii { get; set; }


        public Salter(int BrojSalter)
        {
            BrojNaSalter = BrojSalter;
            VkupenBrojNaKlienti = 0;
            BrojNaUsluzeniKlientiOdSalter = 0;
            BrojNaProdadeniKarti = 0;
            VkupenPromet = 0;
            Destinacii = new string[] { "Rim", "London", "Tokio", "Sofija", "Istanbul", "Toronto", "Majami", "Zagreb", "Belgrad", "Moskva" };

        }

        public string KupiKarta(string destination)
        {
            if (Destinacii.Contains(destination))
            {
                VkupenBrojNaKlienti++;
                BrojNaUsluzeniKlientiOdSalter++;
                BrojNaProdadeniKarti++;
                VkupenPromet += destination.Length * 1000;

                return $"You successfuly bought a ticket to {destination} and it costed you {destination.Length * 1000} denars";
            }
            else
            {
                VkupenBrojNaKlienti++;
                return $"We do not have that destination!";
            }
        }

        public int getBrojNaSalter()
        {
            return BrojNaSalter;
        }
        //Client sum
        public int getVkupnoKlienti()
        {
            return VkupenBrojNaKlienti;
        }

        public int getUsluzeniKlientiOdSalter()
        {
            return BrojNaUsluzeniKlientiOdSalter;
        }

        //sold tickets on a particular buffet 
        public string getProdadeniKartiOdShalter()
        {
            return $"Salterot so broj {BrojNaSalter} ima prodadeno {BrojNaProdadeniKarti} karti ";
        }

        public int getKlientiPoSalter()
        {
            return VkupenBrojNaKlienti;
        }

        public int getPrometOdProdadeniKartiPoSalter()
        {
            return VkupenPromet;
        }

        public int getKartiOdSalter()
        {
            return BrojNaProdadeniKarti;
        }
        public string VkupenPrometOdOdredenSalter()
        {
            return $"Salterot so broj {BrojNaSalter} ima vkupen promet od {VkupenPromet}";
        }
    }
}
