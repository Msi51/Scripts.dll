using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public class ObjectQuality : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LOW;

	private static readonly System.IntPtr NativeFieldInfoPtr_MEDIUM;

	private static readonly System.IntPtr NativeFieldInfoPtr_HIGH;

	private static readonly System.IntPtr NativeFieldInfoPtr_VERY_HIGH;

	private static readonly System.IntPtr NativeFieldInfoPtr_names;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int LOW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOW, (void*)(&num));
		}
	}

	public unsafe static int MEDIUM
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MEDIUM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MEDIUM, (void*)(&num));
		}
	}

	public unsafe static int HIGH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HIGH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HIGH, (void*)(&num));
		}
	}

	public unsafe static int VERY_HIGH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VERY_HIGH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VERY_HIGH, (void*)(&num));
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

	static ObjectQuality()
	{
		Il2CppClassPointerStore<ObjectQuality>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ObjectQuality");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectQuality>.NativeClassPtr);
		NativeFieldInfoPtr_LOW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectQuality>.NativeClassPtr, "LOW");
		NativeFieldInfoPtr_MEDIUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectQuality>.NativeClassPtr, "MEDIUM");
		NativeFieldInfoPtr_HIGH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectQuality>.NativeClassPtr, "HIGH");
		NativeFieldInfoPtr_VERY_HIGH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectQuality>.NativeClassPtr, "VERY_HIGH");
		NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectQuality>.NativeClassPtr, "names");
		NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectQuality>.NativeClassPtr, 100663642);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectQuality>.NativeClassPtr, 100663643);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20710, RefRangeEnd = 20712, XrefRangeStart = 20693, XrefRangeEnd = 20710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe ObjectQuality()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectQuality>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ObjectQuality(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
