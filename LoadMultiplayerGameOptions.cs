using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public sealed class LoadMultiplayerGameOptions : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_gameName;

	private static readonly System.IntPtr NativeFieldInfoPtr_slotName;

	private static readonly System.IntPtr NativeFieldInfoPtr_multiplayerGameOptions;

	public unsafe string gameName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string slotName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slotName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slotName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe MultiplayerGameOptions multiplayerGameOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplayerGameOptions);
			return new MultiplayerGameOptions(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplayerGameOptions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)multiplayerGameOptions)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static LoadMultiplayerGameOptions()
	{
		Il2CppClassPointerStore<LoadMultiplayerGameOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "LoadMultiplayerGameOptions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadMultiplayerGameOptions>.NativeClassPtr);
		NativeFieldInfoPtr_gameName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMultiplayerGameOptions>.NativeClassPtr, "gameName");
		NativeFieldInfoPtr_slotName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMultiplayerGameOptions>.NativeClassPtr, "slotName");
		NativeFieldInfoPtr_multiplayerGameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMultiplayerGameOptions>.NativeClassPtr, "multiplayerGameOptions");
	}

	public LoadMultiplayerGameOptions(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public LoadMultiplayerGameOptions()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadMultiplayerGameOptions>.NativeClassPtr))
	{
	}
}
