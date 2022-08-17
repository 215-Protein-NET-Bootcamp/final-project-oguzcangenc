namespace CarPartsMarketplace.API.Middleware;

public static class CustomizeSwaggerUIMiddleware
{
    public static void UseCustomizeSwaggerUI(this IApplicationBuilder app)
    {
        app.UseSwaggerUI(c =>
        {
            c.DefaultModelsExpandDepth(-1);
        });

    }
}