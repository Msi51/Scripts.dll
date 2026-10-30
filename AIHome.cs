using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AIHome : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_HOSTILE_REPUTATION_THRESHOLD;

	private static readonly System.IntPtr NativeFieldInfoPtr_HOSTILE_FRIENDLINESS_THRESHOLD;

	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_memberCharacterInstanceIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_constructionEntityIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_droppedItemEntityIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterReputations;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiItemRequests;

	private static readonly System.IntPtr NativeFieldInfoPtr_claimedAiItemRequestsByNpc;

	private static readonly System.IntPtr NativeFieldInfoPtr_friendliness;

	private static readonly System.IntPtr NativeFieldInfoPtr_centerPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_restAreaPosition;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateReputation_Public_AIReputation_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReputation_Public_Single_World_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHostileToCharacter_Public_Boolean_World_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetItemRequest_Public_Boolean_Int32_Int32_byref_AIItemRequest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetItemRequest_Public_Void_Int32_Int32_AIItemRequest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrySetItemRequestCompleted_Public_Boolean_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAiItemRequestsForNpc_Public_Void_Int32_List_1_ValueTuple_2_Int32_AIItemRequest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetClaimedAiItemRequest_Public_Boolean_Int32_byref_AIItemRequest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetClaimedAiItemRequest_Public_Void_Int32_AIItemRequest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float HOSTILE_REPUTATION_THRESHOLD
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HOSTILE_REPUTATION_THRESHOLD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HOSTILE_REPUTATION_THRESHOLD, (void*)(&num));
		}
	}

	public unsafe static float HOSTILE_FRIENDLINESS_THRESHOLD
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HOSTILE_FRIENDLINESS_THRESHOLD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HOSTILE_FRIENDLINESS_THRESHOLD, (void*)(&num));
		}
	}

	public unsafe int id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
		}
	}

	public unsafe HashSet<int> memberCharacterInstanceIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memberCharacterInstanceIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memberCharacterInstanceIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<int> constructionEntityIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructionEntityIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructionEntityIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<int> droppedItemEntityIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_droppedItemEntityIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_droppedItemEntityIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Dictionary<int, AIReputation> characterReputations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterReputations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, AIReputation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterReputations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, Dictionary<int, AIItemRequest>> aiItemRequests
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiItemRequests);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Dictionary<int, AIItemRequest>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiItemRequests)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, AIItemRequest> claimedAiItemRequestsByNpc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_claimedAiItemRequestsByNpc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, AIItemRequest>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_claimedAiItemRequestsByNpc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe float friendliness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_friendliness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_friendliness)) = num;
		}
	}

	public unsafe Vector3 centerPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centerPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centerPosition)) = vector;
		}
	}

	public unsafe Vector3 restAreaPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restAreaPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restAreaPosition)) = vector;
		}
	}

	static AIHome()
	{
		Il2CppClassPointerStore<AIHome>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AIHome");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIHome>.NativeClassPtr);
		NativeFieldInfoPtr_HOSTILE_REPUTATION_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIHome>.NativeClassPtr, "HOSTILE_REPUTATION_THRESHOLD");
		NativeFieldInfoPtr_HOSTILE_FRIENDLINESS_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIHome>.NativeClassPtr, "HOSTILE_FRIENDLINESS_THRESHOLD");
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIHome>.NativeClassPtr, "id");
		NativeFieldInfoPtr_memberCharacterInstanceIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIHome>.NativeClassPtr, "memberCharacterInstanceIds");
		NativeFieldInfoPtr_constructionEntityIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIHome>.NativeClassPtr, "constructionEntityIds");
		NativeFieldInfoPtr_droppedItemEntityIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIHome>.NativeClassPtr, "droppedItemEntityIds");
		NativeFieldInfoPtr_characterReputations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIHome>.NativeClassPtr, "characterReputations");
		NativeFieldInfoPtr_aiItemRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIHome>.NativeClassPtr, "aiItemRequests");
		NativeFieldInfoPtr_claimedAiItemRequestsByNpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIHome>.NativeClassPtr, "claimedAiItemRequestsByNpc");
		NativeFieldInfoPtr_friendliness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIHome>.NativeClassPtr, "friendliness");
		NativeFieldInfoPtr_centerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIHome>.NativeClassPtr, "centerPosition");
		NativeFieldInfoPtr_restAreaPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIHome>.NativeClassPtr, "restAreaPosition");
		NativeMethodInfoPtr_GetOrCreateReputation_Public_AIReputation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIHome>.NativeClassPtr, 100668407);
		NativeMethodInfoPtr_GetReputation_Public_Single_World_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIHome>.NativeClassPtr, 100668408);
		NativeMethodInfoPtr_IsHostileToCharacter_Public_Boolean_World_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIHome>.NativeClassPtr, 100668409);
		NativeMethodInfoPtr_TryGetItemRequest_Public_Boolean_Int32_Int32_byref_AIItemRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIHome>.NativeClassPtr, 100668410);
		NativeMethodInfoPtr_SetItemRequest_Public_Void_Int32_Int32_AIItemRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIHome>.NativeClassPtr, 100668411);
		NativeMethodInfoPtr_TrySetItemRequestCompleted_Public_Boolean_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIHome>.NativeClassPtr, 100668412);
		NativeMethodInfoPtr_GetAiItemRequestsForNpc_Public_Void_Int32_List_1_ValueTuple_2_Int32_AIItemRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIHome>.NativeClassPtr, 100668413);
		NativeMethodInfoPtr_TryGetClaimedAiItemRequest_Public_Boolean_Int32_byref_AIItemRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIHome>.NativeClassPtr, 100668414);
		NativeMethodInfoPtr_SetClaimedAiItemRequest_Public_Void_Int32_AIItemRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIHome>.NativeClassPtr, 100668415);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIHome>.NativeClassPtr, 100668416);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 90557, RefRangeEnd = 90563, XrefRangeStart = 90547, XrefRangeEnd = 90557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AIReputation GetOrCreateReputation(int characterInstanceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&characterInstanceId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreateReputation_Public_AIReputation_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIReputation>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90566, RefRangeEnd = 90567, XrefRangeStart = 90563, XrefRangeEnd = 90566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetReputation(World world, int characterInstanceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &characterInstanceId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReputation_Public_Single_World_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90571, RefRangeEnd = 90572, XrefRangeStart = 90567, XrefRangeEnd = 90571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsHostileToCharacter(World world, int characterInstanceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &characterInstanceId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHostileToCharacter_Public_Boolean_World_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 90580, RefRangeEnd = 90586, XrefRangeStart = 90572, XrefRangeEnd = 90580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetItemRequest(int playerCharacterInstanceId, int npcCharacterInstanceId, out AIItemRequest request)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&playerCharacterInstanceId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &npcCharacterInstanceId;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetItemRequest_Public_Boolean_Int32_Int32_byref_AIItemRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		request = ((num3 == 0) ? null : new AIItemRequest(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 90608, RefRangeEnd = 90611, XrefRangeStart = 90586, XrefRangeEnd = 90608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetItemRequest(int playerCharacterInstanceId, int npcCharacterInstanceId, AIItemRequest request)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&playerCharacterInstanceId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &npcCharacterInstanceId;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)request);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetItemRequest_Public_Void_Int32_Int32_AIItemRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90611, XrefRangeEnd = 90618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TrySetItemRequestCompleted(int playerCharacterInstanceId, int npcCharacterInstanceId, bool completed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&playerCharacterInstanceId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &npcCharacterInstanceId;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &completed;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrySetItemRequestCompleted_Public_Boolean_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90618, XrefRangeEnd = 90644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetAiItemRequestsForNpc(int npcCharacterInstanceId, List<Il2CppSystem.ValueTuple<int, AIItemRequest>> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&npcCharacterInstanceId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAiItemRequestsForNpc_Public_Void_Int32_List_1_ValueTuple_2_Int32_AIItemRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 90646, RefRangeEnd = 90650, XrefRangeStart = 90644, XrefRangeEnd = 90646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetClaimedAiItemRequest(int npcCharacterInstanceId, out AIItemRequest request)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&npcCharacterInstanceId);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetClaimedAiItemRequest_Public_Boolean_Int32_byref_AIItemRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		request = ((num3 == 0) ? null : new AIItemRequest(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90661, RefRangeEnd = 90662, XrefRangeStart = 90650, XrefRangeEnd = 90661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetClaimedAiItemRequest(int npcCharacterInstanceId, AIItemRequest request)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&npcCharacterInstanceId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)request);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetClaimedAiItemRequest_Public_Void_Int32_AIItemRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 90702, RefRangeEnd = 90704, XrefRangeStart = 90662, XrefRangeEnd = 90702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AIHome()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIHome>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AIHome(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
