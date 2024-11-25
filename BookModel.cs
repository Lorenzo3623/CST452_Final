using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButtonGrind.Models
{
    public class BookModel
    {
        [Column("BookId")]  // Maps the Id property to the BookId column
        public int Id { get; set; }
      // Changed from BookId to Id

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(250)]
        public string Title { get; set; }

        [Required(ErrorMessage = "ISBN is required.")]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "ISBN must be between 10 and 13 characters.")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Genre is required.")]
        [StringLength(100)]
        public string Genre { get; set; }

        // Constructors...

        public BookModel() { }

        public BookModel(int id, string title, string isbn, string genre)
        {
            Id = id;  // Changed parameter from bookId to id
            Title = title;
            ISBN = isbn;
            Genre = genre;
        }
    }
}
