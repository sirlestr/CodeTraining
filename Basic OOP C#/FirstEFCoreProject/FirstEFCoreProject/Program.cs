using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace FirstEFCoreProject
{
    internal class Program
    {
        static void Main(string[] args)
        {



            using (FirstDbContext dbContext = new FirstDbContext())
            {
                if (dbContext.Database.EnsureDeleted())
                {
                    Console.WriteLine("Databaze byla smazána");
                }
                if (dbContext.Database.EnsureCreated())
                {
                    Console.WriteLine("Daatabaze byla vytvořena");
                }
            }

            using (FirstDbContext dbContext = new FirstDbContext())
            {
                dbContext.Authors.Add(new Author
                {
                    Name = "Jan",
                    LastName = "Novák",
                    BirthDate = new DateTime(1984, 3, 11),
                    ArticlesCount = 8
                });
                dbContext.Authors.Add(new Author
                {
                    Name = "Michaela",
                    LastName = "Slavíková",
                    BirthDate = new DateTime(1990, 8, 14),
                    ArticlesCount = 11
                });
                dbContext.Authors.Add(new Author
                {
                    Name = "Josef",
                    LastName = "Nový",
                    BirthDate = new DateTime(1972, 12, 20),
                    ArticlesCount = 5
                });
                dbContext.Authors.Add(new Author
                {
                    Name = "Ludmila",
                    LastName = "Dvořáková",
                    BirthDate = new DateTime(1967, 4, 7),
                    ArticlesCount = 6
                });
                dbContext.Authors.Add(new Author
                {
                    Name = "Petr",
                    LastName = "Černý",
                    BirthDate = new DateTime(1995, 2, 20),
                    ArticlesCount = 6
                });
                dbContext.Authors.Add(new Author
                {
                    Name = "Pavel",
                    LastName = "Procházka",
                    BirthDate = new DateTime(2002, 12, 3),
                    ArticlesCount = 2
                });

                dbContext.SaveChanges();


            }


            using (FirstDbContext dbContext = new FirstDbContext())
            {
                //Author? author = dbContext.Authors.Find(1);
                dbContext.Authors
                    .Where(a => a.Id < 4)
                    .ExecuteDelete();
                    

                PrintAuthors(dbContext.Authors.ToList());

            }

           Console.ReadLine();






            void PrintAuthors(IEnumerable<Author> authors)
            {
                Console.WriteLine();
                foreach (Author author in authors)
                {
                    Console.WriteLine("[{0}] {1} {2}, narozen {3} s počtem článků {4}",
                        author.Id,author.Name,author.LastName,author.BirthDate.ToShortDateString(),author.ArticlesCount);
                }

            }

        }
    }
}
