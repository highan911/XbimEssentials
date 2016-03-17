// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcBSplineSurface
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcBSplineSurface : IIfcBoundedSurface
	{
		IfcInteger @UDegree { get; }
		IfcInteger @VDegree { get; }
		IEnumerable<IEnumerable<IIfcCartesianPoint>> @ControlPointsList { get; }
		IfcBSplineSurfaceForm @SurfaceForm { get; }
		IfcLogical @UClosed { get; }
		IfcLogical @VClosed { get; }
		IfcLogical @SelfIntersect { get; }
		IfcInteger @UUpper  { get ; }
		IfcInteger @VUpper  { get ; }
		List<List<Common.Geometry.XbimPoint3D>> @ControlPoints  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcBSplineSurface", 1102)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcBSplineSurface : IfcBoundedSurface, IIfcBSplineSurface, IEquatable<@IfcBSplineSurface>
	{
		#region IIfcBSplineSurface explicit implementation
		IfcInteger IIfcBSplineSurface.UDegree { get { return @UDegree; } }	
		IfcInteger IIfcBSplineSurface.VDegree { get { return @VDegree; } }	
		IEnumerable<IEnumerable<IIfcCartesianPoint>> IIfcBSplineSurface.ControlPointsList { get { return @ControlPointsList; } }	
		IfcBSplineSurfaceForm IIfcBSplineSurface.SurfaceForm { get { return @SurfaceForm; } }	
		IfcLogical IIfcBSplineSurface.UClosed { get { return @UClosed; } }	
		IfcLogical IIfcBSplineSurface.VClosed { get { return @VClosed; } }	
		IfcLogical IIfcBSplineSurface.SelfIntersect { get { return @SelfIntersect; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBSplineSurface(IModel model) : base(model) 		{ 
			Model = model; 
			_controlPointsList = new ItemSet<ItemSet<IfcCartesianPoint>>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcInteger _uDegree;
		private IfcInteger _vDegree;
		private ItemSet<ItemSet<IfcCartesianPoint>> _controlPointsList;
		private IfcBSplineSurfaceForm _surfaceForm;
		private IfcLogical _uClosed;
		private IfcLogical _vClosed;
		private IfcLogical _selfIntersect;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcInteger @UDegree 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _uDegree;
				((IPersistEntity)this).Activate(false);
				return _uDegree;
			} 
			set
			{
				SetValue( v =>  _uDegree = v, _uDegree, value,  "UDegree");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcInteger @VDegree 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _vDegree;
				((IPersistEntity)this).Activate(false);
				return _vDegree;
			} 
			set
			{
				SetValue( v =>  _vDegree = v, _vDegree, value,  "VDegree");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.List, 2, -1, 5)]
		public ItemSet<ItemSet<IfcCartesianPoint>> @ControlPointsList 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _controlPointsList;
				((IPersistEntity)this).Activate(false);
				return _controlPointsList;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 6)]
		public IfcBSplineSurfaceForm @SurfaceForm 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _surfaceForm;
				((IPersistEntity)this).Activate(false);
				return _surfaceForm;
			} 
			set
			{
				SetValue( v =>  _surfaceForm = v, _surfaceForm, value,  "SurfaceForm");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcLogical @UClosed 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _uClosed;
				((IPersistEntity)this).Activate(false);
				return _uClosed;
			} 
			set
			{
				SetValue( v =>  _uClosed = v, _uClosed, value,  "UClosed");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public IfcLogical @VClosed 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _vClosed;
				((IPersistEntity)this).Activate(false);
				return _vClosed;
			} 
			set
			{
				SetValue( v =>  _vClosed = v, _vClosed, value,  "VClosed");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 9)]
		public IfcLogical @SelfIntersect 
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


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public IfcInteger @UUpper 
		{
			get 
			{
				//## Getter for UUpper
			    return ControlPointsList.Count - 1;
			    //##
			}
		}

		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public IfcInteger @VUpper 
		{
			get 
			{
				//## Getter for VUpper
                return ControlPointsList[1].Count - 1;
				//##
			}
		}

		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Array, EntityAttributeType.Array, 0, -1, 0)]
		public List<List<Common.Geometry.XbimPoint3D>> @ControlPoints 
		{
			get 
			{
				//## Getter for ControlPoints
			    var result = new List<List<Common.Geometry.XbimPoint3D>>();
			    foreach (var list in ControlPointsList)
			    {
			        var inner = new List<Common.Geometry.XbimPoint3D>();
                    result.Add(inner);
			        inner.AddRange(list.Select(point => new Common.Geometry.XbimPoint3D(point.X, point.Y, point.Z)));
			    }
			    return result;
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
					_uDegree = value.IntegerVal;
					return;
				case 1: 
					_vDegree = value.IntegerVal;
					return;
				case 2: 
					_controlPointsList
						.InternalGetAt(nestedIndex[0])
						.InternalAdd((IfcCartesianPoint)(value.EntityVal));
					return;
				case 3: 
                    _surfaceForm = (IfcBSplineSurfaceForm) System.Enum.Parse(typeof (IfcBSplineSurfaceForm), value.EnumVal, true);
					return;
				case 4: 
					_uClosed = value.BooleanVal;
					return;
				case 5: 
					_vClosed = value.BooleanVal;
					return;
				case 6: 
					_selfIntersect = value.BooleanVal;
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
        public bool Equals(@IfcBSplineSurface other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcBSplineSurface
            var root = (@IfcBSplineSurface)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcBSplineSurface left, @IfcBSplineSurface right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcBSplineSurface left, @IfcBSplineSurface right)
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