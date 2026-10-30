using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Unity.Netcode;
using Unity.Profiling;

public class TwoWayMessageHandler<TRequest, TResponse> : Il2CppSystem.Object where TRequest : new() where TResponse : new()
{
	[ObfuscatedName("TwoWayMessageHandler`2+<ReceiveMessage>d__23")]
	public sealed class _ReceiveMessage_d__23 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

		private static readonly System.IntPtr NativeFieldInfoPtr_reader;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_senderId;

		private static readonly System.IntPtr NativeFieldInfoPtr___u__1;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.AsyncVoidMethodBuilder __t__builder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
				return new Il2CppSystem.Runtime.CompilerServices.AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncVoidMethodBuilder>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncVoidMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncVoidMethodBuilder>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe FastBufferReader reader
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reader);
				return *(FastBufferReader*)num;
			}
			set
			{
				*(FastBufferReader*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reader)) = fastBufferReader;
			}
		}

		public unsafe TwoWayMessageHandler<TRequest, TResponse> __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TwoWayMessageHandler<TRequest, TResponse>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)twoWayMessageHandler));
			}
		}

		public unsafe int senderId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_senderId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_senderId)) = num;
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter __u__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1);
				return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static _ReceiveMessage_d__23()
		{
			Il2CppClassPointerStore<_ReceiveMessage_d__23>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, "<ReceiveMessage>d__23"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRequest>.NativeClassPtr)),
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_ReceiveMessage_d__23>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ReceiveMessage_d__23>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ReceiveMessage_d__23>.NativeClassPtr, "<>t__builder");
			NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ReceiveMessage_d__23>.NativeClassPtr, "reader");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ReceiveMessage_d__23>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_senderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ReceiveMessage_d__23>.NativeClassPtr, "senderId");
			NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ReceiveMessage_d__23>.NativeClassPtr, "<>u__1");
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ReceiveMessage_d__23>.NativeClassPtr, 100664198);
			NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ReceiveMessage_d__23>.NativeClassPtr, 100664199);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27717, XrefRangeEnd = 27744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _ReceiveMessage_d__23(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public _ReceiveMessage_d__23()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_ReceiveMessage_d__23>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_networkManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_messagingManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_requestCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeRequests;

	private static readonly System.IntPtr NativeFieldInfoPtr_receiveMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_receiveRequestCallbackMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_receiveResponseCallbackMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_sendResponseMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_sendRequestMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_networkMessageType;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeout;

	private static readonly System.IntPtr NativeFieldInfoPtr_requestReceiving;

	private static readonly System.IntPtr NativeFieldInfoPtr_responseReceiving;

	private static readonly System.IntPtr NativeFieldInfoPtr_messageDelivery;

	private static readonly System.IntPtr NativeFieldInfoPtr_logActivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_writer;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Byte_INetworkManager_MessagingManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRequest_Protected_Virtual_New_TRequest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResponse_Protected_Virtual_New_TResponse_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleRequest_Protected_Virtual_New_Task_1_TResponse_Int32_TRequest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleRequest_Protected_Abstract_Virtual_New_Task_Int32_Int32_FastBufferReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleResponse_Protected_Abstract_Virtual_New_Void_Int32_FastBufferReader_Int32_ActiveRequest_2_TRequest_TResponse_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_shouldProcessMessage_Private_Boolean_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Final_New_Void_Int32_FastBufferReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendResponse_Public_Void_Int32_Int32_Int32_TResponse_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendRequest_Public_Void_Int32_TRequest_Action_3_Int32_Int32_TResponse_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	public unsafe INetworkManager networkManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<INetworkManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager));
		}
	}

	public unsafe MessagingManager messagingManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messagingManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MessagingManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messagingManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messagingManager));
		}
	}

	public unsafe Il2CppSystem.Action<int, int, TRequest> requestCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requestCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int, int, TRequest>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requestCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Dictionary<int, ActiveRequest<TRequest, TResponse>> activeRequests
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeRequests);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, ActiveRequest<TRequest, TResponse>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeRequests)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe ProfilerMarker receiveMarker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiveMarker);
			return *(ProfilerMarker*)num;
		}
		set
		{
			*(ProfilerMarker*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiveMarker)) = profilerMarker;
		}
	}

	public unsafe ProfilerMarker receiveRequestCallbackMarker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiveRequestCallbackMarker);
			return *(ProfilerMarker*)num;
		}
		set
		{
			*(ProfilerMarker*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiveRequestCallbackMarker)) = profilerMarker;
		}
	}

	public unsafe ProfilerMarker receiveResponseCallbackMarker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiveResponseCallbackMarker);
			return *(ProfilerMarker*)num;
		}
		set
		{
			*(ProfilerMarker*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiveResponseCallbackMarker)) = profilerMarker;
		}
	}

	public unsafe ProfilerMarker sendResponseMarker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sendResponseMarker);
			return *(ProfilerMarker*)num;
		}
		set
		{
			*(ProfilerMarker*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sendResponseMarker)) = profilerMarker;
		}
	}

	public unsafe ProfilerMarker sendRequestMarker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sendRequestMarker);
			return *(ProfilerMarker*)num;
		}
		set
		{
			*(ProfilerMarker*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sendRequestMarker)) = profilerMarker;
		}
	}

	public unsafe byte networkMessageType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkMessageType);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkMessageType)) = b;
		}
	}

	public unsafe float timeout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeout);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeout)) = num;
		}
	}

	public unsafe MessageHandlerReceiving requestReceiving
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requestReceiving);
			return *(MessageHandlerReceiving*)num;
		}
		set
		{
			*(MessageHandlerReceiving*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requestReceiving)) = messageHandlerReceiving;
		}
	}

	public unsafe MessageHandlerReceiving responseReceiving
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_responseReceiving);
			return *(MessageHandlerReceiving*)num;
		}
		set
		{
			*(MessageHandlerReceiving*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_responseReceiving)) = messageHandlerReceiving;
		}
	}

	public unsafe MessageDelivery messageDelivery
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageDelivery);
			return *(MessageDelivery*)num;
		}
		set
		{
			*(MessageDelivery*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageDelivery)) = messageDelivery;
		}
	}

	public unsafe bool logActivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logActivity);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logActivity)) = flag;
		}
	}

	public unsafe FastBufferWriter writer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writer);
			return *(FastBufferWriter*)num;
		}
		set
		{
			*(FastBufferWriter*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writer)) = fastBufferWriter;
		}
	}

	static TwoWayMessageHandler()
	{
		Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Scripts.dll", "", "TwoWayMessageHandler`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRequest>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr);
		NativeFieldInfoPtr_networkManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, "networkManager");
		NativeFieldInfoPtr_messagingManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, "messagingManager");
		NativeFieldInfoPtr_requestCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, "requestCallback");
		NativeFieldInfoPtr_activeRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, "activeRequests");
		NativeFieldInfoPtr_receiveMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, "receiveMarker");
		NativeFieldInfoPtr_receiveRequestCallbackMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, "receiveRequestCallbackMarker");
		NativeFieldInfoPtr_receiveResponseCallbackMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, "receiveResponseCallbackMarker");
		NativeFieldInfoPtr_sendResponseMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, "sendResponseMarker");
		NativeFieldInfoPtr_sendRequestMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, "sendRequestMarker");
		NativeFieldInfoPtr_networkMessageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, "networkMessageType");
		NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, "timeout");
		NativeFieldInfoPtr_requestReceiving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, "requestReceiving");
		NativeFieldInfoPtr_responseReceiving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, "responseReceiving");
		NativeFieldInfoPtr_messageDelivery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, "messageDelivery");
		NativeFieldInfoPtr_logActivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, "logActivity");
		NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, "writer");
		NativeMethodInfoPtr__ctor_Protected_Void_Byte_INetworkManager_MessagingManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, 100664187);
		NativeMethodInfoPtr_GetRequest_Protected_Virtual_New_TRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, 100664188);
		NativeMethodInfoPtr_GetResponse_Protected_Virtual_New_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, 100664189);
		NativeMethodInfoPtr_HandleRequest_Protected_Virtual_New_Task_1_TResponse_Int32_TRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, 100664190);
		NativeMethodInfoPtr_handleRequest_Protected_Abstract_Virtual_New_Task_Int32_Int32_FastBufferReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, 100664191);
		NativeMethodInfoPtr_handleResponse_Protected_Abstract_Virtual_New_Void_Int32_FastBufferReader_Int32_ActiveRequest_2_TRequest_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, 100664192);
		NativeMethodInfoPtr_shouldProcessMessage_Private_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, 100664193);
		NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Final_New_Void_Int32_FastBufferReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, 100664194);
		NativeMethodInfoPtr_SendResponse_Public_Void_Int32_Int32_Int32_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, 100664195);
		NativeMethodInfoPtr_SendRequest_Public_Void_Int32_TRequest_Action_3_Int32_Int32_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, 100664196);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr, 100664197);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27744, XrefRangeEnd = 27783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TwoWayMessageHandler(byte networkMessageType, INetworkManager networkManager, MessagingManager messagingManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwoWayMessageHandler<TRequest, TResponse>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&networkMessageType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messagingManager);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_Byte_INetworkManager_MessagingManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual TRequest GetRequest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRequest_Protected_Virtual_New_TRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<TRequest>(intPtr, false, true);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 27783, RefRangeEnd = 27926, XrefRangeStart = 27783, XrefRangeEnd = 27783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual TResponse GetResponse()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetResponse_Protected_Virtual_New_TResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<TResponse>(intPtr, false, true);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Task<TResponse> HandleRequest(int clientId, TRequest request)
	{
		//IL_005a->IL005d: Incompatible stack types: I vs Ref
		//IL_004d->IL005d: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&clientId);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TRequest reference;
		if (!typeof(TRequest).IsValueType)
		{
			object obj = request;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref request;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleRequest_Protected_Virtual_New_Task_1_TResponse_Int32_TRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<TResponse>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Task handleRequest(int senderId, int requestId, FastBufferReader reader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&senderId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &requestId;
		*(FastBufferReader**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &reader;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_handleRequest_Protected_Abstract_Virtual_New_Task_Int32_Int32_FastBufferReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void handleResponse(int senderId, FastBufferReader reader, int resultCode, ActiveRequest<TRequest, TResponse> activeRequest)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&senderId);
		*(FastBufferReader**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reader;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &resultCode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)activeRequest));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_handleResponse_Protected_Abstract_Virtual_New_Void_Int32_FastBufferReader_Int32_ActiveRequest_2_TRequest_TResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27926, XrefRangeEnd = 27927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool shouldProcessMessage(byte messageType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&messageType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_shouldProcessMessage_Private_Boolean_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27927, XrefRangeEnd = 27931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ReceiveMessage(int senderId, FastBufferReader reader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&senderId);
		*(FastBufferReader**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reader;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Final_New_Void_Int32_FastBufferReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 27967, RefRangeEnd = 27968, XrefRangeStart = 27931, XrefRangeEnd = 27967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendResponse(int toClientId, int requestId, int resultCode, TResponse data = default(TResponse))
	{
		//IL_0077->IL007a: Incompatible stack types: I vs Ref
		//IL_006a->IL007a: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&toClientId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &requestId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &resultCode;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TResponse reference;
		if (!typeof(TResponse).IsValueType)
		{
			object obj = data;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref data;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendResponse_Public_Void_Int32_Int32_Int32_TResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 28002, RefRangeEnd = 28003, XrefRangeStart = 27968, XrefRangeEnd = 28002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendRequest(int toClientId, TRequest data, Il2CppSystem.Action<int, int, TResponse> callback)
	{
		//IL_005a->IL005d: Incompatible stack types: I vs Ref
		//IL_004d->IL005d: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&toClientId);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TRequest reference;
		if (!typeof(TRequest).IsValueType)
		{
			object obj = data;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref data;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendRequest_Public_Void_Int32_TRequest_Action_3_Int32_Int32_TResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28003, XrefRangeEnd = 28015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TwoWayMessageHandler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
