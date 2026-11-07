using WorkHub.Domain.Common;
using WorkHub.Domain.Enums;

namespace WorkHub.Domain.Entities;

/// <summary>
/// Platforma istifadəçisi (iş axtaran və ya işəgötürən).
/// </summary>
public sealed class User : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public string? PhoneNumber { get; set; }

    public UserRole Role { get; set; }

    // --- Navigation properties ---
    public Resume? Resume { get; set; }

    public ICollection<Vacancy> Vacancies { get; set; } = [];

    public ICollection<JobApplication> Applications { get; set; } = [];
}
