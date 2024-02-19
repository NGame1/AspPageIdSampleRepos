using AspCoreSampleRepos.Infra.PageModels;

namespace AspCoreSampleRepos.Pages
{
    public class IndexModel : BasePageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Console.WriteLine($"OnGet:{PageId}");
        }

        public void OnPost()
        {
            // Here I'm get a Guid.Empty result, 
            // But if it is possible somehow I want to automatically set this PageId on BaseRazorPage class. 
            // Somehow, I want to generate a relation between the Page and PageModel by a PageId. 
            // In this way it is much easier to convert a legacy ASP .NET webform app to .NET core with less changes. 
            Console.WriteLine($"OnPost:{PageId}");
        }
    }
}
