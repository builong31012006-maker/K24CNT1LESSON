using System.ComponentModel.DataAnnotations;

namespace buivanlong_2410900047_exam.Models
{
    public class bvlStudent
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Họ và tên không được để trống")]
        [Display(Name = "Họ và Tên")]
        public string bvlName { get; set; } = string.Empty;

        [Display(Name = "Giới Tính")]
        public string? Gender { get; set; }

        [Display(Name = "Ngày Sinh")]
        [DataType(DataType.Date)]
        public DateTime? bvlBirthDay { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string? HvtEmail { get; set; }

        [Display(Name = "Số Điện Thoại")]
        [Phone]
        public string? bvlPhone { get; set; }

        [Display(Name = "Trạng Thái")]
        public bool bvlActive { get; set; }
    }
}