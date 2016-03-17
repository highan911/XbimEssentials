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
using Xbim.Ifc2x3.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPointOnSurface
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPointOnSurface : IIfcPoint
	{
		IIfcSurface @BasisSurface { get; }
		IfcParameterValue @PointParameterU { get; }
		IfcParameterValue @PointParameterV { get; }
	
	}
}

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IfcPointOnSurface", 65)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPointOnSurface : IfcPoint, IInstantiableEntity, IIfcPointOnSurface, IEquatable<@IfcPointOnSurface>
	{
		#region IIfcPointOnSurface explicit implementation
		IIfcSurface IIfcPointOnSurface.BasisSurface { get { return @BasisSurface; } }	
		IfcParameterValue IIfcPointOnSurface.PointParameterU { get { return @PointParameterU; } }	
		IfcParameterValue IIfcPointOnSurface.PointParameterV { get { return @PointParameterV; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPointOnSurface(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSurface _basisSurface;
		private IfcParameterValue _pointParameterU;
		private IfcParameterValue _pointParameterV;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcSurface @BasisSurface 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _basisSurface;
				((IPersistEntity)this).Activate(false);
				return _basisSurface;
			} 
			set
			{
				SetValue( v =>  _basisSurface = v, _basisSurface, value,  "BasisSurface");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcParameterValue @PointParameterU 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _pointParameterU;
				((IPersistEntity)this).Activate(false);
				return _pointParameterU;
			} 
			set
			{
				SetValue( v =>  _pointParameterU = v, _pointParameterU, value,  "PointParameterU");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcParameterValue @PointParameterV 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _pointParameterV;
				((IPersistEntity)this).Activate(false);
				return _pointParameterV;
			} 
			set
			{
				SetValue( v =>  _pointParameterV = v, _pointParameterV, value,  "PointParameterV");
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public override IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
			    return BasisSurface != null
			        ? BasisSurface.Dim
			        : 0;
			    //##
			}
		}

		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_basisSurface = (IfcSurface)(value.EntityVal);
					return;
				case 1: 
					_pointParameterU = value.RealVal;
					return;
				case 2: 
					_pointParameterV = value.RealVal;
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
        public bool Equals(@IfcPointOnSurface other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPointOnSurface
            var root = (@IfcPointOnSurface)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPointOnSurface left, @IfcPointOnSurface right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPointOnSurface left, @IfcPointOnSurface right)
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