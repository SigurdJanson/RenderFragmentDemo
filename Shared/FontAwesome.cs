using Microsoft.AspNetCore.Components;

namespace RenderFragments.Shared;

public static class FontAwesome
{
    public static class Solid
    {
        public static readonly RenderFragment User =
            (__builder) => {
                __builder.AddMarkupContent(0, "<i class=\"fa-solid fa-user\"></i>");
            };

        public static readonly RenderFragment Anchor =
        (__builder) => {
            __builder.AddMarkupContent(0, "<i class=\"fa-solid fa-anchor\"></i>");
    
        };
    }

}
