using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class FindConsumableInteractionResult : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_interactionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionTarget;

	public unsafe InteractionType interactionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionType);
			return *(InteractionType*)num;
		}
		set
		{
			*(InteractionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionType)) = interactionType;
		}
	}

	public unsafe Entity interactionTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	static FindConsumableInteractionResult()
	{
		Il2CppClassPointerStore<FindConsumableInteractionResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "FindConsumableInteractionResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FindConsumableInteractionResult>.NativeClassPtr);
		NativeFieldInfoPtr_interactionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindConsumableInteractionResult>.NativeClassPtr, "interactionType");
		NativeFieldInfoPtr_interactionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindConsumableInteractionResult>.NativeClassPtr, "interactionTarget");
	}

	public FindConsumableInteractionResult(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public FindConsumableInteractionResult()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FindConsumableInteractionResult>.NativeClassPtr))
	{
	}
}
