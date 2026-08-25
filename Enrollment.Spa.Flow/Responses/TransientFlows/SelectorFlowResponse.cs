using LogicBuilder.Expressions.Utils.ExpressionDescriptors;

namespace Enrollment.Spa.Flow.Responses.TransientFlows
{
    public class SelectorFlowResponse : BaseFlowResponse
    {
        public SelectorLambdaDescriptor? Selector { get; set; }
    }
}
