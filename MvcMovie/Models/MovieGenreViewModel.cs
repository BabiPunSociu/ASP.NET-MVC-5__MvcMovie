using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie>? Movies { get; set; }
        public SelectList? Genres { get; set; }     // SelectList: chứa danh sách các thể loại, cho phép người dùng chọn 1 thể loại từ List
        public string? MovieGenre { get; set; }     // MovieGenre chứa thể loại đã chọn
        public string? SearchString { get; set; }   // SearchString chứa văn bản mà người nhập vào hộp văn bản tìm kiếm
    }
}
