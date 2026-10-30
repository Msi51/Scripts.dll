using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public class ObjectTag : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_UNTAGGED;

	private static readonly System.IntPtr NativeFieldInfoPtr_BUSH;

	private static readonly System.IntPtr NativeFieldInfoPtr_GRASS;

	private static readonly System.IntPtr NativeFieldInfoPtr_OBSCURE_TRIGGER;

	private static readonly System.IntPtr NativeFieldInfoPtr_IMPOSTER;

	private static readonly System.IntPtr NativeFieldInfoPtr_NOT_CLIMBABLE;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string UNTAGGED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UNTAGGED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UNTAGGED, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string BUSH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BUSH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BUSH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GRASS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GRASS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GRASS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string OBSCURE_TRIGGER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OBSCURE_TRIGGER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OBSCURE_TRIGGER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string IMPOSTER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IMPOSTER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IMPOSTER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NOT_CLIMBABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NOT_CLIMBABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NOT_CLIMBABLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static ObjectTag()
	{
		Il2CppClassPointerStore<ObjectTag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ObjectTag");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectTag>.NativeClassPtr);
		NativeFieldInfoPtr_UNTAGGED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTag>.NativeClassPtr, "UNTAGGED");
		NativeFieldInfoPtr_BUSH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTag>.NativeClassPtr, "BUSH");
		NativeFieldInfoPtr_GRASS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTag>.NativeClassPtr, "GRASS");
		NativeFieldInfoPtr_OBSCURE_TRIGGER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTag>.NativeClassPtr, "OBSCURE_TRIGGER");
		NativeFieldInfoPtr_IMPOSTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTag>.NativeClassPtr, "IMPOSTER");
		NativeFieldInfoPtr_NOT_CLIMBABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTag>.NativeClassPtr, "NOT_CLIMBABLE");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTag>.NativeClassPtr, 100663386);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1004, XrefRangeEnd = 1005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObjectTag()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectTag>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ObjectTag(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
