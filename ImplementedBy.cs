using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using strange.extensions.injector.api;

public class ImplementedBy : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__DefaultType_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Scope_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_InjectionBindingScope_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultType_Public_get_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DefaultType_Public_set_Void_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Scope_Public_get_InjectionBindingScope_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Scope_Public_set_Void_InjectionBindingScope_0;

	public unsafe Il2CppSystem.Type _DefaultType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DefaultType_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DefaultType_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
		}
	}

	public unsafe InjectionBindingScope _Scope_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Scope_k__BackingField);
			return *(InjectionBindingScope*)num;
		}
		set
		{
			*(InjectionBindingScope*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Scope_k__BackingField)) = injectionBindingScope;
		}
	}

	public unsafe Il2CppSystem.Type DefaultType
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 3866, RefRangeEnd = 3876, XrefRangeStart = 3866, XrefRangeEnd = 3876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29379, RefRangeEnd = 29381, XrefRangeStart = 29379, XrefRangeEnd = 29381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DefaultType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe InjectionBindingScope Scope
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Scope_Public_get_InjectionBindingScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(InjectionBindingScope*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276368, RefRangeEnd = 276370, XrefRangeStart = 276368, XrefRangeEnd = 276368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Scope_Public_set_Void_InjectionBindingScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static ImplementedBy()
	{
		Il2CppClassPointerStore<ImplementedBy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ImplementedBy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImplementedBy>.NativeClassPtr);
		NativeFieldInfoPtr__DefaultType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImplementedBy>.NativeClassPtr, "<DefaultType>k__BackingField");
		NativeFieldInfoPtr__Scope_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImplementedBy>.NativeClassPtr, "<Scope>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_Type_InjectionBindingScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImplementedBy>.NativeClassPtr, 100684083);
		NativeMethodInfoPtr_get_DefaultType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImplementedBy>.NativeClassPtr, 100684084);
		NativeMethodInfoPtr_set_DefaultType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImplementedBy>.NativeClassPtr, 100684085);
		NativeMethodInfoPtr_get_Scope_Public_get_InjectionBindingScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImplementedBy>.NativeClassPtr, 100684086);
		NativeMethodInfoPtr_set_Scope_Public_set_Void_InjectionBindingScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImplementedBy>.NativeClassPtr, 100684087);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 276363, RefRangeEnd = 276368, XrefRangeStart = 276361, XrefRangeEnd = 276363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ImplementedBy(Il2CppSystem.Type t, InjectionBindingScope scope = InjectionBindingScope.SINGLE_CONTEXT)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImplementedBy>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(InjectionBindingScope**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scope;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_InjectionBindingScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ImplementedBy(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
