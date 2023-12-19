using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacchetti_vacanze
{
    internal class Pacchetto_pasto : Pacchetto_base
    {
        private bool _pensioneComp;

        public bool PensioneComp
        {
            get { return _pensioneComp; }
            set { _pensioneComp = value;}
        }

        public Pacchetto_pasto() : base()
        {
            PensioneComp = false;
        }

        public Pacchetto_pasto(bool Pensione, string destinazione, int durata, float costoBase) : base(destinazione, durata, costoBase)
        {
            PensioneComp = Pensione;
        }


        public override float CalcolaPrezzo()
        {
            if(!PensioneComp)
            {
                return (base.CalcolaPrezzo() + 25*Durata);
            }
            else
            {
                return (base.CalcolaPrezzo() + 35*Durata);
            }
        }

        //metodi equals
        public override bool Equals(Pacchetto_pasto cmp)
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
            if (obj is Pacchetto_pasto)
                return Equals((Pacchetto_pasto)obj);
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString() 
        {
            return base.ToString() + " " + PensioneComp;
        }
    }
}
