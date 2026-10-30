using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class DialogDecision : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dialogIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_linkIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_destinationIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string dialogIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int nodeId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeId)) = num;
		}
	}

	public unsafe int linkIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkIndex)) = num;
		}
	}

	public unsafe int destinationIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationIndex)) = num;
		}
	}

	public unsafe int lineIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineIndex)) = num;
		}
	}

	static DialogDecision()
	{
		Il2CppClassPointerStore<DialogDecision>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DialogDecision");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogDecision>.NativeClassPtr);
		NativeFieldInfoPtr_dialogIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogDecision>.NativeClassPtr, "dialogIdentifier");
		NativeFieldInfoPtr_nodeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogDecision>.NativeClassPtr, "nodeId");
		NativeFieldInfoPtr_linkIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogDecision>.NativeClassPtr, "linkIndex");
		NativeFieldInfoPtr_destinationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogDecision>.NativeClassPtr, "destinationIndex");
		NativeFieldInfoPtr_lineIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogDecision>.NativeClassPtr, "lineIndex");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogDecision>.NativeClassPtr, 100669654);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 104046, RefRangeEnd = 104048, XrefRangeStart = 104045, XrefRangeEnd = 104046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DialogDecision()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogDecision>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DialogDecision(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
