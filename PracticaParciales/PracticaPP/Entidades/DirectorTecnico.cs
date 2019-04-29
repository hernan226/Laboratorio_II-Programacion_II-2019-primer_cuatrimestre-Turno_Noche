using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico:Persona
    {
        private int añosDeExperiencia;

        public DirectorTecnico(string apellido, string nombre, int edad, int dni, int añosExperiencia)
            :base(apellido, nombre, edad, dni)
        {
            this.añosDeExperiencia = añosExperiencia;
        }

        public int AñosDeExperiencia
        {
            get
            {
                return this.añosDeExperiencia;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("Años de experiencia: " + this.AñosDeExperiencia);
            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            return (this.Edad<65&&this.AñosDeExperiencia>=2);
        }
    }
}
