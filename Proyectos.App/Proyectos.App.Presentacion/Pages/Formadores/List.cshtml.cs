using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

using Proyectos.App.Dominio.Entidades;
using Proyectos.App.Persistencia.AppRepositorios;
using Proyectos.App.Persistencia;

namespace Proyectos.App.Presentacion.Pages.Formadores
{
    //[Authorize]
    public class ListModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public IEnumerable<Formador> formadores {get; set;} 
        public string searchString;          

        public ListModel()
        {
            this._appContext = new Repositorios(new Proyectos.App.Persistencia.AppContext());
        }
       
        public void OnGet()
        {
            formadores = _appContext.GetAllFormadores(searchString);
        }        

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            formadores = _appContext.GetAllFormadores(searchString);
            return Page();
        }
        
    }
}