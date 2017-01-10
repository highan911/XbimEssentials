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
namespace Xbim.Ifc4.SharedBldgElements
{
	public partial class IfcWallElementedCase : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcWallElementedCase clause) {
			var retVal = false;
			if (clause == Where.IfcWallElementedCase.HasDecomposition) {
				try {
					retVal = HIINDEX(this/* as IfcObjectDefinition*/.IsDecomposedBy) > 0;
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.SharedBldgElements.IfcWallElementedCase");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcWallElementedCase.HasDecomposition' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			return base.ValidateClause((Where.IfcWall)clause);
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(Where.IfcWallElementedCase.HasDecomposition))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcWallElementedCase.HasDecomposition", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcWallElementedCase : IfcWall
	{
		public static readonly IfcWallElementedCase HasDecomposition = new IfcWallElementedCase();
		protected IfcWallElementedCase() {}
	}
}