using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            EpioneContext ec = new EpioneContext();
            Address adresse = new Address { country="a",city="b",Street="c" };
            ec.Address.Add(adresse);
            ec.SaveChanges();
        }
    }
}
