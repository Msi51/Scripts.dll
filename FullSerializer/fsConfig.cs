using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace FullSerializer;

public class fsConfig : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("FullSerializer.fsConfig+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__10_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__10_0_Internal_String_String_MemberInfo_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Func<string, MemberInfo, string> __9__10_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<string, MemberInfo, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__10_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<fsConfig>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__10_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100686584);
			NativeMethodInfoPtr___ctor_b__10_0_Internal_String_String_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100686585);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe string __ctor_b__10_0(string name, MemberInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__10_0_Internal_String_String_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_SerializeAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreSerializeAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultMemberSerialization;

	private static readonly System.IntPtr NativeFieldInfoPtr_GetJsonNameFromMemberName;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnablePropertySerialization;

	private static readonly System.IntPtr NativeFieldInfoPtr_SerializeNonAutoProperties;

	private static readonly System.IntPtr NativeFieldInfoPtr_SerializeNonPublicSetProperties;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomDateTimeFormatString;

	private static readonly System.IntPtr NativeFieldInfoPtr_Serialize64BitIntegerAsString;

	private static readonly System.IntPtr NativeFieldInfoPtr_SerializeEnumsAsInteger;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<Il2CppSystem.Type> SerializeAttributes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SerializeAttributes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SerializeAttributes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppSystem.Type> IgnoreSerializeAttributes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IgnoreSerializeAttributes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IgnoreSerializeAttributes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe fsMemberSerialization DefaultMemberSerialization
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultMemberSerialization);
			return *(fsMemberSerialization*)num;
		}
		set
		{
			*(fsMemberSerialization*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultMemberSerialization)) = fsMemberSerialization2;
		}
	}

	public unsafe Il2CppSystem.Func<string, MemberInfo, string> GetJsonNameFromMemberName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GetJsonNameFromMemberName);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<string, MemberInfo, string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GetJsonNameFromMemberName)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
		}
	}

	public unsafe bool EnablePropertySerialization
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnablePropertySerialization);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnablePropertySerialization)) = flag;
		}
	}

	public unsafe bool SerializeNonAutoProperties
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SerializeNonAutoProperties);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SerializeNonAutoProperties)) = flag;
		}
	}

	public unsafe bool SerializeNonPublicSetProperties
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SerializeNonPublicSetProperties);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SerializeNonPublicSetProperties)) = flag;
		}
	}

	public unsafe string CustomDateTimeFormatString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomDateTimeFormatString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomDateTimeFormatString)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool Serialize64BitIntegerAsString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Serialize64BitIntegerAsString);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Serialize64BitIntegerAsString)) = flag;
		}
	}

	public unsafe bool SerializeEnumsAsInteger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SerializeEnumsAsInteger);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SerializeEnumsAsInteger)) = flag;
		}
	}

	static fsConfig()
	{
		Il2CppClassPointerStore<fsConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer", "fsConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<fsConfig>.NativeClassPtr);
		NativeFieldInfoPtr_SerializeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConfig>.NativeClassPtr, "SerializeAttributes");
		NativeFieldInfoPtr_IgnoreSerializeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConfig>.NativeClassPtr, "IgnoreSerializeAttributes");
		NativeFieldInfoPtr_DefaultMemberSerialization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConfig>.NativeClassPtr, "DefaultMemberSerialization");
		NativeFieldInfoPtr_GetJsonNameFromMemberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConfig>.NativeClassPtr, "GetJsonNameFromMemberName");
		NativeFieldInfoPtr_EnablePropertySerialization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConfig>.NativeClassPtr, "EnablePropertySerialization");
		NativeFieldInfoPtr_SerializeNonAutoProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConfig>.NativeClassPtr, "SerializeNonAutoProperties");
		NativeFieldInfoPtr_SerializeNonPublicSetProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConfig>.NativeClassPtr, "SerializeNonPublicSetProperties");
		NativeFieldInfoPtr_CustomDateTimeFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConfig>.NativeClassPtr, "CustomDateTimeFormatString");
		NativeFieldInfoPtr_Serialize64BitIntegerAsString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConfig>.NativeClassPtr, "Serialize64BitIntegerAsString");
		NativeFieldInfoPtr_SerializeEnumsAsInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsConfig>.NativeClassPtr, "SerializeEnumsAsInteger");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsConfig>.NativeClassPtr, 100686582);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 294238, RefRangeEnd = 294239, XrefRangeStart = 294181, XrefRangeEnd = 294238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsConfig()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<fsConfig>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public fsConfig(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
