﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ITaxCalculator
    {
        public double TaxCalculation(double rendaAnual);

        public double GetImpostoRenda();
    }
}
