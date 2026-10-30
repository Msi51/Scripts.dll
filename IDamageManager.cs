using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class IDamageManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_HandleTargetDamage_Public_Abstract_Virtual_New_DamageResult_Entity_Entity_DamageValues_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleCollisionDamage_Public_Abstract_Virtual_New_DamageResult_Entity_GameObject_Collision_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleFallDamage_Public_Abstract_Virtual_New_DamageResult_Entity_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeHitEntity_Public_Abstract_Virtual_New_Entity_Entity_ActionType_Vector3_Ray_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleMeleeDamage_Public_Abstract_Virtual_New_DamageResult_Entity_DamageValues_Entity_Vector3_Vector3_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleProjectileDamage_Public_Abstract_Virtual_New_DamageResult_Entity_Entity_Entity_Vector3_Single_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleNetworkDamageTaken_Public_Abstract_Virtual_New_Void_Entity_Entity_DamageResult_Vector3_Vector3_Boolean_Boolean_0;

	static IDamageManager()
	{
		Il2CppClassPointerStore<IDamageManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IDamageManager");
		NativeMethodInfoPtr_HandleTargetDamage_Public_Abstract_Virtual_New_DamageResult_Entity_Entity_DamageValues_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamageManager>.NativeClassPtr, 100675340);
		NativeMethodInfoPtr_HandleCollisionDamage_Public_Abstract_Virtual_New_DamageResult_Entity_GameObject_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamageManager>.NativeClassPtr, 100675341);
		NativeMethodInfoPtr_HandleFallDamage_Public_Abstract_Virtual_New_DamageResult_Entity_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamageManager>.NativeClassPtr, 100675342);
		NativeMethodInfoPtr_GetMeleeHitEntity_Public_Abstract_Virtual_New_Entity_Entity_ActionType_Vector3_Ray_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamageManager>.NativeClassPtr, 100675343);
		NativeMethodInfoPtr_HandleMeleeDamage_Public_Abstract_Virtual_New_DamageResult_Entity_DamageValues_Entity_Vector3_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamageManager>.NativeClassPtr, 100675344);
		NativeMethodInfoPtr_HandleProjectileDamage_Public_Abstract_Virtual_New_DamageResult_Entity_Entity_Entity_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamageManager>.NativeClassPtr, 100675345);
		NativeMethodInfoPtr_HandleNetworkDamageTaken_Public_Abstract_Virtual_New_Void_Entity_Entity_DamageResult_Vector3_Vector3_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamageManager>.NativeClassPtr, 100675346);
	}

	[CallerCount(0)]
	public unsafe virtual DamageResult HandleTargetDamage(Entity attackerEntity, Entity targetEntity, DamageValues damageValues, bool showDamage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attackerEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetEntity);
		*(DamageValues**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &damageValues;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &showDamage;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleTargetDamage_Public_Abstract_Virtual_New_DamageResult_Entity_Entity_DamageValues_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new DamageResult(pointer);
	}

	[CallerCount(0)]
	public unsafe virtual DamageResult HandleCollisionDamage(Entity colliderEntity, GameObject targetObject, UnityEngine.Collision collision)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colliderEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetObject);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collision);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleCollisionDamage_Public_Abstract_Virtual_New_DamageResult_Entity_GameObject_Collision_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new DamageResult(pointer);
	}

	[CallerCount(0)]
	public unsafe virtual DamageResult HandleFallDamage(Entity entity, Vector3 velocity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &velocity;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleFallDamage_Public_Abstract_Virtual_New_DamageResult_Entity_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new DamageResult(pointer);
	}

	[CallerCount(0)]
	public unsafe virtual Entity GetMeleeHitEntity(Entity attackerEntity, ActionType actionType, Vector3 attackDirection, Ray thirdPersonRay, out Vector3 hitPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attackerEntity);
		*(ActionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &actionType;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &attackDirection;
		*(Ray**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &thirdPersonRay;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref hitPoint);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMeleeHitEntity_Public_Abstract_Virtual_New_Entity_Entity_ActionType_Vector3_Ray_byref_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual DamageResult HandleMeleeDamage(Entity attackerEntity, DamageValues damageValues, Entity hitEntity, Vector3 hitPoint, Vector3 weaponDirection = default(Vector3), bool critical = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attackerEntity);
		*(DamageValues**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &damageValues;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hitEntity);
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &hitPoint;
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &weaponDirection;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &critical;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleMeleeDamage_Public_Abstract_Virtual_New_DamageResult_Entity_DamageValues_Entity_Vector3_Vector3_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new DamageResult(pointer);
	}

	[CallerCount(0)]
	public unsafe virtual DamageResult HandleProjectileDamage(Entity attackerEntity, Entity projectileEntity, Entity hitEntity, Vector3 hitPosition, float damagePercentage, bool critical = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attackerEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)projectileEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hitEntity);
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &hitPosition;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &damagePercentage;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &critical;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleProjectileDamage_Public_Abstract_Virtual_New_DamageResult_Entity_Entity_Entity_Vector3_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new DamageResult(pointer);
	}

	[CallerCount(0)]
	public unsafe virtual void HandleNetworkDamageTaken(Entity entity, Entity sourceEntity, DamageResult damageResult, Vector3 direction, Vector3 weaponDirection, bool showDamage, bool critical)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)damageResult));
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &direction;
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &weaponDirection;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &showDamage;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &critical;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleNetworkDamageTaken_Public_Abstract_Virtual_New_Void_Entity_Entity_DamageResult_Vector3_Vector3_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IDamageManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
