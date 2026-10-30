using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace strange.extensions.sequencer.api;

public class ISequenceCommand : Il2CppObjectBase
{
	static ISequenceCommand()
	{
		Il2CppClassPointerStore<ISequenceCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.sequencer.api", "ISequenceCommand");
	}

	public ISequenceCommand(IntPtr pointer)
		: base(pointer)
	{
	}
}
