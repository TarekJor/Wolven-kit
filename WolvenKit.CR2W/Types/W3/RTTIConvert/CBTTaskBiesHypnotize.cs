using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskBiesHypnotize : CBTTask3StateAttack
	{
		[Ordinal(1)] [RED("cameraIndex")] 		public CInt32 CameraIndex { get; set;}

		[Ordinal(2)] [RED("ignoreConeCheck")] 		public CBool IgnoreConeCheck { get; set;}

		[Ordinal(3)] [RED("done")] 		public CBool Done { get; set;}

		public CBTTaskBiesHypnotize(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskBiesHypnotize(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}