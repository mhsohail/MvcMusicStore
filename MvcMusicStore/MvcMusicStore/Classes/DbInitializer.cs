using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Classes
{
    public class DbInitializer
    {
        MusicStoreEntities db = new MusicStoreEntities();
        public DbInitializer()
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (db.Artists.ToList().Count == 0)
                    {
                        db.Artists.Add(new Artist { Name = "AC/DC" });
                        db.Artists.Add(new Artist { Name = "Accept" });
                        db.Artists.Add(new Artist { Name = "Adrian Leaper & Doreen de Feis" });
                        db.Artists.Add(new Artist { Name = "Aerosmith" });
                        db.Artists.Add(new Artist { Name = "Aisha Duo" });
                        db.Artists.Add(new Artist { Name = "Alanis Morissette" });
                        db.Artists.Add(new Artist { Name = "Alice In Chains" });
                        db.Artists.Add(new Artist { Name = "Amy Winehouse" });
                        db.Artists.Add(new Artist { Name = "Anita Ward" });
                        db.Artists.Add(new Artist { Name = "Antônio Carlos Jobim" });
                        db.Artists.Add(new Artist { Name = "Apocalyptica" });
                        db.Artists.Add(new Artist { Name = "Audioslave" });
                        db.Artists.Add(new Artist { Name = "Barry Wordsworth & BBC Concert Orchestra" });
                        db.Artists.Add(new Artist { Name = "Berliner Philharmoniker & Hans Rosbaud" });
                        db.Artists.Add(new Artist { Name = "Billy Cobham" });
                        db.Artists.Add(new Artist { Name = "Black Label Society" });
                        db.Artists.Add(new Artist { Name = "Black Sabbath" });
                        db.Artists.Add(new Artist { Name = "Boston Symphony Orchestra & Seiji Ozawa" });
                        db.Artists.Add(new Artist { Name = "Britten Sinfonia, Ivor Bolton & Lesley Garrett" });
                        db.Artists.Add(new Artist { Name = "Bruce Dickinson" });
                        db.Artists.Add(new Artist { Name = "Caetano Veloso" });
                        db.Artists.Add(new Artist { Name = "Cake" });
                        db.Artists.Add(new Artist { Name = "Calexico" });
                        db.Artists.Add(new Artist { Name = "Cássia Eller" });
                        db.Artists.Add(new Artist { Name = "Chic" });
                        db.Artists.Add(new Artist { Name = "Chicago Symphony Orchestra & Fritz Reiner" });
                        db.Artists.Add(new Artist { Name = "Chico Buarque" });
                        db.Artists.Add(new Artist { Name = "Chico Science & Nação Zumbi" });
                        db.Artists.Add(new Artist { Name = "Chris Cornell" });
                        db.Artists.Add(new Artist { Name = "Cidade Negra" });
                        db.Artists.Add(new Artist { Name = "Cláudio Zoli" });
                        db.Artists.Add(new Artist { Name = "Creedence Clearwater Revival" });
                        db.Artists.Add(new Artist { Name = "David Coverdale" });
                        db.Artists.Add(new Artist { Name = "Deep Purple" });
                        db.Artists.Add(new Artist { Name = "Dennis Chambers" });
                        db.Artists.Add(new Artist { Name = "Djavan" });
                        db.Artists.Add(new Artist { Name = "Donna Summer" });
                        db.Artists.Add(new Artist { Name = "Dread Zeppelin" });
                        db.Artists.Add(new Artist { Name = "Ed Motta" });
                        db.Artists.Add(new Artist { Name = "Elis Regina" });
                        db.Artists.Add(new Artist { Name = "English Concert & Trevor Pinnock" });
                        db.Artists.Add(new Artist { Name = "Eric Clapton" });
                        db.Artists.Add(new Artist { Name = "Eugene Ormandy" });
                        db.Artists.Add(new Artist { Name = "Faith No More" });
                        db.Artists.Add(new Artist { Name = "Falamansa" });
                        db.Artists.Add(new Artist { Name = "Foo Fighters" });
                        db.Artists.Add(new Artist { Name = "Frank Zappa & Captain Beefheart" });
                        db.Artists.Add(new Artist { Name = "Funk Como Le Gusta" });
                        db.Artists.Add(new Artist { Name = "Gilberto Gil" });
                        db.Artists.Add(new Artist { Name = "Godsmack" });
                        db.Artists.Add(new Artist { Name = "Gonzaguinha" });
                        db.Artists.Add(new Artist { Name = "Göteborgs Symfoniker & Neeme Järvi" });
                        db.Artists.Add(new Artist { Name = "Guns N' Roses" });
                        db.Artists.Add(new Artist { Name = "Incognito" });
                        db.Artists.Add(new Artist { Name = "Iron Maiden" });
                        db.Artists.Add(new Artist { Name = "James Levine" });
                        db.Artists.Add(new Artist { Name = "Jamiroquai" });
                        db.Artists.Add(new Artist { Name = "Jimi Hendrix" });
                        db.Artists.Add(new Artist { Name = "Joe Satriani" });
                        db.Artists.Add(new Artist { Name = "Jorge Ben" });
                        db.Artists.Add(new Artist { Name = "Jota Quest" });
                        db.Artists.Add(new Artist { Name = "Judas Priest" });
                        db.Artists.Add(new Artist { Name = "Kent Nagano and Orchestre de l'Opéra de Lyon" });
                        db.Artists.Add(new Artist { Name = "Kiss" });
                        db.Artists.Add(new Artist { Name = "Led Zeppelin" });
                        db.Artists.Add(new Artist { Name = "Legião Urbana" });
                        db.Artists.Add(new Artist { Name = "Lenny Kravitz" });
                        db.Artists.Add(new Artist { Name = "London Symphony Orchestra & Sir Charles Mackerras" });
                        db.Artists.Add(new Artist { Name = "Luciana Souza/Romero Lubambo" });
                        db.Artists.Add(new Artist { Name = "Marcos Valle" });
                        db.Artists.Add(new Artist { Name = "Marillion" });
                        db.Artists.Add(new Artist { Name = "Marisa Monte" });
                        db.Artists.Add(new Artist { Name = "Martin Roscoe" });
                        db.Artists.Add(new Artist { Name = "Men At Work" });
                        db.Artists.Add(new Artist { Name = "Metallica" });
                        db.Artists.Add(new Artist { Name = "Michael Tilson Thomas & San Francisco Symphony" });
                        db.Artists.Add(new Artist { Name = "Miles Davis" });
                        db.Artists.Add(new Artist { Name = "Milton Nascimento" });
                        db.Artists.Add(new Artist { Name = "Mötley Crüe" });
                        db.Artists.Add(new Artist { Name = "Motörhead" });
                        db.Artists.Add(new Artist { Name = "Nicolaus Esterhazy Sinfonia" });
                        db.Artists.Add(new Artist { Name = "Nirvana" });
                        db.Artists.Add(new Artist { Name = "O Terço" });
                        db.Artists.Add(new Artist { Name = "Olodum" });
                        db.Artists.Add(new Artist { Name = "Orchestra of The Age of Enlightenment" });
                        db.Artists.Add(new Artist { Name = "Os Paralamas Do Sucesso" });
                        db.Artists.Add(new Artist { Name = "Page & Plant" });
                        db.Artists.Add(new Artist { Name = "Paul D'Ianno" });
                        db.Artists.Add(new Artist { Name = "Pearl Jam" });
                        db.Artists.Add(new Artist { Name = "Pink Floyd" });
                        db.Artists.Add(new Artist { Name = "Queen" });
                        db.Artists.Add(new Artist { Name = "R.E.M." });
                        db.Artists.Add(new Artist { Name = "Raul Seixas" });
                        db.Artists.Add(new Artist { Name = "Red Hot Chili Peppers" });
                        db.Artists.Add(new Artist { Name = "Roger Norrington, London Classical Players" });
                        db.Artists.Add(new Artist { Name = "Royal Philharmonic Orchestra & Sir Thomas Beecham" });
                        db.Artists.Add(new Artist { Name = "Rush" });
                        db.Artists.Add(new Artist { Name = "Santana" });
                        db.Artists.Add(new Artist { Name = "Scholars Baroque Ensemble" });
                        db.Artists.Add(new Artist { Name = "Sergei Prokofiev & Yuri Temirkanov" });
                        db.Artists.Add(new Artist { Name = "Sir Georg Solti & Wiener Philharmoniker" });
                        db.Artists.Add(new Artist { Name = "Skank" });
                        db.Artists.Add(new Artist { Name = "Soundgarden" });
                        db.Artists.Add(new Artist { Name = "Spyro Gyra" });
                        db.Artists.Add(new Artist { Name = "Stevie Ray Vaughan & Double Trouble" });
                        db.Artists.Add(new Artist { Name = "Stone Temple Pilots" });
                        db.Artists.Add(new Artist { Name = "System Of A Down" });
                        db.Artists.Add(new Artist { Name = "Temple of the Dog" });
                        db.Artists.Add(new Artist { Name = "Terry Bozzio, Tony Levin & Steve Stevens" });
                        db.Artists.Add(new Artist { Name = "The 12 Cellists of The Berlin Philharmonic" });
                        db.Artists.Add(new Artist { Name = "The Black Crowes" });
                        db.Artists.Add(new Artist { Name = "The Cult" });
                        db.Artists.Add(new Artist { Name = "The Doors" });
                        db.Artists.Add(new Artist { Name = "The King's Singers" });
                        db.Artists.Add(new Artist { Name = "The Police" });
                        db.Artists.Add(new Artist { Name = "The Posies" });
                        db.Artists.Add(new Artist { Name = "The Rolling Stones" });
                        db.Artists.Add(new Artist { Name = "The Who" });
                        db.Artists.Add(new Artist { Name = "Tim Maia" });
                        db.Artists.Add(new Artist { Name = "Ton Koopman" });
                        db.Artists.Add(new Artist { Name = "U2" });
                        db.Artists.Add(new Artist { Name = "UB40" });
                        db.Artists.Add(new Artist { Name = "Van Halen" });
                        db.Artists.Add(new Artist { Name = "Various Artists" });
                        db.Artists.Add(new Artist { Name = "Velvet Revolver" });
                        db.Artists.Add(new Artist { Name = "Vinícius De Moraes" });
                        db.Artists.Add(new Artist { Name = "Wilhelm Kempff" });
                        db.Artists.Add(new Artist { Name = "Yehudi Menuhin" });
                        db.Artists.Add(new Artist { Name = "Yo-Yo Ma" });
                        db.Artists.Add(new Artist { Name = "Zeca Pagodinho" });
                        db.SaveChanges();
                    }

                    if (db.Genres.ToList().Count == 0)
                    {
                        db.Genres.Add(new Genre { Name = "Rock" });
                        db.Genres.Add(new Genre { Name = "Classical" });
                        db.Genres.Add(new Genre { Name = "Jazz" });
                        db.Genres.Add(new Genre { Name = "Pop" });
                        db.Genres.Add(new Genre { Name = "Disco" });
                        db.Genres.Add(new Genre { Name = "Latin" });
                        db.Genres.Add(new Genre { Name = "Metal" });
                        db.Genres.Add(new Genre { Name = "Alternative" });
                        db.Genres.Add(new Genre { Name = "Reggae" });
                        db.Genres.Add(new Genre { Name = "Blues" });
                        db.SaveChanges();
                    }
                    
                    if (db.Albums.ToList().Count == 0)
                    {
                        db.Albums.Add(new Album {
                            Title = "The Best Of Men At Work",
                            ArtistId = db.Artists.FirstOrDefault(a => a.Name == "Men At Work").ArtistId,
                            GenreId = db.Genres.FirstOrDefault(g => g.Name == "Rock").GenreId,
                            Price = 8.99M,
                            AlbumArtUrl = "/Content/Images/placeholder.gif"
                        });

                        db.Albums.Add(new Album
                        {
                            Title = "For Those About To Rock We Salute You",
                            ArtistId = db.Artists.FirstOrDefault(a => a.Name == "AC/DC").ArtistId,
                            GenreId = db.Genres.FirstOrDefault(g => g.Name == "Rock").GenreId,
                            Price = 8.99M,
                            AlbumArtUrl = "/Content/Images/placeholder.gif"
                        });

                        db.Albums.Add(new Album
                        {
                            Title = "Let There Be Rock",
                            ArtistId = db.Artists.FirstOrDefault(a => a.Name == "AC/DC").ArtistId,
                            GenreId = db.Genres.FirstOrDefault(g => g.Name == "Rock").GenreId,
                            Price = 8.99M,
                            AlbumArtUrl = "/Content/Images/placeholder.gif"
                        });

                        db.Albums.Add(new Album
                        {
                            Title = "Balls to the Wall",
                            ArtistId = db.Artists.FirstOrDefault(a => a.Name == "Accept").ArtistId,
                            GenreId = db.Genres.FirstOrDefault(g => g.Name == "Rock").GenreId,
                            Price = 8.99M,
                            AlbumArtUrl = "/Content/Images/placeholder.gif"
                        });

                        db.Albums.Add(new Album
                        {
                            Title = "Restless and Wild",
                            ArtistId = db.Artists.FirstOrDefault(a => a.Name == "Accept").ArtistId,
                            GenreId = db.Genres.FirstOrDefault(g => g.Name == "Rock").GenreId,
                            Price = 8.99M,
                            AlbumArtUrl = "/Content/Images/placeholder.gif"
                        });

                        db.Albums.Add(new Album
                        {
                            Title = "Big Ones",
                            ArtistId = db.Artists.FirstOrDefault(a => a.Name == "Aerosmith").ArtistId,
                            GenreId = db.Genres.FirstOrDefault(g => g.Name == "Rock").GenreId,
                            Price = 8.99M,
                            AlbumArtUrl = "/Content/Images/placeholder.gif"
                        });

                        db.Albums.Add(new Album
                        {
                            Title = "Jagged Little Pill",
                            ArtistId = db.Artists.FirstOrDefault(a => a.Name == "Alanis Morissette").ArtistId,
                            GenreId = db.Genres.FirstOrDefault(g => g.Name == "Rock").GenreId,
                            Price = 8.99M,
                            AlbumArtUrl = "/Content/Images/placeholder.gif"
                        });

                        db.Albums.Add(new Album
                        {
                            Title = "Facelift",
                            ArtistId = db.Artists.FirstOrDefault(a => a.Name == "Alice In Chains").ArtistId,
                            GenreId = db.Genres.FirstOrDefault(g => g.Name == "Rock").GenreId,
                            Price = 8.99M,
                            AlbumArtUrl = "/Content/Images/placeholder.gif"
                        });

                        db.Albums.Add(new Album
                        {
                            Title = "Audioslave",
                            ArtistId = db.Artists.FirstOrDefault(a => a.Name == "Audioslave").ArtistId,
                            GenreId = db.Genres.FirstOrDefault(g => g.Name == "Rock").GenreId,
                            Price = 8.99M,
                            AlbumArtUrl = "/Content/Images/placeholder.gif"
                        });

                        db.Albums.Add(new Album
                        {
                            Title = "Chronicle, Vol. 1",
                            ArtistId = db.Artists.FirstOrDefault(a => a.Name == "Creedence Clearwater Revival").ArtistId,
                            GenreId = db.Genres.FirstOrDefault(g => g.Name == "Rock").GenreId,
                            Price = 8.99M,
                            AlbumArtUrl = "/Content/Images/placeholder.gif"
                        });

                        db.Albums.Add(new Album
                        {
                            Title = "Chronicle, Vol. 2",
                            ArtistId = db.Artists.FirstOrDefault(a => a.Name == "Creedence Clearwater Revival").ArtistId,
                            GenreId = db.Genres.FirstOrDefault(g => g.Name == "Rock").GenreId,
                            Price = 8.99M,
                            AlbumArtUrl = "/Content/Images/placeholder.gif"
                        });

                        db.Albums.Add(new Album
                        {
                            Title = "Into The Light",
                            ArtistId = db.Artists.FirstOrDefault(a => a.Name == "David Coverdale").ArtistId,
                            GenreId = db.Genres.FirstOrDefault(g => g.Name == "Rock").GenreId,
                            Price = 8.99M,
                            AlbumArtUrl = "/Content/Images/placeholder.gif"
                        });
                        /*
                        Come Taste The Band

                        Deep Purple

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Deep Purple In Rock

                        Deep Purple

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Fireball

                        Deep Purple

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Machine Head

                        Deep Purple

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        MK III The Final Concerts [Disc 1]

                        Deep Purple

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Purpendicular

                        Deep Purple

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Slaves And Masters

                        Deep Purple

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Stormbringer

                        Deep Purple

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        The Battle Rages On

                        Deep Purple

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        The Final Concerts (Disc 2)

                        Deep Purple

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Un-Led-Ed

                        Dread Zeppelin

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        King For A Day Fool For A Lifetime

                        Faith No More

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        In Your Honor [Disc 1]

                        Foo Fighters

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        In Your Honor [Disc 2]

                        Foo Fighters

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        The Colour And The Shape

                        Foo Fighters

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Bongo Fury

                        Frank Zappa & Captain Beefheart

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Appetite for Destruction

                        Guns N' Roses

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Use Your Illusion I

                        Guns N' Roses

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        A Matter of Life and Death

                        Iron Maiden

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Brave New World

                        Iron Maiden

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Fear Of The Dark

                        Iron Maiden

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Live At Donington 1992 (Disc 1)

                        Iron Maiden

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Live At Donington 1992 (Disc 2)

                        Iron Maiden

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Rock In Rio [CD2]

                        Iron Maiden

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        The Number of The Beast

                        Iron Maiden

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        The X Factor

                        Iron Maiden

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Virtual XI

                        Iron Maiden

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Emergency On Planet Earth

                        Jamiroquai

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Are You Experienced?

                        Jimi Hendrix

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Surfing with the Alien (Remastered)

                        Joe Satriani

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Greatest Kiss

                        Kiss

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Unplugged [Live]

                        Kiss

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        BBC Sessions [Disc 1] [Live]

                        Led Zeppelin

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        BBC Sessions [Disc 2] [Live]

                        Led Zeppelin

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Coda

                        Led Zeppelin

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Houses Of The Holy

                        Led Zeppelin

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        In Through The Out Door

                        Led Zeppelin

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        IV

                        Led Zeppelin

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Led Zeppelin I

                        Led Zeppelin

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Led Zeppelin II

                        Led Zeppelin

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Led Zeppelin III

                        Led Zeppelin

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Physical Graffiti [Disc 1]

                        Led Zeppelin

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Physical Graffiti [Disc 2]

                        Led Zeppelin

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Presence

                        Led Zeppelin

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        The Song Remains The Same (Disc 1)

                        Led Zeppelin

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        The Song Remains The Same (Disc 2)

                        Led Zeppelin

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Greatest Hits

                        Lenny Kravitz

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Misplaced Childhood

                        Marillion

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Nevermind

                        Nirvana

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Compositores

                        O Terço

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Bark at the Moon (Remastered)

                        Ozzy Osbourne

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Blizzard of Ozz

                        Ozzy Osbourne

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Diary of a Madman (Remastered)

                        Ozzy Osbourne

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        No More Tears (Remastered)

                        Ozzy Osbourne

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Speak of the Devil

                        Ozzy Osbourne

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Walking Into Clarksdale

                        Page & Plant

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        The Beast Live

                        Paul D'Ianno

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Live On Two Legs [Live]

                        Pearl Jam

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Riot Act

                        Pearl Jam

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Ten

                        Pearl Jam

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Vs.

                        Pearl Jam

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Dark Side Of The Moon

                        Pink Floyd

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Greatest Hits I

                        Queen

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Greatest Hits II

                        Queen

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        News Of The World

                        Queen

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        New Adventures In Hi-Fi

                        R.E.M.

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Raul Seixas

                        Raul Seixas

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        By The Way

                        Red Hot Chili Peppers

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Californication

                        Red Hot Chili Peppers

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Retrospective I (1974-1980)

                        Rush

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Santana - As Years Go By

                        Santana

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Santana Live

                        Santana

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Supernatural

                        Santana

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Maquinarama

                        Skank

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        O Samba Poconé

                        Skank

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        A-Sides

                        Soundgarden

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Core

                        Stone Temple Pilots

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        [1997] Black Light Syndrome

                        Terry Bozzio, Tony Levin & Steve Stevens

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Beyond Good And Evil

                        The Cult

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        The Doors

                        The Doors

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        The Police Greatest Hits

                        The Police

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Every Kind of Light

                        The Posies

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Hot Rocks, 1964-1971 (Disc 1)

                        The Rolling Stones

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        No Security

                        The Rolling Stones

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Voodoo Lounge

                        The Rolling Stones

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        My Generation - The Very Best Of The Who

                        The Who

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Achtung Baby

                        U2

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        B-Sides 1980-1990

                        U2

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        How To Dismantle An Atomic Bomb

                        U2

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Pop

                        U2

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Rattle And Hum

                        U2

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        The Best Of 1980-1990

                        U2

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        War

                        U2

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Zooropa

                        U2

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Diver Down

                        Van Halen

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        The Best Of Van Halen, Vol. I

                        Van Halen

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Van Halen III

                        Van Halen

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Van Halen

                        Van Halen

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        Contraband

                        Velvet Revolver

                        Rock

                        8.99

                        /Content/Images/placeholder.gif


                        A Copland Celebration, Vol. I

                        Aaron Copland & London Symphony Orchestra

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Górecki: Symphony No. 3

                        Adrian Leaper & Doreen de Feis

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        The Last Night of the Proms

                        Barry Wordsworth & BBC Concert Orchestra

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Sibelius: Finlandia

                        Berliner Philharmoniker & Hans Rosbaud

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Mozart: Symphonies Nos. 40 & 41

                        Berliner Philharmoniker & Herbert Von Karajan

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Carmina Burana

                        Boston Symphony Orchestra & Seiji Ozawa

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        A Soprano Inspired

                        Britten Sinfonia, Ivor Bolton & Lesley Garrett

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Scheherazade

                        Chicago Symphony Orchestra & Fritz Reiner

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        SCRIABIN: Vers la flamme

                        Christopher O'Riley

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Adams, John: The Chairman Dances

                        Edo de Waart & San Francisco Symphony

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Pachelbel: Canon & Gigue

                        English Concert & Trevor Pinnock

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Respighi:Pines of Rome

                        Eugene Ormandy

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Strauss: Waltzes

                        Eugene Ormandy

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Nielsen: The Six Symphonies

                        Göteborgs Symfoniker & Neeme Järvi

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Mascagni: Cavalleria Rusticana

                        James Levine

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Weill: The Seven Deadly Sins

                        Kent Nagano and Orchestre de l'Opéra de Lyon

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Tchaikovsky: The Nutcracker

                        London Symphony Orchestra & Sir Charles Mackerras

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Szymanowski: Piano Works, Vol. 1

                        Martin Roscoe

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Berlioz: Symphonie Fantastique

                        Michael Tilson Thomas & San Francisco Symphony

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Prokofiev: Romeo & Juliet

                        Michael Tilson Thomas & San Francisco Symphony

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Mozart: Chamber Music

                        Nash Ensemble

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        The Best of Beethoven

                        Nicolaus Esterhazy Sinfonia

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Bach: The Brandenburg Concertos

                        Orchestra of The Age of Enlightenment

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Purcell: The Fairy Queen

                        Roger Norrington, London Classical Players

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Haydn: Symphonies 99 - 104

                        Royal Philharmonic Orchestra & Sir Thomas Beecham

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Handel: The Messiah (Highlights)

                        Scholars Baroque Ensemble

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Prokofiev: Symphony No.1

                        Sergei Prokofiev & Yuri Temirkanov

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Wagner: Favourite Overtures

                        Sir Georg Solti & Wiener Philharmoniker

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        South American Getaway

                        The 12 Cellists of The Berlin Philharmonic

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        English Renaissance

                        The King's Singers

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Bach: Toccata & Fugue in D Minor

                        Ton Koopman

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Bach: Goldberg Variations

                        Wilhelm Kempff

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Bartok: Violin & Viola Concertos

                        Yehudi Menuhin

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Bach: The Cello Suites

                        Yo-Yo Ma

                        Classical

                        8.99

                        /Content/Images/placeholder.gif


                        Worlds

                        Aaron Goldberg

                        Jazz

                        8.99

                        /Content/Images/placeholder.gif


                        Quiet Songs

                        Aisha Duo

                        Jazz

                        8.99

                        /Content/Images/placeholder.gif


                        Warner 25 Anos

                        Antônio Carlos Jobim

                        Jazz

                        8.99

                        /Content/Images/placeholder.gif


                        The Best Of Billy Cobham

                        Billy Cobham

                        Jazz

                        8.99

                        /Content/Images/placeholder.gif


                        Outbreak

                        Dennis Chambers

                        Jazz

                        8.99

                        /Content/Images/placeholder.gif


                        Quanta Gente Veio ver--Bônus De Carnaval

                        Gilberto Gil

                        Jazz

                        8.99

                        /Content/Images/placeholder.gif


                        Blue Moods

                        Incognito

                        Jazz

                        8.99

                        /Content/Images/placeholder.gif


                        Miles Ahead

                        Miles Davis

                        Jazz

                        8.99

                        /Content/Images/placeholder.gif


                        The Essential Miles Davis [Disc 1]

                        Miles Davis

                        Jazz

                        8.99

                        /Content/Images/placeholder.gif


                        The Essential Miles Davis [Disc 2]

                        Miles Davis

                        Jazz

                        8.99

                        /Content/Images/placeholder.gif


                        Heart of the Night

                        Spyro Gyra

                        Jazz

                        8.99

                        /Content/Images/placeholder.gif


                        Morning Dance

                        Spyro Gyra

                        Jazz

                        8.99

                        /Content/Images/placeholder.gif


                        Frank

                        Amy Winehouse

                        Pop

                        8.99

                        /Content/Images/placeholder.gif


                        Axé Bahia 2001

                        Various Artists

                        Pop

                        8.99

                        /Content/Images/placeholder.gif


                        Ring My Bell

                        Anita Ward

                        Disco

                        8.99

                        /Content/Images/placeholder.gif


                        Le Freak

                        Chic

                        Disco

                        8.99

                        /Content/Images/placeholder.gif


                        MacArthur Park Suite

                        Donna Summer

                        Disco

                        8.99

                        /Content/Images/placeholder.gif


                        Chill: Brazil (Disc 2)

                        Antônio Carlos Jobim

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Prenda Minha

                        Caetano Veloso

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Sozinho Remix Ao Vivo

                        Caetano Veloso

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Cássia Eller - Sem Limite [Disc 1]

                        Cássia Eller

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Minha Historia

                        Chico Buarque

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Afrociberdelia

                        Chico Science & Nação Zumbi

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Da Lama Ao Caos

                        Chico Science & Nação Zumbi

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Na Pista

                        Cláudio Zoli

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Djavan Ao Vivo - Vol. 02

                        Djavan

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Djavan Ao Vivo - Vol. 1

                        Djavan

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        The Best of Ed Motta

                        Ed Motta

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Elis Regina-Minha História

                        Elis Regina

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Unplugged

                        Eric Clapton

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Deixa Entrar

                        Falamansa

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Roda De Funk

                        Funk Como Le Gusta

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Quanta Gente Veio Ver (Live)

                        Gilberto Gil

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Meus Momentos

                        Gonzaguinha

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Jorge Ben Jor 25 Anos

                        Jorge Ben

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Jota Quest-1995

                        Jota Quest

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Mais Do Mesmo

                        Legião Urbana

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Duos II

                        Luciana Souza/Romero Lubambo

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Chill: Brazil (Disc 1)

                        Marcos Valle

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Barulhinho Bom

                        Marisa Monte

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Milton Nascimento Ao Vivo

                        Milton Nascimento

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Minas

                        Milton Nascimento

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Olodum

                        Olodum

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Acústico MTV

                        Os Paralamas Do Sucesso

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Arquivo II

                        Os Paralamas Do Sucesso

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Arquivo Os Paralamas Do Sucesso

                        Os Paralamas Do Sucesso

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Serie Sem Limite (Disc 1)

                        Tim Maia

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Serie Sem Limite (Disc 2)

                        Tim Maia

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Sambas De Enredo 2001

                        Various Artists

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Vozes do MPB

                        Various Artists

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Vinicius De Moraes

                        Vinícius De Moraes

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Ao Vivo [IMPORT]

                        Zeca Pagodinho

                        Latin

                        8.99

                        /Content/Images/placeholder.gif


                        Plays Metallica By Four Cellos

                        Apocalyptica

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Alcohol Fueled Brewtality Live! [Disc 1]

                        Black Label Society

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Alcohol Fueled Brewtality Live! [Disc 2]

                        Black Label Society

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Black Sabbath Vol. 4 (Remaster)

                        Black Sabbath

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Black Sabbath

                        Black Sabbath

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Chemical Wedding

                        Bruce Dickinson

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Faceless

                        Godsmack

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Use Your Illusion II

                        Guns N' Roses

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        A Real Dead One

                        Iron Maiden

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        A Real Live One

                        Iron Maiden

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Live After Death

                        Iron Maiden

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        No Prayer For The Dying

                        Iron Maiden

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Piece Of Mind

                        Iron Maiden

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Powerslave

                        Iron Maiden

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Rock In Rio [CD1]

                        Iron Maiden

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Rock In Rio [CD2]

                        Iron Maiden

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Seventh Son of a Seventh Son

                        Iron Maiden

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Somewhere in Time

                        Iron Maiden

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        The Number of The Beast

                        Iron Maiden

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Living After Midnight

                        Judas Priest

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Greatest Hits

                        Lenny Kravitz

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        ...And Justice For All

                        Metallica

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Black Album

                        Metallica

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Garage Inc. (Disc 1)

                        Metallica

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Garage Inc. (Disc 2)

                        Metallica

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Load

                        Metallica

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Master Of Puppets

                        Metallica

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        ReLoad

                        Metallica

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Ride The Lightning

                        Metallica

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        St. Anger

                        Metallica

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Motley Crue Greatest Hits

                        Mötley Crüe

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Ace Of Spades

                        Motörhead

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Tribute

                        Ozzy Osbourne

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Mezmerize

                        System Of A Down

                        Metal

                        8.99

                        /Content/Images/placeholder.gif


                        Revelations

                        Audioslave

                        Alternative

                        8.99

                        /Content/Images/placeholder.gif


                        Cake: B-Sides and Rarities

                        Cake

                        Alternative

                        8.99

                        /Content/Images/placeholder.gif


                        Carried to Dust (Bonus Track Version)

                        Calexico

                        Alternative

                        8.99

                        /Content/Images/placeholder.gif


                        Carry On

                        Chris Cornell

                        Alternative

                        8.99

                        /Content/Images/placeholder.gif


                        Temple of the Dog

                        Temple of the Dog

                        Alternative

                        8.99

                        /Content/Images/placeholder.gif


                        Acústico MTV [Live]

                        Cidade Negra

                        Reggae

                        8.99

                        /Content/Images/placeholder.gif


                        Cidade Negra - Hits

                        Cidade Negra

                        Reggae

                        8.99

                        /Content/Images/placeholder.gif


                        Greatest Hits

                        Lenny Kravitz

                        Reggae

                        8.99

                        /Content/Images/placeholder.gif


                        UB40 The Best Of - Volume Two [UK]

                        UB40

                        Reggae

                        8.99

                        /Content/Images/placeholder.gif


                        The Cream Of Clapton

                        Eric Clapton

                        Blues

                        8.99

                        /Content/Images/placeholder.gif


                        Unplugged

                        Eric Clapton

                        Blues

                        8.99

                        /Content/Images/placeholder.gif


                        Iron Maiden

                        Iron Maiden

                        Blues

                        8.99

                        /Content/Images/placeholder.gif


                        In Step

                        Stevie Ray Vaughan & Double Trouble

                        Blues

                        8.99

                        /Content/Images/placeholder.gif


                        Live [Disc 1]

                        The Black Crowes

                        Blues

                        8.99

                        /Content/Images/placeholder.gif


                        Live [Disc 2]

                        The Black Crowes

                        Blues

                        8.99

                        /Content/Images/placeholder.gif
                        */

                        db.SaveChanges();
                    }
                    
                    transaction.Commit();

                }
                catch(Exception exc)
                {
                    transaction.Rollback();
                }
            }           
        }
    }
}