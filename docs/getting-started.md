# Getting started

Install the required chrome stylesheet:

```powershell
dotnet add package Novolis.Blazor.GraphicalProfile
```

Link `GraphicalProfile.StylesheetHref` from the host `index.html` and use `--ngp-*` tokens.

Install the Mermaid component:

```powershell
dotnet add package Novolis.Blazor.Mermaid
```

Register the package's Razor components in the host and render a diagram:

```razor
<MermaidDiagram Mermaid="@diagram" Theme="MermaidRenderTheme.GitHubLight" />
```

The component renders through `Novolis.Markup.Mermaid.Rendering`. It is intended for interactive server and other hosts that can execute the Novolis renderer.
