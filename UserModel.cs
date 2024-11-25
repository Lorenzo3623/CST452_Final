using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ButtonGrind.Models
{
    public class UserModel
    {
        public string? UserName { get; set; }  // username for the user
        public int Id { get; set; }  // Unique ID for the user
        public string? Password { get; set; }  // password for the user
        public string Game { get; set; }  // not used

        [Required]  // Ensures the first name is provided
        [DisplayName("First Name")]  // Label
        [StringLength(50)]  // Restricts the length to a maximum of 50 characters
        public string FirstName { get; set; }  // User's first name

        [Required]  // Ensures the last name is provided
        [DisplayName("Last Name")]  // Label
        [StringLength(50)]  // Restricts the length to a maximum of 50 characters
        public string LastName { get; set; }  // User's last name

        [Required]  // Ensures the sex field is provided
        [DisplayName("Sex")]  // Label 
        public string Sex { get; set; }  // Male, Female)

        [Required]  // Ensures age field is provided
        [Range(1, 150)]  // Restricts  age to 1 to 150
        [DisplayName("Age")]  // Label 
        public int Age { get; set; }  // User's age

        [Required]  // Ensures field is provided
        [DisplayName("State")]  // Label for display purposes
        public string State { get; set; }  // User's state or region

        [Required]  // Ensures the email address is entered
        [EmailAddress]  // Validates the format of the email address
        [DisplayName("Email Address")]  // Label for display purposes
        public string Email { get; set; }  // User's email address

        [Required]  // Ensures the username field is provided
        [DisplayName("Username")]  // Label for display purposes
        [StringLength(20, MinimumLength = 4)]  // Restricts the length to 4-20 characters
        public string Username { get; set; }  // User's login username

        // Overrides the default string representation 
        public override string ToString()
        {
            return "Username = " + UserName + " Password = " + Password;
        }
    }
}
