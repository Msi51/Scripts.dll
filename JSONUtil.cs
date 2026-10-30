using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using SimpleJSON;

public static class JSONUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ParseNode_Public_Static_Dictionary_2_String_Object_JSONNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseListNode_Public_Static_List_1_Object_JSONNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseNode_Private_Static_Object_JSONNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertDictionary_Public_Static_JSONNode_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertList_Public_Static_JSONArray_List_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_convertObject_Private_Static_JSONNode_Object_0;

	static JSONUtil()
	{
		Il2CppClassPointerStore<JSONUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "JSONUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONUtil>.NativeClassPtr);
		NativeMethodInfoPtr_ParseNode_Public_Static_Dictionary_2_String_Object_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONUtil>.NativeClassPtr, 100667763);
		NativeMethodInfoPtr_ParseListNode_Public_Static_List_1_Object_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONUtil>.NativeClassPtr, 100667764);
		NativeMethodInfoPtr_parseNode_Private_Static_Object_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONUtil>.NativeClassPtr, 100667765);
		NativeMethodInfoPtr_ConvertDictionary_Public_Static_JSONNode_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONUtil>.NativeClassPtr, 100667766);
		NativeMethodInfoPtr_ConvertList_Public_Static_JSONArray_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONUtil>.NativeClassPtr, 100667767);
		NativeMethodInfoPtr_convertObject_Private_Static_JSONNode_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONUtil>.NativeClassPtr, 100667768);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 82191, RefRangeEnd = 82196, XrefRangeStart = 82176, XrefRangeEnd = 82191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<string, Il2CppSystem.Object> ParseNode(JSONNode node)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseNode_Public_Static_Dictionary_2_String_Object_JSONNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 82213, RefRangeEnd = 82214, XrefRangeStart = 82196, XrefRangeEnd = 82213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Il2CppSystem.Object> ParseListNode(JSONNode node)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseListNode_Public_Static_List_1_Object_JSONNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Object>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 82216, RefRangeEnd = 82218, XrefRangeStart = 82214, XrefRangeEnd = 82216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object parseNode(JSONNode node)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseNode_Private_Static_Object_JSONNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 82239, RefRangeEnd = 82243, XrefRangeStart = 82218, XrefRangeEnd = 82239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JSONNode ConvertDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertDictionary_Public_Static_JSONNode_Dictionary_2_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<JSONNode>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 82262, RefRangeEnd = 82263, XrefRangeStart = 82243, XrefRangeEnd = 82262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JSONArray ConvertList(List<Il2CppSystem.Object> list)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertList_Public_Static_JSONArray_List_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<JSONArray>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 82285, RefRangeEnd = 82287, XrefRangeStart = 82263, XrefRangeEnd = 82285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JSONNode convertObject(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_convertObject_Private_Static_JSONNode_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<JSONNode>(intPtr) : null;
	}

	public JSONUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
