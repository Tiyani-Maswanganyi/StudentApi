namespace StudentApi.Models
{
    using FluentValidation;

    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Age).InclusiveBetween(1, 100);
            RuleFor(x => x.Email).EmailAddress();
        }
    }

}
