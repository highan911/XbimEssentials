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
namespace Xbim.Ifc2x3.Kernel
{
	public partial class IfcRelNests : IExpressValidatable
	{
		public enum IfcRelNestsClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcRelNestsClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcRelNestsClause.WR1:
						retVal = SIZEOF(this/* as IfcRelDecomposes*/.RelatedObjects.Where(Temp => !(TYPEOF(this/* as IfcRelDecomposes*/.RelatingObject) == TYPEOF(Temp)))) == 0;
						break;
				}
			} catch (Exception ex) {
				var Log = LogManager.GetLogger("Xbim.Ifc2x3.Kernel.IfcRelNests");
				Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcRelNests.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcRelNestsClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRelNests.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
