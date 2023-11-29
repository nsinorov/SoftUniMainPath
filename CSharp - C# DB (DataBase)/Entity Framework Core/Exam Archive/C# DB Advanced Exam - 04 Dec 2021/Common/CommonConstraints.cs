namespace Theatre.Common;

public class CommonConstraints
{
    //Cast
    public const int CastFullNameMinLength = 4;
    public const int CastFullNameMaxLength = 30;

    public const string CastPhoneNumberRegex = @"\+44-\d{2}-\d{3}-\d{4}";

    //Theatre
    public const int TheatreNameMinLength = 4;
    public const int TheatreNameMaxLength = 30;

    public const sbyte TheatreHallsMinRange = 0;
    public const sbyte TheatreHallsMaxRange = 10;

    public const int TheatreDirectorMinLength = 4;
    public const int TheatreDirectorMaxLength = 30;

    //Play
    public const int PlayTitleMinLength = 4;
    public const int PlayTitleMaxLength = 50;

    public const int PlayDurationMinLengthInHours = 1;

    public const double PlayRatingMinRange = 0;
    public const double PlayRatingMaxRange = 10;

    public const int PlayDescriptionMaxLength = 700;

    public const int PlayScreenwriterMinLength = 4;
    public const int PlayScreenwriterMaxLength = 30;

    public const int PlayGenreMinRange = 0;
    public const int PlayGenreMaxRange = 3;

    //Ticket
    public const double TicketPriceMinRange = 1.0;
    public const double TicketPriceMaxRange = 100.0;

    public const sbyte TicketRowNumberMinRange = 1;
    public const sbyte TicketRowNumberMaxRange = 10;
}