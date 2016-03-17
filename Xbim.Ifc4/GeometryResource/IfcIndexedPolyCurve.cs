// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometricModelResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcIndexedPolyCurve
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcIndexedPolyCurve : IIfcBoundedCurve
	{
		IIfcCartesianPointList @Points { get; }
		IEnumerable<IIfcSegmentIndexSelect> @Segments { get; }
		IfcBoolean? @SelfIntersect { get; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcIndexedPolyCurve", 1190)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcIndexedPolyCurve : IfcBoundedCurve, IInstantiableEntity, IIfcIndexedPolyCurve, IEquatable<@IfcIndexedPolyCurve>
	{
		#region IIfcIndexedPolyCurve explicit implementation
		IIfcCartesianPointList IIfcIndexedPolyCurve.Points { get { return @Points; } }	
		IEnumerable<IIfcSegmentIndexSelect> IIfcIndexedPolyCurve.Segments { get { return @Segments; } }	
		IfcBoolean? IIfcIndexedPolyCurve.SelfIntersect { get { return @SelfIntersect; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcIndexedPolyCurve(IModel model) : base(model) 		{ 
			Model = model; 
			_segments = new OptionalItemSet<IfcSegmentIndexSelect>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcCartesianPointList _points;
		private OptionalItemSet<IfcSegmentIndexSelect> _segments;
		private IfcBoolean? _selfIntersect;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcCartesianPointList @Points 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _points;
				((IPersistEntity)this).Activate(false);
				return _points;
			} 
			set
			{
				SetValue( v =>  _points = v, _points, value,  "Points");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 4)]
		public OptionalItemSet<IfcSegmentIndexSelect> @Segments 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _segments;
				((IPersistEntity)this).Activate(false);
				return _segments;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcBoolean? @SelfIntersect 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _selfIntersect;
				((IPersistEntity)this).Activate(false);
				return _selfIntersect;
			} 
			set
			{
				SetValue( v =>  _selfIntersect = v, _selfIntersect, value,  "SelfIntersect");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_points = (IfcCartesianPointList)(value.EntityVal);
					return;
				case 1: 
					if (_segments == null) _segments = new OptionalItemSet<IfcSegmentIndexSelect>( this );
					_segments.InternalAdd((IfcSegmentIndexSelect)value.EntityVal);
					return;
				case 2: 
					_selfIntersect = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*Consecutive:	Consecutive : (SIZEOF(Segments) = 0) OR IfcConsecutiveSegments(Segments);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcIndexedPolyCurve other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcIndexedPolyCurve
            var root = (@IfcIndexedPolyCurve)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcIndexedPolyCurve left, @IfcIndexedPolyCurve right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcIndexedPolyCurve left, @IfcIndexedPolyCurve right)
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