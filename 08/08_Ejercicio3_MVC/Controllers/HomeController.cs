﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using System.Diagnostics;
using Entidades;

namespace _08_Ejercicio3_MVC.Controllers
{
    public class HomeController : Controller
    {
        clsPersona persona1 = new clsPersona();
        public ActionResult Editar()
        {
            
            persona1.nombre = "Ricardo";
            persona1.apellidos = "Milos";
            persona1.direccion = "Sarinanda";
            return View(persona1);
        }

        /// <summary>
        /// Recoje los datos introducidos en el formulario e iguala los datos de la persona a lo introducirlo a la persona
        /// Postcondicion: returna a la Vista personaModificada la persona persona1
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="direccion"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Editar(string nombre, string apellidos, string direccion) {

            persona1.nombre = nombre;
            persona1.apellidos = apellidos;
            persona1.direccion = direccion;

            return View("PersonaModificada", persona1);
        }
        /// <summary>
        /// Recibe una persona y lo returna a la vista
        /// </summary>
        /// <param name="persona1"></param>
        /// <returns></returns>
        public ActionResult PersonaModificada(clsPersona persona1) { 
        
            return View();
        }
    }
}