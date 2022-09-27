//Directivas
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Proyectos.App.Dominio.Entidades;
using Proyectos.App.Persistencia.AppRepositorios;

namespace Proyectos.App.Persistencia.AppRepositorios
{
    public interface IRepositorios
    {
        //contratos o firmas para los metodos Formador        
        Formador AddFormador(Formador formador);
        IEnumerable<Formador> GetAllFormadores(string? searchString);         
        Formador GetFormador(int? idFormador);
        Formador UpdateFormador(Formador formador);
        void DeleteFormador(int idFormador); 

        //contratos o firmas para los metodos Tutor        
        Tutor AddTutor(Tutor tutor);
        IEnumerable<Tutor> GetAllTutores(string? searchString);         
        Tutor GetTutor(int? idTutor);
        Tutor UpdateTutor(Tutor tutor);
        void DeleteTutor(int idTutor); 
    }
}



