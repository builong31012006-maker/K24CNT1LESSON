using System;
using System.ComponentModel.DataAnnotations;

namespace long2410900047_exam.Models
{
    public class bvlStudent
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Họ tên không được để trống")]
        [Display(Name = "Họ và Tên")]
        public string longName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng chọn giới tính")]
        [Display(Name = "Giới Tính")]
        public string longGender { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [Display(Name = "Ngày Sinh")]
        public DateTime longBirthDay { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        [Display(Name = "Email")]
        public string longEmail { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        [Display(Name = "Số Điện Thoại")]
        public string? longPhone { get; set; }

        [Display(Name = "Trạng Thái")]
        public bool longActive { get; set; }
    }
}