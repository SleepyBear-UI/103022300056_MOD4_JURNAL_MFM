using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _103022300056_MOD4_JURNAL_MFM
{
    internal class KodeProduk
    {
        String[] produkElektronik =
   {
        "Laptop E100",
        "Smartphone",
        "Tablet",
        "Headset",
        "Keyboard",
        "Mouse",
        "Printer",
        "Monitor",
        "Smartwatch",
        "Kamera",

    };

        String[] kodeProduk =
        {
        "E101",
        "E102",
        "E103",
        "E103",
        "E104",
        "E105",
        "E106",
        "E107",
        "E108",
        "E109"
    };

        public string getKodeProduk(string product)
        {
            for (int i = 0; i < kodeProduk.Length; i++)
            {
                if (produkElektronik[i].Equals(product, StringComparison.OrdinalIgnoreCase))
                {
                    return kodeProduk[i];
                }
            }
            return "Kode Produk Tidak Ditemukan : " + product;
        }
    }
}
