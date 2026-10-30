using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

[System.Serializable]
public sealed class RandomState : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_State;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

	public unsafe Il2CppStructArray<byte> State
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_State);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_State)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static RandomState()
	{
		Il2CppClassPointerStore<RandomState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "RandomState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomState>.NativeClassPtr);
		NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomState>.NativeClassPtr, "State");
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomState>.NativeClassPtr, 100667899);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 24959, RefRangeEnd = 24962, XrefRangeStart = 24959, XrefRangeEnd = 24962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RandomState(Il2CppStructArray<byte> state)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomState>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RandomState(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RandomState()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomState>.NativeClassPtr))
	{
	}
}
