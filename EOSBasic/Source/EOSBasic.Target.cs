// (C) Gaslight Games Ltd, 2019-2020.  All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class EOSBasicTarget : TargetRules
{
	public EOSBasicTarget(TargetInfo Target) : base(Target)
	{
        DefaultBuildSettings = BuildSettingsVersion.V2;

        Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "EOSBasic" } );
	}
}
