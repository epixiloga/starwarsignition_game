using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiteDecouverteLinq
{
    public class Apprenant
    {
        public int Sexe { get; set; } //1 : fille, 2 : garcon

        public bool CheveuxLong { get; set; }

        public bool PorteEcharpe { get; set; }

        public decimal Taille { get; set; }

        public bool ALunettes { get; set; }

        public Color CouleurHabitHaut { get; set; }

        public Color CouleurHabitBas { get; set; }

        public bool EstPetit
        {
            get => (this.Sexe == 1 && this.Taille < 1.65M) ||
                   (this.Sexe == 2 && this.Taille < 1.8M);
        }
    }
}
