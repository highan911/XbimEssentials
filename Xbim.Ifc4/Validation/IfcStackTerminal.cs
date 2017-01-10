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
namespace Xbim.Ifc4.PlumbingFireProtectionDomain
{
	public partial class IfcStackTerminal : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcStackTerminal clause) {
			var retVal = false;
			if (clause == Where.IfcStackTerminal.CorrectPredefinedType) {
				try {
					retVal = !(EXISTS(PredefinedType)) || (PredefinedType != IfcStackTerminalTypeEnum.USERDEFINED) || ((PredefinedType == IfcStackTerminalTypeEnum.USERDEFINED) && EXISTS(this/* as IfcObject*/.ObjectType));
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.PlumbingFireProtectionDomain.IfcStackTerminal");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcStackTerminal.CorrectPredefinedType' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			if (clause == Where.IfcStackTerminal.CorrectTypeAssigned) {
				try {
					retVal = (SIZEOF(IsTypedBy) == 0) || (TYPEOF(this/* as IfcObject*/.IsTypedBy.ItemAt(0).RelatingType).Contains("IFC4.IFCSTACKTERMINALTYPE"));
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.PlumbingFireProtectionDomain.IfcStackTerminal");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcStackTerminal.CorrectTypeAssigned' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			return base.ValidateClause((Where.IfcProduct)clause);
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(Where.IfcStackTerminal.CorrectPredefinedType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcStackTerminal.CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(Where.IfcStackTerminal.CorrectTypeAssigned))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcStackTerminal.CorrectTypeAssigned", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcStackTerminal : IfcProduct
	{
		public static readonly IfcStackTerminal CorrectPredefinedType = new IfcStackTerminal();
		public static readonly IfcStackTerminal CorrectTypeAssigned = new IfcStackTerminal();
		protected IfcStackTerminal() {}
	}
}