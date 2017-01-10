using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc4.Interfaces;
using static Xbim.Ifc4.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.PresentationAppearanceResource
{
	public partial class IfcBlobTexture : IExpressValidatable
	{
		public enum IfcBlobTextureClause
		{
			SupportedRasterFormat,
			RasterCodeByteStream,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcBlobTextureClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcBlobTextureClause.SupportedRasterFormat:
						retVal = NewArray("BMP", "JPG", "GIF", "PNG").Contains(this.RasterFormat);
						break;
					case IfcBlobTextureClause.RasterCodeByteStream:
						retVal = BLENGTH(RasterCode) % 8 == 0;
						break;
				}
			} catch (Exception ex) {
				var Log = LogManager.GetLogger("Xbim.Ifc4.PresentationAppearanceResource.IfcBlobTexture");
				Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcBlobTexture.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcBlobTextureClause.SupportedRasterFormat))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcBlobTexture.SupportedRasterFormat", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcBlobTextureClause.RasterCodeByteStream))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcBlobTexture.RasterCodeByteStream", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
