using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using CineMania.Data;
using CineMania.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CineMania.Pages.Movies
{
    public class ContactModel : PageModel
    {
        #region context config
        private readonly CinemaniaContext _context;
        public ContactModel(CinemaniaContext context)
        {
            _context = context; 
        }

        #endregion

        #region saving

        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty] 
        public Message Message { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
        
            _context.Messages.Add(Message);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }

        #endregion
        
    }
}