using WorkHub.Domain.Common;

namespace WorkHub.Domain.Entities;

/// <summary>
/// İş axtaranın CV-si. Fayl yolu və AI tərəfindən çıxarılan strukturlaşdırılmış məlumatları saxlayır.
/// </summary>
public sealed class Resume : BaseEntity
{
    public Guid UserId { get; set; }

    public User User { get; set; } = null!;

    /// <summary>Faylın diskdə / S3-də saxlanma yolu.</summary>
    public string FilePath { get; set; } = string.Empty;

    /// <summary>PDF/DOCX-dən oxunan təmiz mətn (AI axtarışı üçün).</summary>
    public string RawText { get; set; } = string.Empty;

    /// <summary>AI tərəfindən çıxarılan bacarıqlar (JSON).</summary>
    public string? ParsedSkillsJson { get; set; }

    public int? ExperienceYears { get; set; }

    public ICollection<JobApplication> Applications { get; set; } = [];
}
