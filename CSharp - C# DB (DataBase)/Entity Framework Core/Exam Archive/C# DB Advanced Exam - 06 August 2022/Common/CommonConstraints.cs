using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Footballers.Common;

public class CommonConstraints
{
    //Coach
    public const int CoachNameMinLength = 2;
    public const int CoachNameMaxLength = 40;

    //Team
    public const string TeamNameRegex = @"^[a-zA-Z0-9\s.\-]{3,40}$";
    public const int TeamNationalityMinLength = 2;
    public const int TeamNationalityMaxLength = 40;

    //Footballer
    public const int FootballerNameMinLength = 2;
    public const int FootballerNameMaxLength = 40;

    public const int FootballerPositionMinRange = 0;
    public const int FootballerPositionMaxRange = 3;

    public const int FootballerBestSkillMinRange = 0;
    public const int FootballerBestSkillMaxRange = 4;
}