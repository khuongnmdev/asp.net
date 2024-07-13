using System.ComponentModel.DataAnnotations;

namespace QuanLyQuanCafe.Models
{
    public class KhachHang
    {
        [Display(Name = "Mã Khách Hàng")]
        public int ID { get; set; }
        [Display(Name = "Tên Khách Hàng")]
        public string TenKhachHang { get; set; } = string.Empty;
        [Display(Name = "Điện Thoại")]
        public string DienThoai { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        [Display(Name = "Địa Chỉ")]
        public string DiaChi { get; set; } = string.Empty;
        [Display(Name = "Giới Tính")]
        public string GioiTinh { get; set; } = string.Empty;

        [Display(Name = "Ngày Sinh")]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }
    }
}
