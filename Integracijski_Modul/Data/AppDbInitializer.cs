using Integracijski_Modul.Data.Models;

namespace Integracijski_Modul.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                //Inicijalizacija tagova
                if (!context.Tags.Any())
                {
                    context.Tags.AddRange(new Tag()
                    {
                        Name ="TagPrvi"
                    },

                    new Tag()
                    {
                        Name ="Tag2"
                    });

                    context.SaveChanges();
                }
                //Inicijalizacija žanrova
                if (!context.Genres.Any())
                {
                    context.Genres.AddRange(new Genre()
                    {
                        Name = "Romantika",
                        Description ="Ovo je ljubavna tema"
                    },

                    new Genre()
                    {
                        Name = "Akcija",
                        Description="Pucanje na sve strane"
                    });

                    context.SaveChanges();
                }
                //Inicijalizacija videa
                if (!context.Videos.Any())
                {
                    context.Videos.AddRange(new Video()
                    {
                        CreatedAt = DateTime.Now,
                        Name = "Fast and furious",
                        Description = "Movie about cars",
                        GenreId = 2,
                        Image = "Neka fotka2",
                        TotalTime = 140,
                        StreamingUrl="Https...",
                        
                    },

                    new Video()
                    {
                        CreatedAt=DateTime.Now,
                        Name = "Titanik",
                        Description = "Ostavila ga na brodu",
                        GenreId=1,
                        Image="Neka fotka",
                        TotalTime=170,
                        StreamingUrl="https...",
                        
                    });

                    context.SaveChanges();
                }

            }
        }
    }
}

