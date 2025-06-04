using System.ComponentModel;

namespace SysBot.Pokemon;

public class VersionSettings
{
    private const string FeatureToggle = nameof(FeatureToggle);
    private const string Files = nameof(Files);
    public int BuildID = 556;
    public override string ToString() => "Version Settings";

    [Category(FeatureToggle), Description("When enabled, will compare this application's Build ID with the Azure Build ID.")]
    public bool CheckForLatestBuild { get; set; } = true;
}