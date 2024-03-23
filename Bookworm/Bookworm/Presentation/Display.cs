using Bookworm.Data.Models;
using Bookworm.Business;

namespace Bookworm.Presentation
{
    public class Display
    {

            private readonly BusinessUser businessUser;
            private readonly BusinessReadingList businessReadingList;
            private readonly BusinessBook businessBook;
            private readonly BusinessAuthor businessAuthor;

            public Display()
            {
                businessUser = new BusinessUser();
                businessReadingList = new BusinessReadingList();
                businessBook = new BusinessBook();
                businessAuthor = new BusinessAuthor();
            }

            public void MainMenu()
            {
                Console.WriteLine("Welcome to Bookworm!");

                while (true)
                {
                    Console.WriteLine("\nChoose an option:");
                    Console.WriteLine("1. Add User");
                    Console.WriteLine("2. List All Users");
                    Console.WriteLine("3. Remove User");
                    Console.WriteLine("4. Add Reading List");
                    Console.WriteLine("5. List All Reading Lists");
                    Console.WriteLine("6. Remove Reading List");
                    Console.WriteLine("7. Add Book");
                    Console.WriteLine("8. List All Books");
                    Console.WriteLine("9. Remove Book");
                    Console.WriteLine("10. Add Author");
                    Console.WriteLine("11. List All Authors");
                    Console.WriteLine("12. Remove Author");
                    Console.WriteLine("13. Exit");

                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddUser();
                            break;
                        case "2":
                            ListAllUsers();
                            break;
                        case "3":
                            RemoveUser();
                            break;
                        case "4":
                            AddReadingList();
                            break;
                        case "5":
                            ListAllReadingLists();
                            break;
                        case "6":
                            RemoveReadingList();
                            break;
                        case "7":
                            AddBook();
                            break;
                        case "8":
                            ListAllBooks();
                            break;
                        case "9":
                            RemoveBook();
                            break;
                        case "10":
                            AddAuthor();
                            break;
                        case "11":
                            ListAllAuthors();
                            break;
                        case "12":
                            RemoveAuthor();
                            break;
                        case "13":
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }

            private void AddUser()
            {
                Console.Write("Enter username: ");
                var username = Console.ReadLine();
                var user = new User { UserName = username };
                businessUser.Add(user);
                Console.WriteLine("User added successfully.");
            }

            private void ListAllUsers()
            {
                var users = businessUser.ListAll();
                Console.WriteLine("List of Users:");
                foreach (var user in users)
                {
                    Console.WriteLine($"User ID: {user.UserId}, Username: {user.UserName}");
                }
            }

            private void RemoveUser()
            {
                Console.Write("Enter user ID to remove: ");
                if (int.TryParse(Console.ReadLine(), out int userId))
                {
                    businessUser.Remove(userId);
                    Console.WriteLine("User removed successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid user ID.");
                }
            }

            private void AddReadingList()
            {
                Console.Write("Enter reading list name: ");
                var name = Console.ReadLine();
                Console.Write("Enter user ID: ");
                if (int.TryParse(Console.ReadLine(), out int userId))
                {
                    var readingList = new ReadingList { Name = name, UserId = userId };
                    businessReadingList.Add(readingList);
                    Console.WriteLine("Reading list added successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid user ID.");
                }
            }

            private void ListAllReadingLists()
            {
                var readingLists = businessReadingList.ListAll();
                Console.WriteLine("List of Reading Lists:");
                foreach (var readingList in readingLists)
                {
                    Console.WriteLine($"Reading List ID: {readingList.ReadingListId}, Name: {readingList.Name}");
                }
            }

            private void RemoveReadingList()
            {
                Console.Write("Enter reading list ID to remove: ");
                if (int.TryParse(Console.ReadLine(), out int readingListId))
                {
                    businessReadingList.Remove(readingListId);
                    Console.WriteLine("Reading list removed successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid reading list ID.");
                }
            }

            private void AddBook()
            {
                Console.Write("Enter book title: ");
                string title = Console.ReadLine();
                Console.Write("Enter author ID: ");
                if (int.TryParse(Console.ReadLine(), out int authorId))
                {
                    var book = new Book { Title = title, AuthorId = authorId };
                    businessBook.Add(book);
                    Console.WriteLine("Book added successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid author ID.");
                }
            }

            private void ListAllBooks()
            {
                var books = businessBook.ListAll();
                Console.WriteLine("List of Books:");
                foreach (var book in books)
                {
                    Console.WriteLine($"Book ID: {book.BookId}, Title: {book.Title}");
                }
            }

            private void RemoveBook()
            {
                Console.Write("Enter book ID to remove: ");
                if (int.TryParse(Console.ReadLine(), out int bookId))
                {
                    businessBook.Remove(bookId);
                    Console.WriteLine("Book removed successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid book ID.");
                }
            }

            private void AddAuthor()
            {
                Console.Write("Enter author name: ");
                var name = Console.ReadLine();
                var author = new Author { Name = name };
                businessAuthor.Add(author);
                Console.WriteLine("Author added successfully.");
            }

            private void ListAllAuthors()
            {
                var authors = businessAuthor.ListAll();
                Console.WriteLine("List of Authors:");
                foreach (var author in authors)
                {
                    Console.WriteLine($"Author ID: {author.AuthorId}, Name: {author.Name}");
                }
            }

            private void RemoveAuthor()
            {
                Console.Write("Enter author ID to remove: ");
                if (int.TryParse(Console.ReadLine(), out int authorId))
                {
                    businessAuthor.Remove(authorId);
                    Console.WriteLine("Author removed successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid author ID.");
                }
            }
    }
}
