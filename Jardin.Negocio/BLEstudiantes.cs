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

        public List<Estudiantes> listarGruposEstudiantes()
        {
            DAOestudiantes estudiante = new DAOestudiantes();
            return estudiante.listarGruposEstudiantes();
        }

        public int asignarGrupo(Estudiantes estudent)
        {
            DAOestudiantes estudiante = new DAOestudiantes();
            return estudiante.asignarGrupo(estudent);

        }

        public int contarEstudiantesGrupo(int grupo)
        {
            DAOestudiantes estudiante = new DAOestudiantes();
            return estudiante.totalEstudiantesGrupo(grupo);


        }
        public List<String> consultarPorDocumento(string documento)
        {
            DAOestudiantes estudiante = new DAOestudiantes();
            return estudiante.consultarPorDocumento(documento);

        }

        public List<Estudiantes> buscarEstudianteGrupo(string documento)
        {
            DAOestudiantes estudiante = new DAOestudiantes();
            return estudiante.buscarEstudianteGrupo(documento);
        }

        public List<Estudiantes> listarEstudiantesPorGrupo(int grupo)
        {
            DAOestudiantes estudiante = new DAOestudiantes();
            return estudiante.listarEstudiantesPorGrupo(grupo);

        }


    }
}
