using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Maquina
    {
        private int cantidadMaximaPerifericos;
        private string nombre;
        List<Periferico> perifericos;

        #region Constructores
        private Maquina()
        {
            this.perifericos = new List<Periferico>();
            this.CantidadMaximaPerifericos = 3;
        }

        public Maquina(string nombre)
            :this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// establece la cantidad maxima de perifericos
        /// </summary>
        public int CantidadMaximaPerifericos
        {
            get
            {
                return this.cantidadMaximaPerifericos;
            }

            set
            {
                if (value<0)
                    this.cantidadMaximaPerifericos = 1;
                else if (value>4)
                    this.cantidadMaximaPerifericos = 4;
                else
                    this.cantidadMaximaPerifericos = value;
            }
        }

        /// <summary>
        /// Establece y retorna el nombre de la maquina
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }

        /// <summary>
        /// Muestra la Info. de todos los perifericos de la maquina
        /// </summary>
        public string SystemInfo
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (Periferico item in this.perifericos)
                {
                    if (item is Teclado)
                    {
                        sb.AppendLine(item.ExponerDatos());
                    }
                }
                foreach (Periferico item in this.perifericos)
                {
                    if (item is PlacaVideo)
                    {
                        sb.AppendLine(item.ExponerDatos());
                    }
                }
                return sb.ToString();
            }
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Comprueba si un periferico esta en una maquina
        /// </summary>
        /// <param name="m"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==(Maquina m, Periferico p)
        {
            foreach (Periferico item in m.perifericos)
            {
                if (item == p)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Comprueba si un periferico no esta en una maquina
        /// </summary>
        /// <param name="m"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator !=(Maquina m, Periferico p)
        {
            return !(m == p);
        }

        /// <summary>
        /// Si no existe ya agrega un periferico a la maquina
        /// </summary>
        /// <param name="m"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string operator +(Maquina m, Periferico p)
        {
            if (m != p && m.CantidadMaximaPerifericos > m.perifericos.Count)
            {
                m.perifericos.Add(p);
                return "Periferico conectado!";
            }
            else
                return "No se puede conectar el dispositivo.";
        }

        /// <summary>
        /// Si existe ya elimina un periferico a la maquina
        /// </summary>
        /// <param name="m"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string operator -(Maquina m, Periferico p)
        {
            if (m == p)
            {
                m.perifericos.Remove(p);
                return "Periferico desconectado!";
            }
            else
                return "No se puede desconectar el dispositivo.";
        }
        #endregion
    }
}
