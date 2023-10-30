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
        private string Fecha_Nac;
        private string Email;
        private bool Analitico;
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
