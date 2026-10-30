using System;
using System.Runtime.CompilerServices;
using FullSerializer.Internal;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace FullSerializer;

public class fsAotCompilationManager : Il2CppSystem.Object
{
	public sealed class AotCompilation : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Type;

		private static readonly System.IntPtr NativeFieldInfoPtr_Members;

		private static readonly System.IntPtr NativeFieldInfoPtr_IsConstructorPublic;

		public unsafe Il2CppSystem.Type Type
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
			}
		}

		public unsafe Il2CppReferenceArray<fsMetaProperty> Members
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Members);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<fsMetaProperty>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Members)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe bool IsConstructorPublic
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsConstructorPublic);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsConstructorPublic)) = flag;
			}
		}

		static AotCompilation()
		{
			Il2CppClassPointerStore<AotCompilation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<fsAotCompilationManager>.NativeClassPtr, "AotCompilation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AotCompilation>.NativeClassPtr);
			NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AotCompilation>.NativeClassPtr, "Type");
			NativeFieldInfoPtr_Members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AotCompilation>.NativeClassPtr, "Members");
			NativeFieldInfoPtr_IsConstructorPublic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AotCompilation>.NativeClassPtr, "IsConstructorPublic");
		}

		public AotCompilation(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public AotCompilation()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AotCompilation>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__computedAotCompilations;

	private static readonly System.IntPtr NativeFieldInfoPtr__uncomputedAotCompilations;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AvailableAotCompilations_Public_Static_get_Dictionary_2_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToPerformAotCompilation_Public_Static_Boolean_fsConfig_Type_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAotCompilation_Public_Static_Void_Type_Il2CppReferenceArray_1_fsMetaProperty_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConverterString_Private_Static_String_fsMetaProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateDirectConverterForTypeInCSharp_Private_Static_String_Type_Il2CppReferenceArray_1_fsMetaProperty_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Dictionary<Il2CppSystem.Type, string> _computedAotCompilations
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__computedAotCompilations, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__computedAotCompilations, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static List<AotCompilation> _uncomputedAotCompilations
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__uncomputedAotCompilations, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AotCompilation>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__uncomputedAotCompilations, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static Dictionary<Il2CppSystem.Type, string> AvailableAotCompilations
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293674, XrefRangeEnd = 293695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AvailableAotCompilations_Public_Static_get_Dictionary_2_Type_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, string>>(intPtr) : null;
		}
	}

	static fsAotCompilationManager()
	{
		Il2CppClassPointerStore<fsAotCompilationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer", "fsAotCompilationManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<fsAotCompilationManager>.NativeClassPtr);
		NativeFieldInfoPtr__computedAotCompilations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsAotCompilationManager>.NativeClassPtr, "_computedAotCompilations");
		NativeFieldInfoPtr__uncomputedAotCompilations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsAotCompilationManager>.NativeClassPtr, "_uncomputedAotCompilations");
		NativeMethodInfoPtr_get_AvailableAotCompilations_Public_Static_get_Dictionary_2_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsAotCompilationManager>.NativeClassPtr, 100686559);
		NativeMethodInfoPtr_TryToPerformAotCompilation_Public_Static_Boolean_fsConfig_Type_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsAotCompilationManager>.NativeClassPtr, 100686560);
		NativeMethodInfoPtr_AddAotCompilation_Public_Static_Void_Type_Il2CppReferenceArray_1_fsMetaProperty_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsAotCompilationManager>.NativeClassPtr, 100686561);
		NativeMethodInfoPtr_GetConverterString_Private_Static_String_fsMetaProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsAotCompilationManager>.NativeClassPtr, 100686562);
		NativeMethodInfoPtr_GenerateDirectConverterForTypeInCSharp_Private_Static_String_Type_Il2CppReferenceArray_1_fsMetaProperty_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsAotCompilationManager>.NativeClassPtr, 100686563);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsAotCompilationManager>.NativeClassPtr, 100686564);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293695, XrefRangeEnd = 293703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryToPerformAotCompilation(fsConfig config, Il2CppSystem.Type type, out string aotCompiledClassInCSharp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)config);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToPerformAotCompilation_Public_Static_Boolean_fsConfig_Type_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		aotCompiledClassInCSharp = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293703, XrefRangeEnd = 293711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddAotCompilation(Il2CppSystem.Type type, Il2CppReferenceArray<fsMetaProperty> members, bool isConstructorPublic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)members);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isConstructorPublic;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAotCompilation_Public_Static_Void_Type_Il2CppReferenceArray_1_fsMetaProperty_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293711, XrefRangeEnd = 293721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetConverterString(fsMetaProperty member)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)member);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConverterString_Private_Static_String_fsMetaProperty_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 293987, RefRangeEnd = 293988, XrefRangeStart = 293721, XrefRangeEnd = 293987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GenerateDirectConverterForTypeInCSharp(Il2CppSystem.Type type, Il2CppReferenceArray<fsMetaProperty> members, bool isConstructorPublic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)members);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isConstructorPublic;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateDirectConverterForTypeInCSharp_Private_Static_String_Type_Il2CppReferenceArray_1_fsMetaProperty_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsAotCompilationManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<fsAotCompilationManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public fsAotCompilationManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
