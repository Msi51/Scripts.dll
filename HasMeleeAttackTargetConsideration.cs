using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using strange.extensions.injector.api;

public class HasMeleeAttackTargetConsideration : AIConsideration<AttackTargetResult>
{
	private static readonly IntPtr NativeFieldInfoPtr_characterManager;

	private static readonly IntPtr NativeFieldInfoPtr_creatureManager;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IInjectionBinder_0;

	private static readonly IntPtr NativeMethodInfoPtr_ComputeResult_Protected_Virtual_AttackTargetResult_AIContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_AttackTargetResult_0;

	private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_HasMeleeAttackTargetConsideration_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ICharacterManager characterManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ICharacterManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterManager));
		}
	}

	public unsafe ICreatureManager creatureManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creatureManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ICreatureManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creatureManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)creatureManager));
		}
	}

	static HasMeleeAttackTargetConsideration()
	{
		Il2CppClassPointerStore<HasMeleeAttackTargetConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "HasMeleeAttackTargetConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasMeleeAttackTargetConsideration>.NativeClassPtr);
		NativeFieldInfoPtr_characterManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasMeleeAttackTargetConsideration>.NativeClassPtr, "characterManager");
		NativeFieldInfoPtr_creatureManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasMeleeAttackTargetConsideration>.NativeClassPtr, "creatureManager");
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasMeleeAttackTargetConsideration>.NativeClassPtr, 100668292);
		NativeMethodInfoPtr_ComputeResult_Protected_Virtual_AttackTargetResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasMeleeAttackTargetConsideration>.NativeClassPtr, 100668293);
		NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_AttackTargetResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasMeleeAttackTargetConsideration>.NativeClassPtr, 100668294);
		NativeMethodInfoPtr_New_Public_Static_HasMeleeAttackTargetConsideration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasMeleeAttackTargetConsideration>.NativeClassPtr, 100668295);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasMeleeAttackTargetConsideration>.NativeClassPtr, 100668296);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89629, XrefRangeEnd = 89638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize(IInjectionBinder binder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binder);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IInjectionBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89638, XrefRangeEnd = 89639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override AttackTargetResult ComputeResult(AIContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ComputeResult_Protected_Virtual_AttackTargetResult_AIContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new AttackTargetResult(pointer);
	}

	[CallerCount(0)]
	public unsafe override float Score(AIContext ctx, AttackTargetResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_AttackTargetResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89639, XrefRangeEnd = 89645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HasMeleeAttackTargetConsideration New()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_New_Public_Static_HasMeleeAttackTargetConsideration_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HasMeleeAttackTargetConsideration>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 89648, RefRangeEnd = 89650, XrefRangeStart = 89645, XrefRangeEnd = 89648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HasMeleeAttackTargetConsideration()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasMeleeAttackTargetConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HasMeleeAttackTargetConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}
