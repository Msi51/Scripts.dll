using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public class AIIntentFlags : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_NEED_WOOD_FOR_FIRE;

	private static readonly System.IntPtr NativeFieldInfoPtr_NEED_TINDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_NEED_KINDLING;

	private static readonly System.IntPtr NativeFieldInfoPtr_NEED_IGNITION_SOURCE;

	private static readonly System.IntPtr NativeFieldInfoPtr_NEED_WATER_FOR_FIRE;

	private static readonly System.IntPtr NativeFieldInfoPtr_NEED_ITEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_CRAFTING_RECIPE_TARGET;

	private static readonly System.IntPtr NativeFieldInfoPtr_BUILD_BLUEPRINT_TARGET;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string NEED_WOOD_FOR_FIRE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NEED_WOOD_FOR_FIRE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NEED_WOOD_FOR_FIRE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NEED_TINDER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NEED_TINDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NEED_TINDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NEED_KINDLING
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NEED_KINDLING, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NEED_KINDLING, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NEED_IGNITION_SOURCE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NEED_IGNITION_SOURCE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NEED_IGNITION_SOURCE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NEED_WATER_FOR_FIRE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NEED_WATER_FOR_FIRE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NEED_WATER_FOR_FIRE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NEED_ITEM
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NEED_ITEM, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NEED_ITEM, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CRAFTING_RECIPE_TARGET
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CRAFTING_RECIPE_TARGET, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CRAFTING_RECIPE_TARGET, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string BUILD_BLUEPRINT_TARGET
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BUILD_BLUEPRINT_TARGET, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BUILD_BLUEPRINT_TARGET, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static AIIntentFlags()
	{
		Il2CppClassPointerStore<AIIntentFlags>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AIIntentFlags");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIIntentFlags>.NativeClassPtr);
		NativeFieldInfoPtr_NEED_WOOD_FOR_FIRE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIIntentFlags>.NativeClassPtr, "NEED_WOOD_FOR_FIRE");
		NativeFieldInfoPtr_NEED_TINDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIIntentFlags>.NativeClassPtr, "NEED_TINDER");
		NativeFieldInfoPtr_NEED_KINDLING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIIntentFlags>.NativeClassPtr, "NEED_KINDLING");
		NativeFieldInfoPtr_NEED_IGNITION_SOURCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIIntentFlags>.NativeClassPtr, "NEED_IGNITION_SOURCE");
		NativeFieldInfoPtr_NEED_WATER_FOR_FIRE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIIntentFlags>.NativeClassPtr, "NEED_WATER_FOR_FIRE");
		NativeFieldInfoPtr_NEED_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIIntentFlags>.NativeClassPtr, "NEED_ITEM");
		NativeFieldInfoPtr_CRAFTING_RECIPE_TARGET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIIntentFlags>.NativeClassPtr, "CRAFTING_RECIPE_TARGET");
		NativeFieldInfoPtr_BUILD_BLUEPRINT_TARGET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIIntentFlags>.NativeClassPtr, "BUILD_BLUEPRINT_TARGET");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIIntentFlags>.NativeClassPtr, 100668420);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AIIntentFlags()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIIntentFlags>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AIIntentFlags(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
