// Author: Lucas Vilas-Boas
// Year: 2023
// Repo: https://github.com/lucoiso/UEAzSpeechSampleProject

using UnrealBuildTool;
using System.Collections.Generic;

public class PluginsManagementEditorTarget : TargetRules
{
	public PluginsManagementEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;

		ExtraModuleNames.AddRange(new[] { "PluginsManagement" });
	}
}
