using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class InteractionResult : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_possible;

	private static readonly System.IntPtr NativeFieldInfoPtr_duplicate;

	private static readonly System.IntPtr NativeFieldInfoPtr_started;

	private static readonly System.IntPtr NativeFieldInfoPtr_withinRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_interaction;

	public unsafe bool possible
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possible);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possible)) = flag;
		}
	}

	public unsafe bool duplicate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duplicate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duplicate)) = flag;
		}
	}

	public unsafe bool started
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_started);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_started)) = flag;
		}
	}

	public unsafe bool withinRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_withinRange);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_withinRange)) = flag;
		}
	}

	public unsafe IInteraction interaction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interaction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteraction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interaction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interaction));
		}
	}

	static InteractionResult()
	{
		Il2CppClassPointerStore<InteractionResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InteractionResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionResult>.NativeClassPtr);
		NativeFieldInfoPtr_possible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionResult>.NativeClassPtr, "possible");
		NativeFieldInfoPtr_duplicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionResult>.NativeClassPtr, "duplicate");
		NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionResult>.NativeClassPtr, "started");
		NativeFieldInfoPtr_withinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionResult>.NativeClassPtr, "withinRange");
		NativeFieldInfoPtr_interaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionResult>.NativeClassPtr, "interaction");
	}

	public InteractionResult(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public InteractionResult()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionResult>.NativeClassPtr))
	{
	}
}
