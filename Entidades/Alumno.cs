using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        #region Atributos
        private int DNI;
        private string NombreApellido;
        private DateTime Fecha_Nac;
        private string Email;
        private bool Analitico;

        public int dni
        {
            get { return DNI; }
            set { DNI = value; }

        }

        public string nombreapellido
        {
            get { return NombreApellido; }
            set { NombreApellido = value; }
        }

<<<<<<< HEAD
        public DateTime fecha_nac
        {
            get { return Fecha_Nac;}
            set { Fecha_Nac = value;}
        }
=======

>>>>>>> a17495e2fe1f0992cc50e44c8d6b55a2da5fe98d
        #endregion

        #region Constructores
        public Alumno()
        { }
        public Alumno(int Dni, string nomApellido, string fecha_Nac, string email, bool analitico)
        {
            DNI = Dni;
            NombreApellido = nomApellido;
            Fecha_Nac = fecha_Nac;
            Email = email;
            Analitico = analitico;
        }
        #endregion

        #region Metodos
        
        #endregion
    }


}
