using System.Reflection;

namespace minecraft.Application.Resources;

public static class ResourceAssembly
{
    public static Assembly Assembly => typeof(ResourceAssembly).Assembly;
}
