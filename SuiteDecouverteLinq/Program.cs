using StarWarsIgnition.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiteDecouverteLinq
{
    class Program
    {
        static Random __rand = new Random();

        static void Main(string[] args)
        {
            List<Droide> list = new List<Droide>();

            for (int i = 0; i < 100; i++)
            {
                int puissance = __rand.Next(100, 201);
                Arme arme = new Arme(puissance);

                Droide droide = new Droide(i, arme);

                list.Add(droide);
            }


            var query = from toto in list
                        where toto.MonArme.Puissance >= 180
                        orderby toto.Matricule
                        select toto;

            var maList = query.ToList();

           
            foreach (var item in maList)
            {
                Console.WriteLine(item.Matricule + " " + item.MonArme.Puissance);
            }

            var query2 = from toto in list
                         where toto.MonArme.Puissance >= 180
                         orderby toto.Matricule
                         select new { Matr = toto.Matricule,
                                      Puis = toto.MonArme.Puissance,
                                      TuVasBien = true,
                                      Aleatoire = __rand.Next(1, 300)
                                    };

            foreach (var item in query2.ToList())
            {
                Console.WriteLine(item.Matr + " " + item.Puis + "," + 
                                  item.TuVasBien);
            }





        }
    }
}
