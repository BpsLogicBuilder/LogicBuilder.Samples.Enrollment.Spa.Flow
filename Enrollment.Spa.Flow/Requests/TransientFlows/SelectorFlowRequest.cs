using LogicBuilder.Domain;

namespace Enrollment.Spa.Flow.Requests.TransientFlows
{
    public class SelectorFlowRequest
    {
        public BaseModel? Entity { get; set; }
        public string? ReloadItemsFlowName { get; set; }
    }
}
