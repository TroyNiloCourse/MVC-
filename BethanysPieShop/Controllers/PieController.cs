using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPieRepository _pieRepository;
      

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _pieRepository = pieRepository;
        }
     /*   public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;
            piesListViewModel.CurrentCategory = "Cheesse cakes";
            return View(piesListViewModel);
        }*/
        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if(pie == null)
             return NotFound();
            return View(pie);
            
        }
        public ViewResult List(string category)
        {
            IEnumerable<Pie> pies;
            string currentCategory;

            if (string.IsNullOrEmpty(category)) 
            {
                pies = _pieRepository.AllPies.OrderBy(p => p.PieId);
                currentCategory = "All Pies";
            }
            else
            {
                pies = _pieRepository.AllPies.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.PieId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }
            return View(new PiesListViewModel
            {
                Pies = pies,
                CurrentCategory = currentCategory
            }); ;
        }
    }
}
