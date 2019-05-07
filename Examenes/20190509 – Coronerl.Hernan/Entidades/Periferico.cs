using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Periferico
    {
        private EConector conector;
        private string marca;
        private string modelo;
        

        public Periferico(string marca, string modelo, EConector conector)
        {
            this.conector = conector;
            this.marca = marca;
            this.modelo = modelo;
        }

        #region Operadores
        /// <summary>
        /// Muestra la Info. del periferico
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Periferico p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format(" {0} {1} (Puerto: {2})", p.marca, p.modelo, p.conector));
            return sb.ToString();
        }

        /// <summary>
        /// Verifica que dos perifericos sean iguaLES
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Periferico p1, Periferico p2)
        {
            return (p1.marca == p2.marca && p1.modelo == p2.modelo);
        }

        /// <summary>
        /// Verifica que dos perifericos no sean iguaLES
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Periferico p1, Periferico p2)
        {
            return !(p1 == p2);
        }
        #endregion

        public abstract String ExponerDatos();
    }
}
