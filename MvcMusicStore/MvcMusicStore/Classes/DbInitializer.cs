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