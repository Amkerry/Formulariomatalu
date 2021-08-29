using Microsoft.AspNetCore.Mvc;
using formulariomatalu.Models;
using formulariomatalu.Data;
using System.Linq;

namespace formulariomatalu.Controllers
{
    public class RegistroController:Controller
    {
        private readonly ApplicationDbContext _context;

        public RegistroController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            return View(_context.DataRegistros.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Registro objRegistro)
        {
            _context.Add(objRegistro);
            _context.SaveChanges();
            ViewData["Message"] = "El alumno ya esta registrado para la matricula";
            //return RedirectToAction(nameof(Index));
            return View();
        }

        
        public IActionResult Edit(int id)
        {
            Registro objRegistro = _context.DataRegistros.Find(nombre);
            if(objRegistro == null){
                return NotFound();
            }
            return View(objRegistro);
        }

        [HttpPost]
        public IActionResult Edit(int id,[Bind("Nombres,Apellidos,FechaNacimiento,Dni,Genero,Carrera")] Registro objRegistro)
        {
             _context.Update(objRegistro);
             _context.SaveChanges();
              ViewData["Message"] = "El contacto ya esta actualizado";
             return View(objRegistro);
        }

        public IActionResult Delete(int nombres)
        {
            Registro objRegistro = _context.DataRegistros.Find(nombres);
            _context.DataRegistros.Remove(objRegistro);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}