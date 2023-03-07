﻿using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                // Cinema
                if (context.Cinema.Any() == false)
                {
                    context.Cinema.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            CinemaName = "Cinema 1",
                            CinemaLogo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            CinemaDescription = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            CinemaName = "Cinema 2",
                            CinemaLogo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            CinemaDescription = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            CinemaName = "Cinema 3",
                            CinemaLogo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            CinemaDescription = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            CinemaName = "Cinema 4",
                            CinemaLogo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            CinemaDescription = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            CinemaName = "Cinema 5",
                            CinemaLogo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            CinemaDescription = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                // Actors
                if (context.Actors.Any() == false)
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                // Producers
                if (context.Producers.Any() == false)
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                // Movies
                if (context.Movies.Any() == false)
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            MovieName = "Life",
                            MovieDescription = "This is the Life movie description",
                            MoviePrice = 39.50,
                            MovieImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            MovieStartDate = DateTime.Now.AddDays(-10),
                            MovieEndDate = DateTime.Now.AddDays(10),
                            CinemaID = 3,
                            ProducerID = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            MovieName = "The Shawshank Redemption",
                            MovieDescription = "This is the Shawshank Redemption description",
                            MoviePrice = 29.50,
                            MovieImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            MovieStartDate = DateTime.Now,
                            MovieEndDate = DateTime.Now.AddDays(3),
                            CinemaID = 1,
                            ProducerID = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            MovieName = "Ghost",
                            MovieDescription = "This is the Ghost movie description",
                            MoviePrice = 39.50,
                            MovieImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            MovieStartDate = DateTime.Now,
                            MovieEndDate = DateTime.Now.AddDays(7),
                            CinemaID = 4,
                            ProducerID = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            MovieName = "Race",
                            MovieDescription = "This is the Race movie description",
                            MoviePrice = 39.50,
                            MovieImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            MovieStartDate = DateTime.Now.AddDays(-10),
                            MovieEndDate = DateTime.Now.AddDays(-5),
                            CinemaID = 1,
                            ProducerID = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            MovieName = "Scoob",
                            MovieDescription = "This is the Scoob movie description",
                            MoviePrice = 39.50,
                            MovieImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            MovieStartDate = DateTime.Now.AddDays(-10),
                            MovieEndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 1,
                            ProducerID = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            MovieName = "Cold Soles",
                            MovieDescription = "This is the Cold Soles movie description",
                            MoviePrice = 39.50,
                            MovieImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            MovieStartDate = DateTime.Now.AddDays(3),
                            MovieEndDate = DateTime.Now.AddDays(20),
                            CinemaID = 1,
                            ProducerID = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                // Actors & Movies
                if (context.Actors_Movies.Any() == false)
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorID = 1,
                            MovieID = 1
                        },
                        new Actor_Movie()
                        {
                            ActorID = 3,
                            MovieID = 1
                        },

                         new Actor_Movie()
                        {
                            ActorID = 1,
                            MovieID = 2
                        },
                         new Actor_Movie()
                        {
                            ActorID = 4,
                            MovieID = 2
                        },

                        new Actor_Movie()
                        {
                            ActorID = 1,
                            MovieID = 3
                        },
                        new Actor_Movie()
                        {
                            ActorID = 2,
                            MovieID = 3
                        },
                        new Actor_Movie()
                        {
                            ActorID = 5,
                            MovieID = 3
                        },


                        new Actor_Movie()
                        {
                            ActorID = 2,
                            MovieID = 4
                        },
                        new Actor_Movie()
                        {
                            ActorID = 3,
                            MovieID = 4
                        },
                        new Actor_Movie()
                        {
                            ActorID = 4,
                            MovieID = 4
                        },


                        new Actor_Movie()
                        {
                            ActorID = 2,
                            MovieID = 5
                        },
                        new Actor_Movie()
                        {
                            ActorID = 3,
                            MovieID = 5
                        },
                        new Actor_Movie()
                        {
                            ActorID = 4,
                            MovieID = 5
                        },
                        new Actor_Movie()
                        {
                            ActorID = 5,
                            MovieID = 5
                        },


                        new Actor_Movie()
                        {
                            ActorID = 3,
                            MovieID = 6
                        },
                        new Actor_Movie()
                        {
                            ActorID = 4,
                            MovieID = 6
                        },
                        new Actor_Movie()
                        {
                            ActorID = 5,
                            MovieID = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
