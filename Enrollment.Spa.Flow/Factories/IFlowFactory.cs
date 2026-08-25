using Enrollment.Spa.Flow.Interfaces;
using LogicBuilder.RulesDirector;

namespace Enrollment.Spa.Flow.Factories
{
    public interface IFlowFactory
    {
        DirectorBase GetDirector(IFlowManager flowManager);
        IFlowActivity GetFlowActivity(IFlowManager flowManager);
    }
}
