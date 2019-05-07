using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Teclado:Periferico
    {
        private EDistribucion distribucion;

        #region COnstructores
        public Teclado(string marca, string modelo, EConector conector, EDistribucion distribucion)
            :base(marca, modelo, conector)
        {
            this.distribucion = distribucion;
        }

        public Teclado(string marca, string modelo, EConector conector)
            : base(marca, modelo, conector)
        {
            this.distribucion = EDistribucion.Dvorak;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// compara dos teclados usando su distribucion como referencia
        /// </summary>
        /// <param name="t"></param>
        /// <param name="distribucion"></param>
        /// <returns></returns>
        public static bool operator ==(Teclado t, EDistribucion distribucion)
        {
            return (t.distribucion == distribucion);
        }

        /// <summary>
        /// compara dos teclados usando su distribucion como referencia
        /// </summary>
        /// <param name="t"></param>
        /// <param name="distribucion"></param>
        /// <returns></returns>
        public static bool operator !=(Teclado t, EDistribucion distribucion)
        {
            return !(t == distribucion);
        }
        #endregion

        /// <summary>
        /// Expone los datos del teclado
        /// </summary>
        /// <returns></returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("TECLADO");
            sb.Append((string)this);
            sb.AppendLine(string.Format("Distribucion {0}", this.distribucion));

            return sb.ToString();
        }

        /// <summary>
        /// distribuciones de los teclados
        /// </summary>
        public enum EDistribucion
        {
            Dvorak,
            QWERTY,
            QWERTZ,
            AZERTY
        }
    }
}
