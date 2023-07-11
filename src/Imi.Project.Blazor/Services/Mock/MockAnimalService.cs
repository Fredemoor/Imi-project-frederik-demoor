using Imi.Project.Blazor.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Core.Services.Mock
{

    public class MockAnimalService
    {

        private static List<Animal> animalsList = new List<Animal>
        {
            new Animal
            {
                Id = Guid.Parse("11111111-0000-0000-0000-000000000001"),
                Age = 5,
                Name = "Chappie",
                Description = "zeer lieve hond goed voor gezin met kinderen",
                Gender = Enums.Gender.Male,
                ImageUrl = "image0.png",
                Breed = "Podenco"
            
            },
            new Animal
            {
                Id = Guid.Parse("22222222-0000-0000-0000-000000000002"),
                Age = 3,
                Name = "Sjonnie",
                Description = "zeer luide hond",
                Gender = Enums.Gender.Male,
                ImageUrl = "image1.png",
                Breed = "Pitbull",             
            },
            new Animal {
                Id = Guid.Parse("33333333-0000-0000-0000-000000000002"),
                Age = 3,
                Name = "Ozzy",
                Description = "zeer Leuk karakter hond",
                Gender = Enums.Gender.Female,
                ImageUrl = "image2.png",
                Breed = "Australian CattleDog",
            },
            new Animal {
                Id = Guid.Parse("44444444-0000-0000-0000-000000000002"),
                Age = 8,
                Name = "Schnoedel",
                Description = "Grappige energieke hond",
                Gender = Enums.Gender.Female,
                ImageUrl = "image3.png",
                Breed = "Labradoodle"
            }
        };


        public async Task<Animal> AddAsync(Animal entity)
        {
            animalsList.Add(entity);
            return await Task.FromResult(entity);
        }

        public async Task<Animal> DeleteAsync(Animal entity)
        {
            animalsList.Remove(entity);
            return await Task.FromResult(entity);
        }

        public async Task<IQueryable<Animal>> GetAll()
        {
            var animals = animalsList.AsQueryable();
            return await Task.FromResult(animals);
        }

        public async Task<IEnumerable<Animal>> GetAllAsync()
        {
            var animals = await GetAll();
            return await Task.FromResult(animals);
        }

        public async Task<Animal> GetByIdAsync(Guid id)
        {
            var animals = animalsList.FirstOrDefault(a => a.Id.Equals(id));
            return await Task.FromResult(animals);
        }

        public async Task<Animal> UpdateAsync(Animal entity)
        {
            var oldEntity = animalsList.FirstOrDefault(a => a.Id.Equals(entity.Id));

            if(oldEntity != null)
            animalsList.Remove(oldEntity);
            animalsList.Add(entity);

            return await Task.FromResult(entity);
        }
    }
}

