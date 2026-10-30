using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class DialogNodeInstance : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_nodeDefinition;

	private static readonly System.IntPtr NativeFieldInfoPtr_links;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DialogNodeDefinition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Lines_Public_get_List_1_DialogLineDefinition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RandomLine_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemRequestPrompt_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LocationHintPrompt_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemRequestPromptType_Public_get_NPCRequestPromptType_0;

	public unsafe DialogNodeDefinition nodeDefinition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeDefinition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DialogNodeDefinition>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeDefinition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogNodeDefinition));
		}
	}

	public unsafe List<DialogLink> links
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_links);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DialogLink>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_links)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int Id
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104391, RefRangeEnd = 104392, XrefRangeStart = 104391, XrefRangeEnd = 104391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe List<DialogLineDefinition> Lines
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 104392, RefRangeEnd = 104406, XrefRangeStart = 104392, XrefRangeEnd = 104392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Lines_Public_get_List_1_DialogLineDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DialogLineDefinition>>(intPtr) : null;
		}
	}

	public unsafe bool RandomLine
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 104406, RefRangeEnd = 104410, XrefRangeStart = 104406, XrefRangeEnd = 104406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RandomLine_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool ItemRequestPrompt
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104410, RefRangeEnd = 104411, XrefRangeStart = 104410, XrefRangeEnd = 104410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ItemRequestPrompt_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool LocationHintPrompt
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104411, RefRangeEnd = 104412, XrefRangeStart = 104411, XrefRangeEnd = 104411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LocationHintPrompt_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe NPCRequestPromptType ItemRequestPromptType
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104412, RefRangeEnd = 104413, XrefRangeStart = 104412, XrefRangeEnd = 104412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ItemRequestPromptType_Public_get_NPCRequestPromptType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(NPCRequestPromptType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static DialogNodeInstance()
	{
		Il2CppClassPointerStore<DialogNodeInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DialogNodeInstance");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogNodeInstance>.NativeClassPtr);
		NativeFieldInfoPtr_nodeDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogNodeInstance>.NativeClassPtr, "nodeDefinition");
		NativeFieldInfoPtr_links = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogNodeInstance>.NativeClassPtr, "links");
		NativeMethodInfoPtr__ctor_Public_Void_DialogNodeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogNodeInstance>.NativeClassPtr, 100669692);
		NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogNodeInstance>.NativeClassPtr, 100669693);
		NativeMethodInfoPtr_get_Lines_Public_get_List_1_DialogLineDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogNodeInstance>.NativeClassPtr, 100669694);
		NativeMethodInfoPtr_get_RandomLine_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogNodeInstance>.NativeClassPtr, 100669695);
		NativeMethodInfoPtr_get_ItemRequestPrompt_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogNodeInstance>.NativeClassPtr, 100669696);
		NativeMethodInfoPtr_get_LocationHintPrompt_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogNodeInstance>.NativeClassPtr, 100669697);
		NativeMethodInfoPtr_get_ItemRequestPromptType_Public_get_NPCRequestPromptType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogNodeInstance>.NativeClassPtr, 100669698);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 104390, RefRangeEnd = 104391, XrefRangeStart = 104380, XrefRangeEnd = 104390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DialogNodeInstance(DialogNodeDefinition definition)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogNodeInstance>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)definition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DialogNodeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DialogNodeInstance(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
