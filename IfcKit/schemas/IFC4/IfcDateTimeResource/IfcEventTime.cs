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
	[Guid("0d780540-b4aa-49d6-a0d5-4c6e14da3427")]
	public partial class IfcEventTime : IfcSchedulingTime
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcDateTime? _ActualDate;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcDateTime? _EarlyDate;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcDateTime? _LateDate;
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		IfcDateTime? _ScheduleDate;
	
	
		[Description("<EPM-HTML>\r\n     The date on which an event actually occurs. It is a measured val" +
	    "ue.\r\n</EPM-HTML>\r\n")]
		public IfcDateTime? ActualDate { get { return this._ActualDate; } set { this._ActualDate = value;} }
	
		[Description("<EPM-HTML>\r\n     The earliest date on which an event can occur. It is a calculate" +
	    "d value.\r\n</EPM-HTML>")]
		public IfcDateTime? EarlyDate { get { return this._EarlyDate; } set { this._EarlyDate = value;} }
	
		[Description("<EPM-HTML>\r\n     The latest date on which an event can occur. It is a calculated " +
	    "value.\r\n</EPM-HTML>")]
		public IfcDateTime? LateDate { get { return this._LateDate; } set { this._LateDate = value;} }
	
		[Description("<EPM-HTML>\r\n    The date on which an event is scheduled to occur. \r\n    The value" +
	    " might be measured or somehow calculated, which is defined by\r\n    <em>ScheduleD" +
	    "ataOrigin</em>.\r\n\r\n</EPM-HTML>")]
		public IfcDateTime? ScheduleDate { get { return this._ScheduleDate; } set { this._ScheduleDate = value;} }
	
	
	}
	
}
