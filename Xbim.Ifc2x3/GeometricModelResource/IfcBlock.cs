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
using Xbim.Ifc2x3.GeometricModelResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcBlock
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcBlock : IIfcCsgPrimitive3D
	{
		IfcPositiveLengthMeasure @XLength { get; }
		IfcPositiveLengthMeasure @YLength { get; }
		IfcPositiveLengthMeasure @ZLength { get; }
	
	}
}

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[ExpressType("IfcBlock", 702)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBlock : IfcCsgPrimitive3D, IInstantiableEntity, IIfcBlock, IEquatable<@IfcBlock>
	{
		#region IIfcBlock explicit implementation
		IfcPositiveLengthMeasure IIfcBlock.XLength { get { return @XLength; } }	
		IfcPositiveLengthMeasure IIfcBlock.YLength { get { return @YLength; } }	
		IfcPositiveLengthMeasure IIfcBlock.ZLength { get { return @ZLength; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBlock(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _xLength;
		private IfcPositiveLengthMeasure _yLength;
		private IfcPositiveLengthMeasure _zLength;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcPositiveLengthMeasure @XLength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _xLength;
				((IPersistEntity)this).Activate(false);
				return _xLength;
			} 
			set
			{
				SetValue( v =>  _xLength = v, _xLength, value,  "XLength");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcPositiveLengthMeasure @YLength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _yLength;
				((IPersistEntity)this).Activate(false);
				return _yLength;
			} 
			set
			{
				SetValue( v =>  _yLength = v, _yLength, value,  "YLength");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcPositiveLengthMeasure @ZLength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _zLength;
				((IPersistEntity)this).Activate(false);
				return _zLength;
			} 
			set
			{
				SetValue( v =>  _zLength = v, _zLength, value,  "ZLength");
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
					_xLength = value.RealVal;
					return;
				case 2: 
					_yLength = value.RealVal;
					return;
				case 3: 
					_zLength = value.RealVal;
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
        public bool Equals(@IfcBlock other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcBlock
            var root = (@IfcBlock)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcBlock left, @IfcBlock right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcBlock left, @IfcBlock right)
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