using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitRace_Game
{
   public class Logic
    {
        public string plyer { get; set; }
        public int rbit { get; set; }

        public int bet  { get; set; }
        public int blnce { get; set; }

        public void genrateAmount(ComboBox cb) {
            // here we need to
            int x = 5;
            while (x<=50) {
                cb.Items.Add(x);
                x = x + 5;
            }
        }
        public int genrte() {
            Random rd = new Random();
            return rd.Next(1, 50);
        }
        public int genrte2()
        {
            Random rd = new Random();
            return rd.Next(1, 50);
        }
        public int genrte3()
        {
            Random rd = new Random();
            return rd.Next(1, 50);
        }
        public int genrte4()
        {
            Random rd = new Random();
            return rd.Next(1, 50);
        }


    }
}
