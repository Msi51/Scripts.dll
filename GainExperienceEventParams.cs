using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class GainExperienceEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_entity;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillType;

	private static readonly System.IntPtr NativeFieldInfoPtr_rawXpGained;

	public unsafe Entity entity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe SkillType skillType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillType);
			return *(SkillType*)num;
		}
		set
		{
			*(SkillType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillType)) = skillType;
		}
	}

	public unsafe float rawXpGained
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rawXpGained);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rawXpGained)) = num;
		}
	}

	static GainExperienceEventParams()
	{
		Il2CppClassPointerStore<GainExperienceEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "GainExperienceEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainExperienceEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainExperienceEventParams>.NativeClassPtr, "entity");
		NativeFieldInfoPtr_skillType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainExperienceEventParams>.NativeClassPtr, "skillType");
		NativeFieldInfoPtr_rawXpGained = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainExperienceEventParams>.NativeClassPtr, "rawXpGained");
	}

	public GainExperienceEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public GainExperienceEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainExperienceEventParams>.NativeClassPtr))
	{
	}
}
