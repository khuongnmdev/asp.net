using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanCafe.Data;
using QuanLyQuanCafe.Models;

namespace QuanLyQuanCafe.Pages.QuanLyKhachHang
{
    public class IndexModel : PageModel
    {
        private readonly QuanLyQuanCafe.Data.QuanLyQuanCafeContext _context;

        public IndexModel(QuanLyQuanCafe.Data.QuanLyQuanCafeContext context)
        {
            _context = context;
        }

        public IList<KhachHang> KhachHang { get;set; } = default!;

        public async Task OnGetAsync()
        {
            KhachHang = await _context.KhachHang.ToListAsync();
        }
    }
}
