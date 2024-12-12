using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public record SignUp(string UserName, string EmailAddress, string Password);

    public class SignUpValidator : AbstractValidator<SignUp>
    {
        public SignUpValidator()
        {
            RuleFor(x => x.UserName)
                .NotEmpty()
                .WithMessage("Username is required.");

            RuleFor(x => x.EmailAddress)
                .NotEmpty()
                .WithMessage("Email is required.")
                .EmailAddress().WithMessage("Email is invalid");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Password is required.")
                .MinimumLength(6)
                .WithMessage("Password must be at least 6 characters long");
            //.Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{4,}$")
            //.WithMessage("Password must be at least 6 characters long, contain at least one uppercase letter, one lowercase letter, and one number.");
        }
    }
}
