using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [DisplayName("Tiêu đề ")]
        [Required(ErrorMessage = "Tiêu đề không được bỏ trống")]
        [MinLength(5, ErrorMessage = "Tiêu đề tối thiểu phải có 5 ký tự")]
        public string Title { get; set; }
        [DisplayName("Thông tin tóm tắt")]
        public string Short_content { get; set; }
        [DisplayName("Thông tin đầy đủ")]
        public string Full_content { get; set; }
        [DisplayName("Ngày tháng năm ")]
        public DateTime Publish_date { get; set; }
        [DisplayName("Ảnh")]
        [Required(ErrorMessage = "Ảnh không được bỏ trống")]
        public string ImageUrl { get; set; }
        public int Likes { get; set; }
        public int Views { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<BlogTag> BlogTags { get; set; } = new List<BlogTag>();
    }
}
