    using Microsoft.EntityFrameworkCore;
    using Blazor213FinalWebAPP.Models;
    using _213FinalWebAPP.Data;
using _213FinalWebAPP.Migrations;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace Blazor213FinalWebAPP.Data
    {
        public class SeedData1
        {
            public static void Initialize(IServiceProvider serviceProvider)
            {
                using var context = new _213FinalWebAPPContext(serviceProvider.GetRequiredService<DbContextOptions<_213FinalWebAPPContext>>());

                if (context == null || context.Dog == null)
                {
                    throw new NullReferenceException("Null BlazorWebAppMoviesContext or Student DbSet");
                }
                 if (context.Dog.Any())
                 {
                    return;
                 }


            context.Dog.AddRange(
                new Dog {
                    Images = "Images1/dog1.jpg",
                    Name = "Milo",
                    Breed = "Golden Retriver",
                    Size = "Large",
                    Age = "2 Years old",
                    Description = "Milo is a energeic and loving dog, that will be perfect for a family",
                    Other = "",
                    Gender = "Male", 
                    Temperament = "Energetic",
                    Availability = "Pending"
                },
                new Dog
                {
                    Images = "Images1/dog10.jpg",
                    Name = "Barker",
                    Breed = "Chocolate Labrador",
                    Size = "Small",
                    Age = "4 Months old",
                    Description = "Barker is a sweet young puppy who has a lot of love to give",
                    Other = "He has not been neutered",
                    Gender = "Male",
                    Temperament = "Gentle",
                    Availability = "Availible"
                },
                new Dog
                {
                    Images = "Images1/dog11.jpg",
                    Name = "Zara",
                    Breed = "Beagle",
                    Size = "Small",
                    Age = "4 years old",
                    Description = "A lovable Beagle with a curious nose and a soft spot for kids",
                    Other = "She has been trained",
                    Gender = "Female",
                    Temperament = "Friendly",
                    Availability = "Availible"
                },
                new Dog {
                Images = "Images1/dog15.jpg",
                    Name = "Bella",
                    Breed = "Maltese",
                    Size = "Small",
                    Age = "7 years old",
                    Description = "A fully maltese with a big personality and a love for cuddling",
                    Other = "",
                    Gender = "Female",
                    Temperament = "Easy Going",
                    Availability = "Availible"
                },
                new Dog
                {
                    Images = "Images1/dog3.jpg",
                    Name = "Zeus",
                    Breed = "German Shepard",
                    Size = "Large",
                    Age = "3 years old",
                    Description = "A loyal German Shepherd with a heart of gold, perfect for an active person",
                    Other = "Zeus has shown some aggression torwards other dogs. He will need training",
                    Gender = "Male",
                    Temperament = "Active",
                    Availability = "Availible"
                },
                new Dog
                {
                    Images = "Images1/dog7.jpg",
                    Name = "Daisy",
                    Breed = "Jack Russell Terrier",
                    Size = "Small",
                    Age = "5 years old",
                    Description = "A small but energetic Jack Russell Terrier who’s always ready for an adventure",
                    Other = "",
                    Gender = "Female",
                    Temperament = "Kind",
                    Availability = "Availible"
                }
                );
            context.SaveChanges();
            }
        }
    }
