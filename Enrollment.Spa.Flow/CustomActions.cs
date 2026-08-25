using Enrollment.Spa.Flow.Cache.Interfaces;
using Enrollment.Spa.Flow.Interfaces;
using Enrollment.Spa.Flow.ScreenSettings.Navigation;

namespace Enrollment.Spa.Flow
{
    public class CustomActions(IFlowDataCache flowDataCache) : ICustomActions
    {
        private readonly IFlowDataCache flowDataCache = flowDataCache;

        public void UpdateNavigationBar(NavigationBar navBar)
        {
            this.flowDataCache.NavigationBar = navBar;
        }
    }
}
