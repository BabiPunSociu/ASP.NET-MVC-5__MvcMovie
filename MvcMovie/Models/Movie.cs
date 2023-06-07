//      Thêm một lớp model

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }                 // id được csdl yêu cầu cho khóa chính
        public string Title { get; set; }


        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]                    // Chỉ định loại dữ liệu
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }          // Dấu '?' cho biết thuộc tính là vô hiệu... Tham chiếu Nullable
        

        [Column(TypeName = "decimal(18,2)")]        
        public decimal? Price { get; set; }

        public string? Rating { get; set; }
    }
}
