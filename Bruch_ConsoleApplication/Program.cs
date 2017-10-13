using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Bruch_ConsoleApplication
{
    class Program
    {
        class Bruch
        {
            int zaehler, nenner;
            double dezimalWert;
            /* public void bruchDefinieren(int zaehl, int nenn)    // kompletter Bruch
            {
                zaehler = zaehl;
                // nenner = (!(nenn ==0)) ? nenn: 1;
                // geht beides
                nenner = (nenn != 0) ? nenn : 1;
            }   */
            public void nennerSetzen(int wert)
            {
                nenner = (!(wert == 0)) ? wert : 1;
            }
            public void zaehlerSetzen(int wert)
            {
                zaehler = wert;
            }
            public double dezimal_ermitteln()
            {
                dezimalWert = (double)zaehler / nenner;
                return dezimalWert;
            }
            public void darstellen()
            {
                Write("{0}/{1} =\t", zaehler, nenner);
            }
        }


        static void Main(string[] args)
        {
            Bruch einBruch = new Bruch();

            // einBruch.bruchDefinieren(1, 2);
            
            einBruch.zaehlerSetzen(200);
            einBruch.nennerSetzen(300);
            einBruch.darstellen();
            Write("{0,3:F2}", einBruch.dezimal_ermitteln());

            ReadLine();
        }
    }
}
