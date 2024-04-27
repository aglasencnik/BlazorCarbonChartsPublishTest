using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;

namespace BlazorCarbonCharts.Components;

/// <summary>
/// Represents the base class for all Carbon Chart components.
/// </summary>
public abstract class CarbonChartComponentBase : ComponentBase, IAsyncDisposable
{
    /// <summary>
    /// Gets the JavaScript runtime.
    /// </summary>
    [Inject]
    protected IJSRuntime JSRuntime { get; set; } = default!;

    /// <summary>
    /// Gets the path to the components directory.
    /// </summary>
    protected const string COMPONENTS_PATH = "./_content/BlazorCarbonCharts/Components";

    /// <summary>
    /// Gets the reference to the component element.
    /// </summary>
    protected ElementReference _ref;

    /// <summary>
    /// Gets or sets the JavaScript module reference.
    /// </summary>
    protected IJSObjectReference? Module { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier.
    /// The value will be used as the HTML <see href="https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/id">global id attribute</see>.
    /// </summary>
    [Parameter]
    public string? Id { get; set; } = null;

    /// <summary>
    /// Optional CSS class names. If given, these will be included in the class attribute of the component.
    /// </summary>
    [Parameter]
    public virtual string? Class { get; set; } = null;

    /// <summary>
    /// Optional in-line styles. If given, these will be included in the style attribute of the component.
    /// </summary>
    [Parameter]
    public virtual string? Style { get; set; } = null;

    /// <summary>
    /// Gets or sets a collection of additional attributes that will be applied to the created element.
    /// </summary>
    [Parameter(CaptureUnmatchedValues = true)]
    public virtual IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }


    /// <summary>
    /// Builds the render tree for the Carbon Chart component.
    /// </summary>
    /// <param name="builder">RenderTreeBuilder object.</param>
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var seq = 0;
        builder.OpenElement(seq, "div");
        builder.AddAttribute(++seq, "id", Id);
        builder.AddAttribute(++seq, "class", Class);
        builder.AddAttribute(++seq, "style", Style);
        builder.AddMultipleAttributes(++seq, AdditionalAttributes);
        builder.AddElementReferenceCapture(++seq, (element) => _ref = element);
        builder.CloseElement();
    }

    /// <summary>
    /// Initializes the Carbon Chart component.
    /// </summary>
    /// <param name="firstRender">Whether it is the first render.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            //var componentName = GetType().Name;
            //var modulePath = $"{COMPONENTS_PATH}/{componentName}/{componentName}.cs.js";

            //Module ??= await JSRuntime.InvokeAsync<IJSObjectReference>("import", modulePath);

            //await Module.InvokeVoidAsync("createChart", _ref);
        }
    }

    /// <summary>
    /// Disposes the Carbon Chart component.
    /// </summary>
    /// <returns>ValueTask</returns>
    public ValueTask DisposeAsync()
    {
        if (Module is not null)
        {
            return Module.DisposeAsync();
        }
        return ValueTask.CompletedTask;
    }
}
