using Microsoft.AspNetCore.Components;

namespace BoltBlazor;

public partial class BoltLoadContainer : ComponentBase
{
    /// <summary>
    /// Puts the container into loading mode.
    /// </summary>
    /// <remarks>
    /// Defaults to <c>false</c>.
    /// </remarks>
    [Parameter]
    public bool Loading { get; set; }
    
    /// <summary>
    /// Child content of the component.
    /// </summary>
    /// <remarks>
    /// Defaults to <c>null</c>.
    /// </remarks>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}