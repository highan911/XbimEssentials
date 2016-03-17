// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.ArchitectureDomain;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcWindowStyle
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcWindowStyle : IIfcTypeProduct
	{
		IfcWindowStyleConstructionEnum @ConstructionType { get; }
		IfcWindowStyleOperationEnum @OperationType { get; }
		IfcBoolean @ParameterTakesPrecedence { get; }
		IfcBoolean @Sizeable { get; }
	
	}
}

namespace Xbim.Ifc4.ArchitectureDomain
{
	[ExpressType("IfcWindowStyle", 345)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWindowStyle : IfcTypeProduct, IInstantiableEntity, IIfcWindowStyle, IEquatable<@IfcWindowStyle>
	{
		#region IIfcWindowStyle explicit implementation
		IfcWindowStyleConstructionEnum IIfcWindowStyle.ConstructionType { get { return @ConstructionType; } }	
		IfcWindowStyleOperationEnum IIfcWindowStyle.OperationType { get { return @OperationType; } }	
		IfcBoolean IIfcWindowStyle.ParameterTakesPrecedence { get { return @ParameterTakesPrecedence; } }	
		IfcBoolean IIfcWindowStyle.Sizeable { get { return @Sizeable; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWindowStyle(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcWindowStyleConstructionEnum _constructionType;
		private IfcWindowStyleOperationEnum _operationType;
		private IfcBoolean _parameterTakesPrecedence;
		private IfcBoolean _sizeable;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 18)]
		public IfcWindowStyleConstructionEnum @ConstructionType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _constructionType;
				((IPersistEntity)this).Activate(false);
				return _constructionType;
			} 
			set
			{
				SetValue( v =>  _constructionType = v, _constructionType, value,  "ConstructionType");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 19)]
		public IfcWindowStyleOperationEnum @OperationType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _operationType;
				((IPersistEntity)this).Activate(false);
				return _operationType;
			} 
			set
			{
				SetValue( v =>  _operationType = v, _operationType, value,  "OperationType");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 20)]
		public IfcBoolean @ParameterTakesPrecedence 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _parameterTakesPrecedence;
				((IPersistEntity)this).Activate(false);
				return _parameterTakesPrecedence;
			} 
			set
			{
				SetValue( v =>  _parameterTakesPrecedence = v, _parameterTakesPrecedence, value,  "ParameterTakesPrecedence");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 21)]
		public IfcBoolean @Sizeable 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _sizeable;
				((IPersistEntity)this).Activate(false);
				return _sizeable;
			} 
			set
			{
				SetValue( v =>  _sizeable = v, _sizeable, value,  "Sizeable");
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
                    _constructionType = (IfcWindowStyleConstructionEnum) System.Enum.Parse(typeof (IfcWindowStyleConstructionEnum), value.EnumVal, true);
					return;
				case 9: 
                    _operationType = (IfcWindowStyleOperationEnum) System.Enum.Parse(typeof (IfcWindowStyleOperationEnum), value.EnumVal, true);
					return;
				case 10: 
					_parameterTakesPrecedence = value.BooleanVal;
					return;
				case 11: 
					_sizeable = value.BooleanVal;
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
        public bool Equals(@IfcWindowStyle other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcWindowStyle
            var root = (@IfcWindowStyle)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcWindowStyle left, @IfcWindowStyle right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcWindowStyle left, @IfcWindowStyle right)
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