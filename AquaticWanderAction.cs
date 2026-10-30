using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

public class AquaticWanderAction : AIAction
{
	private static readonly IntPtr NativeFieldInfoPtr_MAX_PATHFINDING_ITERATIONS;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_AIConsideration_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_AIActionResult_AIContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_determineUnderwaterIdleTargetPosition_Private_Vector3_World_Entity_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_isTargetIdlePositionValid_Private_Boolean_World_Vector3_0;

	public unsafe static int MAX_PATHFINDING_ITERATIONS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_PATHFINDING_ITERATIONS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_PATHFINDING_ITERATIONS, (void*)(&num));
		}
	}

	static AquaticWanderAction()
	{
		Il2CppClassPointerStore<AquaticWanderAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AquaticWanderAction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AquaticWanderAction>.NativeClassPtr);
		NativeFieldInfoPtr_MAX_PATHFINDING_ITERATIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AquaticWanderAction>.NativeClassPtr, "MAX_PATHFINDING_ITERATIONS");
		NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_AIConsideration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AquaticWanderAction>.NativeClassPtr, 100668029);
		NativeMethodInfoPtr_Execute_Public_Virtual_AIActionResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AquaticWanderAction>.NativeClassPtr, 100668030);
		NativeMethodInfoPtr_determineUnderwaterIdleTargetPosition_Private_Vector3_World_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AquaticWanderAction>.NativeClassPtr, 100668031);
		NativeMethodInfoPtr_isTargetIdlePositionValid_Private_Boolean_World_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AquaticWanderAction>.NativeClassPtr, 100668032);
	}

	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 86249, RefRangeEnd = 86286, XrefRangeStart = 86249, XrefRangeEnd = 86286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AquaticWanderAction(string identifier, [Optional] Il2CppReferenceArray<AIConsideration> considerations)
	{
		if (considerations == null)
		{
			considerations = new Il2CppReferenceArray<AIConsideration>(0L);
		}
		this._002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AquaticWanderAction>.NativeClassPtr));
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)considerations);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_AIConsideration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86491, XrefRangeEnd = 86499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override AIActionResult Execute(AIContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_AIActionResult_AIContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AIActionResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86499, XrefRangeEnd = 86510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 determineUnderwaterIdleTargetPosition(World world, Entity aiEntity, int iterations)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiEntity);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &iterations;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_determineUnderwaterIdleTargetPosition_Private_Vector3_World_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86510, XrefRangeEnd = 86511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isTargetIdlePositionValid(World world, Vector3 targetPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &targetPosition;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isTargetIdlePositionValid_Private_Boolean_World_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public AquaticWanderAction(string identifier, params AIConsideration[] considerations)
		: this(identifier, new Il2CppReferenceArray<AIConsideration>(considerations))
	{
	}

	public AquaticWanderAction(IntPtr pointer)
		: base(pointer)
	{
	}
}
