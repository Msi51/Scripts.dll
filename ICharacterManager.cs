using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

public class ICharacterManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeCharacterEntity_Public_Abstract_Virtual_New_Void_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShouldDestroyEntity_Public_Abstract_Virtual_New_Boolean_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateCharacterInstance_Public_Abstract_Virtual_New_CharacterInstance_Entity_CharacterCustomization_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateCharacterInstance_Public_Abstract_Virtual_New_CharacterInstance_Entity_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_AssignCharacterInstance_Public_Abstract_Virtual_New_CharacterInstance_Entity_CharacterInstance_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetCharacterInstanceEntity_Public_Abstract_Virtual_New_Entity_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetCharacters_Public_Abstract_Virtual_New_IEnumerable_1_Character_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetCharacter_Public_Abstract_Virtual_New_Character_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDefaultCharacterCustomization_Public_Abstract_Virtual_New_CharacterCustomization_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRandomCharacterCustomization_Public_Abstract_Virtual_New_CharacterCustomization_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRandomCharacterCustomization_Public_Abstract_Virtual_New_CharacterCustomization_Entity_CharacterVariant_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDefaultClothingOptions_Public_Abstract_Virtual_New_List_1_String_CharacterVariant_0;

	private static readonly IntPtr NativeMethodInfoPtr_LoadGame_Public_Abstract_Virtual_New_Void_GameSave_0;

	private static readonly IntPtr NativeMethodInfoPtr_SaveGame_Public_Abstract_Virtual_New_Void_GameSave_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetCharacterInstance_Public_Abstract_Virtual_New_CharacterInstance_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetCharacterInstance_Public_Abstract_Virtual_New_CharacterInstance_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleDestroyedEntity_Public_Abstract_Virtual_New_Void_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddCharacterInstance_Public_Abstract_Virtual_New_Void_CharacterInstance_0;

	private static readonly IntPtr NativeMethodInfoPtr_ClearData_Public_Abstract_Virtual_New_Void_0;

	static ICharacterManager()
	{
		Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ICharacterManager");
		NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675275);
		NativeMethodInfoPtr_InitializeCharacterEntity_Public_Abstract_Virtual_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675276);
		NativeMethodInfoPtr_ShouldDestroyEntity_Public_Abstract_Virtual_New_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675277);
		NativeMethodInfoPtr_CreateCharacterInstance_Public_Abstract_Virtual_New_CharacterInstance_Entity_CharacterCustomization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675278);
		NativeMethodInfoPtr_CreateCharacterInstance_Public_Abstract_Virtual_New_CharacterInstance_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675279);
		NativeMethodInfoPtr_AssignCharacterInstance_Public_Abstract_Virtual_New_CharacterInstance_Entity_CharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675280);
		NativeMethodInfoPtr_GetCharacterInstanceEntity_Public_Abstract_Virtual_New_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675281);
		NativeMethodInfoPtr_GetCharacters_Public_Abstract_Virtual_New_IEnumerable_1_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675282);
		NativeMethodInfoPtr_GetCharacter_Public_Abstract_Virtual_New_Character_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675283);
		NativeMethodInfoPtr_GetDefaultCharacterCustomization_Public_Abstract_Virtual_New_CharacterCustomization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675284);
		NativeMethodInfoPtr_GetRandomCharacterCustomization_Public_Abstract_Virtual_New_CharacterCustomization_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675285);
		NativeMethodInfoPtr_GetRandomCharacterCustomization_Public_Abstract_Virtual_New_CharacterCustomization_Entity_CharacterVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675286);
		NativeMethodInfoPtr_GetDefaultClothingOptions_Public_Abstract_Virtual_New_List_1_String_CharacterVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675287);
		NativeMethodInfoPtr_LoadGame_Public_Abstract_Virtual_New_Void_GameSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675288);
		NativeMethodInfoPtr_SaveGame_Public_Abstract_Virtual_New_Void_GameSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675289);
		NativeMethodInfoPtr_GetCharacterInstance_Public_Abstract_Virtual_New_CharacterInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675290);
		NativeMethodInfoPtr_GetCharacterInstance_Public_Abstract_Virtual_New_CharacterInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675291);
		NativeMethodInfoPtr_HandleDestroyedEntity_Public_Abstract_Virtual_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675292);
		NativeMethodInfoPtr_AddCharacterInstance_Public_Abstract_Virtual_New_Void_CharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675293);
		NativeMethodInfoPtr_ClearData_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterManager>.NativeClassPtr, 100675294);
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
	public unsafe virtual void InitializeCharacterEntity(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeCharacterEntity_Public_Abstract_Virtual_New_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool ShouldDestroyEntity(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ShouldDestroyEntity_Public_Abstract_Virtual_New_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual CharacterInstance CreateCharacterInstance(Entity entity, CharacterCustomization characterCustomization = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterCustomization);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateCharacterInstance_Public_Abstract_Virtual_New_CharacterInstance_Entity_CharacterCustomization_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CharacterInstance>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual CharacterInstance CreateCharacterInstance(Entity entity, string instanceIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(instanceIdentifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateCharacterInstance_Public_Abstract_Virtual_New_CharacterInstance_Entity_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CharacterInstance>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual CharacterInstance AssignCharacterInstance(Entity entity, CharacterInstance characterInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterInstance);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AssignCharacterInstance_Public_Abstract_Virtual_New_CharacterInstance_Entity_CharacterInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CharacterInstance>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Entity GetCharacterInstanceEntity(int characterInstanceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&characterInstanceId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCharacterInstanceEntity_Public_Abstract_Virtual_New_Entity_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerable<Character> GetCharacters()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCharacters_Public_Abstract_Virtual_New_IEnumerable_1_Character_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<Character>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Character GetCharacter(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCharacter_Public_Abstract_Virtual_New_Character_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Character>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual CharacterCustomization GetDefaultCharacterCustomization()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDefaultCharacterCustomization_Public_Abstract_Virtual_New_CharacterCustomization_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CharacterCustomization>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual CharacterCustomization GetRandomCharacterCustomization(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRandomCharacterCustomization_Public_Abstract_Virtual_New_CharacterCustomization_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CharacterCustomization>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual CharacterCustomization GetRandomCharacterCustomization(Entity entity, CharacterVariant variant)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(CharacterVariant**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &variant;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRandomCharacterCustomization_Public_Abstract_Virtual_New_CharacterCustomization_Entity_CharacterVariant_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CharacterCustomization>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual List<string> GetDefaultClothingOptions(CharacterVariant variant)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&variant);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDefaultClothingOptions_Public_Abstract_Virtual_New_List_1_String_CharacterVariant_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void LoadGame(GameSave gameSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameSave);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadGame_Public_Abstract_Virtual_New_Void_GameSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SaveGame(GameSave gameSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameSave);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveGame_Public_Abstract_Virtual_New_Void_GameSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual CharacterInstance GetCharacterInstance(int characterInstanceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&characterInstanceId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCharacterInstance_Public_Abstract_Virtual_New_CharacterInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CharacterInstance>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual CharacterInstance GetCharacterInstance(string characterInstanceIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(characterInstanceIdentifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCharacterInstance_Public_Abstract_Virtual_New_CharacterInstance_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CharacterInstance>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void HandleDestroyedEntity(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleDestroyedEntity_Public_Abstract_Virtual_New_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddCharacterInstance(CharacterInstance characterInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterInstance);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddCharacterInstance_Public_Abstract_Virtual_New_Void_CharacterInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void ClearData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ClearData_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ICharacterManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
