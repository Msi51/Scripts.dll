using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class IMapExplorer : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetChunkExploration_Public_Abstract_Virtual_New_ChunkExplorationData_Coordinates_0;

	static IMapExplorer()
	{
		Il2CppClassPointerStore<IMapExplorer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IMapExplorer");
		NativeMethodInfoPtr_GetChunkExploration_Public_Abstract_Virtual_New_ChunkExplorationData_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMapExplorer>.NativeClassPtr, 100681768);
	}

	[CallerCount(0)]
	public unsafe virtual ChunkExplorationData GetChunkExploration(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetChunkExploration_Public_Abstract_Virtual_New_ChunkExplorationData_Coordinates_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ChunkExplorationData>(intPtr) : null;
	}

	public IMapExplorer(IntPtr pointer)
		: base(pointer)
	{
	}
}
