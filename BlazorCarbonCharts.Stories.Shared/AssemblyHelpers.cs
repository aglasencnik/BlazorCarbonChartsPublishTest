using System.Reflection;

namespace BlazorCarbonCharts.Stories.Shared;

public static class AssemblyHelpers
{
    public static Assembly Assembly => typeof(AssemblyHelpers).Assembly;
}