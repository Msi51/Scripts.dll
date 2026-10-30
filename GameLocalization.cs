using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class GameLocalization : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_LANGUAGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportedLanguages;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportedLanguageNames;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string DEFAULT_LANGUAGE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_LANGUAGE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_LANGUAGE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static List<string> supportedLanguages
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_supportedLanguages, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_supportedLanguages, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> supportedLanguageNames
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_supportedLanguageNames, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_supportedLanguageNames, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static GameLocalization()
	{
		Il2CppClassPointerStore<GameLocalization>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "GameLocalization");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLocalization>.NativeClassPtr);
		NativeFieldInfoPtr_DEFAULT_LANGUAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLocalization>.NativeClassPtr, "DEFAULT_LANGUAGE");
		NativeFieldInfoPtr_supportedLanguages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLocalization>.NativeClassPtr, "supportedLanguages");
		NativeFieldInfoPtr_supportedLanguageNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLocalization>.NativeClassPtr, "supportedLanguageNames");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLocalization>.NativeClassPtr, 100663706);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameLocalization()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLocalization>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameLocalization(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
