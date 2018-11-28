using StarWarsIgnition.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            List<Apprenant> apprenantList = new List<Apprenant>();

            apprenantList.Add(new Apprenant()
            {
                ALunettes = false,
                CheveuxLong = false,
                CouleurHabitBas = System.Drawing.Color.Blue,
                CouleurHabitHaut = System.Drawing.Color.Gray,
                PorteEcharpe = true,
                Sexe = 2,
                Taille = 1.78M
            });

            apprenantList.Add(new Apprenant()
            {
                ALunettes = false,
                CheveuxLong = true,
                CouleurHabitBas = System.Drawing.Color.Black,
                CouleurHabitHaut = System.Drawing.Color.Maroon,
                PorteEcharpe = true,
                Sexe = 1,
                Taille = 1.56M
            });

            apprenantList.Add(new Apprenant()
            {
                ALunettes = true,
                CheveuxLong = false,
                CouleurHabitBas = System.Drawing.Color.Black,
                CouleurHabitHaut = System.Drawing.Color.DarkRed,
                PorteEcharpe = true,
                Sexe = 2,
                Taille = 1.94M
            });

            apprenantList.Add(new Apprenant()
            {
                ALunettes = false,
                CheveuxLong = true,
                CouleurHabitBas = System.Drawing.Color.Blue,
                CouleurHabitHaut = System.Drawing.Color.White,
                PorteEcharpe = false,
                Sexe = 1,
                Taille = 1.60M
            });

            apprenantList.Add(new Apprenant()
            {
                ALunettes = false,
                CheveuxLong = true,
                CouleurHabitBas = System.Drawing.Color.Black,
                CouleurHabitHaut = System.Drawing.Color.Gray,
                PorteEcharpe = false,
                Sexe = 1,
                Taille = 1.65M
            });

            apprenantList.Add(new Apprenant()
            {
                ALunettes = true,
                CheveuxLong = false,
                CouleurHabitBas = System.Drawing.Color.Blue,
                CouleurHabitHaut = System.Drawing.Color.Gray,
                PorteEcharpe = true,
                Sexe = 2,
                Taille = 1.90M
            });

            apprenantList.Add(new Apprenant()
            {
                ALunettes = false,
                CheveuxLong = false,
                CouleurHabitBas = System.Drawing.Color.Blue,
                CouleurHabitHaut = System.Drawing.Color.Black,
                PorteEcharpe = false,
                Sexe = 2,
                Taille = 1.85M
            });

            apprenantList.Add(new Apprenant()
            {
                ALunettes = false,
                CheveuxLong = false,
                CouleurHabitBas = System.Drawing.Color.Blue,
                CouleurHabitHaut = System.Drawing.Color.Gray,
                PorteEcharpe = false,
                Sexe = 2,
                Taille = 1.88M
            });

            apprenantList.Add(new Apprenant()
            {
                ALunettes = false,
                CheveuxLong = false,
                CouleurHabitBas = System.Drawing.Color.Blue,
                CouleurHabitHaut = System.Drawing.Color.Black,
                PorteEcharpe = false,
                Sexe = 2,
                Taille = 1.87M
            });

            apprenantList.Add(new Apprenant()
            {
                ALunettes = true,
                CheveuxLong = false,
                CouleurHabitBas = System.Drawing.Color.DarkRed,
                CouleurHabitHaut = System.Drawing.Color.Coral,
                PorteEcharpe = true,
                Sexe = 2,
                Taille = 1.85M
            });


            var query = from apprend in apprenantList
                        where apprend.Sexe == 1 
                        where apprend.CheveuxLong == false
                        select apprend;

            foreach (var item in query.ToList())
            {
                Console.WriteLine("1 : " + item.ToString());
            }


            var query2 = from apprenant in apprenantList
                         where apprenant.Sexe == 2 &&
                               apprenant.Taille > 1.7M
                         select apprenant;

            foreach (var item in query2)
            {
                Console.WriteLine("2 : " + item.ToString());
            }

            var query3 = from item in apprenantList
                         where item.CouleurHabitBas == System.Drawing.Color.Black ||
                               item.CouleurHabitHaut == System.Drawing.Color.Black
                         select item;

            foreach (var yoyo in query3)
            {
                Console.WriteLine("3 : " + yoyo.ToString());
            }

            var query5 = from item in apprenantList
                         where item.EstPetit
                         select new
                         {
                             Couleur1 = item.CouleurHabitBas,
                             Couleur2 = item.CouleurHabitHaut
                         };

            foreach (var item in query5)
            {
                Console.WriteLine("5 : " + item.Couleur1 + ", " + item.Couleur2);
            }


            var query6 = from appreitem in apprenantList
                         group appreitem by appreitem.CheveuxLong into grouping
                         select grouping;

            foreach (var item in query6)
            {
                Console.WriteLine("Cheveux " + (item.Key ? "long" : "court") + ", nb : " + item.Count());
                foreach (var app in item)
                {
                    Console.WriteLine("Apprenant : " + app.Sexe + ", " + app.Taille);
                }
            }


            var ss = "";

            //List<Droide> list = new List<Droide>();

            //for (int i = 0; i < 100; i++)
            //{
            //    int puissance = __rand.Next(100, 201);
            //    Arme arme = new Arme(puissance);

            //    Droide droide = new Droide(i, arme);

            //    list.Add(droide);
            //}


            //var query = from toto in list
            //            where toto.MonArme.Puissance >= 180
            //            orderby toto.Matricule //descending
            //            select toto;

            //var maList = query.ToList();


            //foreach (var item in maList)
            //{
            //    Console.WriteLine(item.Matricule + " " + item.MonArme.Puissance);
            //}

            //var query2 = from toto in list
            //             where toto.MonArme.Puissance >= 180
            //             orderby toto.Matricule
            //             select new { Matr = toto.Matricule,
            //                          Puis = toto.MonArme.Puissance,
            //                          TuVasBien = true,
            //                          Aleatoire = __rand.Next(1, 300)
            //                        };

            //foreach (var item in query2.ToList())
            //{
            //    Console.WriteLine(item.Matr + " " + item.Puis + "," + 
            //                      item.TuVasBien);
            //}





        }
    }
}
