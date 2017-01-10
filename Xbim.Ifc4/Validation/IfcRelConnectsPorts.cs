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
namespace Xbim.Ifc4.ProductExtension
{
	public partial class IfcRelConnectsPorts : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcRelConnectsPorts clause) {
			var retVal = false;
			if (clause == Where.IfcRelConnectsPorts.NoSelfReference) {
				try {
					retVal = !Object.ReferenceEquals(RelatingPort, RelatedPort);
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.ProductExtension.IfcRelConnectsPorts");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcRelConnectsPorts.NoSelfReference' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			throw new ArgumentException(string.Format("Invalid clause specifier: '{0}'", clause));
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcRelConnectsPorts.NoSelfReference))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRelConnectsPorts.NoSelfReference", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcRelConnectsPorts
	{
		public static readonly IfcRelConnectsPorts NoSelfReference = new IfcRelConnectsPorts();
		protected IfcRelConnectsPorts() {}
	}
}