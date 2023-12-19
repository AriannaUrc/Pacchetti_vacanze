using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pacchetti_vacanze
{
    internal class Pacchetto_base
    {
        private string _destinazione;
        private int _durata;
        private float _costoBase;

        public string Destinazione
        {
            get { return _destinazione; } 
            set { _destinazione = value; }
        }

        public int Durata
        {
            get { return _durata; }
            set { if (value > 0) { _durata = value; } else { _durata = 0; } }
        }

        public float CostoBase
        {
            get { return _costoBase; }
            set { if (value > 0) { _costoBase = value; } else { _costoBase = 0; } }
        }


        public Pacchetto_base() 
        {
            Destinazione = "";
            Durata = 0;
            CostoBase = 0;
        }

        public Pacchetto_base(string destinazione, int durata, float costoBase)
        {
            Destinazione = destinazione;
            Durata = durata;
            CostoBase = costoBase;
        }

        public virtual float CalcolaPrezzo()
        {
            return CostoBase;
        }

        //metodi equals
        public virtual bool Equals(Pacchetto_base cmp)
        {
            if (Destinazione == cmp.Destinazione && Durata == cmp.Durata && CostoBase == cmp.CostoBase)
            {
                return true;
            }
            return false;
        }

        // Override di Equals
        public override bool Equals(object obj)
        {
            // Controllo se oggetto è un pacchetto base
            if (obj is Pacchetto_base)
                return Equals((Pacchetto_base)obj);
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //overrride di string
        public override string ToString()
        {
            return Destinazione + " " + Durata + " " + CostoBase;
        }
    }
}
