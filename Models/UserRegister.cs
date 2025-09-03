// Tạo ra 1 đối tượng để binding dữ liệu từ form
// Dữ liệu này khớp với các trường input trong file register.razor

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class UserRegisterViewModel
{
    [Required(ErrorMessage = "Username không được để trống")]
    [MinLength(3, ErrorMessage = "Username phải có ít nhất 3 ký tự")]
    [MaxLength(20, ErrorMessage = "Username không được vượt quá 20 ký tự")]
    public string Username { get; set; } = "";

    [Required(ErrorMessage = "Password không được để trống")]
    [MinLength(6, ErrorMessage = "Password phải có ít nhất 6 ký tự")]
    [MaxLength(20, ErrorMessage = "Password không được vượt quá 20 ký tự")]
    [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$", ErrorMessage = "Password phải chứa ít nhất 1 chữ hoa, 1 chữ thường và 1 số")]
    // Có thể sử dụng RegularExpression để kiểm tra định dạng password
    // [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])
    public string Password { get; set; } = "";

    [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
    [Required(ErrorMessage = "Email không được để trống")]
    public string Email { get; set; } = "";

    public bool Gender { get; set; } = false;
    public string City { get; set; } = "";
    public List<string> Hobbies { get; set; } = new List<string>() { "Ăn uống", "Ngủ" };



}



    // ViewModel class
    public class CustomerContactViewModel
    {
        [Required(ErrorMessage = "Full name is required")]
        [MinLength(3, ErrorMessage = "Full name must be at least 3 characters long")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; } = string.Empty;

        [MinLength(5, ErrorMessage = "Address must be at least 5 characters long")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Message is required")]
        [MinLength(10, ErrorMessage = "Message must be at least 10 characters long")]
        public string Message { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a service")]
        public string SelectedService { get; set; } = string.Empty;

        [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to the terms and conditions")]
        public bool AgreeToTerms { get; set; } = false;
    }



        // ViewModel class
    public class CourseRegistrationViewModel
    {
        [Required(ErrorMessage = "Full name is required")]
        [MinLength(3, ErrorMessage = "Full name must be at least 3 characters long")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a course")]
        public string SelectedCourse { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a study mode")]
        public string StudyMode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a preferred start date")]
        public DateTime PreferredStartDate { get; set; } = DateTime.Today;

        public string Comments { get; set; } = string.Empty;

        [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to the terms and conditions")]
        public bool AgreeToTerms { get; set; } = false;
    }