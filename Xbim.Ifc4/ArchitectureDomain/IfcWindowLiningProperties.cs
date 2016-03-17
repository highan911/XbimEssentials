// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.RepresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ArchitectureDomain;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcWindowLiningProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcWindowLiningProperties : IIfcPreDefinedPropertySet
	{
		IfcPositiveLengthMeasure? @LiningDepth { get; }
		IfcNonNegativeLengthMeasure? @LiningThickness { get; }
		IfcNonNegativeLengthMeasure? @TransomThickness { get; }
		IfcNonNegativeLengthMeasure? @MullionThickness { get; }
		IfcNormalisedRatioMeasure? @FirstTransomOffset { get; }
		IfcNormalisedRatioMeasure? @SecondTransomOffset { get; }
		IfcNormalisedRatioMeasure? @FirstMullionOffset { get; }
		IfcNormalisedRatioMeasure? @SecondMullionOffset { get; }
		IIfcShapeAspect @ShapeAspectStyle { get; }
		IfcLengthMeasure? @LiningOffset { get; }
		IfcLengthMeasure? @LiningToPanelOffsetX { get; }
		IfcLengthMeasure? @LiningToPanelOffsetY { get; }
	
	}
}

namespace Xbim.Ifc4.ArchitectureDomain
{
	[ExpressType("IfcWindowLiningProperties", 252)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWindowLiningProperties : IfcPreDefinedPropertySet, IInstantiableEntity, IIfcWindowLiningProperties, IEquatable<@IfcWindowLiningProperties>
	{
		#region IIfcWindowLiningProperties explicit implementation
		IfcPositiveLengthMeasure? IIfcWindowLiningProperties.LiningDepth { get { return @LiningDepth; } }	
		IfcNonNegativeLengthMeasure? IIfcWindowLiningProperties.LiningThickness { get { return @LiningThickness; } }	
		IfcNonNegativeLengthMeasure? IIfcWindowLiningProperties.TransomThickness { get { return @TransomThickness; } }	
		IfcNonNegativeLengthMeasure? IIfcWindowLiningProperties.MullionThickness { get { return @MullionThickness; } }	
		IfcNormalisedRatioMeasure? IIfcWindowLiningProperties.FirstTransomOffset { get { return @FirstTransomOffset; } }	
		IfcNormalisedRatioMeasure? IIfcWindowLiningProperties.SecondTransomOffset { get { return @SecondTransomOffset; } }	
		IfcNormalisedRatioMeasure? IIfcWindowLiningProperties.FirstMullionOffset { get { return @FirstMullionOffset; } }	
		IfcNormalisedRatioMeasure? IIfcWindowLiningProperties.SecondMullionOffset { get { return @SecondMullionOffset; } }	
		IIfcShapeAspect IIfcWindowLiningProperties.ShapeAspectStyle { get { return @ShapeAspectStyle; } }	
		IfcLengthMeasure? IIfcWindowLiningProperties.LiningOffset { get { return @LiningOffset; } }	
		IfcLengthMeasure? IIfcWindowLiningProperties.LiningToPanelOffsetX { get { return @LiningToPanelOffsetX; } }	
		IfcLengthMeasure? IIfcWindowLiningProperties.LiningToPanelOffsetY { get { return @LiningToPanelOffsetY; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWindowLiningProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _liningDepth;
		private IfcNonNegativeLengthMeasure? _liningThickness;
		private IfcNonNegativeLengthMeasure? _transomThickness;
		private IfcNonNegativeLengthMeasure? _mullionThickness;
		private IfcNormalisedRatioMeasure? _firstTransomOffset;
		private IfcNormalisedRatioMeasure? _secondTransomOffset;
		private IfcNormalisedRatioMeasure? _firstMullionOffset;
		private IfcNormalisedRatioMeasure? _secondMullionOffset;
		private IfcShapeAspect _shapeAspectStyle;
		private IfcLengthMeasure? _liningOffset;
		private IfcLengthMeasure? _liningToPanelOffsetX;
		private IfcLengthMeasure? _liningToPanelOffsetY;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 10)]
		public IfcPositiveLengthMeasure? @LiningDepth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _liningDepth;
				((IPersistEntity)this).Activate(false);
				return _liningDepth;
			} 
			set
			{
				SetValue( v =>  _liningDepth = v, _liningDepth, value,  "LiningDepth");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 11)]
		public IfcNonNegativeLengthMeasure? @LiningThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _liningThickness;
				((IPersistEntity)this).Activate(false);
				return _liningThickness;
			} 
			set
			{
				SetValue( v =>  _liningThickness = v, _liningThickness, value,  "LiningThickness");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public IfcNonNegativeLengthMeasure? @TransomThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _transomThickness;
				((IPersistEntity)this).Activate(false);
				return _transomThickness;
			} 
			set
			{
				SetValue( v =>  _transomThickness = v, _transomThickness, value,  "TransomThickness");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 13)]
		public IfcNonNegativeLengthMeasure? @MullionThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _mullionThickness;
				((IPersistEntity)this).Activate(false);
				return _mullionThickness;
			} 
			set
			{
				SetValue( v =>  _mullionThickness = v, _mullionThickness, value,  "MullionThickness");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 14)]
		public IfcNormalisedRatioMeasure? @FirstTransomOffset 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _firstTransomOffset;
				((IPersistEntity)this).Activate(false);
				return _firstTransomOffset;
			} 
			set
			{
				SetValue( v =>  _firstTransomOffset = v, _firstTransomOffset, value,  "FirstTransomOffset");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 15)]
		public IfcNormalisedRatioMeasure? @SecondTransomOffset 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _secondTransomOffset;
				((IPersistEntity)this).Activate(false);
				return _secondTransomOffset;
			} 
			set
			{
				SetValue( v =>  _secondTransomOffset = v, _secondTransomOffset, value,  "SecondTransomOffset");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 16)]
		public IfcNormalisedRatioMeasure? @FirstMullionOffset 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _firstMullionOffset;
				((IPersistEntity)this).Activate(false);
				return _firstMullionOffset;
			} 
			set
			{
				SetValue( v =>  _firstMullionOffset = v, _firstMullionOffset, value,  "FirstMullionOffset");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 17)]
		public IfcNormalisedRatioMeasure? @SecondMullionOffset 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _secondMullionOffset;
				((IPersistEntity)this).Activate(false);
				return _secondMullionOffset;
			} 
			set
			{
				SetValue( v =>  _secondMullionOffset = v, _secondMullionOffset, value,  "SecondMullionOffset");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 18)]
		public IfcShapeAspect @ShapeAspectStyle 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _shapeAspectStyle;
				((IPersistEntity)this).Activate(false);
				return _shapeAspectStyle;
			} 
			set
			{
				SetValue( v =>  _shapeAspectStyle = v, _shapeAspectStyle, value,  "ShapeAspectStyle");
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 19)]
		public IfcLengthMeasure? @LiningOffset 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _liningOffset;
				((IPersistEntity)this).Activate(false);
				return _liningOffset;
			} 
			set
			{
				SetValue( v =>  _liningOffset = v, _liningOffset, value,  "LiningOffset");
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 20)]
		public IfcLengthMeasure? @LiningToPanelOffsetX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _liningToPanelOffsetX;
				((IPersistEntity)this).Activate(false);
				return _liningToPanelOffsetX;
			} 
			set
			{
				SetValue( v =>  _liningToPanelOffsetX = v, _liningToPanelOffsetX, value,  "LiningToPanelOffsetX");
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 21)]
		public IfcLengthMeasure? @LiningToPanelOffsetY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _liningToPanelOffsetY;
				((IPersistEntity)this).Activate(false);
				return _liningToPanelOffsetY;
			} 
			set
			{
				SetValue( v =>  _liningToPanelOffsetY = v, _liningToPanelOffsetY, value,  "LiningToPanelOffsetY");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_liningDepth = value.RealVal;
					return;
				case 5: 
					_liningThickness = value.RealVal;
					return;
				case 6: 
					_transomThickness = value.RealVal;
					return;
				case 7: 
					_mullionThickness = value.RealVal;
					return;
				case 8: 
					_firstTransomOffset = value.RealVal;
					return;
				case 9: 
					_secondTransomOffset = value.RealVal;
					return;
				case 10: 
					_firstMullionOffset = value.RealVal;
					return;
				case 11: 
					_secondMullionOffset = value.RealVal;
					return;
				case 12: 
					_shapeAspectStyle = (IfcShapeAspect)(value.EntityVal);
					return;
				case 13: 
					_liningOffset = value.RealVal;
					return;
				case 14: 
					_liningToPanelOffsetX = value.RealVal;
					return;
				case 15: 
					_liningToPanelOffsetY = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:	WR31 : NOT(EXISTS(LiningDepth) AND NOT(EXISTS(LiningThickness)));*/
		/*WR32:	WR32 : NOT(NOT(EXISTS(FirstTransomOffset)) AND EXISTS(SecondTransomOffset));*/
		/*WR33:	WR33 : NOT(NOT(EXISTS(FirstMullionOffset)) AND EXISTS(SecondMullionOffset));*/
		/*WR34:);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcWindowLiningProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcWindowLiningProperties
            var root = (@IfcWindowLiningProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcWindowLiningProperties left, @IfcWindowLiningProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcWindowLiningProperties left, @IfcWindowLiningProperties right)
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