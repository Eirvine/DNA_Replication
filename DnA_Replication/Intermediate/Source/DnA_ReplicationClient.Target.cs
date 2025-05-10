using UnrealBuildTool;

public class DnA_ReplicationClientTarget : TargetRules
{
	public DnA_ReplicationClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("DnA_Replication");
	}
}
