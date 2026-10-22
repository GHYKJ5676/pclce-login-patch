using PCL.Core.App.Region;
using PCL.Core.App.Localization;
using PCL.Core.UI;

namespace PCL;

internal static class RestrictedFeaturePolicy
{
    internal static RegionAssessment Assess() => new(RegionClassification.Other, "patched");

    internal static bool IsRestricted => false;

    internal static bool Check(string feature, bool showHint = true)
    {
        // 已修改：始终允许所有功能
        return true;
    }

    internal static void ThrowIfRestricted(string feature)
    {
        // 已修改：永不抛出限制异常
    }
}