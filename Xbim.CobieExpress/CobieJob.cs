// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.CobieExpress.Interfaces;
using Xbim.CobieExpress;
//## Custom using statements
//##

namespace Xbim.CobieExpress.Interfaces
{
	/// <summary>
    /// Readonly interface for CobieJob
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @ICobieJob : ICobieReferencedObject
	{
		string @TaskNumber { get; }
		string @Name { get; }
		string @Description { get; }
		ICobieJobType @JobType { get; }
		ICobieJobStatusType @JobStatusType { get; }
		double? @Duration { get; }
		ICobieDurationUnit @DurationUnit { get; }
		double? @Start { get; }
		ICobieDurationUnit @StartUnit { get; }
		double? @Frequency { get; }
		ICobieDurationUnit @FrequencyUnit { get; }
		ICobieJob @Priors { get; }
		IEnumerable<ICobieResource> @Resources { get; }
		ICobieType @Type { get; }
	
	}
}

namespace Xbim.CobieExpress
{
	[ExpressType("Job", 28)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieJob : CobieReferencedObject, IInstantiableEntity, ICobieJob, IEquatable<@CobieJob>
	{
		#region ICobieJob explicit implementation
		string ICobieJob.TaskNumber { get { return @TaskNumber; } }	
		string ICobieJob.Name { get { return @Name; } }	
		string ICobieJob.Description { get { return @Description; } }	
		ICobieJobType ICobieJob.JobType { get { return @JobType; } }	
		ICobieJobStatusType ICobieJob.JobStatusType { get { return @JobStatusType; } }	
		double? ICobieJob.Duration { get { return @Duration; } }	
		ICobieDurationUnit ICobieJob.DurationUnit { get { return @DurationUnit; } }	
		double? ICobieJob.Start { get { return @Start; } }	
		ICobieDurationUnit ICobieJob.StartUnit { get { return @StartUnit; } }	
		double? ICobieJob.Frequency { get { return @Frequency; } }	
		ICobieDurationUnit ICobieJob.FrequencyUnit { get { return @FrequencyUnit; } }	
		ICobieJob ICobieJob.Priors { get { return @Priors; } }	
		IEnumerable<ICobieResource> ICobieJob.Resources { get { return @Resources; } }	
		ICobieType ICobieJob.Type { get { return @Type; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieJob(IModel model) : base(model) 		{ 
			Model = model; 
			_resources = new OptionalItemSet<CobieResource>( this, 0 );
		}

		#region Explicit attribute fields
		private string _taskNumber;
		private string _name;
		private string _description;
		private CobieJobType _jobType;
		private CobieJobStatusType _jobStatusType;
		private double? _duration;
		private CobieDurationUnit _durationUnit;
		private double? _start;
		private CobieDurationUnit _startUnit;
		private double? _frequency;
		private CobieDurationUnit _frequencyUnit;
		private CobieJob _priors;
		private OptionalItemSet<CobieResource> _resources;
		private CobieType _type;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public string @TaskNumber 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _taskNumber;
				((IPersistEntity)this).Activate(false);
				return _taskNumber;
			} 
			set
			{
				SetValue( v =>  _taskNumber = v, _taskNumber, value,  "TaskNumber");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public string @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public string @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 9)]
		public CobieJobType @JobType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _jobType;
				((IPersistEntity)this).Activate(false);
				return _jobType;
			} 
			set
			{
				SetValue( v =>  _jobType = v, _jobType, value,  "JobType");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 10)]
		public CobieJobStatusType @JobStatusType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _jobStatusType;
				((IPersistEntity)this).Activate(false);
				return _jobStatusType;
			} 
			set
			{
				SetValue( v =>  _jobStatusType = v, _jobStatusType, value,  "JobStatusType");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 11)]
		public double? @Duration 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _duration;
				((IPersistEntity)this).Activate(false);
				return _duration;
			} 
			set
			{
				SetValue( v =>  _duration = v, _duration, value,  "Duration");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 12)]
		public CobieDurationUnit @DurationUnit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _durationUnit;
				((IPersistEntity)this).Activate(false);
				return _durationUnit;
			} 
			set
			{
				SetValue( v =>  _durationUnit = v, _durationUnit, value,  "DurationUnit");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 13)]
		public double? @Start 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _start;
				((IPersistEntity)this).Activate(false);
				return _start;
			} 
			set
			{
				SetValue( v =>  _start = v, _start, value,  "Start");
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 14)]
		public CobieDurationUnit @StartUnit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _startUnit;
				((IPersistEntity)this).Activate(false);
				return _startUnit;
			} 
			set
			{
				SetValue( v =>  _startUnit = v, _startUnit, value,  "StartUnit");
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 15)]
		public double? @Frequency 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _frequency;
				((IPersistEntity)this).Activate(false);
				return _frequency;
			} 
			set
			{
				SetValue( v =>  _frequency = v, _frequency, value,  "Frequency");
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 16)]
		public CobieDurationUnit @FrequencyUnit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _frequencyUnit;
				((IPersistEntity)this).Activate(false);
				return _frequencyUnit;
			} 
			set
			{
				SetValue( v =>  _frequencyUnit = v, _frequencyUnit, value,  "FrequencyUnit");
			} 
		}	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 17)]
		public CobieJob @Priors 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _priors;
				((IPersistEntity)this).Activate(false);
				return _priors;
			} 
			set
			{
				SetValue( v =>  _priors = v, _priors, value,  "Priors");
			} 
		}	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 0, -1, 18)]
		public OptionalItemSet<CobieResource> @Resources 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _resources;
				((IPersistEntity)this).Activate(false);
				return _resources;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(19, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 19)]
		public CobieType @Type 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _type;
				((IPersistEntity)this).Activate(false);
				return _type;
			} 
			set
			{
				SetValue( v =>  _type = v, _type, value,  "Type");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_taskNumber = value.StringVal;
					return;
				case 6: 
					_name = value.StringVal;
					return;
				case 7: 
					_description = value.StringVal;
					return;
				case 8: 
					_jobType = (CobieJobType)(value.EntityVal);
					return;
				case 9: 
					_jobStatusType = (CobieJobStatusType)(value.EntityVal);
					return;
				case 10: 
					_duration = value.RealVal;
					return;
				case 11: 
					_durationUnit = (CobieDurationUnit)(value.EntityVal);
					return;
				case 12: 
					_start = value.RealVal;
					return;
				case 13: 
					_startUnit = (CobieDurationUnit)(value.EntityVal);
					return;
				case 14: 
					_frequency = value.RealVal;
					return;
				case 15: 
					_frequencyUnit = (CobieDurationUnit)(value.EntityVal);
					return;
				case 16: 
					_priors = (CobieJob)(value.EntityVal);
					return;
				case 17: 
					if (_resources == null) _resources = new OptionalItemSet<CobieResource>( this );
					_resources.InternalAdd((CobieResource)value.EntityVal);
					return;
				case 18: 
					_type = (CobieType)(value.EntityVal);
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
        public bool Equals(@CobieJob other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @CobieJob
            var root = (@CobieJob)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@CobieJob left, @CobieJob right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@CobieJob left, @CobieJob right)
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