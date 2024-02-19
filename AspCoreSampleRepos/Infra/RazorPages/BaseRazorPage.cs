using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspCoreSampleRepos.Infra.RazorPages;

public abstract class BaseRazorPage : Page
{
    public Guid PageId { get; set; } = Guid.NewGuid();
}
