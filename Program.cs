using System;
using System.Linq;

var context = new LibraryContext();

context.Database.EnsureCreated();

if (!context.Books.Any())
{
    context.Books.Add(new Book { Title = "1984", Author = "George Orwell", PurchaseDate = new DateTime(2015, 12, 31), Category = (CategoryType)2 });
    context.Books.Add(new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", PurchaseDate = new DateTime(2020, 5, 12), Category = (CategoryType)3 });
    context.SaveChanges();
}

var books = context.Books.ToList();
foreach (var book in books)
{
    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Purchase Date: {book.PurchaseDate}, Category: {book.Category}");
}
