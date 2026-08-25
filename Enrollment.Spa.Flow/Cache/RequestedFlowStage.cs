using LogicBuilder.Attributes;

namespace Enrollment.Spa.Flow.Cache
{
    public class RequestedFlowStage
    {
        [AlsoKnownAs("RequestedFlowStage.InitialModule")]
        public string InitialModule { get; set; } = "";
        [AlsoKnownAs("RequestedFlowStage.TargetModule")]
        public int TargetModule { get; set; }
    }
}
