using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Proyectos.App.Dominio.Entidades;

namespace Proyectos.App.Persistencia.AppRepositorios
{
    public class Repositorios : IRepositorios
    {
       private readonly AppContext _appContext;
       public IEnumerable<Formador> formadores {get; set;} 
       public IEnumerable<Tutor> tutores {get; set;} 

       public Repositorios(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        //AQUÍ CADA UNO DE LOS MÉTODOS DEL CRUD, REFERENCIADOS EN LA INTERFACE
        //SIGUIENTE DIAPOSITIVA

        Formador IRepositorios.AddFormador(Formador formador)
        {
        try
         {
            var FormadorAdicionado = _appContext.formador.Add( formador );  //INSERT en la BD
            _appContext.SaveChanges();                  
            return FormadorAdicionado.Entity;
          }catch
            {
                throw;
            }
        }

        IEnumerable<Formador> IRepositorios.GetAllFormadores(string? searchString)
        {
            if (searchString == null)
                formadores = _appContext.formador;
            else{
                //busca coincidencias entre los registros y la cadena enviada
                //formadores = _appContext.formador.Where(s => s.identificacion.Contains(searchString));   
                //busca solamente los que son exactamente igual a la cadena enviada 
                formadores = _appContext.formador.Where(s => s.identificacion.Equals(searchString));    
            }
            return formadores;
        }

       Formador IRepositorios.GetFormador(int? idFormador)
       {
            return _appContext.formador.FirstOrDefault(p => p.id == idFormador);
       }

       Formador IRepositorios.UpdateFormador(Formador formador)
        {    
            var FormadorEncontrado = _appContext.formador.FirstOrDefault(p => p.id == formador.id);
            if (FormadorEncontrado != null)
            {
                FormadorEncontrado.identificacion  = formador.identificacion;
                FormadorEncontrado.nombre          = formador.nombre;
                FormadorEncontrado.mail            = formador.mail;
                FormadorEncontrado.movil           = formador.movil;
                FormadorEncontrado.vigente         = formador.vigente;
                _appContext.SaveChanges();
            }
            return FormadorEncontrado;
        }

        void IRepositorios.DeleteFormador(int idFormador)
        {   
            var FormadorEncontrado = _appContext.formador.FirstOrDefault(p => p.id == idFormador);
            if (FormadorEncontrado != null){                
                _appContext.formador.Remove(FormadorEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }

        //repositorio para tutores
        Tutor IRepositorios.AddTutor(Tutor tutor)
        {
        try
         {
            var TutorAdicionado = _appContext.tutor.Add( tutor );  //INSERT en la BD
            _appContext.SaveChanges();                  
            return TutorAdicionado.Entity;
          }catch
            {
                throw;
            }
        }

        IEnumerable<Tutor> IRepositorios.GetAllTutores(string? searchString)
        {
            if (searchString == null)
                tutores = _appContext.tutor;
            else{
                //busca coincidencias entre los registros y la cadena enviada
                //tutores = _appContext.tutor.Where(s => s.identificacion.Contains(searchString));   
                //busca solamente los que son exactamente igual a la cadena enviada 
                tutores = _appContext.tutor.Where(s => s.identificacion.Equals(searchString));    
            }
            return tutores;
        }

       Tutor IRepositorios.GetTutor(int? idTutor)
       {
            return _appContext.tutor.FirstOrDefault(p => p.id == idTutor);
       }

       Tutor IRepositorios.UpdateTutor(Tutor tutor)
        {    
            var TutorEncontrado = _appContext.tutor.FirstOrDefault(p => p.id == tutor.id);
            if (TutorEncontrado != null)
            {
                TutorEncontrado.identificacion  = tutor.identificacion;
                TutorEncontrado.nombre          = tutor.nombre;
                TutorEncontrado.mail            = tutor.mail;
                TutorEncontrado.movil           = tutor.movil;
                TutorEncontrado.vigente         = tutor.vigente;
                _appContext.SaveChanges();
            }
            return TutorEncontrado;
        }

        void IRepositorios.DeleteTutor(int idTutor)
        {   
            var TutorEncontrado = _appContext.tutor.FirstOrDefault(p => p.id == idTutor);
            if (TutorEncontrado != null){                
                _appContext.tutor.Remove(TutorEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }

    } //fin repositorios
}

