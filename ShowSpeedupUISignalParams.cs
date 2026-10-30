using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class ShowSpeedupUISignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_player;

	private static readonly System.IntPtr NativeFieldInfoPtr_preferNormalSpeed;

	public unsafe LocalPlayer player
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LocalPlayer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)localPlayer));
		}
	}

	public unsafe bool preferNormalSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferNormalSpeed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferNormalSpeed)) = flag;
		}
	}

	static ShowSpeedupUISignalParams()
	{
		Il2CppClassPointerStore<ShowSpeedupUISignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowSpeedupUISignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowSpeedupUISignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSpeedupUISignalParams>.NativeClassPtr, "player");
		NativeFieldInfoPtr_preferNormalSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSpeedupUISignalParams>.NativeClassPtr, "preferNormalSpeed");
	}

	public ShowSpeedupUISignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ShowSpeedupUISignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowSpeedupUISignalParams>.NativeClassPtr))
	{
	}
}
