using Enrollment.Spa.Flow.ScreenSettings.Views;
using LogicBuilder.Expressions.Utils.Json;

namespace Enrollment.Spa.Flow.ScreenSettings.Json
{
    public class ScreenSettingsConverter : JsonTypeConverter<ScreenSettingsBase>
    {
        public override string TypePropertyName => nameof(ScreenSettingsBase.TypeString);
    }
}
