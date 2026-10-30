using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

[System.Serializable]
public sealed class AIFlag : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ttlSeconds;

	private static readonly System.IntPtr NativeFieldInfoPtr_stringValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_flagDetails;

	public unsafe float ttlSeconds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ttlSeconds);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ttlSeconds)) = num;
		}
	}

	public unsafe string stringValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stringValue);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stringValue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Il2CppSystem.Object flagDetails
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flagDetails);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flagDetails)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	static AIFlag()
	{
		Il2CppClassPointerStore<AIFlag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AIFlag");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIFlag>.NativeClassPtr);
		NativeFieldInfoPtr_ttlSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFlag>.NativeClassPtr, "ttlSeconds");
		NativeFieldInfoPtr_stringValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFlag>.NativeClassPtr, "stringValue");
		NativeFieldInfoPtr_flagDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIFlag>.NativeClassPtr, "flagDetails");
	}

	public AIFlag(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public AIFlag()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIFlag>.NativeClassPtr))
	{
	}
}
