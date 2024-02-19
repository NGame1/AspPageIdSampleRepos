using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspCoreSampleRepos.Infra.PageModels;

public class BasePageModel : PageModel
{
    [BindProperty]
    public Guid PageId { get; set; }

}
