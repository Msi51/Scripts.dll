using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public class AttackStyle : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ALWAYS_ATTACK;

	private static readonly System.IntPtr NativeFieldInfoPtr_HOLD_MODIFIER;

	private static readonly System.IntPtr NativeFieldInfoPtr_names;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int ALWAYS_ATTACK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ALWAYS_ATTACK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ALWAYS_ATTACK, (void*)(&num));
		}
	}

	public unsafe static int HOLD_MODIFIER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HOLD_MODIFIER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HOLD_MODIFIER, (void*)(&num));
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

	static AttackStyle()
	{
		Il2CppClassPointerStore<AttackStyle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AttackStyle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackStyle>.NativeClassPtr);
		NativeFieldInfoPtr_ALWAYS_ATTACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackStyle>.NativeClassPtr, "ALWAYS_ATTACK");
		NativeFieldInfoPtr_HOLD_MODIFIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackStyle>.NativeClassPtr, "HOLD_MODIFIER");
		NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackStyle>.NativeClassPtr, "names");
		NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackStyle>.NativeClassPtr, 100663563);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackStyle>.NativeClassPtr, 100663564);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 19102, RefRangeEnd = 19104, XrefRangeStart = 19085, XrefRangeEnd = 19102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe AttackStyle()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttackStyle>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AttackStyle(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
