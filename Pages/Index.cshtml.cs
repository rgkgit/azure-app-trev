using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_app_trev.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger, IConfiguration _configuration)
    {
        _logger = logger;
        Configuration = _configuration;
    }

    public IConfiguration Configuration { get; }

    public void OnGet()
    {
        ViewData["Greeting"] = Configuration["Greeting"];
    }
}
