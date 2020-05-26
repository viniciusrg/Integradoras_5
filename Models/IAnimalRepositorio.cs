using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Models.Animal
{
    public interface IAnimalRepositorio
    {
        IQueryable<Animal> Animais { get; }

        public void Create(Animal animal);
        public Animal ObterAnimal(int id);
        public void Edit(Animal animal);
        public void Delete(Animal animal);
    }
}
