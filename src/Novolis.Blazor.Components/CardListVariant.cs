namespace Novolis.Blazor.Components;

/// <summary>How a <see cref="CardList"/> lays out its items.</summary>
public enum CardListVariant
{
    /// <summary>As many columns as fit, at least 15rem each.</summary>
    Deck,

    /// <summary>Two columns, collapsing to one under 800px.</summary>
    Grid,
}
