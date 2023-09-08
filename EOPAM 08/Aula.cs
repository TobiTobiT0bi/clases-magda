using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
/*Queremos representar con programación orientada a objetos, un aula con estudiantes y un profesor.
Tanto de los estudiantes como de los profesores necesitamos saber su nombre, edad y sexo. De los estudiantes, queremos saber también su calificación actual (entre 0 y 10) y del profesor que materia da.
Las materias disponibles son matemáticas, filosofía y física.
Los estudiantes tendrán un 50% para no ir a clase, por lo que sí hacen faltazo no van a clase pero aunque no vayan quedará registrado en el aula (como que cada uno tiene su sitio).
El profesor tiene un 20% de no encontrarse disponible (reuniones, baja, etc.)
Las dos operaciones anteriores deben llamarse igual en Estudiante y Profesor (polimorfismo).
El aula debe tener un identificador numérico, el número máximo de estudiantes y para que está destinada (matemáticas, filosofía o física). Piensa que más atributos necesita.
Un aula para que se pueda dar clase necesita que el profesor esté disponible, que el profesor de la materia que correspondiente esté en el aula correspondiente (un profesor de filosofía no puede dar en un aula de matemáticas) y que haya más del 50% de alumnos.
El objetivo es crear un aula de alumnos y un profesor y determinar si puede darse clase, teniendo en cuenta las condiciones antes dichas.
Si se puede dar clase mostrar cuántos alumnos y alumnas (por separado) están aprobados de momento (imaginad que les están entregando las notas).
NOTA: Los datos pueden ser aleatorios (nombres, edad, calificaciones, etc.) siempre y cuando tengan sentido (edad no puede ser 80 en un estudiante o calificación ser 12). */
namespace EOPAM_08
{
    internal class Aula
    {
        public int identificador = 0;
        public int maximoestudiantes = 0;
        public string materia = "";
        public List<Estudiantes> est = new List<Estudiantes>();

        string[] materiasDisponibles = { "matematicas", "filosofia", "fisica" };

        public Aula(int identificador, int maximoestudiantes, Random rnd)
        {
            this.identificador = identificador;
            this.maximoestudiantes = maximoestudiantes;
            materia = materiasDisponibles[rnd.Next(0, materiasDisponibles.Count())];
        }

        public void agregarEstudiante(Estudiantes estu) {
            est.Add(estu);
        }

        public bool MateriaProfe(Profesores profe) { 
            return profe.materia == materia;
        }

        public bool cantAlumnosApta() {
            Random rnd = new Random();

            //int cantVino = est.Count(p => p.Vino(rnd) == true);

            //return cantVino >= (est.Count() / 2);

            return est.Count(p => p.Vino(rnd) == true) >= (est.Count() / 2);
        }
    }
}
