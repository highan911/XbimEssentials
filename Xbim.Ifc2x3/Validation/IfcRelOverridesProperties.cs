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
	public partial class IfcRelOverridesProperties : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcRelOverridesProperties clause) {
			var retVal = false;
			if (clause == Where.IfcRelOverridesProperties.WR1) {
				try {
					retVal = SIZEOF(this/* as IfcRelDefines*/.RelatedObjects) == 1;
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc2x3.Kernel.IfcRelOverridesProperties");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcRelOverridesProperties.WR1' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			throw new ArgumentException(string.Format("Invalid clause specifier: '{0}'", clause));
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcRelOverridesProperties.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRelOverridesProperties.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.Where
{
	public class IfcRelOverridesProperties
	{
		public static readonly IfcRelOverridesProperties WR1 = new IfcRelOverridesProperties();
		protected IfcRelOverridesProperties() {}
	}
}