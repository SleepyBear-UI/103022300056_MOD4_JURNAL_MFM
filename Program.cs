// See https://aka.ms/new-console-template for more information

using _103022300056_MOD4_JURNAL_MFM;

internal class Program
{
    private static void Main(string[] args)
    {
        KodeProduk kode = new KodeProduk();

        FanLaptop fan = new FanLaptop();

        Console.WriteLine("1. Fan Laptop \n2.  Check \n0. Close");
        Console.WriteLine("Pilih Angka : ");
        string pilih = Console.ReadLine();
        int pilihan = int.Parse(pilih);

        while (pilihan != 0)
        {
            string fanss;
            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("Fan \n1. Balance \n2.  Performa\n3. Turbo\n4.Quiet");
                    Console.WriteLine("Pilih Angka Fan : ");
                    pilih = Console.ReadLine();
                    pilihan = int.Parse(pilih);
                    switch (pilihan)
                    {
                        case 1:
                        fan.changeStates("Balance");
                        fanss = "Balance";
                            break;
                        case 2:
                        fan.changeStates("Performa");
                        fanss = "Performa";
                        break;
                        case 3:
                            fan.changeStates("Turbo");
                        fanss = "Turbo";
                        break;
                        case 4:
                            fan.changeStates("Quiet");
                        fanss = "Quiet";
                        break;
                        default:
                        Console.WriteLine("Pilihan tidak ada");
                        break;
                    }
                break;
                case 2:
                    Console.WriteLine("Cari Kode Produk Elektronik: ");
                    string produk = Console.ReadLine();
                    Console.WriteLine(kode.getKodeProduk(produk));
                    break;
                default:
                    Console.WriteLine("pilihan tidak ada");
                    break;
            }

            pilih = Console.ReadLine();
            pilihan = int.Parse(pilih);

        }
    }
}