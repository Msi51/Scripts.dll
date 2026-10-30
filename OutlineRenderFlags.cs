using System;

[Flags]
public enum OutlineRenderFlags
{
	None = 0,
	Blurred = 1,
	EnableDepthTesting = 2,
	EnableAlphaTesting = 4
}
