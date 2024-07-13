using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyQuanCafe.Models
{
    public class NhanVien
    {
        [Display(Name = "Mã Nhân Viên")]
        [Key]
        public int MaNhanVien { get; set; }

        [Display(Name = "Tên Nhân Viên")]
        [Column(TypeName = "nvarchar(100)")]
        public string TenNhanVien { get; set; } = string.Empty;

        [Display(Name = "Giới Tính")]
        [Column(TypeName = "nvarchar(10)")]
        public string GioiTinh { get; set; } = string.Empty;

        [Display(Name = "Chức Vụ")]
        [Column(TypeName = "nvarchar(50)")]
        public string ChucVu { get; set; } = string.Empty;

        [Display(Name = "Điện Thoại")]
        [Column(TypeName = "nvarchar(20)")]
        public string DienThoai { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; } = string.Empty;
    }
}
