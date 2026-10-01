using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreL.Models
{
    [Table("Category")]
    public class Category
    {
        // Khởi tạo danh sách mặc định để tránh lỗi NullReferenceException
        public Category()
        {
            Products = new HashSet<Product>();
            CreatedDate = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(100, ErrorMessage = "Tên danh mục không quá 100 ký tự")]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "tinyint")]
        public byte Status { get; set; }

        public DateTime CreatedDate { get; set; }

        // Danh sách sản phẩm theo danh mục (Quan hệ 1 - N)
        public virtual ICollection<Product> Products { get; set; }
    }
}