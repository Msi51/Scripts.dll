using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

public class IDialogManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDialogDefinition_Public_Abstract_Virtual_New_DialogDefinition_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetNPCRequestDefinition_Public_Abstract_Virtual_New_NPCRequestDefinition_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDialogLocationTypeDefinition_Public_Abstract_Virtual_New_DialogLocationTypeDefinition_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetNodeInstance_Public_Abstract_Virtual_New_DialogNodeInstance_DialogDefinition_Int32_List_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_StartDialog_Public_Abstract_Virtual_New_Boolean_Entity_Entity_byref_DialogDefinition_byref_DialogNodeInstance_0;

	private static readonly IntPtr NativeMethodInfoPtr_EvaluateLink_Public_Abstract_Virtual_New_Void_Entity_Entity_DialogLink_byref_Int32_List_1_Int32_byref_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetNodeLineDecision_Public_Abstract_Virtual_New_Int32_IDialogConverser_DialogNodeDefinition_Boolean_0;

	static IDialogManager()
	{
		Il2CppClassPointerStore<IDialogManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IDialogManager");
		NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDialogManager>.NativeClassPtr, 100675351);
		NativeMethodInfoPtr_GetDialogDefinition_Public_Abstract_Virtual_New_DialogDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDialogManager>.NativeClassPtr, 100675352);
		NativeMethodInfoPtr_GetNPCRequestDefinition_Public_Abstract_Virtual_New_NPCRequestDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDialogManager>.NativeClassPtr, 100675353);
		NativeMethodInfoPtr_GetDialogLocationTypeDefinition_Public_Abstract_Virtual_New_DialogLocationTypeDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDialogManager>.NativeClassPtr, 100675354);
		NativeMethodInfoPtr_GetNodeInstance_Public_Abstract_Virtual_New_DialogNodeInstance_DialogDefinition_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDialogManager>.NativeClassPtr, 100675355);
		NativeMethodInfoPtr_StartDialog_Public_Abstract_Virtual_New_Boolean_Entity_Entity_byref_DialogDefinition_byref_DialogNodeInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDialogManager>.NativeClassPtr, 100675356);
		NativeMethodInfoPtr_EvaluateLink_Public_Abstract_Virtual_New_Void_Entity_Entity_DialogLink_byref_Int32_List_1_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDialogManager>.NativeClassPtr, 100675357);
		NativeMethodInfoPtr_GetNodeLineDecision_Public_Abstract_Virtual_New_Int32_IDialogConverser_DialogNodeDefinition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDialogManager>.NativeClassPtr, 100675358);
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerator Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual DialogDefinition GetDialogDefinition(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDialogDefinition_Public_Abstract_Virtual_New_DialogDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DialogDefinition>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual NPCRequestDefinition GetNPCRequestDefinition(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetNPCRequestDefinition_Public_Abstract_Virtual_New_NPCRequestDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NPCRequestDefinition>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual DialogLocationTypeDefinition GetDialogLocationTypeDefinition(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDialogLocationTypeDefinition_Public_Abstract_Virtual_New_DialogLocationTypeDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DialogLocationTypeDefinition>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual DialogNodeInstance GetNodeInstance(DialogDefinition dialogDefinition, int nodeId, List<int> linkIndexes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogDefinition);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &nodeId;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)linkIndexes);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetNodeInstance_Public_Abstract_Virtual_New_DialogNodeInstance_DialogDefinition_Int32_List_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DialogNodeInstance>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual bool StartDialog(Entity initiatorEntity, Entity targetEntity, out DialogDefinition dialog, out DialogNodeInstance nodeInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)initiatorEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetEntity);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_StartDialog_Public_Abstract_Virtual_New_Boolean_Entity_Entity_byref_DialogDefinition_byref_DialogNodeInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num5 = num2;
		dialog = ((num5 == 0) ? null : new DialogDefinition(num5));
		nint num6 = num4;
		nodeInstance = ((num6 == 0) ? null : new DialogNodeInstance(num6));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void EvaluateLink(Entity initiatorEntity, Entity targetEntity, DialogLink link, out int nextNodeId, List<int> resultLinkIndexes, out int chosenDestinationIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)initiatorEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)link);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref nextNodeId);
		*(IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultLinkIndexes);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref chosenDestinationIndex);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_EvaluateLink_Public_Abstract_Virtual_New_Void_Entity_Entity_DialogLink_byref_Int32_List_1_Int32_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual int GetNodeLineDecision(IDialogConverser dialogConverser, DialogNodeDefinition nodeDefinition, bool pickIfMissing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogConverser);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodeDefinition);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &pickIfMissing;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetNodeLineDecision_Public_Abstract_Virtual_New_Int32_IDialogConverser_DialogNodeDefinition_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IDialogManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
