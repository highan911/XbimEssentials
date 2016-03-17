// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.TimeSeriesResource;
using Xbim.Ifc2x3.MaterialResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedBldgServiceElements;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcFluidFlowProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcFluidFlowProperties : IIfcPropertySetDefinition
	{
		IfcPropertySourceEnum @PropertySource { get; }
		IIfcTimeSeries @FlowConditionTimeSeries { get; }
		IIfcTimeSeries @VelocityTimeSeries { get; }
		IIfcTimeSeries @FlowrateTimeSeries { get; }
		IIfcMaterial @Fluid { get; }
		IIfcTimeSeries @PressureTimeSeries { get; }
		IfcLabel? @UserDefinedPropertySource { get; }
		IfcThermodynamicTemperatureMeasure? @TemperatureSingleValue { get; }
		IfcThermodynamicTemperatureMeasure? @WetBulbTemperatureSingleValue { get; }
		IIfcTimeSeries @WetBulbTemperatureTimeSeries { get; }
		IIfcTimeSeries @TemperatureTimeSeries { get; }
		IIfcDerivedMeasureValue @FlowrateSingleValue { get; }
		IfcPositiveRatioMeasure? @FlowConditionSingleValue { get; }
		IfcLinearVelocityMeasure? @VelocitySingleValue { get; }
		IfcPressureMeasure? @PressureSingleValue { get; }
	
	}
}

namespace Xbim.Ifc2x3.SharedBldgServiceElements
{
	[ExpressType("IfcFluidFlowProperties", 466)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFluidFlowProperties : IfcPropertySetDefinition, IInstantiableEntity, IIfcFluidFlowProperties, IEquatable<@IfcFluidFlowProperties>
	{
		#region IIfcFluidFlowProperties explicit implementation
		IfcPropertySourceEnum IIfcFluidFlowProperties.PropertySource { get { return @PropertySource; } }	
		IIfcTimeSeries IIfcFluidFlowProperties.FlowConditionTimeSeries { get { return @FlowConditionTimeSeries; } }	
		IIfcTimeSeries IIfcFluidFlowProperties.VelocityTimeSeries { get { return @VelocityTimeSeries; } }	
		IIfcTimeSeries IIfcFluidFlowProperties.FlowrateTimeSeries { get { return @FlowrateTimeSeries; } }	
		IIfcMaterial IIfcFluidFlowProperties.Fluid { get { return @Fluid; } }	
		IIfcTimeSeries IIfcFluidFlowProperties.PressureTimeSeries { get { return @PressureTimeSeries; } }	
		IfcLabel? IIfcFluidFlowProperties.UserDefinedPropertySource { get { return @UserDefinedPropertySource; } }	
		IfcThermodynamicTemperatureMeasure? IIfcFluidFlowProperties.TemperatureSingleValue { get { return @TemperatureSingleValue; } }	
		IfcThermodynamicTemperatureMeasure? IIfcFluidFlowProperties.WetBulbTemperatureSingleValue { get { return @WetBulbTemperatureSingleValue; } }	
		IIfcTimeSeries IIfcFluidFlowProperties.WetBulbTemperatureTimeSeries { get { return @WetBulbTemperatureTimeSeries; } }	
		IIfcTimeSeries IIfcFluidFlowProperties.TemperatureTimeSeries { get { return @TemperatureTimeSeries; } }	
		IIfcDerivedMeasureValue IIfcFluidFlowProperties.FlowrateSingleValue { get { return @FlowrateSingleValue; } }	
		IfcPositiveRatioMeasure? IIfcFluidFlowProperties.FlowConditionSingleValue { get { return @FlowConditionSingleValue; } }	
		IfcLinearVelocityMeasure? IIfcFluidFlowProperties.VelocitySingleValue { get { return @VelocitySingleValue; } }	
		IfcPressureMeasure? IIfcFluidFlowProperties.PressureSingleValue { get { return @PressureSingleValue; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFluidFlowProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPropertySourceEnum _propertySource;
		private IfcTimeSeries _flowConditionTimeSeries;
		private IfcTimeSeries _velocityTimeSeries;
		private IfcTimeSeries _flowrateTimeSeries;
		private IfcMaterial _fluid;
		private IfcTimeSeries _pressureTimeSeries;
		private IfcLabel? _userDefinedPropertySource;
		private IfcThermodynamicTemperatureMeasure? _temperatureSingleValue;
		private IfcThermodynamicTemperatureMeasure? _wetBulbTemperatureSingleValue;
		private IfcTimeSeries _wetBulbTemperatureTimeSeries;
		private IfcTimeSeries _temperatureTimeSeries;
		private IfcDerivedMeasureValue _flowrateSingleValue;
		private IfcPositiveRatioMeasure? _flowConditionSingleValue;
		private IfcLinearVelocityMeasure? _velocitySingleValue;
		private IfcPressureMeasure? _pressureSingleValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 8)]
		public IfcPropertySourceEnum @PropertySource 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _propertySource;
				((IPersistEntity)this).Activate(false);
				return _propertySource;
			} 
			set
			{
				SetValue( v =>  _propertySource = v, _propertySource, value,  "PropertySource");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 9)]
		public IfcTimeSeries @FlowConditionTimeSeries 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _flowConditionTimeSeries;
				((IPersistEntity)this).Activate(false);
				return _flowConditionTimeSeries;
			} 
			set
			{
				SetValue( v =>  _flowConditionTimeSeries = v, _flowConditionTimeSeries, value,  "FlowConditionTimeSeries");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 10)]
		public IfcTimeSeries @VelocityTimeSeries 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _velocityTimeSeries;
				((IPersistEntity)this).Activate(false);
				return _velocityTimeSeries;
			} 
			set
			{
				SetValue( v =>  _velocityTimeSeries = v, _velocityTimeSeries, value,  "VelocityTimeSeries");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 11)]
		public IfcTimeSeries @FlowrateTimeSeries 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _flowrateTimeSeries;
				((IPersistEntity)this).Activate(false);
				return _flowrateTimeSeries;
			} 
			set
			{
				SetValue( v =>  _flowrateTimeSeries = v, _flowrateTimeSeries, value,  "FlowrateTimeSeries");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 12)]
		public IfcMaterial @Fluid 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _fluid;
				((IPersistEntity)this).Activate(false);
				return _fluid;
			} 
			set
			{
				SetValue( v =>  _fluid = v, _fluid, value,  "Fluid");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 13)]
		public IfcTimeSeries @PressureTimeSeries 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _pressureTimeSeries;
				((IPersistEntity)this).Activate(false);
				return _pressureTimeSeries;
			} 
			set
			{
				SetValue( v =>  _pressureTimeSeries = v, _pressureTimeSeries, value,  "PressureTimeSeries");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 14)]
		public IfcLabel? @UserDefinedPropertySource 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _userDefinedPropertySource;
				((IPersistEntity)this).Activate(false);
				return _userDefinedPropertySource;
			} 
			set
			{
				SetValue( v =>  _userDefinedPropertySource = v, _userDefinedPropertySource, value,  "UserDefinedPropertySource");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 15)]
		public IfcThermodynamicTemperatureMeasure? @TemperatureSingleValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _temperatureSingleValue;
				((IPersistEntity)this).Activate(false);
				return _temperatureSingleValue;
			} 
			set
			{
				SetValue( v =>  _temperatureSingleValue = v, _temperatureSingleValue, value,  "TemperatureSingleValue");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 16)]
		public IfcThermodynamicTemperatureMeasure? @WetBulbTemperatureSingleValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _wetBulbTemperatureSingleValue;
				((IPersistEntity)this).Activate(false);
				return _wetBulbTemperatureSingleValue;
			} 
			set
			{
				SetValue( v =>  _wetBulbTemperatureSingleValue = v, _wetBulbTemperatureSingleValue, value,  "WetBulbTemperatureSingleValue");
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 17)]
		public IfcTimeSeries @WetBulbTemperatureTimeSeries 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _wetBulbTemperatureTimeSeries;
				((IPersistEntity)this).Activate(false);
				return _wetBulbTemperatureTimeSeries;
			} 
			set
			{
				SetValue( v =>  _wetBulbTemperatureTimeSeries = v, _wetBulbTemperatureTimeSeries, value,  "WetBulbTemperatureTimeSeries");
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 18)]
		public IfcTimeSeries @TemperatureTimeSeries 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _temperatureTimeSeries;
				((IPersistEntity)this).Activate(false);
				return _temperatureTimeSeries;
			} 
			set
			{
				SetValue( v =>  _temperatureTimeSeries = v, _temperatureTimeSeries, value,  "TemperatureTimeSeries");
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 19)]
		public IfcDerivedMeasureValue @FlowrateSingleValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _flowrateSingleValue;
				((IPersistEntity)this).Activate(false);
				return _flowrateSingleValue;
			} 
			set
			{
				SetValue( v =>  _flowrateSingleValue = v, _flowrateSingleValue, value,  "FlowrateSingleValue");
			} 
		}	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 20)]
		public IfcPositiveRatioMeasure? @FlowConditionSingleValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _flowConditionSingleValue;
				((IPersistEntity)this).Activate(false);
				return _flowConditionSingleValue;
			} 
			set
			{
				SetValue( v =>  _flowConditionSingleValue = v, _flowConditionSingleValue, value,  "FlowConditionSingleValue");
			} 
		}	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 21)]
		public IfcLinearVelocityMeasure? @VelocitySingleValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _velocitySingleValue;
				((IPersistEntity)this).Activate(false);
				return _velocitySingleValue;
			} 
			set
			{
				SetValue( v =>  _velocitySingleValue = v, _velocitySingleValue, value,  "VelocitySingleValue");
			} 
		}	
		[EntityAttribute(19, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 22)]
		public IfcPressureMeasure? @PressureSingleValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _pressureSingleValue;
				((IPersistEntity)this).Activate(false);
				return _pressureSingleValue;
			} 
			set
			{
				SetValue( v =>  _pressureSingleValue = v, _pressureSingleValue, value,  "PressureSingleValue");
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
                    _propertySource = (IfcPropertySourceEnum) System.Enum.Parse(typeof (IfcPropertySourceEnum), value.EnumVal, true);
					return;
				case 5: 
					_flowConditionTimeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				case 6: 
					_velocityTimeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				case 7: 
					_flowrateTimeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				case 8: 
					_fluid = (IfcMaterial)(value.EntityVal);
					return;
				case 9: 
					_pressureTimeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				case 10: 
					_userDefinedPropertySource = value.StringVal;
					return;
				case 11: 
					_temperatureSingleValue = value.RealVal;
					return;
				case 12: 
					_wetBulbTemperatureSingleValue = value.RealVal;
					return;
				case 13: 
					_wetBulbTemperatureTimeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				case 14: 
					_temperatureTimeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				case 15: 
					_flowrateSingleValue = (IfcDerivedMeasureValue)(value.EntityVal);
					return;
				case 16: 
					_flowConditionSingleValue = value.RealVal;
					return;
				case 17: 
					_velocitySingleValue = value.RealVal;
					return;
				case 18: 
					_pressureSingleValue = value.RealVal;
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
        public bool Equals(@IfcFluidFlowProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcFluidFlowProperties
            var root = (@IfcFluidFlowProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcFluidFlowProperties left, @IfcFluidFlowProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcFluidFlowProperties left, @IfcFluidFlowProperties right)
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