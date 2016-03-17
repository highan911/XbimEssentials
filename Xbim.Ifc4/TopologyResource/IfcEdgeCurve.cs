// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.TopologyResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcEdgeCurve
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcEdgeCurve : IIfcEdge, IfcCurveOrEdgeCurve
	{
		IIfcCurve @EdgeGeometry { get; }
		IfcBoolean @SameSense { get; }
	
	}
}

namespace Xbim.Ifc4.TopologyResource
{
	[ExpressType("IfcEdgeCurve", 203)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcEdgeCurve : IfcEdge, IInstantiableEntity, IIfcEdgeCurve, IEquatable<@IfcEdgeCurve>
	{
		#region IIfcEdgeCurve explicit implementation
		IIfcCurve IIfcEdgeCurve.EdgeGeometry { get { return @EdgeGeometry; } }	
		IfcBoolean IIfcEdgeCurve.SameSense { get { return @SameSense; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEdgeCurve(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurve _edgeGeometry;
		private IfcBoolean _sameSense;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcCurve @EdgeGeometry 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _edgeGeometry;
				((IPersistEntity)this).Activate(false);
				return _edgeGeometry;
			} 
			set
			{
				SetValue( v =>  _edgeGeometry = v, _edgeGeometry, value,  "EdgeGeometry");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcBoolean @SameSense 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _sameSense;
				((IPersistEntity)this).Activate(false);
				return _sameSense;
			} 
			set
			{
				SetValue( v =>  _sameSense = v, _sameSense, value,  "SameSense");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_edgeGeometry = (IfcCurve)(value.EntityVal);
					return;
				case 3: 
					_sameSense = value.BooleanVal;
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
        public bool Equals(@IfcEdgeCurve other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcEdgeCurve
            var root = (@IfcEdgeCurve)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcEdgeCurve left, @IfcEdgeCurve right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcEdgeCurve left, @IfcEdgeCurve right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcEdgeCurve left, IfcCurveOrEdgeCurve right)
		{
			return left == right as @IfcEdgeCurve;
		}

		public static bool operator !=(@IfcEdgeCurve left, IfcCurveOrEdgeCurve right)
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