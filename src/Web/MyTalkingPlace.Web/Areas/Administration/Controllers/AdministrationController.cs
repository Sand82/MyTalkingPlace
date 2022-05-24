namespace MyTalkingPlace.Web.Areas.Administration.Controllers
{
    using MyTalkingPlace.Common;
    using MyTalkingPlace.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
