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
using Xbim.Ifc2x3.MaterialPropertyResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcHygroscopicMaterialProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcHygroscopicMaterialProperties : IIfcMaterialProperties
	{
		IfcPositiveRatioMeasure? @UpperVaporResistanceFactor { get; }
		IfcPositiveRatioMeasure? @LowerVaporResistanceFactor { get; }
		IfcIsothermalMoistureCapacityMeasure? @IsothermalMoistureCapacity { get; }
		IfcVaporPermeabilityMeasure? @VaporPermeability { get; }
		IfcMoistureDiffusivityMeasure? @MoistureDiffusivity { get; }
	
	}
}

namespace Xbim.Ifc2x3.MaterialPropertyResource
{
	[ExpressType("IfcHygroscopicMaterialProperties", 717)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcHygroscopicMaterialProperties : IfcMaterialProperties, IInstantiableEntity, IIfcHygroscopicMaterialProperties, IEquatable<@IfcHygroscopicMaterialProperties>
	{
		#region IIfcHygroscopicMaterialProperties explicit implementation
		IfcPositiveRatioMeasure? IIfcHygroscopicMaterialProperties.UpperVaporResistanceFactor { get { return @UpperVaporResistanceFactor; } }	
		IfcPositiveRatioMeasure? IIfcHygroscopicMaterialProperties.LowerVaporResistanceFactor { get { return @LowerVaporResistanceFactor; } }	
		IfcIsothermalMoistureCapacityMeasure? IIfcHygroscopicMaterialProperties.IsothermalMoistureCapacity { get { return @IsothermalMoistureCapacity; } }	
		IfcVaporPermeabilityMeasure? IIfcHygroscopicMaterialProperties.VaporPermeability { get { return @VaporPermeability; } }	
		IfcMoistureDiffusivityMeasure? IIfcHygroscopicMaterialProperties.MoistureDiffusivity { get { return @MoistureDiffusivity; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcHygroscopicMaterialProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveRatioMeasure? _upperVaporResistanceFactor;
		private IfcPositiveRatioMeasure? _lowerVaporResistanceFactor;
		private IfcIsothermalMoistureCapacityMeasure? _isothermalMoistureCapacity;
		private IfcVaporPermeabilityMeasure? _vaporPermeability;
		private IfcMoistureDiffusivityMeasure? _moistureDiffusivity;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcPositiveRatioMeasure? @UpperVaporResistanceFactor 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _upperVaporResistanceFactor;
				((IPersistEntity)this).Activate(false);
				return _upperVaporResistanceFactor;
			} 
			set
			{
				SetValue( v =>  _upperVaporResistanceFactor = v, _upperVaporResistanceFactor, value,  "UpperVaporResistanceFactor");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcPositiveRatioMeasure? @LowerVaporResistanceFactor 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lowerVaporResistanceFactor;
				((IPersistEntity)this).Activate(false);
				return _lowerVaporResistanceFactor;
			} 
			set
			{
				SetValue( v =>  _lowerVaporResistanceFactor = v, _lowerVaporResistanceFactor, value,  "LowerVaporResistanceFactor");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcIsothermalMoistureCapacityMeasure? @IsothermalMoistureCapacity 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _isothermalMoistureCapacity;
				((IPersistEntity)this).Activate(false);
				return _isothermalMoistureCapacity;
			} 
			set
			{
				SetValue( v =>  _isothermalMoistureCapacity = v, _isothermalMoistureCapacity, value,  "IsothermalMoistureCapacity");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcVaporPermeabilityMeasure? @VaporPermeability 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _vaporPermeability;
				((IPersistEntity)this).Activate(false);
				return _vaporPermeability;
			} 
			set
			{
				SetValue( v =>  _vaporPermeability = v, _vaporPermeability, value,  "VaporPermeability");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcMoistureDiffusivityMeasure? @MoistureDiffusivity 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _moistureDiffusivity;
				((IPersistEntity)this).Activate(false);
				return _moistureDiffusivity;
			} 
			set
			{
				SetValue( v =>  _moistureDiffusivity = v, _moistureDiffusivity, value,  "MoistureDiffusivity");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_upperVaporResistanceFactor = value.RealVal;
					return;
				case 2: 
					_lowerVaporResistanceFactor = value.RealVal;
					return;
				case 3: 
					_isothermalMoistureCapacity = value.RealVal;
					return;
				case 4: 
					_vaporPermeability = value.RealVal;
					return;
				case 5: 
					_moistureDiffusivity = value.RealVal;
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
        public bool Equals(@IfcHygroscopicMaterialProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcHygroscopicMaterialProperties
            var root = (@IfcHygroscopicMaterialProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcHygroscopicMaterialProperties left, @IfcHygroscopicMaterialProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcHygroscopicMaterialProperties left, @IfcHygroscopicMaterialProperties right)
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