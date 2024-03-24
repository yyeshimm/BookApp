using NUnit.Framework;
using Bookworm.Data.Models;
using Bookworm.Business;
namespace UnitTest
{
    [TestFixture]
    public class BusinessReadingListTests
    {
        [Test]
        public void AddReadingList_AddsToList()
        {
            // Arrange
            var businessReadingList = new BusinessReadingList();
            var readingList = new ReadingList();

            // Act
            businessReadingList.Add(readingList);
            var allReadingLists = businessReadingList.ListAll();

            // Assert
            Assert.Contains(readingList, allReadingLists);
        }

        [Test]
        public void ListAll_ReturnsAllReadingLists()
        {
            // Arrange
            var businessReadingList = new BusinessReadingList();
            var readingList1 = new ReadingList();
            var readingList2 = new ReadingList();
            businessReadingList.Add(readingList1);
            businessReadingList.Add(readingList2);

            // Act
            var allReadingLists = businessReadingList.ListAll();

            // Assert
            Assert.AreEqual(2, allReadingLists.Count);
            Assert.Contains(readingList1, allReadingLists);
            Assert.Contains(readingList2, allReadingLists);
        }

        [Test]
        public void RemoveReadingList_RemovesFromList()
        {
            // Arrange
            var businessReadingList = new BusinessReadingList();
            var readingList = new ReadingList();
            businessReadingList.Add(readingList);

            // Act
            businessReadingList.Remove(readingList.ReadingListId);
            var allReadingLists = businessReadingList.ListAll();

            // Assert
            Assert.IsFalse(allReadingLists.Contains(readingList));
        }
    }
    [TestFixture]
    public class BusinessUserTests
    {
        [Test]
        public void AddUser_AddsToList()
        {
            // Arrange
            var businessUser = new BusinessUser();
            var user = new User { UserName = "TestUser" };

            // Act
            businessUser.Add(user);
            var allUsers = businessUser.ListAll();

            // Assert
            Assert.Contains(user, allUsers);
        }

        [Test]
        public void ListAll_ReturnsAllUsers()
        {
            // Arrange
            var businessUser = new BusinessUser();
            var user1 = new User { UserName = "TestUser1" };
            var user2 = new User { UserName = "TestUser2" };
            businessUser.Add(user1);
            businessUser.Add(user2);

            // Act
            var allUsers = businessUser.ListAll();

            // Assert
            Assert.AreEqual(2, allUsers.Count);
            Assert.Contains(user1, allUsers);
            Assert.Contains(user2, allUsers);
        }

        [Test]
        public void RemoveUser_RemovesFromList()
        {
            // Arrange
            var businessUser = new BusinessUser();
            var user = new User { UserName = "TestUser" };
            businessUser.Add(user);

            // Act
            businessUser.Remove(user.UserId);
            var allUsers = businessUser.ListAll();

            // Assert
            Assert.IsFalse(allUsers.Contains(user));
        }
    }

    [TestFixture]
    public class BusinessBookTests
    {
        [Test]
        public void AddBook_AddsToList()
        {
            // Arrange
            var businessBook = new BusinessBook();
            var book = new Book { Title = "Test Book" };

            // Act
            businessBook.Add(book);
            var allBooks = businessBook.ListAll();

            // Assert
            Assert.Contains(book, allBooks);
        }

        [Test]
        public void ListAll_ReturnsAllBooks()
        {
            // Arrange
            var businessBook = new BusinessBook();
            var book1 = new Book { Title = "Test Book 1" };
            var book2 = new Book { Title = "Test Book 2" };
            businessBook.Add(book1);
            businessBook.Add(book2);

            // Act
            var allBooks = businessBook.ListAll();

            // Assert
            Assert.AreEqual(2, allBooks.Count);
            Assert.Contains(book1, allBooks);
            Assert.Contains(book2, allBooks);
        }

        [Test]
        public void RemoveBook_RemovesFromList()
        {
            // Arrange
            var businessBook = new BusinessBook();
            var book = new Book { Title = "Test Book" };
            businessBook.Add(book);

            // Act
            businessBook.Remove(book.BookId);
            var allBooks = businessBook.ListAll();

            // Assert
            Assert.IsFalse(allBooks.Contains(book));
        }
    }

    [TestFixture]
    public class BusinessAuthorTests
    {
        [Test]
        public void AddAuthor_AddsToList()
        {
            // Arrange
            var businessAuthor = new BusinessAuthor();
            var author = new Author { Name = "Test Author" };

            // Act
            businessAuthor.Add(author);
            var allAuthors = businessAuthor.ListAll();

            // Assert
            Assert.Contains(author, allAuthors);
        }

        [Test]
        public void ListAll_ReturnsAllAuthors()
        {
            // Arrange
            var businessAuthor = new BusinessAuthor();
            var author1 = new Author { Name = "Test Author 1" };
            var author2 = new Author { Name = "Test Author 2" };
            businessAuthor.Add(author1);
            businessAuthor.Add(author2);

            // Act
            var allAuthors = businessAuthor.ListAll();

            // Assert
            Assert.AreEqual(2, allAuthors.Count);
            Assert.Contains(author1, allAuthors);
            Assert.Contains(author2, allAuthors);
        }

        [Test]
        public void RemoveAuthor_RemovesFromList()
        {
            // Arrange
            var businessAuthor = new BusinessAuthor();
            var author = new Author { Name = "Test Author" };
            businessAuthor.Add(author);

            // Act
            businessAuthor.Remove(author.AuthorId);
            var allAuthors = businessAuthor.ListAll();

            // Assert
            Assert.IsFalse(allAuthors.Contains(author));
        }
    }
}