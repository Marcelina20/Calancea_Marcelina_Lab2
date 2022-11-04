using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Calancea_Marcelina_Lab2.Data;
using Calancea_Marcelina_Lab2.Models;

namespace Calancea_Marcelina_Lab2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Calancea_Marcelina_Lab2.Data.Calancea_Marcelina_Lab2Context _context;

        public DetailsModel(Calancea_Marcelina_Lab2.Data.Calancea_Marcelina_Lab2Context context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
