// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometricModelResource;
using Xbim.Ifc4.GeometricConstraintResource;
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
    /// Readonly interface for IfcSurface
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurface : IIfcGeometricRepresentationItem, IfcGeometricSetSelect, IfcSurfaceOrFaceSurface
	{
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcSurface", 111)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcSurface : IfcGeometricRepresentationItem, IIfcSurface, IEquatable<@IfcSurface>
	{
		#region IIfcSurface explicit implementation
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurface(IModel model) : base(model) 		{ 
			Model = model; 
		}



		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
                var es = this as IfcElementarySurface;
                if (es != null)
                    return es.Dim;
                var sws = this as IfcSweptSurface;
                if (sws != null)
                    return sws.Dim;
                var cbd = this as IfcCurveBoundedPlane;
                if (cbd != null)
                    return cbd.Dim;
                var rts = this as IfcRectangularTrimmedSurface;
                if (rts != null)
                    return rts.Dim;
                return 0;
				//##
			}
		}

		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			//there are no attributes defined for this entity
            throw new System.IndexOutOfRangeException("There are no attributes defined for this entity");
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurface other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSurface
            var root = (@IfcSurface)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSurface left, @IfcSurface right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSurface left, @IfcSurface right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcSurface left, IfcGeometricSetSelect right)
		{
			return left == right as @IfcSurface;
		}

		public static bool operator !=(@IfcSurface left, IfcGeometricSetSelect right)
		{
			return !(left == right);
		}

        public static bool operator ==(@IfcSurface left, IfcSurfaceOrFaceSurface right)
		{
			return left == right as @IfcSurface;
		}

		public static bool operator !=(@IfcSurface left, IfcSurfaceOrFaceSurface right)
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