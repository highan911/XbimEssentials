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
namespace Xbim.Ifc2x3.MeasureResource
{
	public partial class IfcUnitAssignment : IExpressValidatable
	{
		public enum IfcUnitAssignmentClause
		{
			WR01,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcUnitAssignmentClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcUnitAssignmentClause.WR01:
						retVal = IfcCorrectUnitAssignment(Units);
						break;
				}
			} catch (Exception ex) {
				var Log = LogManager.GetLogger("Xbim.Ifc2x3.MeasureResource.IfcUnitAssignment");
				Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcUnitAssignment.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcUnitAssignmentClause.WR01))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcUnitAssignment.WR01", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
