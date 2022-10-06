using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Converter
    {
        private decimal usdUah;
        private decimal eurUah;
        public Converter(decimal usdUah, decimal eurUah)
        {
            this.usdUah = usdUah;
            this.eurUah = eurUah;
        }
        public decimal UahToUsd(decimal hrivnaAmount) => hrivnaAmount / usdUah;
        public decimal UahToEur(decimal hrivnaAmount) => hrivnaAmount / eurUah;
        public decimal UsdToUah(decimal usdAmount) => usdAmount * usdUah;
        public decimal EurToUah(decimal eurAmount) => eurAmount * eurUah;

    }
}
