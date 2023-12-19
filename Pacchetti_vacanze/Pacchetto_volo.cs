using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacchetti_vacanze
{
    internal class Pacchetto_volo : Pacchetto_base
    {
        private bool _voloRitorno;

        public bool VoloRitorno
        {
            get { return _voloRitorno;}
            set { _voloRitorno = value;}
        }

        public Pacchetto_volo() : base()
        {
            VoloRitorno = false;
        }

        public Pacchetto_volo(bool voloRitorno, string destinazione, int durata, float costoBase) : base(destinazione, durata, costoBase)
        {
            VoloRitorno = voloRitorno;
        }


        public override float CalcolaPrezzo()
        {
            if(!VoloRitorno)
            {
                return (base.CalcolaPrezzo() + CostoBase*5/10);
            }
            else
            {
                return (base.CalcolaPrezzo() + CostoBase * 85 / 100);
            }
        }

        //metodi equals
        public override bool Equals(Pacchetto_volo cmp)
        {
            if (Destinazione == cmp.Destinazione && Durata == cmp.Durata && CostoBase == cmp.CostoBase && VoloRitorno == cmp.VoloRitorno)
            {
                return true;
            }
            return false;
        }

        // Override di Equals
        public override bool Equals(object obj)
        {
            // Controllo se oggetto è un pacchetto base
            if (obj is Pacchetto_volo)
                return Equals((Pacchetto_volo)obj);
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString() 
        {
            return base.ToString() + " " + VoloRitorno;
        }
    }
}
