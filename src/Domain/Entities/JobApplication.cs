using WorkHub.Domain.Common;
using WorkHub.Domain.Enums;

namespace WorkHub.Domain.Entities;

/// <summary>
/// İş axtaranın vakansiyaya müraciəti.
/// </summary>
public sealed class JobApplication : BaseEntity
{
    public Guid VacancyId { get; set; }

    public Vacancy Vacancy { get; set; } = null!;

    public Guid ApplicantId { get; set; }

    public User Applicant { get; set; } = null!;

    public Guid ResumeId { get; set; }

    public Resume Resume { get; set; } = null!;

    public JobApplicationStatus Status { get; set; } = JobApplicationStatus.Submitted;

    /// <summary>AI tərəfindən hesablanan uyğunluq faizi (0–100).</summary>
    public float? MatchScore { get; set; }

    /// <summary>AI tərəfindən yaradılan rəy (məs. "SQL biliyi çatışmır").</summary>
    public string? AiFeedback { get; set; }
}
