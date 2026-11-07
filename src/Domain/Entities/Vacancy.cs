using WorkHub.Domain.Common;
using WorkHub.Domain.Enums;

namespace WorkHub.Domain.Entities;

/// <summary>
/// İşəgötürən tərəfindən yaradılan vakansiya elanı.
/// </summary>
public sealed class Vacancy : BaseEntity
{
    public Guid EmployerId { get; set; }

    public User Employer { get; set; } = null!;

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string? CompanyName { get; set; }

    public string? Location { get; set; }

    public EmploymentType EmploymentType { get; set; }

    public ExperienceLevel ExperienceLevel { get; set; }

    public VacancyStatus Status { get; set; } = VacancyStatus.Draft;

    public decimal? SalaryMin { get; set; }

    public decimal? SalaryMax { get; set; }

    /// <summary>AI axtarışı üçün tələb olunan bacarıqlar (vergüllə ayrılmış).</summary>
    public string? RequiredSkills { get; set; }

    public DateTime? PublishedAt { get; set; }

    public DateTime? Deadline { get; set; }

    public ICollection<JobApplication> Applications { get; set; } = [];
}
