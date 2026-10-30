using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

public class ISecondaryTerrainHeightFilterLayer : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_ComputeHeight_Public_Abstract_Virtual_New_Single_byref_WorldGenerationHeightData_Il2CppReferenceArray_1_Il2CppStructArray_1_Vector2_Int32_Int32_Il2CppObjectBase_0;

	static ISecondaryTerrainHeightFilterLayer()
	{
		Il2CppClassPointerStore<ISecondaryTerrainHeightFilterLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ISecondaryTerrainHeightFilterLayer");
		NativeMethodInfoPtr_ComputeHeight_Public_Abstract_Virtual_New_Single_byref_WorldGenerationHeightData_Il2CppReferenceArray_1_Il2CppStructArray_1_Vector2_Int32_Int32_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISecondaryTerrainHeightFilterLayer>.NativeClassPtr, 100683876);
	}

	[CallerCount(0)]
	public unsafe virtual float ComputeHeight(ref WorldGenerationHeightData data, Il2CppReferenceArray<Il2CppStructArray<Vector2>> slopeData, int alphamapX, int alphamapY, Il2CppObjectBase alphamaps)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slopeData);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &alphamapX;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &alphamapY;
		*(IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(alphamaps);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ComputeHeight_Public_Abstract_Virtual_New_Single_byref_WorldGenerationHeightData_Il2CppReferenceArray_1_Il2CppStructArray_1_Vector2_Int32_Int32_Il2CppObjectBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ISecondaryTerrainHeightFilterLayer(IntPtr pointer)
		: base(pointer)
	{
	}
}
