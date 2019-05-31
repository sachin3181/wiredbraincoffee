using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee.Pages
{
    public class ItemModel : PageModel
    {
        private IMenuService _menuService;
        public MenuItem Item { get; set; }
        public ItemModel(IMenuService menuService)
        {
           _menuService = menuService;
        }
        public void OnGet(string slug)
        {
           
            Item = _menuService.GetMenuItems().FirstOrDefault(x => x.Slug == slug);
        }
    }
}