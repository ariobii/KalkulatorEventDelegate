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
    public partial class frmHitung : Form
    {
        //tipe data event
        public delegate void HandlerHitung(int operasi, int nilaiA, int nilaiB);

        //event
        public event HandlerHitung Hitung;      

        public frmHitung()
        {
            InitializeComponent();
            InisialisasiComboBox();
        }

        private void InisialisasiComboBox()
        {
            cmbOperasi.Items.Add("Penambahan");
            cmbOperasi.Items.Add("Pengurangan");
            cmbOperasi.Items.Add("Perkalian");
            cmbOperasi.Items.Add("Pembagian");
            cmbOperasi.SelectedIndex = 0;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            int nilaiA = int.Parse(txtNilaiA.Text);
            int nilaiB = int.Parse(txtNilaiB.Text);

            switch (cmbOperasi.SelectedIndex)
            {
                case 0:
                    Hitung(0, nilaiA, nilaiB);
                    break;
                case 1:
                    Hitung(1, nilaiA, nilaiB);
                    break;
                case 2:
                    Hitung(2, nilaiA, nilaiB);
                    break;
                case 3:
                    Hitung(3, nilaiA, nilaiB);
                    break;               
            }
        }       
    }
}
