namespace Novolis.Blazor.Components;

/// <summary>One row in <see cref="EntryList"/>.</summary>
/// <param name="Href">Destination for the row.</param>
/// <param name="Title">Row title.</param>
/// <param name="Kicker">Short label shown above the title.</param>
/// <param name="Excerpt">One-line summary under the title.</param>
/// <param name="Tags">Labels joined with a middot beside the kicker.</param>
public sealed record EntryItem(
    string Href,
    string Title,
    string? Kicker = null,
    string? Excerpt = null,
    IReadOnlyList<string>? Tags = null);
