using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public class HealingState : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_interactInjury;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeInjuryInteraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeInjuryInteractionType;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ActiveInjury interactInjury
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactInjury);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActiveInjury>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactInjury)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury));
		}
	}

	public unsafe IInteraction activeInjuryInteraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeInjuryInteraction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteraction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeInjuryInteraction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interaction));
		}
	}

	public unsafe InteractionType activeInjuryInteractionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeInjuryInteractionType);
			return *(InteractionType*)num;
		}
		set
		{
			*(InteractionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeInjuryInteractionType)) = interactionType;
		}
	}

	static HealingState()
	{
		Il2CppClassPointerStore<HealingState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "HealingState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HealingState>.NativeClassPtr);
		NativeFieldInfoPtr_interactInjury = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealingState>.NativeClassPtr, "interactInjury");
		NativeFieldInfoPtr_activeInjuryInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealingState>.NativeClassPtr, "activeInjuryInteraction");
		NativeFieldInfoPtr_activeInjuryInteractionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealingState>.NativeClassPtr, "activeInjuryInteractionType");
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealingState>.NativeClassPtr, 100670432);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealingState>.NativeClassPtr, 100670433);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 121060, RefRangeEnd = 121062, XrefRangeStart = 121058, XrefRangeEnd = 121060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HealingState()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HealingState>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HealingState(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
