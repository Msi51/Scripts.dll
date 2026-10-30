using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

public class ICustomizableSkinnedRenderer : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SetCharacterCustomization_Public_Abstract_Virtual_New_Void_CharacterCustomization_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSkinnedMeshPieceData_Public_Abstract_Virtual_New_Void_CharacterMeshDetails_Transform_Il2CppReferenceArray_1_Transform_EntitySkinnedMeshData_0;

	private static readonly IntPtr NativeMethodInfoPtr_SkinnedMeshPieceDataSet_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleItemSlotUpdate_Public_Abstract_Virtual_New_Void_InventorySlot_0;

	private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Abstract_Virtual_New_Void_0;

	static ICustomizableSkinnedRenderer()
	{
		Il2CppClassPointerStore<ICustomizableSkinnedRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ICustomizableSkinnedRenderer");
		NativeMethodInfoPtr_SetCharacterCustomization_Public_Abstract_Virtual_New_Void_CharacterCustomization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomizableSkinnedRenderer>.NativeClassPtr, 100681360);
		NativeMethodInfoPtr_SetSkinnedMeshPieceData_Public_Abstract_Virtual_New_Void_CharacterMeshDetails_Transform_Il2CppReferenceArray_1_Transform_EntitySkinnedMeshData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomizableSkinnedRenderer>.NativeClassPtr, 100681361);
		NativeMethodInfoPtr_SkinnedMeshPieceDataSet_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomizableSkinnedRenderer>.NativeClassPtr, 100681362);
		NativeMethodInfoPtr_HandleItemSlotUpdate_Public_Abstract_Virtual_New_Void_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomizableSkinnedRenderer>.NativeClassPtr, 100681363);
		NativeMethodInfoPtr_Refresh_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomizableSkinnedRenderer>.NativeClassPtr, 100681364);
	}

	[CallerCount(0)]
	public unsafe virtual void SetCharacterCustomization(CharacterCustomization characterCustomization)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterCustomization);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetCharacterCustomization_Public_Abstract_Virtual_New_Void_CharacterCustomization_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetSkinnedMeshPieceData(CharacterMeshDetails characterMeshDetails, Transform rootBone, Il2CppReferenceArray<Transform> bones, EntitySkinnedMeshData entitySkinnedMeshData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterMeshDetails);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rootBone);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bones);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entitySkinnedMeshData);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetSkinnedMeshPieceData_Public_Abstract_Virtual_New_Void_CharacterMeshDetails_Transform_Il2CppReferenceArray_1_Transform_EntitySkinnedMeshData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool SkinnedMeshPieceDataSet()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SkinnedMeshPieceDataSet_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void HandleItemSlotUpdate(InventorySlot slot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slot);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleItemSlotUpdate_Public_Abstract_Virtual_New_Void_InventorySlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void Refresh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Refresh_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ICustomizableSkinnedRenderer(IntPtr pointer)
		: base(pointer)
	{
	}
}
