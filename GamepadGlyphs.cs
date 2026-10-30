using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public class GamepadGlyphs : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_AUTO;

	private static readonly System.IntPtr NativeFieldInfoPtr_XBOX;

	private static readonly System.IntPtr NativeFieldInfoPtr_PS;

	private static readonly System.IntPtr NativeFieldInfoPtr_STEAM_DECK;

	private static readonly System.IntPtr NativeFieldInfoPtr_names;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int AUTO
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AUTO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AUTO, (void*)(&num));
		}
	}

	public unsafe static int XBOX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_XBOX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_XBOX, (void*)(&num));
		}
	}

	public unsafe static int PS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PS, (void*)(&num));
		}
	}

	public unsafe static int STEAM_DECK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STEAM_DECK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STEAM_DECK, (void*)(&num));
		}
	}

	public unsafe static Il2CppStringArray names
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_names, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_names, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static GamepadGlyphs()
	{
		Il2CppClassPointerStore<GamepadGlyphs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "GamepadGlyphs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadGlyphs>.NativeClassPtr);
		NativeFieldInfoPtr_AUTO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadGlyphs>.NativeClassPtr, "AUTO");
		NativeFieldInfoPtr_XBOX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadGlyphs>.NativeClassPtr, "XBOX");
		NativeFieldInfoPtr_PS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadGlyphs>.NativeClassPtr, "PS");
		NativeFieldInfoPtr_STEAM_DECK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadGlyphs>.NativeClassPtr, "STEAM_DECK");
		NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadGlyphs>.NativeClassPtr, "names");
		NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadGlyphs>.NativeClassPtr, 100663621);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadGlyphs>.NativeClassPtr, 100663622);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20200, RefRangeEnd = 20202, XrefRangeStart = 20183, XrefRangeEnd = 20200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetNames()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GamepadGlyphs()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadGlyphs>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GamepadGlyphs(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
