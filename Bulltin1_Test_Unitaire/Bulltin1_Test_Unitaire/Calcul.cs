using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulltin1_Test_Unitaire
{
     public  class Calcul
    {
        public Calcul()
        {

        }
        public double calculerMoyenne(double Math, double Phisique, double Francais)
        {
            double moy;

            int c1 = 5, c2 = 7, c3 = 3;
            int total = c1 + c2 + c3;
            moy = (Math * c1 + Phisique * c2 + Francais * c3) / total;




            return moy;

        }
    }
}
