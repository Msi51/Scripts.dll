using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class IToolUser : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetToolAmount_Public_Abstract_Virtual_New_Single_ActionType_ToolType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetToolAmount_Public_Abstract_Virtual_New_Single_ActionType_List_1_ToolType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetToolMinRange_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetToolRange_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetActiveToolTypes_Public_Abstract_Virtual_New_HashSet_1_ToolType_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItemEquipPoint_Public_Abstract_Virtual_New_EquipPoint_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetToolItem_Public_Abstract_Virtual_New_InventoryItem_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_TakeConditionDamage_Public_Abstract_Virtual_New_Void_ActionType_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStaminaExertion_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_HasToolType_Public_Abstract_Virtual_New_Boolean_ToolType_0;

	private static readonly IntPtr NativeMethodInfoPtr_HasAnyToolTypes_Public_Abstract_Virtual_New_Boolean_List_1_ToolType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetToolAnimation_Public_Abstract_Virtual_New_AnimationState_ActionType_ToolType_Entity_0;

	static IToolUser()
	{
		Il2CppClassPointerStore<IToolUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IToolUser");
		NativeMethodInfoPtr_GetToolAmount_Public_Abstract_Virtual_New_Single_ActionType_ToolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolUser>.NativeClassPtr, 100682051);
		NativeMethodInfoPtr_GetToolAmount_Public_Abstract_Virtual_New_Single_ActionType_List_1_ToolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolUser>.NativeClassPtr, 100682052);
		NativeMethodInfoPtr_GetToolMinRange_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolUser>.NativeClassPtr, 100682053);
		NativeMethodInfoPtr_GetToolRange_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolUser>.NativeClassPtr, 100682054);
		NativeMethodInfoPtr_GetActiveToolTypes_Public_Abstract_Virtual_New_HashSet_1_ToolType_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolUser>.NativeClassPtr, 100682055);
		NativeMethodInfoPtr_GetItemEquipPoint_Public_Abstract_Virtual_New_EquipPoint_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolUser>.NativeClassPtr, 100682056);
		NativeMethodInfoPtr_GetToolItem_Public_Abstract_Virtual_New_InventoryItem_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolUser>.NativeClassPtr, 100682057);
		NativeMethodInfoPtr_TakeConditionDamage_Public_Abstract_Virtual_New_Void_ActionType_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolUser>.NativeClassPtr, 100682058);
		NativeMethodInfoPtr_GetStaminaExertion_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolUser>.NativeClassPtr, 100682059);
		NativeMethodInfoPtr_HasToolType_Public_Abstract_Virtual_New_Boolean_ToolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolUser>.NativeClassPtr, 100682060);
		NativeMethodInfoPtr_HasAnyToolTypes_Public_Abstract_Virtual_New_Boolean_List_1_ToolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolUser>.NativeClassPtr, 100682061);
		NativeMethodInfoPtr_GetToolAnimation_Public_Abstract_Virtual_New_AnimationState_ActionType_ToolType_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolUser>.NativeClassPtr, 100682062);
	}

	[CallerCount(0)]
	public unsafe virtual float GetToolAmount(ActionType actionType, ToolType toolType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&actionType);
		*(ToolType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &toolType;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetToolAmount_Public_Abstract_Virtual_New_Single_ActionType_ToolType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetToolAmount(ActionType actionType, List<ToolType> targetToolTypes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&actionType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetToolTypes);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetToolAmount_Public_Abstract_Virtual_New_Single_ActionType_List_1_ToolType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetToolMinRange(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetToolMinRange_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetToolRange(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetToolRange_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual HashSet<ToolType> GetActiveToolTypes(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetActiveToolTypes_Public_Abstract_Virtual_New_HashSet_1_ToolType_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HashSet<ToolType>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual EquipPoint GetItemEquipPoint(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetItemEquipPoint_Public_Abstract_Virtual_New_EquipPoint_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(EquipPoint*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual InventoryItem GetToolItem(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetToolItem_Public_Abstract_Virtual_New_InventoryItem_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventoryItem>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void TakeConditionDamage(ActionType actionType, Entity fromEntity = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&actionType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fromEntity);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TakeConditionDamage_Public_Abstract_Virtual_New_Void_ActionType_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual float GetStaminaExertion(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetStaminaExertion_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool HasToolType(ToolType toolType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&toolType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HasToolType_Public_Abstract_Virtual_New_Boolean_ToolType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool HasAnyToolTypes(List<ToolType> toolTypes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toolTypes);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HasAnyToolTypes_Public_Abstract_Virtual_New_Boolean_List_1_ToolType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual AnimationState GetToolAnimation(ActionType actionType, ToolType toolType, Entity toolableEntity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&actionType);
		*(ToolType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &toolType;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toolableEntity);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetToolAnimation_Public_Abstract_Virtual_New_AnimationState_ActionType_ToolType_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AnimationState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IToolUser(IntPtr pointer)
		: base(pointer)
	{
	}
}
