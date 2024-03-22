// See https://aka.ms/new-console-template for more information
using CSProjeDemo1;

Console.WriteLine("Hello, World!");

Library library = new Library();

Book book1 = new BookHistory();
book1.Id = Guid.NewGuid();
book1.ISBN = "1234";
book1.Title = "Test";
book1.Author = "tester";
book1.TotalBookCount = 5;
book1.ReleaseDate = new DateOnly(2020,2,5);

BookNovel book2 = new BookNovel();
book2.Id = Guid.NewGuid();
book2.ISBN = "2234";
book2.Title = "Test";
book2.Author = "tester";
book2.TotalBookCount = 0;
book2.ReleaseDate = new DateOnly(2020, 2, 5);

BookScience book3 = new BookScience();
book3.Id = Guid.NewGuid();
book3.ISBN = "3334";
book3.Title = "Test";
book3.Author = "tester";
book3.TotalBookCount = 1;
book3.ReleaseDate = new DateOnly(3030, 3, 5);

library.Books.Add(book1);
library.Books.Add(book2);
library.Books.Add(book3);

Member member1 = new Member();
member1.Id = Guid.NewGuid();
member1.Name = "Test";
member1.Surname = "1";
member1.MemberNumber = 1;

Member member2 = new Member();
member2.Id = Guid.NewGuid();
member2.Name = "Test";
member2.Surname = "2";
member2.MemberNumber = 2;

library.Members.Add(member1);
library.Members.Add(member2);

library.LendBookToMember(member1, book1);
library.LendBookToMember(member2, book1);

library.LendBookToMember(member1, book2);
library.LendBookToMember(member2, book2);

library.LendBookToMember(member1, book3);
library.LendBookToMember(member2, book3);

library.GetBookBackFromMember(member2, book1);
library.GetBookBackFromMember(member2, book3);
library.GetBookBackFromMember(member1, book3);
library.LendBookToMember(member2, book3);
Console.ReadLine();