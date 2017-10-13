using System;
using static System.Console;

namespace KlasseBruch_ConsoleApplication
{
    class Program
    {
        class Bruch
        {
            int _zaehler, _nenner;
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
                _nenner = (!(wert == 0)) ? wert : 1;
            }
            public void zaehlerSetzen(int wert)
            {
                _zaehler = wert;
            }
            public double dezimal_ermitteln()
            {
                dezimalWert = (double)_zaehler / _nenner;
                return dezimalWert;
            }
            public void darstellen()
            {
                Write("{0}/{1} = {2,4:F3}", _zaehler, _nenner, dezimalWert);
            }
            public int zaehler  // hat keine ()
            {
                set     // setter für eine Property
                {
                    _zaehler = value;
                    if (value != 0)
                    { dezimalWert = (double)_zaehler / _nenner; }
                    else
                    { dezimalWert = 0; }
                }
                get
                {
                    return _zaehler;
                }
            }
            public int nenner
            {
                set
                {
                    if (value != 0)
                    { dezimalWert = (double)_zaehler / _nenner; }
                    else
                    { WriteLine("Nenner darf nicht 0 sein!"); }
                }
                get
                {
                    return _nenner;
                }
            }
        }

        static void Main(string[] args)
        {
            Bruch meinBruch = new Bruch();

            // einBruch.bruchDefinieren(1, 2);

            // meinBruch.zaehlerSetzen(200);   // könnte auch meinBruch.zaehler = 200; sein braucht Methode
            // meinBruch.nennerSetzen(300);
            meinBruch.zaehler = 200;
            meinBruch.nenner = 300;
            meinBruch.darstellen();


            // Write("{0,3:F2}", meinBruch.dezimal_ermitteln());

            ReadLine();
        }
    }
}