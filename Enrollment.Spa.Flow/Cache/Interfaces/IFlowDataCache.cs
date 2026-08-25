using Enrollment.Spa.Flow.ScreenSettings.Navigation;
using Enrollment.Spa.Flow.ScreenSettings.Views;
using System.Collections.Generic;

namespace Enrollment.Spa.Flow.Cache.Interfaces
{
    public interface IFlowDataCache
    {
        RequestedFlowStage RequestedFlowStage { get; set; }
        NavigationBar NavigationBar { get; set; }
        ScreenSettingsBase? ScreenSettings { get; set; }
        Dictionary<string, object> Items { get; set; }
    }
}
