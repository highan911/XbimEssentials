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
	public partial class IfcBeamType : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcBeamType clause) {
			var retVal = false;
			if (clause == Where.IfcBeamType.CorrectPredefinedType) {
				try {
					retVal = (PredefinedType != IfcBeamTypeEnum.USERDEFINED) || ((PredefinedType == IfcBeamTypeEnum.USERDEFINED) && EXISTS(this/* as IfcElementType*/.ElementType));
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.SharedBldgElements.IfcBeamType");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcBeamType.CorrectPredefinedType' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			return base.ValidateClause((Where.IfcTypeProduct)clause);
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(Where.IfcBeamType.CorrectPredefinedType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcBeamType.CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcBeamType : IfcTypeProduct
	{
		public static readonly IfcBeamType CorrectPredefinedType = new IfcBeamType();
		protected IfcBeamType() {}
	}
}