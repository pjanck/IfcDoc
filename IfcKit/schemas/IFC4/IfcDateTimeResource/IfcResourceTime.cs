// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcDateTimeResource
{
	[Guid("d5120875-1fc0-4135-8be9-51f5bd59fc0c")]
	public partial class IfcResourceTime : IfcSchedulingTime
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcDuration? _ScheduleWork;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcPositiveRatioMeasure? _ScheduleUsage;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcDateTime? _ScheduleStart;
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		IfcDateTime? _ScheduleFinish;
	
		[DataMember(Order=4)] 
		[XmlAttribute]
		IfcLabel? _ScheduleContour;
	
		[DataMember(Order=5)] 
		[XmlAttribute]
		IfcDuration? _LevelingDelay;
	
		[DataMember(Order=6)] 
		Boolean? _IsOverAllocated;
	
		[DataMember(Order=7)] 
		[XmlAttribute]
		IfcDateTime? _StatusTime;
	
		[DataMember(Order=8)] 
		[XmlAttribute]
		IfcDuration? _ActualWork;
	
		[DataMember(Order=9)] 
		[XmlAttribute]
		IfcPositiveRatioMeasure? _ActualUsage;
	
		[DataMember(Order=10)] 
		[XmlAttribute]
		IfcDateTime? _ActualStart;
	
		[DataMember(Order=11)] 
		[XmlAttribute]
		IfcDateTime? _ActualFinish;
	
		[DataMember(Order=12)] 
		[XmlAttribute]
		IfcDuration? _RemainingWork;
	
		[DataMember(Order=13)] 
		[XmlAttribute]
		IfcPositiveRatioMeasure? _RemainingUsage;
	
		[DataMember(Order=14)] 
		[XmlAttribute]
		IfcPositiveRatioMeasure? _Completion;
	
	
		[Description(@"Indicates the total work (e.g. person-hours) allocated to the task on behalf of the resource. 
	Note: this is not necessarily the same as the task duration (IfcTaskTime.ScheduleDuration); it may vary according to the resource usage ratio and other resources assigned to the task.")]
		public IfcDuration? ScheduleWork { get { return this._ScheduleWork; } set { this._ScheduleWork = value;} }
	
		[Description(@"Indicates the amount of the resource used concurrently. For example, 100% means 1 worker, 300% means 3 workers, 50% means half of 1 worker's time for scenarios where multitasking is feasible. If not provided, then the usage ratio is considered to be 100%. ")]
		public IfcPositiveRatioMeasure? ScheduleUsage { get { return this._ScheduleUsage; } set { this._ScheduleUsage = value;} }
	
		[Description("Indicates the time when the resource is scheduled to start working.")]
		public IfcDateTime? ScheduleStart { get { return this._ScheduleStart; } set { this._ScheduleStart = value;} }
	
		[Description("Indicates the time when the resource is scheduled to finish working. ")]
		public IfcDateTime? ScheduleFinish { get { return this._ScheduleFinish; } set { this._ScheduleFinish = value;} }
	
		[Description(@"Indicates how a resource should be leveled over time by adjusting the resource usage according to a specified curve.  Standard values include: 'Flat', 'BackLoaded', 'FrontLoaded', 'DoublePeak', 'EarlyPeak', 'LatePeak', 'Bell', and 'Turtle'.  Custom values may specify a custom name or formula.")]
		public IfcLabel? ScheduleContour { get { return this._ScheduleContour; } set { this._ScheduleContour = value;} }
	
		[Description("Indicates a delay in the ScheduleStart caused by leveling.")]
		public IfcDuration? LevelingDelay { get { return this._LevelingDelay; } set { this._LevelingDelay = value;} }
	
		[Description("Indicates that the resource is scheduled in excess of its capacity.")]
		public Boolean? IsOverAllocated { get { return this._IsOverAllocated; } set { this._IsOverAllocated = value;} }
	
		[Description(@"Indicates the date and time for which status values are applicable; particularly completion, actual, and remaining values.  If values are time-phased (the referencing IfcConstructionResource has associated time series values for attributes), then the status values may be determined from such time-phased data as of the StatusTime.")]
		public IfcDateTime? StatusTime { get { return this._StatusTime; } set { this._StatusTime = value;} }
	
		[Description("Indicates the actual work performed by the resource as of the StatusTime.")]
		public IfcDuration? ActualWork { get { return this._ActualWork; } set { this._ActualWork = value;} }
	
		[Description("Indicates the actual amount of the resource used concurrently.")]
		public IfcPositiveRatioMeasure? ActualUsage { get { return this._ActualUsage; } set { this._ActualUsage = value;} }
	
		[Description("Indicates the time when the resource actually started working.")]
		public IfcDateTime? ActualStart { get { return this._ActualStart; } set { this._ActualStart = value;} }
	
		[Description("Indicates the time when the resource actually finished working.")]
		public IfcDateTime? ActualFinish { get { return this._ActualFinish; } set { this._ActualFinish = value;} }
	
		[Description("Indicates the work remaining to be completed by the resource.")]
		public IfcDuration? RemainingWork { get { return this._RemainingWork; } set { this._RemainingWork = value;} }
	
		public IfcPositiveRatioMeasure? RemainingUsage { get { return this._RemainingUsage; } set { this._RemainingUsage = value;} }
	
		[Description(@"Indicates the percent completion of this resource.  If the resource is assigned to a task, then indicates completion of the task on behalf of the resource; if the resource is partitioned into sub-allocations, then indicates overall completion of sub-allocations.")]
		public IfcPositiveRatioMeasure? Completion { get { return this._Completion; } set { this._Completion = value;} }
	
	
	}
	
}
