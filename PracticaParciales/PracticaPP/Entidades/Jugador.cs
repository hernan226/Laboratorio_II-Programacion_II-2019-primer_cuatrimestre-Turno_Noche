using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador:Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public Jugador(string apellido, string nombre, int edad, int dni,
            float peso, float altura, Posicion posicion) 
            : base(apellido, nombre, edad, dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        #region Propiedades
        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }
        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }
        #endregion

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("Altura: " + this.Altura);
            sb.AppendLine("Peso: " + this.Peso);
            sb.AppendLine("Posicion: " + this.Posicion.ToString());

            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {            
            return (ValidarEstadoFisico() && this.Edad > 40);
        }

        public bool ValidarEstadoFisico()
        {
            return ((this.Peso / (this.Altura * this.Altura)) >= 18.5 &&
                (this.Peso / (this.Altura * this.Altura)) <= 25);
        }
    }
}
