using UnrealBuildTool;

public class TFGTarget : TargetRules
{
	public TFGTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TFG");
	}
}
