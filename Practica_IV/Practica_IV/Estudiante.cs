using System;
using System.Linq;
namespace Practica_IV
{
    public class Estudiante
    {
        private string codigo, nombre, facultad;
        private int edad, id;


        public int Id { get { return id; } set { id = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public string Codigo { get { return codigo; } set { codigo = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Facultad { get { return facultad; } set { facultad = value; } }

        public Estudiante(int id, string codigo, string nombre, int edad, string facultad)
        {
            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
            this.edad = edad;
            this.facultad = facultad;
        }


        public string mostrar()
        {
            return id + " " + codigo + " " + nombre + " " + edad + " "+ facultad;
        }

    }
}

