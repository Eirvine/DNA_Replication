using UnrealBuildTool;

public class DnA_ReplicationServerTarget : TargetRules
{
	public DnA_ReplicationServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("DnA_Replication");
	}
}
