using UnrealBuildTool;

public class Slime_GameTarget : TargetRules
{
	public Slime_GameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Slime_Game");
	}
}
