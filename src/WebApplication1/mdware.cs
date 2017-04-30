using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class mdware
    {
        private readonly RequestDelegate del;
        public mdware(RequestDelegate next)
        {
            this.del = next;
        }

        public async Task Invoke(HttpContext context)
        {
            switch (context.Request.Path.Value.ToLower())
            {
                case "/root": await context.Response.WriteAsync(" write /htmlpage.html for read static html-page"); break;
                case "/info": await context.Response.WriteAsync("infopage"); break;
                default: await context.Response.WriteAsync("открой страничку по /htmlpage.html "); break;

            }

        }
    }
}