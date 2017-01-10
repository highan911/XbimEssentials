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
namespace Xbim.Ifc4.PresentationAppearanceResource
{
	public partial class IfcTextStyleFontModel : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcTextStyleFontModel clause) {
			var retVal = false;
			if (clause == Where.IfcTextStyleFontModel.MeasureOfFontSize) {
				try {
					retVal = (TYPEOF(this.FontSize).Contains("IFC4.IFCLENGTHMEASURE")) && (this.FontSize.AsIfcLengthMeasure() > 0);
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.PresentationAppearanceResource.IfcTextStyleFontModel");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcTextStyleFontModel.MeasureOfFontSize' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			throw new ArgumentException(string.Format("Invalid clause specifier: '{0}'", clause));
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcTextStyleFontModel.MeasureOfFontSize))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcTextStyleFontModel.MeasureOfFontSize", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcTextStyleFontModel
	{
		public static readonly IfcTextStyleFontModel MeasureOfFontSize = new IfcTextStyleFontModel();
		protected IfcTextStyleFontModel() {}
	}
}