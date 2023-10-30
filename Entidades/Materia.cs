using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Materia
    {
        #region Atributos
        private int Codigo;
        private string Nombre;
        private int Año_Cursado;
        private string Dia_Cursado;
        private string Nombre_Carrera;
        #endregion

        #region Constructores
        public Materia()
        { }
        public Materia(int Cod, string Nom, int Año, string Dia_Clases, string Carrera)
        {
            Codigo = Cod;
            Nombre = Nom;
            Año_Cursado = Año;
            Dia_Cursado = Dia_Clases;
            Nombre_Carrera = Carrera;

        }
        #endregion
    }
}
