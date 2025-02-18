using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage
    {
        int pointDeVie;
        int puissanceAttaque;
        int pointDeVieMaximum;

        public int PointDeVie { get => pointDeVie; 
            set {
                if (value < 0)
                {
                    pointDeVie = 0;
                }

                else if (value > PointDeVieMaximum)
                {
                    pointDeVie = PointDeVieMaximum;
                }

                else 
                {
                    pointDeVie = value;
                }
            } 
        }

        public bool EstMort
        {
            get
            {
                if (pointDeVie == 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
        }
        public int PuissanceAttaque { get => puissanceAttaque; set => puissanceAttaque = value; }
        public int PointDeVieMaximum { get => pointDeVieMaximum; set => pointDeVieMaximum = value; }
    }
}
