using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public class EntityUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_random;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomYRotation_Public_Static_Quaternion_Random_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomYRotation_Public_Static_Quaternion_CustomRandom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomYRotation_Public_Static_Quaternion_Quaternion_CustomRandom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomZRotation_Public_Static_Quaternion_CustomRandom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpeakerGender_Public_Static_GrammaticalGender_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static CustomRandom random
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_random, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CustomRandom>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_random, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)customRandom));
		}
	}

	static EntityUtil()
	{
		Il2CppClassPointerStore<EntityUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "EntityUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityUtil>.NativeClassPtr);
		NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityUtil>.NativeClassPtr, "random");
		NativeMethodInfoPtr_GetRandomYRotation_Public_Static_Quaternion_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityUtil>.NativeClassPtr, 100667715);
		NativeMethodInfoPtr_GetRandomYRotation_Public_Static_Quaternion_CustomRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityUtil>.NativeClassPtr, 100667716);
		NativeMethodInfoPtr_GetRandomYRotation_Public_Static_Quaternion_Quaternion_CustomRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityUtil>.NativeClassPtr, 100667717);
		NativeMethodInfoPtr_GetRandomZRotation_Public_Static_Quaternion_CustomRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityUtil>.NativeClassPtr, 100667718);
		NativeMethodInfoPtr_GetSpeakerGender_Public_Static_GrammaticalGender_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityUtil>.NativeClassPtr, 100667719);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityUtil>.NativeClassPtr, 100667720);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 81248, RefRangeEnd = 81249, XrefRangeStart = 81247, XrefRangeEnd = 81248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion GetRandomYRotation(Il2CppSystem.Random random)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)random);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomYRotation_Public_Static_Quaternion_Random_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 81255, RefRangeEnd = 81281, XrefRangeStart = 81249, XrefRangeEnd = 81255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion GetRandomYRotation(CustomRandom random = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)random);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomYRotation_Public_Static_Quaternion_CustomRandom_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81281, XrefRangeEnd = 81291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion GetRandomYRotation(Quaternion rotation, CustomRandom random = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rotation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)random);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomYRotation_Public_Static_Quaternion_Quaternion_CustomRandom_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81291, XrefRangeEnd = 81297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion GetRandomZRotation(CustomRandom random = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)random);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomZRotation_Public_Static_Quaternion_CustomRandom_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 81305, RefRangeEnd = 81315, XrefRangeStart = 81297, XrefRangeEnd = 81305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GrammaticalGender GetSpeakerGender(Entity speakerEntity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)speakerEntity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpeakerGender_Public_Static_GrammaticalGender_Entity_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(GrammaticalGender*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EntityUtil()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityUtil>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EntityUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
