using doLittle.FluentValidation.Commands;
using FluentValidation;

namespace Domain
{
    public class AddDataCollectorValidator : CommandInputValidator<AddDataCollector>
    {
        public AddDataCollectorValidator()
        {
            RuleFor(_ => _.FullName)
                .NotEmpty()
                .WithMessage("Full name is not correct - Has to be defined");

            RuleFor(_ => _.DisplayName)
                .NotEmpty()
                .WithMessage("Display name is not correct - Has to be defined");

            //TODO: rest of the rules
        }
    }
}