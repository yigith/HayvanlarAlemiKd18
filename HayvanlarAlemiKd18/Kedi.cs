using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanlarAlemiKd18
{
    public class Kedi : Hayvan
    {
        public Kedi() : base("Kedi")
        {

        }

        public override void SesCikar()
        {
            // base.SesCikar(); // miras alınan
            Console.WriteLine("Miyav miyav miyav..");
        }
    }
}
