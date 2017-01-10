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
namespace Xbim.Ifc2x3.ConstraintResource
{
	public partial class IfcConstraintRelationship : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcConstraintRelationship clause) {
			var retVal = false;
			if (clause == Where.IfcConstraintRelationship.WR11) {
				try {
					retVal = SIZEOF(RelatedConstraints.Where(temp => Object.ReferenceEquals(temp, RelatingConstraint))) == 0;
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc2x3.ConstraintResource.IfcConstraintRelationship");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcConstraintRelationship.WR11' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			throw new ArgumentException(string.Format("Invalid clause specifier: '{0}'", clause));
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcConstraintRelationship.WR11))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcConstraintRelationship.WR11", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.Where
{
	public class IfcConstraintRelationship
	{
		public static readonly IfcConstraintRelationship WR11 = new IfcConstraintRelationship();
		protected IfcConstraintRelationship() {}
	}
}