using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public sealed class SkillEffect : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_localizationKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_perLevelAmount;

	public unsafe string localizationKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizationKey);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizationKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float baseAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseAmount)) = num;
		}
	}

	public unsafe float perLevelAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perLevelAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perLevelAmount)) = num;
		}
	}

	static SkillEffect()
	{
		Il2CppClassPointerStore<SkillEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SkillEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkillEffect>.NativeClassPtr);
		NativeFieldInfoPtr_localizationKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffect>.NativeClassPtr, "localizationKey");
		NativeFieldInfoPtr_baseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffect>.NativeClassPtr, "baseAmount");
		NativeFieldInfoPtr_perLevelAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffect>.NativeClassPtr, "perLevelAmount");
	}

	public SkillEffect(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public SkillEffect()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkillEffect>.NativeClassPtr))
	{
	}
}
