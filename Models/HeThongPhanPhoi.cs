using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class HeThogPhanPhoi
    {
        public string MaHTPP { get; set; } = default!;
        public string TenHTPP { get; set; } = default!;
        public ICollection<DaiLy> DaiLys { get; set; } = default!;
    }
}