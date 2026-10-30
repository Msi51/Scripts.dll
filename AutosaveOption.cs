using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class AutosaveOption : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_OFF;

	private static readonly System.IntPtr NativeFieldInfoPtr_ONE_MINUTE;

	private static readonly System.IntPtr NativeFieldInfoPtr_TWO_MINUTES;

	private static readonly System.IntPtr NativeFieldInfoPtr_FIVE_MINUTES;

	private static readonly System.IntPtr NativeFieldInfoPtr_TEN_MINUTES;

	private static readonly System.IntPtr NativeFieldInfoPtr_THIRTY_MINUTES;

	private static readonly System.IntPtr NativeFieldInfoPtr_values;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValues_Public_Static_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int OFF
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OFF, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OFF, (void*)(&num));
		}
	}

	public unsafe static int ONE_MINUTE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ONE_MINUTE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ONE_MINUTE, (void*)(&num));
		}
	}

	public unsafe static int TWO_MINUTES
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TWO_MINUTES, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TWO_MINUTES, (void*)(&num));
		}
	}

	public unsafe static int FIVE_MINUTES
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FIVE_MINUTES, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FIVE_MINUTES, (void*)(&num));
		}
	}

	public unsafe static int TEN_MINUTES
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEN_MINUTES, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEN_MINUTES, (void*)(&num));
		}
	}

	public unsafe static int THIRTY_MINUTES
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_THIRTY_MINUTES, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_THIRTY_MINUTES, (void*)(&num));
		}
	}

	public unsafe static List<Il2CppSystem.ValueTuple<int, string>> values
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_values, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<int, string>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_values, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static AutosaveOption()
	{
		Il2CppClassPointerStore<AutosaveOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AutosaveOption");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutosaveOption>.NativeClassPtr);
		NativeFieldInfoPtr_OFF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutosaveOption>.NativeClassPtr, "OFF");
		NativeFieldInfoPtr_ONE_MINUTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutosaveOption>.NativeClassPtr, "ONE_MINUTE");
		NativeFieldInfoPtr_TWO_MINUTES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutosaveOption>.NativeClassPtr, "TWO_MINUTES");
		NativeFieldInfoPtr_FIVE_MINUTES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutosaveOption>.NativeClassPtr, "FIVE_MINUTES");
		NativeFieldInfoPtr_TEN_MINUTES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutosaveOption>.NativeClassPtr, "TEN_MINUTES");
		NativeFieldInfoPtr_THIRTY_MINUTES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutosaveOption>.NativeClassPtr, "THIRTY_MINUTES");
		NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutosaveOption>.NativeClassPtr, "values");
		NativeMethodInfoPtr_GetValues_Public_Static_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutosaveOption>.NativeClassPtr, 100663566);
		NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutosaveOption>.NativeClassPtr, 100663567);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutosaveOption>.NativeClassPtr, 100663568);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 19121, RefRangeEnd = 19123, XrefRangeStart = 19104, XrefRangeEnd = 19121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> GetValues()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValues_Public_Static_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 19146, RefRangeEnd = 19148, XrefRangeStart = 19123, XrefRangeEnd = 19146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe AutosaveOption()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutosaveOption>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AutosaveOption(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
