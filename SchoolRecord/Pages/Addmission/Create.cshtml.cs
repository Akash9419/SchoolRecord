using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolRecord.Data;
using SchoolRecord.Models;

namespace SchoolRecord.Pages.Addmission
{
    public class CreateModel : PageModel
    {
        private readonly SchoolRecord.Data.SchoolRecordContext _context;

        public CreateModel(SchoolRecord.Data.SchoolRecordContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SchoolClassID"] = new SelectList(_context.schoolClass, "id", "Name");
            return Page();
        }

        [BindProperty]
        public schoolAdminssion schoolAdminssion { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.schoolAdminssion.Add(schoolAdminssion);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
