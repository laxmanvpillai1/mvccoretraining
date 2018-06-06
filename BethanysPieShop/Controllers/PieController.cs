﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BethanysPieShop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
		private readonly ICategoryRepository _categoryRepository;
		private readonly IPieRepository _pieRepository;

		public PieController(ICategoryRepository categoryRepository, IPieRepository pieRepository)
        {
            _categoryRepository = categoryRepository;
            _pieRepository = pieRepository;
        }

		public ViewResult List(){
			return View(_pieRepository.Pies);
		}
    }


}
