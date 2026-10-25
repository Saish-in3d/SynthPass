// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class GPUCompositionGraphicsPipeline : ModuleRules
{
	public GPUCompositionGraphicsPipeline(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"RenderCore",
			"Renderer",
			"RHI",
			"Projects",
			"MediaAssets",
		});
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		string EngineDir = Path.GetFullPath(Target.RelativeEnginePath);

		// Public because CommonStructs.h includes SceneTextureParameters.h, so dependent modules need these paths too
		PublicIncludePaths.AddRange(
			new string[] {
				// Including to Find shader utilities path
				Path.Combine(EngineDir, "Source/Runtime/Renderer/Private"),
				Path.Combine(EngineDir, "Source/Runtime/Renderer/Internal")
			}
		);
	}
}
