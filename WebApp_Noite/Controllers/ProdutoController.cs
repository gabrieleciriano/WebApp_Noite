﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp_Noite.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Listar()
        {
            return View();
        }

        //outro metodo que retorna uma tela
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}