using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public sealed class PlayerActivityEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_playerName;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	public unsafe string playerName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe PlayerActivityType type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(PlayerActivityType*)num;
		}
		set
		{
			*(PlayerActivityType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = playerActivityType;
		}
	}

	static PlayerActivityEventParams()
	{
		Il2CppClassPointerStore<PlayerActivityEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PlayerActivityEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerActivityEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_playerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActivityEventParams>.NativeClassPtr, "playerName");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActivityEventParams>.NativeClassPtr, "type");
	}

	public PlayerActivityEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PlayerActivityEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerActivityEventParams>.NativeClassPtr))
	{
	}
}
