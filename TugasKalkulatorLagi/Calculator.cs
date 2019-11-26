using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasKalkulatorLagi
{
    public class Calculator
    {
        public int Penjumlahan(int nilaiA, int nilaiB)
        {
            return nilaiA + nilaiB;
        }
        public int Pengurangan(int nilaiA, int nilaiB)
        {
            return nilaiA - nilaiB;
        }
        public int Perkalian(int nilaiA, int nilaiB)
        {
            return nilaiA * nilaiB;
        }
        public int Pembagian(int nilaiA, int nilaiB)
        {
            return nilaiA / nilaiB;
        }
    }
}
