using System;

[Serializable]
[Flags]
public enum CellCulling
{
	NOTHING_VISIBLE = 0,
	SHORT_ENTITIES_VISIBLE = 2,
	TALL_ENTITIES_VISIBLE = 4,
	DETAILS_VISIBLE = 8,
	TERRAIN_VISIBLE = 0x10
}
