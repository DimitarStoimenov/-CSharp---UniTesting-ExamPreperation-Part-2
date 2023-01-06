namespace Book.Tests
{
    using System;

    using NUnit.Framework;

    public class Tests
    {
        [TestCase("Love", "Josh")]
        


        public void TastingOrNameProppertiesAreEqual(string name, string autor)
        {


            Book book = new Book(name, autor);
            
            Assert.AreEqual(book.BookName, "Love");
            Assert.AreEqual(book.Author, "Josh");

           

        }
        [TestCase(null, "Josh")]
        [TestCase("", "Smith")]
        

        public void PasteOrNameProppertiesAreEqual(string name, string autor)
        {
            

            Assert.Throws<ArgumentException>(() => new Book(name, autor));
            Assert.Throws<ArgumentException>(() => new Book(name, autor));
            
        }

        [TestCase("Josh", null)]
        [TestCase("Smith", "")]


        public void PasteOrAutorProppertiesAreEqual(string name, string autor)
        {
          

            Assert.Throws<ArgumentException>(() => new Book(name, autor));
            Assert.Throws<ArgumentException>(() => new Book(name, autor));
        }

        [Test]

        public void CheckIfDictionaryRtutnesValues()
        {
            Book book = new Book("Josh", "Smith");
            book.AddFootnote(1, "h");

            Assert.AreEqual(book.FootnoteCount, 1);

           
        }
        [Test]

        public void CheckIfDictionaryThrowsPageExeptionRtutnesValues()
        {
            Book book = new Book("Josh", "Smith");
            book.AddFootnote(1, "h");

           

            Assert.Throws<InvalidOperationException>(() 
                => book.AddFootnote(1, "w"));
        }

        [Test]

        public void CheckIfDictionaryFindsTextValues()
        {
            Book book = new Book("Josh", "Smith");
            book.AddFootnote(1, "h");
            book.FindFootnote(1);
            string textOutput = "Footnote #1: h";
            Assert.AreEqual(book.FindFootnote(1), textOutput);


        }
        [Test]

        public void CheckIfDictionaryThrowsPageExeptionValues()
        {
            Book book = new Book("Josh", "Smith");
            book.AddFootnote(1, "w");



            Assert.Throws<InvalidOperationException>(()
                => book.FindFootnote(2));
        }
        [Test]

        public void CheckIfDictionaryThrowsPageExeptionValuesForReplace()
        {
            Book book = new Book("Josh", "Smith");
            book.AddFootnote(1, "w");



            Assert.Throws<InvalidOperationException>(()
                => book.AlterFootnote(2, "m"));
        }
        [Test]

        public void CheckIfDictionaryReplacePageText()
        {
            Book book = new Book("Josh", "Smith");
            book.AddFootnote(1, "w");
            book.AlterFootnote(1, "m");
            book.FindFootnote(1);
            string textOutput = "Footnote #1: m";
            Assert.AreEqual(book.FindFootnote(1), textOutput);


        }
    }
}