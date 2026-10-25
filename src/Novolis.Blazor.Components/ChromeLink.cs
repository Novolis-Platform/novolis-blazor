using Microsoft.AspNetCore.Components.Routing;

namespace Novolis.Blazor.Components;

/// <summary>One destination in <see cref="AppChrome"/>.</summary>
/// <param name="Href">Route or absolute URL.</param>
/// <param name="Label">Visible link text.</param>
/// <param name="External">When true, render a plain anchor instead of a route link.</param>
/// <param name="Match">How an in-app link decides it is current.</param>
public sealed record ChromeLink(
    string Href,
    string Label,
    bool External = false,
    NavLinkMatch Match = NavLinkMatch.Prefix);
