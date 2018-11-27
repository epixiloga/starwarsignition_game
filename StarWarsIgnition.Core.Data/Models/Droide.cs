using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsIgnition.Core.Data.Models
{
    /// <summary>
    /// Droide de combat pour le jeu
    /// </summary>
    public class Droide
    {
        #region Champs privés
        private static Random __random = new Random();
        #endregion

        #region Constructeurs
        public Droide(int matricule, Arme arme, int pointsDeVie = 100)
        {
            this.Matricule = matricule;
            this.PointsDeVie = pointsDeVie;
            this.MonArme = arme;
        }
        #endregion

        #region Méthodes publiques
        public void Attaquer(Droide droide)
        {
            while(this.EstVivant && droide.EstVivant)
            {
                this.GererUnCoup(this, droide);
                this.GererUnCoup(droide, this);
            }
        }
        #endregion

        #region Méthodes privées
        private void GererUnCoup(Droide attaquant, Droide defenseur)
        {
            if(attaquant.EstVivant)
            {
                int coup = __random.Next(0, 51);
                defenseur.PointsDeVie -= (int)(coup * attaquant.MonArme.Puissance);

                Console.WriteLine($"Attaquant({attaquant.Matricule}) attaque avec " + coup);

            }       
            
        }
        #endregion

        #region Propriétés
        /// <summary>
        /// Matricule > 0 du droide
        /// </summary>
        public int Matricule { get; private set; }

        /// <summary>
        /// Taille du droide 
        /// </summary>
        public decimal Taille { get; set; }

        /// <summary>
        /// Points de vie (à priori de 0 à 100)
        /// </summary>
        public int PointsDeVie { get; set; }

        /// <summary>
        /// Permet de savoir si le droide est vivant
        /// </summary>
        public bool EstVivant { get => this.PointsDeVie > 0; }

        /// <summary>
        /// Arme du droide
        /// </summary>
        public Arme MonArme { get; private set; }
        #endregion
    }
}
