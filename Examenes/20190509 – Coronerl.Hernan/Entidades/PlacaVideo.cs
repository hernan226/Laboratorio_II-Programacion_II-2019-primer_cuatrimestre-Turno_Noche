using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlacaVideo:Periferico
    {
        private int ramMB;

        public PlacaVideo(string marca, string modelo, int ramMB)
            :base(marca, modelo, EConector.PCIExpress)
        {
            this.ramMB = ramMB;
        }

        /// <summary>
        /// Expone los datos de la placa de video
        /// </summary>
        /// <returns></returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PLACA DE VIDEO");
            sb.Append((string)this);
            sb.AppendLine(string.Format("Memoria {0}MB", this.ramMB));

            return sb.ToString();
        }
    }
}
