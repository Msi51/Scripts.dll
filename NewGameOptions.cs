using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public sealed class NewGameOptions : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_gameOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_hideHints;

	private static readonly System.IntPtr NativeFieldInfoPtr_skipTutorialTasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_seed;

	public unsafe GameOptions gameOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameOptions);
			return new GameOptions(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameOptions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameOptions)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool hideHints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideHints);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideHints)) = flag;
		}
	}

	public unsafe bool skipTutorialTasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipTutorialTasks);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipTutorialTasks)) = flag;
		}
	}

	public unsafe int seed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed)) = num;
		}
	}

	static NewGameOptions()
	{
		Il2CppClassPointerStore<NewGameOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NewGameOptions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewGameOptions>.NativeClassPtr);
		NativeFieldInfoPtr_gameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameOptions>.NativeClassPtr, "gameOptions");
		NativeFieldInfoPtr_hideHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameOptions>.NativeClassPtr, "hideHints");
		NativeFieldInfoPtr_skipTutorialTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameOptions>.NativeClassPtr, "skipTutorialTasks");
		NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameOptions>.NativeClassPtr, "seed");
	}

	public NewGameOptions(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public NewGameOptions()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewGameOptions>.NativeClassPtr))
	{
	}
}
