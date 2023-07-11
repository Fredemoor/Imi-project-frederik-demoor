using FluentValidation;
using Imi.Project.Mobile.Domain.Models;

namespace Imi.Project.Mobile.Domain.Validators
{
    public class AnimalValidator : AbstractValidator<Animal>
    {
        public AnimalValidator()
        {
            RuleFor(animal => animal.Name)
                .NotNull()
                .WithMessage("Name is required")
                .NotEmpty()
                .WithMessage("Name is required")
                .Length(5, 15)
                .WithMessage("Name must be between 5 and 15 characters");

            RuleFor(animal => animal.Description)
                .NotNull()
                .WithMessage("Name is Description is required")
                .NotEmpty()
                .WithMessage("Name is required");

            RuleFor(animal => animal.Gender)
                .NotNull()
                .WithMessage("Gender is required")
                .IsInEnum();

            RuleFor(animal => animal.Breed).NotNull()
                .WithMessage("Breed is required")
                .NotEmpty()
                .WithMessage("Breed is required")
                .Length(5, 40)
                .WithMessage("Breed must be between 20 and 40 characters");

            RuleFor(animal => animal.Birthdate).NotNull();
        }
    }
}
