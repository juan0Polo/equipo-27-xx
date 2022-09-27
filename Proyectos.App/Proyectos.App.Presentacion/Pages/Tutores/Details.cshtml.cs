using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Entidades;
using Proyectos.App.Persistencia.AppRepositorios;
using Proyectos.App.Persistencia;

namespace Proyectos.App.Presentacion.Pages.Tutores
{
    public class DetailsModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Tutor tutor  { get; set; } 

        public DetailsModel()
        {            
            this._appContext = new Repositorios(new Proyectos.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? tutorId)
        {
            if (tutorId.HasValue)
            {
                tutor = _appContext.GetTutor(tutorId.Value);
            }
            if (tutor == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }
    }
}