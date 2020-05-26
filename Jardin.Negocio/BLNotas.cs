using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jardin.Entidades;
using Jardin.Datos;
using Jardin.Utilidades;

namespace Jardin.Negocio
{
    public class BLNotas
    {

        DAONotas daoNota = new DAONotas();

        public int insertarNota(Notas nota)
        {
            return daoNota.insertarNotas(nota);
        }

        public List<Notas> listarNotasEstudiante(int idEstudiante,int idPeriodo)
        {
            return daoNota.listarNotasPorEstudiante(idEstudiante,idPeriodo);
        }

        public int validarExistenciaNota(int idEstudiante, int idMateria, int periodo)
        {
            return daoNota.validarExistenciaNota(idEstudiante, idMateria, periodo);

        }

        public int modificarNotas(Notas nota)
        {
            return daoNota.modificarNotas(nota);
        }

        public List<Notas> listarNotasEstudianteAnio(int idEstudiante, string anio)
        {
            return daoNota.listarNotasEstudianteAnio(idEstudiante, anio);
        }

        public int insertarNotasFinal(Notas NotaFinal)
        {
            return daoNota.insertarNotasFinal(NotaFinal);

        }

        public double listarNotasFinalesAnio(int idAlumno,string anio, int idMateria)
        {
            return daoNota.listarNotasFinalesAnio(idAlumno, anio, idMateria);

        }

        public void actualizarValoracionFinal(int idAlumno, string anio, int idMateria, string valoracionFinal)
        {
            daoNota.actualizarValoracionFinal(idAlumno, anio, idMateria, valoracionFinal);


        }

        public void modificarNotasFinal(Notas notaFinal)
        {
            daoNota.modificarNotasFinal(notaFinal);

        }

        public List<Notas> listarValoracionPeriodo(int idEstudiante, int idPeriodo)
        {
            return daoNota.listarValoracionPeriodo(idEstudiante,idPeriodo);

        }

        public List<DatosReportePeriodo> listarPeriodoReporte(int idEstudiante, int idPeriodo)
        {
            return daoNota.listarPeriodoReporte(idEstudiante, idPeriodo);

        }

        public List<DatosReporteFinal> listarReporteFinal(int idEstudiante, string anio)
        {
            return daoNota.listarReporteFinal(idEstudiante, anio);

        }

    }
}
