using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacchetti_vacanze
{
    internal class Pacchetto_escursione : Pacchetto_pasto
    {
        private int _numEscursioni;

        public int NumEscursioni
        {
            get { return _numEscursioni; }
            set {
                if(value>0) { _numEscursioni = value; }
                else { _numEscursioni = 0; }
            }
        }

        public Pacchetto_escursione() : base()
        {
            PensioneComp = false;
        }

        public Pacchetto_escursione(int escursioni, bool voloRitorno, string destinazione, int durata, float costoBase) : base(voloRitorno, destinazione, durata, costoBase)
        {
            NumEscursioni = escursioni;
        }


        public override float CalcolaPrezzo()
        {
            return base.CalcolaPrezzo() + base.CalcolaPrezzo()*NumEscursioni*15/100;
        }

        //metodi equals
        public bool Equals(Pacchetto_escursione cmp)
        {
            if (Destinazione == cmp.Destinazione && Durata == cmp.Durata && CostoBase == cmp.CostoBase && PensioneComp == cmp.PensioneComp)
            {
                return true;
            }
            return false;
        }

        // Override di Equals
        public override bool Equals(object obj)
        {
            // Controllo se oggetto è un pacchetto base
            if (obj is Pacchetto_escursione)
                return Equals((Pacchetto_escursione)obj);
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString() 
        {
            return base.ToString() + " NumEscursioni: " + PensioneComp;
        }
    }
}
