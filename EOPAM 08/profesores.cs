using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOPAM_08
{
    internal class Profesores : Persona
    {
        public string materia = "";

        string[] materiasDisponibles = { "matematicas", "filosofia", "fisica" };

        public Profesores(Random rnd) : base(rnd)
        {
            materia = materiasDisponibles[rnd.Next(0, materiasDisponibles.Length)];
            edad = rnd.Next(25, 60);
        }

        public bool Vino(Random rnd)
        {
            esta = (rnd.Next(0, 5) == 4);
            return esta;
        }
    }


}