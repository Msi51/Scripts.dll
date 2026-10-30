using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class IObjectiveTaskCondition : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetObjectiveConditionType_Public_Abstract_Virtual_New_ObjectiveTaskConditionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_Satisfied_Public_Abstract_Virtual_New_Boolean_Entity_Vector3_0;

	static IObjectiveTaskCondition()
	{
		Il2CppClassPointerStore<IObjectiveTaskCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IObjectiveTaskCondition");
		NativeMethodInfoPtr_GetObjectiveConditionType_Public_Abstract_Virtual_New_ObjectiveTaskConditionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveTaskCondition>.NativeClassPtr, 100678431);
		NativeMethodInfoPtr_Satisfied_Public_Abstract_Virtual_New_Boolean_Entity_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveTaskCondition>.NativeClassPtr, 100678432);
	}

	[CallerCount(0)]
	public unsafe virtual ObjectiveTaskConditionType GetObjectiveConditionType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetObjectiveConditionType_Public_Abstract_Virtual_New_ObjectiveTaskConditionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ObjectiveTaskConditionType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool Satisfied(Entity triggerEntity, Vector3 triggerPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)triggerEntity);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &triggerPosition;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Satisfied_Public_Abstract_Virtual_New_Boolean_Entity_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IObjectiveTaskCondition(IntPtr pointer)
		: base(pointer)
	{
	}
}
