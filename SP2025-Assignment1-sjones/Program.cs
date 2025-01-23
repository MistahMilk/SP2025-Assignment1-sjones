namespace SP2025_Assignment1_sjones
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseDefaultFiles();

            app.UseStaticFiles();

            app.Run();
        }
    }
}
