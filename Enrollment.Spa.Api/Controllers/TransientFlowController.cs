using LogicBuilder.App.Spa.Business.Requests.TransientFlows;
using LogicBuilder.App.Spa.Utils.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Enrollment.Spa.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransientFlowController(ITransientFlowHelper transientFlowHelper) : ControllerBase
    {
        private readonly ITransientFlowHelper _transientFlowHelper = transientFlowHelper;

        [HttpPost("RunSelectorFlow")]
        public IActionResult RunSelectorFlow([FromBody] SelectorFlowRequest selectorFlowRequest)
        {
            return Ok(_transientFlowHelper.RunSelectorFlow(selectorFlowRequest));
        }
    }
}
