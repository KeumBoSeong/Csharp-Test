using System.ComponentModel.DataAnnotations;

namespace ValiationTest.Models
{
    public class Student
    {
        //[Required]
        //[Display(Name="이름 :")]  Indet.cshtml의 <label>부분과 함께 사용 (없어도 됨)
        [Required(ErrorMessage = "이름을 입력해야합니다.")]
        [StringLength(15, 
            MinimumLength = 2, 
            ErrorMessage = "이름은 2자 이상 15이하로 작성해 주세요.")]
        public string Name { get;set;}

        [Required(ErrorMessage = "나이를 입력해야합니다.")]
        [Range(20, 70, ErrorMessage = "20살 이상 70세 미만의 나이를 입력해주세요.")]
        public int? Age {get; set;}

        [Required(ErrorMessage = "패스워드를 적어주세요.")]
        [RegularExpression(@"(?=.*[a-zA-Z])(?=.*[0-9]).{8,25}$", 
            ErrorMessage = "영문자, 숫자조합으로 8자리이상 입력해주세요.")]
        public string Password { get; set; }

    }
}
