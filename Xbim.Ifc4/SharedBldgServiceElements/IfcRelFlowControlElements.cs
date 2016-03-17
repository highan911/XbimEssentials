// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.SharedBldgServiceElements;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelFlowControlElements
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelFlowControlElements : IIfcRelConnects
	{
		IEnumerable<IIfcDistributionControlElement> @RelatedControlElements { get; }
		IIfcDistributionFlowElement @RelatingFlowElement { get; }
	
	}
}

namespace Xbim.Ifc4.SharedBldgServiceElements
{
	[ExpressType("IfcRelFlowControlElements", 360)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelFlowControlElements : IfcRelConnects, IInstantiableEntity, IIfcRelFlowControlElements, IEquatable<@IfcRelFlowControlElements>
	{
		#region IIfcRelFlowControlElements explicit implementation
		IEnumerable<IIfcDistributionControlElement> IIfcRelFlowControlElements.RelatedControlElements { get { return @RelatedControlElements; } }	
		IIfcDistributionFlowElement IIfcRelFlowControlElements.RelatingFlowElement { get { return @RelatingFlowElement; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelFlowControlElements(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedControlElements = new ItemSet<IfcDistributionControlElement>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcDistributionControlElement> _relatedControlElements;
		private IfcDistributionFlowElement _relatingFlowElement;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 5)]
		public ItemSet<IfcDistributionControlElement> @RelatedControlElements 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedControlElements;
				((IPersistEntity)this).Activate(false);
				return _relatedControlElements;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcDistributionFlowElement @RelatingFlowElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingFlowElement;
				((IPersistEntity)this).Activate(false);
				return _relatingFlowElement;
			} 
			set
			{
				SetValue( v =>  _relatingFlowElement = v, _relatingFlowElement, value,  "RelatingFlowElement");
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
					if (_relatedControlElements == null) _relatedControlElements = new ItemSet<IfcDistributionControlElement>( this );
					_relatedControlElements.InternalAdd((IfcDistributionControlElement)value.EntityVal);
					return;
				case 5: 
					_relatingFlowElement = (IfcDistributionFlowElement)(value.EntityVal);
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
        public bool Equals(@IfcRelFlowControlElements other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelFlowControlElements
            var root = (@IfcRelFlowControlElements)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelFlowControlElements left, @IfcRelFlowControlElements right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelFlowControlElements left, @IfcRelFlowControlElements right)
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