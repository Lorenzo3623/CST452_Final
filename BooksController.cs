using ButtonGrind.Models;
using ButtonGrind.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ButtonGrind.Controllers
{
    // This controller handles actions related to books
    public class BooksController : Controller
    {
        // Action to display all books
        public IActionResult Index()
        {
            // Create an instance of the data access object
            SecurityDAO dao = new SecurityDAO();
            // Get the list of all books from the DAO
            List<BookModel> books = dao.GetAllBooks();
            // Pass the list of books to the view
            return View(books);
        }

        // GET: Books/Create
        // Action to show the form for creating a new book
        public IActionResult Create()
        {
            // Display the create book view
            return View();
        }

        // POST: Books/Create
        // Action to handle the form submission for creating a new book
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookModel book)
        {
            // Check if the submitted data is valid
            if (ModelState.IsValid)
            {
                // Create an instance of the data access object
                SecurityDAO dao = new SecurityDAO();
                // Try to insert the new book into the database
                bool success = dao.InsertBook(book);
                if (success)
                {
                    // If successful, redirect to the list of books
                    return RedirectToAction("Index");
                }
                else
                {
                    // If there's an error, display a message
                    ViewBag.ErrorMessage = "Error adding the book.";
                    // Return the view with the current book data
                    return View(book);
                }
            }
            // If the data is invalid, redisplay the form with errors
            return View(book);
        }

        // GET: Books/Edit/5
        // Action to show the form for editing an existing book
        public IActionResult Edit(int id)
        {
            // Create an instance of the data access object
            SecurityDAO dao = new SecurityDAO();
            // Retrieve the book by its ID
            BookModel book = dao.GetBookById(id);
            // Pass the book data to the view
            return View(book);
        }

        // POST: Books/Edit/5
        // Action to handle the form submission for editing a book
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BookModel book)
        {
            // Check if the submitted data is valid
            if (ModelState.IsValid)
            {
                // Create an instance of the data access object
                SecurityDAO dao = new SecurityDAO();
                // Try to update the book in the database
                bool success = dao.UpdateBook(book);
                if (success)
                {
                    // If successful, redirect to the list of books
                    return RedirectToAction("Index");
                }
                else
                {
                    // If there's an error, display a message
                    ViewBag.ErrorMessage = "Error updating the book.";
                    // Return the view with the current book data
                    return View(book);
                }
            }
            // If the data is invalid, redisplay the form with errors
            return View(book);
        }

        // POST: Books/Delete/5
        // Action to handle the deletion of a book
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            // Create an instance of the data access object
            SecurityDAO dao = new SecurityDAO();
            // Try to delete the book from the database
            bool success = dao.DeleteBook(id);
            if (success)
            {
                // If successful, redirect to the list of books
                return RedirectToAction("Index");
            }
            else
            {
                // If there's an error, display a message
                ViewBag.ErrorMessage = "Error deleting the book.";
                // Show the error view
                return View("Error");
            }
        }
    }
}
