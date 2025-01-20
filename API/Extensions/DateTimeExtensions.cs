namespace API.Extensions;

public static class DateTimeExtensions
{
    public static int CalculateAge(this DateOnly dateOfBirth)
{
    var today = DateOnly.FromDateTime(DateTime.Now);
    var age = today.Year - dateOfBirth.Year;

    // If the birthday hasn't occurred yet this year, subtract one year from the age
    if (dateOfBirth > today.AddYears(-age))
    {
        age--;
    }

    return age;
}

}
