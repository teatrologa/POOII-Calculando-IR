using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TaxCalculator : ITaxCalculator
    {

        public double TaxCalculation(double rendaAnual)
        {

            double impostoRenda;

            if (rendaAnual <= 22847.76)
            {

                impostoRenda = 0;
                return impostoRenda;

            }
            else if (rendaAnual > 22847.76 && rendaAnual <= 33919.80)
            {

                impostoRenda = (rendaAnual * 0.075) - 1713.58;
                return impostoRenda;
            }
            else if (rendaAnual > 33919.80 && rendaAnual <= 45012.60)
            {

                impostoRenda = (rendaAnual * 0.150) - 4257.57;
                return impostoRenda;
            }
            else if (rendaAnual > 45012.60 && rendaAnual <= 55976.16)
            {

                impostoRenda = (rendaAnual * 0.225) - 7633.51;
                return impostoRenda;
            }
            else
            {

                impostoRenda = (rendaAnual * 0.275) - 10432.32;
                return impostoRenda;
            }

        }

       
    }
}
