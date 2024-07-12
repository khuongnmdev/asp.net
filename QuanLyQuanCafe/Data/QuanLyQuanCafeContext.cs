﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanCafe.Models;

namespace QuanLyQuanCafe.Data
{
    public class QuanLyQuanCafeContext : DbContext
    {
        public QuanLyQuanCafeContext (DbContextOptions<QuanLyQuanCafeContext> options)
            : base(options)
        {
        }

        public DbSet<QuanLyQuanCafe.Models.KhachHang> KhachHang { get; set; } = default!;
    }
}