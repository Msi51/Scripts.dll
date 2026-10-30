using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using strange.extensions.injector.api;

public class Implements : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Name_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__DefaultInterface_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Scope_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_InjectionBindingScope_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_InjectionBindingScope_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_InjectionBindingScope_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_InjectionBindingScope_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_get_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultInterface_Public_get_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DefaultInterface_Public_set_Void_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Scope_Public_get_InjectionBindingScope_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Scope_Public_set_Void_InjectionBindingScope_0;

	public unsafe Il2CppSystem.Object _Name_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Name_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Name_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe Il2CppSystem.Type _DefaultInterface_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DefaultInterface_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DefaultInterface_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
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

	public unsafe Il2CppSystem.Object Name
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 3866, RefRangeEnd = 3876, XrefRangeStart = 3866, XrefRangeEnd = 3876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Name_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29379, RefRangeEnd = 29381, XrefRangeStart = 29379, XrefRangeEnd = 29381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Name_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Il2CppSystem.Type DefaultInterface
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 28728, RefRangeEnd = 28739, XrefRangeStart = 28728, XrefRangeEnd = 28739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultInterface_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DefaultInterface_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe InjectionBindingScope Scope
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32451, RefRangeEnd = 32452, XrefRangeStart = 32451, XrefRangeEnd = 32452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Scope_Public_get_InjectionBindingScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(InjectionBindingScope*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
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

	static Implements()
	{
		Il2CppClassPointerStore<Implements>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "Implements");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Implements>.NativeClassPtr);
		NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Implements>.NativeClassPtr, "<Name>k__BackingField");
		NativeFieldInfoPtr__DefaultInterface_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Implements>.NativeClassPtr, "<DefaultInterface>k__BackingField");
		NativeFieldInfoPtr__Scope_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Implements>.NativeClassPtr, "<Scope>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Implements>.NativeClassPtr, 100684072);
		NativeMethodInfoPtr__ctor_Public_Void_InjectionBindingScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Implements>.NativeClassPtr, 100684073);
		NativeMethodInfoPtr__ctor_Public_Void_Type_InjectionBindingScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Implements>.NativeClassPtr, 100684074);
		NativeMethodInfoPtr__ctor_Public_Void_InjectionBindingScope_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Implements>.NativeClassPtr, 100684075);
		NativeMethodInfoPtr__ctor_Public_Void_Type_InjectionBindingScope_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Implements>.NativeClassPtr, 100684076);
		NativeMethodInfoPtr_get_Name_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Implements>.NativeClassPtr, 100684077);
		NativeMethodInfoPtr_set_Name_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Implements>.NativeClassPtr, 100684078);
		NativeMethodInfoPtr_get_DefaultInterface_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Implements>.NativeClassPtr, 100684079);
		NativeMethodInfoPtr_set_DefaultInterface_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Implements>.NativeClassPtr, 100684080);
		NativeMethodInfoPtr_get_Scope_Public_get_InjectionBindingScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Implements>.NativeClassPtr, 100684081);
		NativeMethodInfoPtr_set_Scope_Public_set_Void_InjectionBindingScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Implements>.NativeClassPtr, 100684082);
	}

	[CallerCount(283)]
	[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 284, XrefRangeStart = 1, XrefRangeEnd = 284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Implements()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Implements>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276353, XrefRangeEnd = 276354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Implements(InjectionBindingScope scope)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Implements>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&scope);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_InjectionBindingScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276354, XrefRangeEnd = 276356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Implements(Il2CppSystem.Type t, InjectionBindingScope scope = InjectionBindingScope.SINGLE_CONTEXT)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Implements>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(InjectionBindingScope**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scope;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_InjectionBindingScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276356, XrefRangeEnd = 276358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Implements(InjectionBindingScope scope, Il2CppSystem.Object name)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Implements>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&scope);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_InjectionBindingScope_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276358, XrefRangeEnd = 276361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Implements(Il2CppSystem.Type t, InjectionBindingScope scope, Il2CppSystem.Object name)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Implements>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(InjectionBindingScope**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scope;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_InjectionBindingScope_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Implements(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
