using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[StructLayout(LayoutKind.Explicit)]
public struct InteractionAnimationData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_leftHandState;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightHandState;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	[FieldOffset(0)]
	public AnimationState leftHandState;

	[FieldOffset(4)]
	public AnimationState rightHandState;

	static InteractionAnimationData()
	{
		Il2CppClassPointerStore<InteractionAnimationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InteractionAnimationData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionAnimationData>.NativeClassPtr);
		NativeFieldInfoPtr_leftHandState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAnimationData>.NativeClassPtr, "leftHandState");
		NativeFieldInfoPtr_rightHandState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAnimationData>.NativeClassPtr, "rightHandState");
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionAnimationData>.NativeClassPtr, 100671819);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129231, XrefRangeEnd = 129240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractionAnimationData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
