using StarWarsIgnition.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsIgnition.Core
{
    public class MoteurDeJeu
    {
        public void Demarrer()
        {
            Arme arme1 = new Arme();
            Arme maSecondeArme = new MaSuperArme();

            Droide droide1 = new Droide(1, arme1);
            Droide droide2 = new Droide(2, maSecondeArme);

            droide1.Attaquer(droide2);
        }
    }
}
