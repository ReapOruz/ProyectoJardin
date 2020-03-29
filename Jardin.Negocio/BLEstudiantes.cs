using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jardin.Entidades;
using Jardin.Datos;


namespace Jardin.Negocio
{
    public class BLEstudiantes
    {
        //listar estudiantes
        public List<Estudiantes> listarEstudiantes()
        {
            DAOestudiantes estudiante = new DAOestudiantes();
            return estudiante.listarEstudiantes();
        }

        //insertar estudiantes
        public int insertarEstudiante(Estudiantes student)
        {
            DAOestudiantes estudiante = new DAOestudiantes();
            return estudiante.insertarEstudiante(student);
        }

        //actualizarEstudiante
        public int actualizarEstudiante(Estudiantes student)
        {
            DAOestudiantes estudiante = new DAOestudiantes();
            return estudiante.actualizarEstudiantes(student);
        }

    }
}
