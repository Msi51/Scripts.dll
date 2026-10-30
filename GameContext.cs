using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.context.impl;
using UnityEngine;

public class GameContext : MVCSContext
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MonoBehaviour_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_mapBindings_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Launch_Public_Virtual_Void_0;

	static GameContext()
	{
		Il2CppClassPointerStore<GameContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "GameContext");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameContext>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_MonoBehaviour_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameContext>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_mapBindings_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameContext>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_Launch_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameContext>.NativeClassPtr, 100663389);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2719, XrefRangeEnd = 2723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameContext(MonoBehaviour view, bool autoStartup)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameContext>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)view);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &autoStartup;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_MonoBehaviour_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2723, XrefRangeEnd = 3806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void mapBindings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_mapBindings_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3806, XrefRangeEnd = 3813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Launch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Launch_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameContext(IntPtr pointer)
		: base(pointer)
	{
	}
}
