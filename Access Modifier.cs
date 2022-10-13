using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgAccessModified
{
    class PublicPerson
    {
        public string nama = "Meidiana";
    }
    class ProtectedPerson
    {
        protected string nama = "Hana";
    }
    class Program : ProtectedPerson
    {
        class PrivatePerson
        {
            private string nama = "Putri";
            static void Main(String[] args)
            {
                Console.WriteLine("Metode Access Modified Public");
                PublicPerson org = new PublicPerson();
                Console.WriteLine(org.nama);
                Console.WriteLine("");
                Console.WriteLine("Metode Access Modified Protected");
                Program program = new Program();
                Console.WriteLine(program.nama);
                Console.WriteLine("");
                Console.WriteLine("Access Modified Private");
                PrivatePerson privateOrg = new PrivatePerson();
                Console.WriteLine(privateOrg.nama);
            }
        }
    }
}
