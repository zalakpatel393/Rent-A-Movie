namespace RAM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMovies : DbMigration
    {
        public override void Up()
        {
            //Add Movies

            Sql(@"

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Avatar','1', getdate() ,'1/6/2009','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Pirates of the Caribbean: At Worlds End','1', getdate() ,'1/6/2007','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Spectre','1', getdate() ,'1/6/2015','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Dark Knight Rises','4', getdate() ,'1/6/2012','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Star Wars: Episode VII - The Force Awakens            ','4', getdate() ,'1/6/2012','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('John Carter','1', getdate() ,'1/6/2012','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('J.K. Simmons','1', getdate() ,'1/6/2007','25','17')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Tangled','2', getdate() ,'1/6/2010','30','21')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Avengers: Age of Ultron','1', getdate() ,'1/6/2015','35','24')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Harry Potter and the Half-Blood Prince','2', getdate() ,'1/6/2009','40','28')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Batman v Superman: Dawn of Justice','1', getdate() ,'1/6/2016','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Superman Returns','1', getdate() ,'1/6/2006','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Quantum of Solace','1', getdate() ,'1/6/2008','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Pirates of the Caribbean: Dead Mans Chest','1', getdate() ,'1/6/2006','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Lone Ranger','1', getdate() ,'1/6/2013','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Man of Steel','1', getdate() ,'1/6/2013','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Chronicles of Narnia: Prince Caspian','1', getdate() ,'1/6/2008','25','17')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Avengers','1', getdate() ,'1/6/2012','30','21')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Pirates of the Caribbean: On Stranger Tides','1', getdate() ,'1/6/2011','35','24')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Men in Black 3','1', getdate() ,'1/6/2012','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Hobbit: The Battle of the Five Armies','2', getdate() ,'1/6/2014','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Amazing Spider-Man','1', getdate() ,'1/6/2012','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Robin Hood','1', getdate() ,'1/6/2010','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Hobbit: The Desolation of Smaug','2', getdate() ,'1/6/2013','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Golden Compass','2', getdate() ,'1/6/2007','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('King Kong','1', getdate() ,'1/6/2005','25','17')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Titanic','4', getdate() ,'1/6/1997','30','21')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Captain America: Civil War','1', getdate() ,'1/6/2016','35','24')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Battleship','1', getdate() ,'1/6/2012','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Jurassic World','1', getdate() ,'1/6/2015','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Skyfall','1', getdate() ,'1/6/2012','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Spider-Man 2','1', getdate() ,'1/6/2004','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Iron Man 3','1', getdate() ,'1/6/2013','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Alice in Wonderland','2', getdate() ,'1/6/2010','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('X-Men: The Last Stand','1', getdate() ,'1/6/2006','25','17')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Monsters University','2', getdate() ,'1/6/2013','30','21')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Transformers: Revenge of the Fallen','1', getdate() ,'1/6/2009','35','24')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Transformers: Age of Extinction','1', getdate() ,'1/6/2014','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Oz the Great and Powerful','2', getdate() ,'1/6/2013','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Amazing Spider-Man 2','1', getdate() ,'1/6/2014','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('TRON: Legacy','1', getdate() ,'1/6/2010','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Cars 2','2', getdate() ,'1/6/2011','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Green Lantern','1', getdate() ,'1/6/2011','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Toy Story 3','2', getdate() ,'1/6/2010','25','17')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Terminator Salvation','1', getdate() ,'1/6/2009','30','21')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Furious 7','1', getdate() ,'1/6/2015','35','24')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('World War Z','1', getdate() ,'1/6/2013','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('X-Men: Days of Future Past','1', getdate() ,'1/6/2014','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Star Trek Into Darkness','1', getdate() ,'1/6/2013','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Jack the Giant Slayer','2', getdate() ,'1/6/2013','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Great Gatsby','4', getdate() ,'1/6/2013','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Prince of Persia: The Sands of Time','1', getdate() ,'1/6/2010','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Pacific Rim','1', getdate() ,'1/6/2013','25','17')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Transformers: Dark of the Moon','1', getdate() ,'1/6/2011','30','21')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Indiana Jones and the Kingdom of the Crystal Skull','1', getdate() ,'1/6/2008','35','24')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Good Dinosaur','2', getdate() ,'1/6/2015','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Brave','2', getdate() ,'1/6/2012','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Star Trek Beyond','1', getdate() ,'1/6/2016','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('WALL·E','2', getdate() ,'1/6/2008','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Rush Hour 3','1', getdate() ,'1/6/2007','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('2012','1', getdate() ,'1/6/2009','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('A Christmas Carol','4', getdate() ,'1/6/2009','25','17')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Jupiter Ascending','1', getdate() ,'1/6/2015','30','21')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Legend of Tarzan','1', getdate() ,'1/6/2016','35','24')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Chronicles of Narnia: The Lion, the Witch and the Wardrobe','2', getdate() ,'1/6/2005','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('X-Men: Apocalypse','1', getdate() ,'1/6/2016','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Dark Knight','1', getdate() ,'1/6/2008','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Up','2', getdate() ,'1/6/2009','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Monsters vs. Aliens','1', getdate() ,'1/6/2009','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Iron Man','1', getdate() ,'1/6/2008','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Hugo','2', getdate() ,'1/6/2011','25','17')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Wild Wild West','1', getdate() ,'1/6/1999','30','21')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Mummy: Tomb of the Dragon Emperor','1', getdate() ,'1/6/2008','35','24')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Suicide Squad','1', getdate() ,'1/6/2016','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Evan Almighty','4', getdate() ,'1/6/2007','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Edge of Tomorrow','1', getdate() ,'1/6/2014','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Waterworld','1', getdate() ,'1/6/1995','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('G.I. Joe: The Rise of Cobra','1', getdate() ,'1/6/2009','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Inside Out','2', getdate() ,'1/6/2015','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Jungle Book','2', getdate() ,'1/6/2016','25','17')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Iron Man 2','1', getdate() ,'1/6/2010','30','21')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Snow White and the Huntsman','1', getdate() ,'1/6/2012','35','24')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Maleficent','1', getdate() ,'1/6/2014','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Dawn of the Planet of the Apes','1', getdate() ,'1/6/2014','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Lovers','1', getdate() ,'1/6/2015','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('47 Ronin','1', getdate() ,'1/6/2013','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Captain America: The Winter Soldier','1', getdate() ,'1/6/2014','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Shrek Forever After','2', getdate() ,'1/6/2010','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Tomorrowland','1', getdate() ,'1/6/2015','25','17')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Big Hero 6','1', getdate() ,'1/6/2014','30','21')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Wreck-It Ralph','2', getdate() ,'1/6/2012','35','24')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Polar Express','2', getdate() ,'1/6/2004','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Independence Day: Resurgence','1', getdate() ,'1/6/2016','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('How to Train Your Dragon','2', getdate() ,'1/6/2010','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Terminator 3: Rise of the Machines','1', getdate() ,'1/6/2003','10','7')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Guardians of the Galaxy','1', getdate() ,'1/6/2014','15','10')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Interstellar','2', getdate() ,'1/6/2014','20','14')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Inception','1', getdate() ,'1/6/2010','25','17')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('Godzilla Resurgence','1', getdate() ,'1/6/2016','30','21')

INSERT INTO [dbo].[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock],[NumberAvailable] ) VALUES ('The Hobbit: An Unexpected Journey','4', getdate() ,'1/6/2012','35','24')

");
        }
        
        public override void Down()
        {
        }
    }
}
