using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

public sealed class DisplayedStat : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_statName;

	private static readonly System.IntPtr NativeFieldInfoPtr_statPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_statCappedPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_statLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_statMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_statColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_statIconType;

	private static readonly System.IntPtr NativeFieldInfoPtr_alertColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_alertAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayWhenEmpty;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayWhenFull;

	private static readonly System.IntPtr NativeFieldInfoPtr_barType;

	private static readonly System.IntPtr NativeFieldInfoPtr_statText;

	private static readonly System.IntPtr NativeFieldInfoPtr_showSecondaryPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondaryPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_showTertiaryPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_tertiaryPercentage;

	public unsafe string statName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float statPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statPercentage)) = num;
		}
	}

	public unsafe float statCappedPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statCappedPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statCappedPercentage)) = num;
		}
	}

	public unsafe float statLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statLevel);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statLevel)) = num;
		}
	}

	public unsafe float statMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statMax)) = num;
		}
	}

	public unsafe Color statColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statColor)) = color;
		}
	}

	public unsafe IconType statIconType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statIconType);
			return *(IconType*)num;
		}
		set
		{
			*(IconType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statIconType)) = iconType;
		}
	}

	public unsafe Color alertColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertColor)) = color;
		}
	}

	public unsafe float alertAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertAmount)) = num;
		}
	}

	public unsafe bool displayWhenEmpty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayWhenEmpty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayWhenEmpty)) = flag;
		}
	}

	public unsafe bool displayWhenFull
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayWhenFull);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayWhenFull)) = flag;
		}
	}

	public unsafe DisplayedStatBarType barType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barType);
			return *(DisplayedStatBarType*)num;
		}
		set
		{
			*(DisplayedStatBarType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barType)) = displayedStatBarType;
		}
	}

	public unsafe string statText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool showSecondaryPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showSecondaryPercentage);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showSecondaryPercentage)) = flag;
		}
	}

	public unsafe float secondaryPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryPercentage)) = num;
		}
	}

	public unsafe bool showTertiaryPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showTertiaryPercentage);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showTertiaryPercentage)) = flag;
		}
	}

	public unsafe float tertiaryPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tertiaryPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tertiaryPercentage)) = num;
		}
	}

	static DisplayedStat()
	{
		Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DisplayedStat");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr);
		NativeFieldInfoPtr_statName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr, "statName");
		NativeFieldInfoPtr_statPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr, "statPercentage");
		NativeFieldInfoPtr_statCappedPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr, "statCappedPercentage");
		NativeFieldInfoPtr_statLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr, "statLevel");
		NativeFieldInfoPtr_statMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr, "statMax");
		NativeFieldInfoPtr_statColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr, "statColor");
		NativeFieldInfoPtr_statIconType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr, "statIconType");
		NativeFieldInfoPtr_alertColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr, "alertColor");
		NativeFieldInfoPtr_alertAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr, "alertAmount");
		NativeFieldInfoPtr_displayWhenEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr, "displayWhenEmpty");
		NativeFieldInfoPtr_displayWhenFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr, "displayWhenFull");
		NativeFieldInfoPtr_barType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr, "barType");
		NativeFieldInfoPtr_statText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr, "statText");
		NativeFieldInfoPtr_showSecondaryPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr, "showSecondaryPercentage");
		NativeFieldInfoPtr_secondaryPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr, "secondaryPercentage");
		NativeFieldInfoPtr_showTertiaryPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr, "showTertiaryPercentage");
		NativeFieldInfoPtr_tertiaryPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr, "tertiaryPercentage");
	}

	public DisplayedStat(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public DisplayedStat()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayedStat>.NativeClassPtr))
	{
	}
}
