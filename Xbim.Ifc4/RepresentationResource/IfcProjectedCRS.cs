// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.RepresentationResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcProjectedCRS
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcProjectedCRS : IIfcCoordinateReferenceSystem
	{
		IfcIdentifier? @MapProjection { get; }
		IfcIdentifier? @MapZone { get; }
		IIfcNamedUnit @MapUnit { get; }
	
	}
}

namespace Xbim.Ifc4.RepresentationResource
{
	[ExpressType("IfcProjectedCRS", 1230)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProjectedCRS : IfcCoordinateReferenceSystem, IInstantiableEntity, IIfcProjectedCRS, IEquatable<@IfcProjectedCRS>
	{
		#region IIfcProjectedCRS explicit implementation
		IfcIdentifier? IIfcProjectedCRS.MapProjection { get { return @MapProjection; } }	
		IfcIdentifier? IIfcProjectedCRS.MapZone { get { return @MapZone; } }	
		IIfcNamedUnit IIfcProjectedCRS.MapUnit { get { return @MapUnit; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProjectedCRS(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier? _mapProjection;
		private IfcIdentifier? _mapZone;
		private IfcNamedUnit _mapUnit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcIdentifier? @MapProjection 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _mapProjection;
				((IPersistEntity)this).Activate(false);
				return _mapProjection;
			} 
			set
			{
				SetValue( v =>  _mapProjection = v, _mapProjection, value,  "MapProjection");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcIdentifier? @MapZone 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _mapZone;
				((IPersistEntity)this).Activate(false);
				return _mapZone;
			} 
			set
			{
				SetValue( v =>  _mapZone = v, _mapZone, value,  "MapZone");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 8)]
		public IfcNamedUnit @MapUnit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _mapUnit;
				((IPersistEntity)this).Activate(false);
				return _mapUnit;
			} 
			set
			{
				SetValue( v =>  _mapUnit = v, _mapUnit, value,  "MapUnit");
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
					_mapProjection = value.StringVal;
					return;
				case 5: 
					_mapZone = value.StringVal;
					return;
				case 6: 
					_mapUnit = (IfcNamedUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*IsLengthUnit:	IsLengthUnit : NOT(EXISTS(MapUnit)) OR (MapUnit.UnitType = IfcUnitEnum.LENGTHUNIT);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcProjectedCRS other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcProjectedCRS
            var root = (@IfcProjectedCRS)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcProjectedCRS left, @IfcProjectedCRS right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcProjectedCRS left, @IfcProjectedCRS right)
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