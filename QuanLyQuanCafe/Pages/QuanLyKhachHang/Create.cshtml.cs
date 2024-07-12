using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuanLyQuanCafe.Data;
using QuanLyQuanCafe.Models;

namespace QuanLyQuanCafe.Pages.QuanLyKhachHang
{
    public class CreateModel : PageModel
    {
        private readonly QuanLyQuanCafe.Data.QuanLyQuanCafeContext _context;

        public CreateModel(QuanLyQuanCafe.Data.QuanLyQuanCafeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public KhachHang KhachHang { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.KhachHang.Add(KhachHang);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
