using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.ProfileResource;
using Xbim.Ifc2x3.ProfilePropertyResource;
using static Xbim.Ifc2x3.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class IfcRelContainedInSpatialStructure : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcRelContainedInSpatialStructure clause) {
			var retVal = false;
			if (clause == Where.IfcRelContainedInSpatialStructure.WR31) {
				try {
					retVal = SIZEOF(RelatedElements.Where(temp => TYPEOF(temp).Contains("IFC2X3.IFCSPATIALSTRUCTUREELEMENT"))) == 0;
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc2x3.ProductExtension.IfcRelContainedInSpatialStructure");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcRelContainedInSpatialStructure.WR31' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			throw new ArgumentException(string.Format("Invalid clause specifier: '{0}'", clause));
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcRelContainedInSpatialStructure.WR31))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRelContainedInSpatialStructure.WR31", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.Where
{
	public class IfcRelContainedInSpatialStructure
	{
		public static readonly IfcRelContainedInSpatialStructure WR31 = new IfcRelContainedInSpatialStructure();
		protected IfcRelContainedInSpatialStructure() {}
	}
}