using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace FullSerializer;

public sealed class fsForwardAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MemberName;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	public unsafe string MemberName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MemberName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MemberName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static fsForwardAttribute()
	{
		Il2CppClassPointerStore<fsForwardAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer", "fsForwardAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<fsForwardAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_MemberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsForwardAttribute>.NativeClassPtr, "MemberName");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsForwardAttribute>.NativeClassPtr, 100686556);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 276372, RefRangeEnd = 276389, XrefRangeStart = 276372, XrefRangeEnd = 276389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsForwardAttribute(string memberName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<fsForwardAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(memberName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public fsForwardAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
