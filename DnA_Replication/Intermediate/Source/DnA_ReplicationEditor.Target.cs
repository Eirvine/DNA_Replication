using UnrealBuildTool;

public class DnA_ReplicationEditorTarget : TargetRules
{
	public DnA_ReplicationEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("DnA_Replication");
	}
}
