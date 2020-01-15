// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Test_Prog_DungeonTarget : TargetRules
{
	public Test_Prog_DungeonTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Test_Prog_Dungeon");
	}
}
