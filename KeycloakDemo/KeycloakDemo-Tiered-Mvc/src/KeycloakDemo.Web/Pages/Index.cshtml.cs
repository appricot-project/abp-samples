using KeycloakDemo.Identity;
using KeycloakDemo.Web.Identity;
using Microsoft.AspNetCore.Authentication;
using System.Threading.Tasks;

namespace KeycloakDemo.Web.Pages;

public class IndexModel : KeycloakDemoPageModel
{
    //private readonly IExampleAppService exampleAppService;

    //public IndexModel(IExampleAppService exampleAppService)
    //{
    //    this.exampleAppService = exampleAppService;
    //}

    public async Task OnGetAsync()
    {
        var t = CurrentUser;
        var authenticated = t.IsAuthenticated;
        var claims = CurrentUser.GetAllClaims();

        //await exampleAppService.PostSomethingAsync();
    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }

    public async Task OnPostAsync()
    {
        await LazyServiceProvider.LazyGetRequiredService<IIdentityProfileAppService>().CreateOrUpdateAsync();
    }
}
