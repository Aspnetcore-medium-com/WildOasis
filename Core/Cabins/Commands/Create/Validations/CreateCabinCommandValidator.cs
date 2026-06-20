

using FluentValidation;

namespace Core.Cabins.Commands.Create.Validations
{
    public class CreateCabinCommandValidator : AbstractValidator<CreateCabinCommand>
    {
        public CreateCabinCommandValidator()
        {
            RuleFor(CreateCabinCommand => CreateCabinCommand.Name).NotEmpty().WithMessage("Cabin Name is Required")
                .MinimumLength(3).WithMessage("Cabin Name should be 3 chars long")
                .MaximumLength(50).WithMessage("Cabin Name should be less than 50 chars");
            RuleFor(CreateCabinCommand => CreateCabinCommand.Description).NotEmpty().WithMessage("Description is Required");
            RuleFor(CreateCabinCommand => CreateCabinCommand.MaxCapacity).LessThan(50).WithMessage("Max Capacity cant be greater than 50");
            RuleFor(CreateCabinCommand => CreateCabinCommand.Discount).LessThan(80).WithMessage("Discount cant be greater than 80");

        }
    }
}
