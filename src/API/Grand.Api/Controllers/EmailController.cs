using Grand.Api.Commands.Models.Common;
using Grand.Api.Models.Common;
using Grand.Business.Customers.Interfaces;
using Grand.Business.Messages.Interfaces;
using Grand.Domain.Messages;
using Grand.SharedKernel;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Grand.Api.Controllers
{
    [ApiController]
    [Area("Api")]
    [Route("[area]/[controller]/[action]")]
    [ApiExplorerSettings(IgnoreApi = false)]
    [SwaggerTag(description: "Create token")]
    public class EmailController : Controller
    {
        private readonly IUserApiService _userApiService;
        private readonly IEmailSender _emailSender;
        private readonly IEmailAccountService _emailAccountService;
        private readonly EmailAccountSettings _emailAccountSettings;
        private readonly IMediator _mediator;

        public EmailController(IMediator mediator, 
            IUserApiService userApiService, 
            IEmailSender emailSender,
            IEmailAccountService emailAccountService,
            EmailAccountSettings emailAccountSettings)
        {
            _userApiService = userApiService;
            _mediator = mediator;
            _emailSender = emailSender;
            _emailAccountService = emailAccountService;
            _emailAccountSettings = emailAccountSettings;
        }

        [AllowAnonymous]
        [IgnoreAntiforgeryToken]
        [HttpPost]
        public async Task<IActionResult> Send([FromBody] EmailSendModel model)
        {
            var emailAccount = await _emailAccountService.GetEmailAccountById(_emailAccountSettings.DefaultEmailAccountId);
            if (emailAccount == null)
                throw new GrandException("Email account could not be loaded");

            await _emailSender.SendEmail(emailAccount, model.Subject, model.Body, emailAccount.Email, emailAccount.DisplayName, model.Email, null);

            return Ok();
        }
    }
}
