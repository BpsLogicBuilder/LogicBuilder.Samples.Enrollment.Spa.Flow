using Enrollment.Spa.Flow.Interfaces;
using Enrollment.Spa.Flow.ScreenSettings.Navigation;
using LogicBuilder.Attributes;

namespace Enrollment.Spa.Flow
{
    public static class CustomActionUtilities
    {
        [AlsoKnownAs("SetupNavigationMenu")]
        public static void UpdateNavigationBar(ICustomActions customActions, NavigationBar navBar)
        {
            customActions.UpdateNavigationBar(navBar);
        }
    }
}
