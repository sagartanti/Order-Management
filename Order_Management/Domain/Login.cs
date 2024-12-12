using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    //public class Login
    //{
    //    public string Username { get; set; }
    //    public string Password { get; set; }
    //    public bool RememberMe { get; set; }
    //}

    public record Login(string Username, string Password, bool RememberMe = false);

    public class LoginValidator : AbstractValidator<Login>
    {
        public LoginValidator()
        {
            RuleFor(x => x.Username)
                .NotEmpty()
                .WithMessage("Username is required.")
                .EmailAddress().WithMessage("Username is invalid");

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
