# Design

Blazor is a UI island. Components may depend on headless Novolis packages, but headless markup packages do not depend on Blazor. Blazor, Avalonia, and MAUI are selected by an executable host and never reference each other. `Novolis.Blazor.GraphicalProfile` is the required chrome stylesheet for Blazor hosts. `Novolis.Blazor.Components` is the shell, card, dialog, list, and article markup on those tokens. Product pages keep their domain surfaces.

`MermaidDiagram` keeps rendering server-side through `MermaidSvgRenderer`; the component does not add a JavaScript wrapper dependency.
