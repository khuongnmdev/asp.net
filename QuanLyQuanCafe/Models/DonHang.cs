using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyQuanCafe.Models
{
    public class DonHang
    {
        [Display(Name = "Mã Đơn Hàng")]
        [Key]
        public int MaDonHang { get; set; }

        [Display(Name = "Mã Khách Hàng")]
        [Required]
        public int MaKhachHang { get; set; }

      
        [Display(Name = "Mã Nhân Viên")]
        [Required]
        public int MaNhanVien { get; set; }

        [Display(Name = "Ngày Đặt")]
        [DataType(DataType.Date)]
        public DateTime NgayDat { get; set; }

        [Display(Name = "Tổng Tiền")]
        [Precision(10, 2)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal TongTien { get; set; }
    }
}
