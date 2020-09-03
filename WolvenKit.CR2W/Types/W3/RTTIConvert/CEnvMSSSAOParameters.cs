using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvMSSSAOParameters : CVariable
	{
		[Ordinal(1)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("noiseFilterTolerance")] 		public SSimpleCurve NoiseFilterTolerance { get; set;}

		[Ordinal(3)] [RED("blurTolerance")] 		public SSimpleCurve BlurTolerance { get; set;}

		[Ordinal(4)] [RED("upsampleTolerance")] 		public SSimpleCurve UpsampleTolerance { get; set;}

		[Ordinal(5)] [RED("rejectionFalloff")] 		public SSimpleCurve RejectionFalloff { get; set;}

		[Ordinal(6)] [RED("combineResolutionsBeforeBlur")] 		public CBool CombineResolutionsBeforeBlur { get; set;}

		[Ordinal(7)] [RED("combineResolutionsWithMul")] 		public CBool CombineResolutionsWithMul { get; set;}

		[Ordinal(8)] [RED("hierarchyDepth")] 		public SSimpleCurve HierarchyDepth { get; set;}

		[Ordinal(9)] [RED("normalAOMultiply")] 		public SSimpleCurve NormalAOMultiply { get; set;}

		[Ordinal(10)] [RED("normalToDepthBrightnessEqualiser")] 		public SSimpleCurve NormalToDepthBrightnessEqualiser { get; set;}

		[Ordinal(11)] [RED("normalBackProjectionTolerance")] 		public SSimpleCurve NormalBackProjectionTolerance { get; set;}

		public CEnvMSSSAOParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvMSSSAOParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}