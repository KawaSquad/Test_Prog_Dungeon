// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Test_Prog_DungeonEditorTarget : TargetRules
{
	public Test_Prog_DungeonEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Test_Prog_Dungeon");
	}
}
