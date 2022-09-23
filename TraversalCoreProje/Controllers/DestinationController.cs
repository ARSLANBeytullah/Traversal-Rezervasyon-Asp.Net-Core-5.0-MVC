﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal()); //Refaktoring yapılacak ve EntityFramework'e bapımlılık sonradan giderilecektir.
        public IActionResult Index()
            {
                var values = destinationManager.TGetList();
                return View(values);
            }
        }
    
}

