// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.ProfileResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometricConstraintResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcConnectionPortGeometry
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConnectionPortGeometry : IIfcConnectionGeometry
	{
		IIfcAxis2Placement @LocationAtRelatingElement { get; }
		IIfcAxis2Placement @LocationAtRelatedElement { get; }
		IIfcProfileDef @ProfileOfPort { get; }
	
	}
}

namespace Xbim.Ifc2x3.GeometricConstraintResource
{
	[ExpressType("IfcConnectionPortGeometry", 713)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConnectionPortGeometry : IfcConnectionGeometry, IInstantiableEntity, IIfcConnectionPortGeometry, IEquatable<@IfcConnectionPortGeometry>
	{
		#region IIfcConnectionPortGeometry explicit implementation
		IIfcAxis2Placement IIfcConnectionPortGeometry.LocationAtRelatingElement { get { return @LocationAtRelatingElement; } }	
		IIfcAxis2Placement IIfcConnectionPortGeometry.LocationAtRelatedElement { get { return @LocationAtRelatedElement; } }	
		IIfcProfileDef IIfcConnectionPortGeometry.ProfileOfPort { get { return @ProfileOfPort; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionPortGeometry(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis2Placement _locationAtRelatingElement;
		private IfcAxis2Placement _locationAtRelatedElement;
		private IfcProfileDef _profileOfPort;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 1)]
		public IfcAxis2Placement @LocationAtRelatingElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _locationAtRelatingElement;
				((IPersistEntity)this).Activate(false);
				return _locationAtRelatingElement;
			} 
			set
			{
				SetValue( v =>  _locationAtRelatingElement = v, _locationAtRelatingElement, value,  "LocationAtRelatingElement");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 2)]
		public IfcAxis2Placement @LocationAtRelatedElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _locationAtRelatedElement;
				((IPersistEntity)this).Activate(false);
				return _locationAtRelatedElement;
			} 
			set
			{
				SetValue( v =>  _locationAtRelatedElement = v, _locationAtRelatedElement, value,  "LocationAtRelatedElement");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcProfileDef @ProfileOfPort 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _profileOfPort;
				((IPersistEntity)this).Activate(false);
				return _profileOfPort;
			} 
			set
			{
				SetValue( v =>  _profileOfPort = v, _profileOfPort, value,  "ProfileOfPort");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_locationAtRelatingElement = (IfcAxis2Placement)(value.EntityVal);
					return;
				case 1: 
					_locationAtRelatedElement = (IfcAxis2Placement)(value.EntityVal);
					return;
				case 2: 
					_profileOfPort = (IfcProfileDef)(value.EntityVal);
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
        public bool Equals(@IfcConnectionPortGeometry other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcConnectionPortGeometry
            var root = (@IfcConnectionPortGeometry)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcConnectionPortGeometry left, @IfcConnectionPortGeometry right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcConnectionPortGeometry left, @IfcConnectionPortGeometry right)
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