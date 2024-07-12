using System.ComponentModel.DataAnnotations;

namespace QuanLyQuanCafe.Models
{
    public class KhachHang
    {
        public int ID { get; set; }
        public string TenKhachHang { get; set; } = string.Empty;
        public string DienThoai { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string DiaChi { get; set; } = string.Empty;
        public string GioiTinh { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }
    }
}
