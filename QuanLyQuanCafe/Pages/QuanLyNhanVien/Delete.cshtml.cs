using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanCafe.Data;
using QuanLyQuanCafe.Models;

namespace QuanLyQuanCafe.Pages.QuanLyNhanVien
{
    public class DeleteModel : PageModel
    {
        private readonly QuanLyQuanCafe.Data.QuanLyQuanCafeContext _context;

        public DeleteModel(QuanLyQuanCafe.Data.QuanLyQuanCafeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public NhanVien NhanVien { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanvien = await _context.NhanVien.FirstOrDefaultAsync(m => m.ID == id);

            if (nhanvien == null)
            {
                return NotFound();
            }
            else
            {
                NhanVien = nhanvien;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanvien = await _context.NhanVien.FindAsync(id);
            if (nhanvien != null)
            {
                NhanVien = nhanvien;
                _context.NhanVien.Remove(NhanVien);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
