using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaDeJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(string nombre):this()
        {
            this.nombre = nombre;
        }

        #region Propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                    this.directorTecnico = value;
            }
            
        }
        #endregion

        #region Operadores
        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();

            if (e.directorTecnico != null)
                sb.AppendLine(e.directorTecnico.Mostrar());
            else
                sb.AppendLine("Sin DT asignado");
            foreach (Jugador item in e.jugadores)
            {
                sb.AppendLine(item.Mostrar());
            }

            return sb.ToString();
        }

        public static bool operator ==(Equipo e,Jugador j)
        {
            foreach (Jugador item in e.jugadores)
            {
                if (item.Dni == j.Dni)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && e.jugadores.Count < cantidadMaximaDeJugadores && j.ValidarAptitud())
                e.jugadores.Add(j);
            return e;
        }
        #endregion

        public static bool ValidarEquipo(Equipo e)
        {
            bool hayDelantero = false;
            bool hayDefensor = false;
            bool hayCentral = false;
            int cantidadArqueros = 0;

            foreach (Jugador item in e.jugadores)
            {
                if (item.Posicion == Posicion.Arquero)
                    cantidadArqueros++;                    
                if (item.Posicion == Posicion.Central)
                    hayCentral = true;
                if (item.Posicion == Posicion.Defensor)
                    hayDefensor = true;
                if (item.Posicion == Posicion.Delantero)
                    hayDelantero = true;
            }

            return (e.directorTecnico != null && cantidadArqueros == 1 
                && hayCentral && hayDefensor && hayDelantero 
                && e.jugadores.Count == cantidadMaximaDeJugadores);
        }
    }
}
