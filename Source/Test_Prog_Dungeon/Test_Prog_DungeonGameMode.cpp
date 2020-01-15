// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

#include "Test_Prog_DungeonGameMode.h"
#include "Test_Prog_DungeonCharacter.h"
#include "UObject/ConstructorHelpers.h"

ATest_Prog_DungeonGameMode::ATest_Prog_DungeonGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
