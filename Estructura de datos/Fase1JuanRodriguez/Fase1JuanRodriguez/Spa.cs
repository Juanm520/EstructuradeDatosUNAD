using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1JuanRodriguez
{
    public class Spa
    {
        public int Id_owner { get; set; }
        public string Name_owner { get; set; }
        public string Name_pet { get; set; }
        public int Id_service { get; set; }
        public int Estrato { get; set; }
        public DateTime Date { get; set; }
        
        public int Cost_service { get; set; }
        public decimal Discount { get; set; }
        public decimal TserviceCost { get; set; }

        public decimal Tservice (int Estrato, int Cost_service)
        {
            switch (Estrato)
            {
                case 1:
                case 2:
                    TserviceCost = Cost_service - (Cost_service * 0.15M);
                    break;
                case 3:
                case 4:
                    TserviceCost = Cost_service - (Cost_service * 0.10M);
                    break;
                case 5:
                case 6:
                    TserviceCost = Cost_service - (Cost_service * 0.05M);
                    break;
            }

            return TserviceCost;
        }


    }


}
