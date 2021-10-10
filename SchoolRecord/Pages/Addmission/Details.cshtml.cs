﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolRecord.Data;
using SchoolRecord.Models;

namespace SchoolRecord.Pages.Addmission
{
    public class DetailsModel : PageModel
    {
        private readonly SchoolRecord.Data.SchoolRecordContext _context;

        public DetailsModel(SchoolRecord.Data.SchoolRecordContext context)
        {
            _context = context;
        }

        public schoolAdminssion schoolAdminssion { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            schoolAdminssion = await _context.schoolAdminssion
                .Include(s => s.schoolClass).FirstOrDefaultAsync(m => m.id == id);

            if (schoolAdminssion == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
