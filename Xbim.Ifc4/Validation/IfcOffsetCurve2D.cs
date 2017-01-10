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
namespace Xbim.Ifc4.GeometryResource
{
	public partial class IfcOffsetCurve2D : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcOffsetCurve2D clause) {
			var retVal = false;
			if (clause == Where.IfcOffsetCurve2D.DimIs2D) {
				try {
					retVal = BasisCurve.Dim == 2;
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.GeometryResource.IfcOffsetCurve2D");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcOffsetCurve2D.DimIs2D' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			throw new ArgumentException(string.Format("Invalid clause specifier: '{0}'", clause));
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcOffsetCurve2D.DimIs2D))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcOffsetCurve2D.DimIs2D", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcOffsetCurve2D
	{
		public static readonly IfcOffsetCurve2D DimIs2D = new IfcOffsetCurve2D();
		protected IfcOffsetCurve2D() {}
	}
}