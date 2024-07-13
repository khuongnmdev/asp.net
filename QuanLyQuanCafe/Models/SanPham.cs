using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyQuanCafe.Models
{
    public class SanPham
    {
        [Display(Name = "Mã Sản Phẩm")]
        [Key]
        public int MaSanPham { get; set; }

        [Display(Name = "Tên Khách Hàng")]
        [Column(TypeName = "nvarchar(100)")]
        public string TenKhachHang { get; set; } = string.Empty;

        [Display(Name = "Giá")]
        [Precision(10, 2)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Gia { get; set; }

        [Display(Name = "Loại")]
        [Column(TypeName = "nvarchar(50)")]
        public string Loai { get; set; } = string.Empty;

        [Display(Name = "Đơn Vị Tính")]
        [Column(TypeName = "nvarchar(10)")]
        public string DonViTinh { get; set; } = string.Empty;
    }
}
