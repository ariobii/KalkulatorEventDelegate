using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasKalkulatorLagi
{
    public partial class frmHasil : Form
    {        
        public frmHasil()
        {
            InitializeComponent();            
        }

        private void frmHasil_Hitung(int Operasi, int nilaiA, int nilaiB)
        {
            Calculator calculator = new Calculator();

            switch (Operasi)
            {
                case 0:
                    lstHasil.Items.Add(string.Format("Hasil Penjumlahan : {0} + {1} = {2}", nilaiA, nilaiB, calculator.Penjumlahan(nilaiA, nilaiB)));
                    break;
                case 1:
                    lstHasil.Items.Add(string.Format("Hasil Pengurangan : {0} + {1} = {2}", nilaiA, nilaiB, calculator.Pengurangan(nilaiA, nilaiB)));
                    break;
                case 2:
                    lstHasil.Items.Add(string.Format("Hasil Perkalian : {0} + {1} = {2}", nilaiA, nilaiB, calculator.Perkalian(nilaiA, nilaiB)));
                    break;
                case 3:
                    lstHasil.Items.Add(string.Format("Hasil Pembagian : {0} + {1} = {2}", nilaiA, nilaiB, calculator.Pembagian(nilaiA, nilaiB)));
                    break;
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            //objek form hitung baru
            frmHitung formHitung = new frmHitung();

            formHitung.Hitung += frmHasil_Hitung;

            //menampilkan form
            formHitung.ShowDialog();            
        }
    }
}
