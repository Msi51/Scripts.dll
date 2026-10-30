using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Profiling;

public static class NetworkingStatistics : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_bytesSentCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_bytesSentPerSecCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_bytesReceivedCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_bytesReceivedPerSecCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_messagesSentCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_messagesReceivedCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_networkedEntitiesCount;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BytesCategory_Public_Static_get_ProfilerCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MessagesCategory_Public_Static_get_ProfilerCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EntitiesCategory_Public_Static_get_ProfilerCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BytesSentName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BytesSentPerSecName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BytesReceivedName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BytesReceivedPerSecName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MessagesSentName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MessagesReceivedName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NetworkedEntitiesName_Public_Static_get_String_0;

	public unsafe static ProfilerCounterValue<int> bytesSentCount
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProfilerCounterValue<int>>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bytesSentCount, (void*)intPtr);
			return new ProfilerCounterValue<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerCounterValue<int>>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bytesSentCount, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)profilerCounterValue)));
		}
	}

	public unsafe static ProfilerCounter<int> bytesSentPerSecCount
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProfilerCounter<int>>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bytesSentPerSecCount, (void*)intPtr);
			return new ProfilerCounter<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerCounter<int>>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bytesSentPerSecCount, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)profilerCounter)));
		}
	}

	public unsafe static ProfilerCounterValue<int> bytesReceivedCount
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProfilerCounterValue<int>>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bytesReceivedCount, (void*)intPtr);
			return new ProfilerCounterValue<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerCounterValue<int>>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bytesReceivedCount, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)profilerCounterValue)));
		}
	}

	public unsafe static ProfilerCounter<int> bytesReceivedPerSecCount
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProfilerCounter<int>>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bytesReceivedPerSecCount, (void*)intPtr);
			return new ProfilerCounter<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerCounter<int>>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bytesReceivedPerSecCount, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)profilerCounter)));
		}
	}

	public unsafe static ProfilerCounterValue<int> messagesSentCount
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProfilerCounterValue<int>>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_messagesSentCount, (void*)intPtr);
			return new ProfilerCounterValue<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerCounterValue<int>>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_messagesSentCount, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)profilerCounterValue)));
		}
	}

	public unsafe static ProfilerCounterValue<int> messagesReceivedCount
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProfilerCounterValue<int>>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_messagesReceivedCount, (void*)intPtr);
			return new ProfilerCounterValue<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerCounterValue<int>>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_messagesReceivedCount, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)profilerCounterValue)));
		}
	}

	public unsafe static ProfilerCounter<int> networkedEntitiesCount
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProfilerCounter<int>>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_networkedEntitiesCount, (void*)intPtr);
			return new ProfilerCounter<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerCounter<int>>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_networkedEntitiesCount, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)profilerCounter)));
		}
	}

	public unsafe static ProfilerCategory BytesCategory
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28522, XrefRangeEnd = 28525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BytesCategory_Public_Static_get_ProfilerCategory_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ProfilerCategory*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static ProfilerCategory MessagesCategory
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28525, XrefRangeEnd = 28528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MessagesCategory_Public_Static_get_ProfilerCategory_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ProfilerCategory*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static ProfilerCategory EntitiesCategory
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28528, XrefRangeEnd = 28531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EntitiesCategory_Public_Static_get_ProfilerCategory_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ProfilerCategory*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static string BytesSentName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28531, XrefRangeEnd = 28533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BytesSentName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string BytesSentPerSecName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28533, XrefRangeEnd = 28535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BytesSentPerSecName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string BytesReceivedName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28535, XrefRangeEnd = 28537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BytesReceivedName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string BytesReceivedPerSecName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28537, XrefRangeEnd = 28539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BytesReceivedPerSecName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string MessagesSentName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28539, XrefRangeEnd = 28541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MessagesSentName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string MessagesReceivedName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28541, XrefRangeEnd = 28543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MessagesReceivedName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string NetworkedEntitiesName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28543, XrefRangeEnd = 28545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NetworkedEntitiesName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	static NetworkingStatistics()
	{
		Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NetworkingStatistics");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr);
		NativeFieldInfoPtr_bytesSentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr, "bytesSentCount");
		NativeFieldInfoPtr_bytesSentPerSecCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr, "bytesSentPerSecCount");
		NativeFieldInfoPtr_bytesReceivedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr, "bytesReceivedCount");
		NativeFieldInfoPtr_bytesReceivedPerSecCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr, "bytesReceivedPerSecCount");
		NativeFieldInfoPtr_messagesSentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr, "messagesSentCount");
		NativeFieldInfoPtr_messagesReceivedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr, "messagesReceivedCount");
		NativeFieldInfoPtr_networkedEntitiesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr, "networkedEntitiesCount");
		NativeMethodInfoPtr_get_BytesCategory_Public_Static_get_ProfilerCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr, 100664245);
		NativeMethodInfoPtr_get_MessagesCategory_Public_Static_get_ProfilerCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr, 100664246);
		NativeMethodInfoPtr_get_EntitiesCategory_Public_Static_get_ProfilerCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr, 100664247);
		NativeMethodInfoPtr_get_BytesSentName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr, 100664248);
		NativeMethodInfoPtr_get_BytesSentPerSecName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr, 100664249);
		NativeMethodInfoPtr_get_BytesReceivedName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr, 100664250);
		NativeMethodInfoPtr_get_BytesReceivedPerSecName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr, 100664251);
		NativeMethodInfoPtr_get_MessagesSentName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr, 100664252);
		NativeMethodInfoPtr_get_MessagesReceivedName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr, 100664253);
		NativeMethodInfoPtr_get_NetworkedEntitiesName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkingStatistics>.NativeClassPtr, 100664254);
	}

	public NetworkingStatistics(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
