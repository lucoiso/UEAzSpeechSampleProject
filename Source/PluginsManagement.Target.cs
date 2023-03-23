// Author: Lucas Vilas-Boas
// Year: 2023
// Repo: https://github.com/lucoiso/UEAzSpeechSampleProject

using UnrealBuildTool;
using System.Collections.Generic;

public class PluginsManagementTarget : TargetRules
{
	public PluginsManagementTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;

		ExtraModuleNames.AddRange(new[] { "PluginsManagement" });
	}
}
