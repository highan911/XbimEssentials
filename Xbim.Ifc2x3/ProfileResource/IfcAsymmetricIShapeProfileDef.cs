// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProfileResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcAsymmetricIShapeProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAsymmetricIShapeProfileDef : IIfcIShapeProfileDef
	{
		IfcPositiveLengthMeasure @TopFlangeWidth { get; }
		IfcPositiveLengthMeasure? @TopFlangeThickness { get; }
		IfcPositiveLengthMeasure? @TopFlangeFilletRadius { get; }
		IfcPositiveLengthMeasure? @CentreOfGravityInY { get; }
	
	}
}

namespace Xbim.Ifc2x3.ProfileResource
{
	[ExpressType("IfcAsymmetricIShapeProfileDef", 672)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAsymmetricIShapeProfileDef : IfcIShapeProfileDef, IInstantiableEntity, IIfcAsymmetricIShapeProfileDef, IEquatable<@IfcAsymmetricIShapeProfileDef>
	{
		#region IIfcAsymmetricIShapeProfileDef explicit implementation
		IfcPositiveLengthMeasure IIfcAsymmetricIShapeProfileDef.TopFlangeWidth { get { return @TopFlangeWidth; } }	
		IfcPositiveLengthMeasure? IIfcAsymmetricIShapeProfileDef.TopFlangeThickness { get { return @TopFlangeThickness; } }	
		IfcPositiveLengthMeasure? IIfcAsymmetricIShapeProfileDef.TopFlangeFilletRadius { get { return @TopFlangeFilletRadius; } }	
		IfcPositiveLengthMeasure? IIfcAsymmetricIShapeProfileDef.CentreOfGravityInY { get { return @CentreOfGravityInY; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAsymmetricIShapeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _topFlangeWidth;
		private IfcPositiveLengthMeasure? _topFlangeThickness;
		private IfcPositiveLengthMeasure? _topFlangeFilletRadius;
		private IfcPositiveLengthMeasure? _centreOfGravityInY;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 9)]
		public IfcPositiveLengthMeasure @TopFlangeWidth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _topFlangeWidth;
				((IPersistEntity)this).Activate(false);
				return _topFlangeWidth;
			} 
			set
			{
				SetValue( v =>  _topFlangeWidth = v, _topFlangeWidth, value,  "TopFlangeWidth");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 10)]
		public IfcPositiveLengthMeasure? @TopFlangeThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _topFlangeThickness;
				((IPersistEntity)this).Activate(false);
				return _topFlangeThickness;
			} 
			set
			{
				SetValue( v =>  _topFlangeThickness = v, _topFlangeThickness, value,  "TopFlangeThickness");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 11)]
		public IfcPositiveLengthMeasure? @TopFlangeFilletRadius 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _topFlangeFilletRadius;
				((IPersistEntity)this).Activate(false);
				return _topFlangeFilletRadius;
			} 
			set
			{
				SetValue( v =>  _topFlangeFilletRadius = v, _topFlangeFilletRadius, value,  "TopFlangeFilletRadius");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public IfcPositiveLengthMeasure? @CentreOfGravityInY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _centreOfGravityInY;
				((IPersistEntity)this).Activate(false);
				return _centreOfGravityInY;
			} 
			set
			{
				SetValue( v =>  _centreOfGravityInY = v, _centreOfGravityInY, value,  "CentreOfGravityInY");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
					_topFlangeWidth = value.RealVal;
					return;
				case 9: 
					_topFlangeThickness = value.RealVal;
					return;
				case 10: 
					_topFlangeFilletRadius = value.RealVal;
					return;
				case 11: 
					_centreOfGravityInY = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAsymmetricIShapeProfileDef other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcAsymmetricIShapeProfileDef
            var root = (@IfcAsymmetricIShapeProfileDef)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcAsymmetricIShapeProfileDef left, @IfcAsymmetricIShapeProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcAsymmetricIShapeProfileDef left, @IfcAsymmetricIShapeProfileDef right)
        {
            return !(left == right);
        }

        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}