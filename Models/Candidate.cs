using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
  public class Candidate
  {
    [Required(ErrorMessage = "Lütfen email adresinizi giriniz.")]
    public String? Email { get; set; } = String.Empty;

    [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
    public String? FirstName{ get; set; } = String.Empty;

    [Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
    public String? LastName{ get; set; } = String.Empty;

    public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
    public String? SelectedCourse{ get; set; } = String.Empty;

    [Required(ErrorMessage = "Lütfen yaşınızı giriniz.")]
    public int? Age { get; set; }

    public DateTime ApplyAt { get; set; }

    public Candidate()
    {
      ApplyAt = DateTime.Now;
    }
  }
}