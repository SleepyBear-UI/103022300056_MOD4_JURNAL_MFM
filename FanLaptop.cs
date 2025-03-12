using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _103022300056_MOD4_JURNAL_MFM
{
    
    internal class FanLaptop
    {
      private string fanLaptopStatus; 
      public void changeStates(string status)
        {
            fanLaptopStatus = "Quiet";
            Console.WriteLine("Fan " + fanLaptopStatus + " berubah menjadi " + status); 
            fanLaptopStatus += status;

        }

    }
}
