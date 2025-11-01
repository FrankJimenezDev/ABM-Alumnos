using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMAlumnos
{
    public class Alumno
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int legajo { get; set; }
        public string carrera { get; set; }
        public decimal promedio { get; set; }

        public override string ToString()
        {
            return $"{nombre};{apellido};{fechaNacimiento.ToShortDateString()};{legajo};{carrera};{promedio}";
        }
        public static Alumno getAlumnosFromTxt(string linea)
        {
            var partes = linea.Split(';');
            return new Alumno()
            {
                nombre = partes[0],
                apellido = partes[1],
                fechaNacimiento = DateTime.Parse(partes[2]),
                legajo = int.Parse(partes[3]),
                carrera = partes[4],
                promedio = decimal.Parse(partes[5])
            };

        }
    }
}
