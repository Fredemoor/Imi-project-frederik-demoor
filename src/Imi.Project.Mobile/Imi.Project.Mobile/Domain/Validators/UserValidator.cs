using FluentValidation;
using Imi.Project.Mobile.Domain.Models;
using System;

namespace Imi.Project.Mobile.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public class AnimalValidator : AbstractValidator<User>
        {
            public AnimalValidator()
            {
                RuleFor(user => user.Username)
                    .NotNull()
                    .WithMessage("username is required")
                    .NotEmpty()
                    .WithMessage("username is required")
                    .Length(5, 15)
                    .WithMessage("Name must be between 5 and 15 characters");

                RuleFor(user => user.Email)
                    .NotNull()
                    .WithMessage("Email required")
                    .NotEmpty()
                    .WithMessage("Email required");

                RuleFor(user => user.Email).EmailAddress();

                RuleFor(user => user.Password)
                    .NotNull()
                    .WithMessage("Password required")
                    .NotEmpty()
                    .WithMessage("password required");

                RuleFor(user => user.ConfirmPassword)
                    .NotNull()
                    .WithMessage("Password required")
                    .NotEmpty()
                    .WithMessage("password required");

                RuleFor(user => user.Password).Equal(user => user.ConfirmPassword);

                RuleFor(user => user.HasAcceptedTermsAndConditions).NotEmpty();

                RuleFor(user => user.BirthDate)
                    .NotEmpty()
                    .WithMessage("Birthdate required")
                    .InclusiveBetween(new DateTime(1900, 1, 1), new DateTime(2100, 1, 1));

            }
        }
    }
}
