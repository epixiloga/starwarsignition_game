using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsIgnition.Core.Data.Models
{
    /// <summary>
    /// Arme pour les combats, pourront être utilisées par les Droides
    /// </summary>
    public class Arme
    {
        #region Constructors
        public Arme(decimal puissance)
        {
            this.Puissance = puissance;
        }

        public Arme() : this(1) {}
        #endregion

        #region Propriétés
        /// <summary>
        /// Nom de code de l'arme
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Puissance à priori entre 1 et 2
        /// </summary>
        public decimal Puissance { get; set; }
        #endregion
    }
}
