using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetBehVarOnScriptEvent : IBehTreeTask
	{
		[Ordinal(1)] [RED("activationEventName")] 		public CName ActivationEventName { get; set;}

		[Ordinal(2)] [RED("behVarName")] 		public CName BehVarName { get; set;}

		[Ordinal(3)] [RED("behVarValue")] 		public CFloat BehVarValue { get; set;}

		[Ordinal(4)] [RED("prevBehVarValue")] 		public CFloat PrevBehVarValue { get; set;}

		[Ordinal(5)] [RED("delay")] 		public CFloat Delay { get; set;}

		[Ordinal(6)] [RED("activationEventReceived")] 		public CBool ActivationEventReceived { get; set;}

		[Ordinal(7)] [RED("previousValueOnDurationEnd")] 		public CBool PreviousValueOnDurationEnd { get; set;}

		public CBTTaskSetBehVarOnScriptEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSetBehVarOnScriptEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}