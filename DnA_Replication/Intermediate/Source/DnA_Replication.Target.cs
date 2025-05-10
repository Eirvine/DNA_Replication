using UnrealBuildTool;

public class DnA_ReplicationTarget : TargetRules
{
	public DnA_ReplicationTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("DnA_Replication");
	}
}
