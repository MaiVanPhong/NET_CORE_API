using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class DaiLy
    {
        public string MaDaiLy { get; set; } = default!;
        public string TenDaiLy { get; set; } = default!;
        public string DiaChi { get; set; } = default!;
        public string NguoiDaiDien { get; set; } = default!;
        public string DienThoai { get; set; } = default!;
        public string MaHTPP { get; set; } = default!;
        public HeThogPhanPhoi heThogPhanPhoi { get; set; } = default!;
    }
}