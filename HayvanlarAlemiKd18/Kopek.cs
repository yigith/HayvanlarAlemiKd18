using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanlarAlemiKd18
{
    public class Kopek : Hayvan
    {
        public Kopek() : base("Köpek")
        {
            
        }

        public void KulaklariniDik()
        {
            Console.WriteLine($"{Tur} kulaklarını dikiyor.");
        }

        public override void SesCikar()
        {
            Console.WriteLine("Hav hav hav..");
        }
    }
}
