using System;
using System.Collections.Generic;
using System.Text;

namespace L10_JEMH_1043721
{
    class TRIANGULO_RECTANGULO
    {
        public double CATETOA;
        public double anguloOpuestoA;

        public double ObtenercatetoB()
        {
            return Math.Round(CATETOA / Math.Tan(anguloOpuestoA),3);
        }

        public double obtenerhhipotenusa()
        {
            return Math.Round(CATETOA / Math.Sin(anguloOpuestoA),3);
        }

        public double obteneranguloOpuestoB()
        {
            return Math.Round( 90 - anguloOpuestoA,3);
        }

        public double obtener()
        {

        }
    }
}
