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
namespace Xbim.Ifc4.QuantityResource
{
	public partial class IfcPhysicalComplexQuantity : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcPhysicalComplexQuantity clause) {
			var retVal = false;
			if (clause == Where.IfcPhysicalComplexQuantity.NoSelfReference) {
				try {
					retVal = SIZEOF(HasQuantities.Where(temp => Object.ReferenceEquals(this, temp))) == 0;
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.QuantityResource.IfcPhysicalComplexQuantity");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcPhysicalComplexQuantity.NoSelfReference' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			if (clause == Where.IfcPhysicalComplexQuantity.UniqueQuantityNames) {
				try {
					retVal = IfcUniqueQuantityNames(HasQuantities);
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.QuantityResource.IfcPhysicalComplexQuantity");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcPhysicalComplexQuantity.UniqueQuantityNames' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			throw new ArgumentException(string.Format("Invalid clause specifier: '{0}'", clause));
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcPhysicalComplexQuantity.NoSelfReference))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPhysicalComplexQuantity.NoSelfReference", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(Where.IfcPhysicalComplexQuantity.UniqueQuantityNames))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPhysicalComplexQuantity.UniqueQuantityNames", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcPhysicalComplexQuantity
	{
		public static readonly IfcPhysicalComplexQuantity NoSelfReference = new IfcPhysicalComplexQuantity();
		public static readonly IfcPhysicalComplexQuantity UniqueQuantityNames = new IfcPhysicalComplexQuantity();
		protected IfcPhysicalComplexQuantity() {}
	}
}