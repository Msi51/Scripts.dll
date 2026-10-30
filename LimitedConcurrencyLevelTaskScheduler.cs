using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;

public class LimitedConcurrencyLevelTaskScheduler : TaskScheduler
{
	private static readonly System.IntPtr NativeFieldInfoPtr__currentThreadIsProcessingItems;

	private static readonly System.IntPtr NativeFieldInfoPtr__tasks;

	private static readonly System.IntPtr NativeFieldInfoPtr__maxDegreeOfParallelism;

	private static readonly System.IntPtr NativeFieldInfoPtr__delegatesQueuedOrRunning;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueTask_Protected_Virtual_Final_Void_Task_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyThreadPoolOfPendingWork_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Virtual_Final_Boolean_Task_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryDequeue_Protected_Virtual_Final_Boolean_Task_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MaximumConcurrencyLevel_Public_Virtual_Final_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScheduledTasks_Protected_Virtual_Final_IEnumerable_1_Task_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__NotifyThreadPoolOfPendingWork_b__6_0_Private_Void_Object_0;

	public unsafe static bool _currentThreadIsProcessingItems
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__currentThreadIsProcessingItems, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__currentThreadIsProcessingItems, (void*)(&flag));
		}
	}

	public unsafe LinkedList<Task> _tasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tasks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LinkedList<Task>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tasks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)linkedList));
		}
	}

	public unsafe int _maxDegreeOfParallelism
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxDegreeOfParallelism);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxDegreeOfParallelism)) = num;
		}
	}

	public unsafe int _delegatesQueuedOrRunning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__delegatesQueuedOrRunning);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__delegatesQueuedOrRunning)) = num;
		}
	}

	public unsafe override int MaximumConcurrencyLevel
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32451, RefRangeEnd = 32452, XrefRangeStart = 32451, XrefRangeEnd = 32451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaximumConcurrencyLevel_Public_Virtual_Final_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static LimitedConcurrencyLevelTaskScheduler()
	{
		Il2CppClassPointerStore<LimitedConcurrencyLevelTaskScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "LimitedConcurrencyLevelTaskScheduler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LimitedConcurrencyLevelTaskScheduler>.NativeClassPtr);
		NativeFieldInfoPtr__currentThreadIsProcessingItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LimitedConcurrencyLevelTaskScheduler>.NativeClassPtr, "_currentThreadIsProcessingItems");
		NativeFieldInfoPtr__tasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LimitedConcurrencyLevelTaskScheduler>.NativeClassPtr, "_tasks");
		NativeFieldInfoPtr__maxDegreeOfParallelism = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LimitedConcurrencyLevelTaskScheduler>.NativeClassPtr, "_maxDegreeOfParallelism");
		NativeFieldInfoPtr__delegatesQueuedOrRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LimitedConcurrencyLevelTaskScheduler>.NativeClassPtr, "_delegatesQueuedOrRunning");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedConcurrencyLevelTaskScheduler>.NativeClassPtr, 100664557);
		NativeMethodInfoPtr_QueueTask_Protected_Virtual_Final_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedConcurrencyLevelTaskScheduler>.NativeClassPtr, 100664558);
		NativeMethodInfoPtr_NotifyThreadPoolOfPendingWork_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedConcurrencyLevelTaskScheduler>.NativeClassPtr, 100664559);
		NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Virtual_Final_Boolean_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedConcurrencyLevelTaskScheduler>.NativeClassPtr, 100664560);
		NativeMethodInfoPtr_TryDequeue_Protected_Virtual_Final_Boolean_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedConcurrencyLevelTaskScheduler>.NativeClassPtr, 100664561);
		NativeMethodInfoPtr_get_MaximumConcurrencyLevel_Public_Virtual_Final_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedConcurrencyLevelTaskScheduler>.NativeClassPtr, 100664562);
		NativeMethodInfoPtr_GetScheduledTasks_Protected_Virtual_Final_IEnumerable_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedConcurrencyLevelTaskScheduler>.NativeClassPtr, 100664563);
		NativeMethodInfoPtr__NotifyThreadPoolOfPendingWork_b__6_0_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedConcurrencyLevelTaskScheduler>.NativeClassPtr, 100664564);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32416, RefRangeEnd = 32417, XrefRangeStart = 32405, XrefRangeEnd = 32416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LimitedConcurrencyLevelTaskScheduler(int maxDegreeOfParallelism)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LimitedConcurrencyLevelTaskScheduler>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maxDegreeOfParallelism);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32417, XrefRangeEnd = 32431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void QueueTask(Task task)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueTask_Protected_Virtual_Final_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32431, XrefRangeEnd = 32439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NotifyThreadPoolOfPendingWork()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyThreadPoolOfPendingWork_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32439, XrefRangeEnd = 32444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &taskWasPreviouslyQueued;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Virtual_Final_Boolean_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32444, XrefRangeEnd = 32451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool TryDequeue(Task task)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryDequeue_Protected_Virtual_Final_Boolean_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32452, XrefRangeEnd = 32456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerable<Task> GetScheduledTasks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScheduledTasks_Protected_Virtual_Final_IEnumerable_1_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<Task>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32456, XrefRangeEnd = 32477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _NotifyThreadPoolOfPendingWork_b__6_0(Il2CppSystem.Object _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__NotifyThreadPoolOfPendingWork_b__6_0_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LimitedConcurrencyLevelTaskScheduler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
