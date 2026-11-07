namespace WorkHub.Domain.Enums;

/// <summary>
/// İş müraciətinin nəzərdən keçirilmə statusu.
/// </summary>
public enum JobApplicationStatus
{
    Submitted = 1,
    UnderReview = 2,
    Shortlisted = 3,
    Interview = 4,
    Rejected = 5,
    Hired = 6
}