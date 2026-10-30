using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Netcode;

[System.Serializable]
public sealed class GameOptions : Il2CppSystem.ValueType
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<GameOptions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_difficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_realism;

	private static readonly System.IntPtr NativeFieldInfoPtr_startSeason;

	private static readonly System.IntPtr NativeFieldInfoPtr_seasonProgression;

	private static readonly System.IntPtr NativeFieldInfoPtr_advancedGameOptions;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	public unsafe GameDifficulty difficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficulty);
			return *(GameDifficulty*)num;
		}
		set
		{
			*(GameDifficulty*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficulty)) = gameDifficulty;
		}
	}

	public unsafe GameRealism realism
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realism);
			return *(GameRealism*)num;
		}
		set
		{
			*(GameRealism*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realism)) = gameRealism;
		}
	}

	public unsafe StartSeason startSeason
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startSeason);
			return *(StartSeason*)num;
		}
		set
		{
			*(StartSeason*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startSeason)) = startSeason;
		}
	}

	public unsafe SeasonProgression seasonProgression
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seasonProgression);
			return *(SeasonProgression*)num;
		}
		set
		{
			*(SeasonProgression*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seasonProgression)) = seasonProgression;
		}
	}

	public unsafe AdvancedGameOptions advancedGameOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advancedGameOptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdvancedGameOptions>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advancedGameOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)advancedGameOptions));
		}
	}

	static GameOptions()
	{
		Il2CppClassPointerStore<GameOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "GameOptions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameOptions>.NativeClassPtr);
		NativeFieldInfoPtr_difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, "difficulty");
		NativeFieldInfoPtr_realism = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, "realism");
		NativeFieldInfoPtr_startSeason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, "startSeason");
		NativeFieldInfoPtr_seasonProgression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, "seasonProgression");
		NativeFieldInfoPtr_advancedGameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, "advancedGameOptions");
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, 100663547);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18741, XrefRangeEnd = 18745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameOptions(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public GameOptions()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameOptions>.NativeClassPtr))
	{
	}
}
