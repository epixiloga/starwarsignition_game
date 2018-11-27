using StarWarsIgnition.Core;
using StarWarsIgnition.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StarWarsIgnition.Win.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            MoteurDeJeu moteur = new MoteurDeJeu();
            moteur.Demarrer();
        }
    }
}
