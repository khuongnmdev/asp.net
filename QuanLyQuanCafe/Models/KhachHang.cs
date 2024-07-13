using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyQuanCafe.Models
{
    public class KhachHang
    {
        [Display(Name = "Mã Khách Hàng")]
        [Key]
        public int MaKhachHang { get; set; }

        [Display(Name = "Tên Khách Hàng")]
        [Column(TypeName = "nvarchar(100)")]
        public string TenKhachHang { get; set; } = string.Empty;

        [Display(Name = "Điện Thoại")]
        [Column(TypeName = "nvarchar(20)")]
        public string DienThoai { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Địa Chỉ")]
        [Column(TypeName = "nvarchar(200)")]
        public string DiaChi { get; set; } = string.Empty;

        [Display(Name = "Giới Tính")]
        [Column(TypeName = "nvarchar(10)")]
        public string GioiTinh { get; set; } = string.Empty;

        [Display(Name = "Ngày Sinh")]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }
    }
}
