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

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcCostResource;
using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;

namespace BuildingSmart.IFC.IfcProcessExtension
{
	[Guid("d05923c3-37a8-444a-b811-bf0709bab84f")]
	public partial class IfcWorkCalendar : IfcControl
	{
		[DataMember(Order=0)] 
		ISet<IfcWorkTime> _WorkingTimes = new HashSet<IfcWorkTime>();
	
		[DataMember(Order=1)] 
		ISet<IfcWorkTime> _ExceptionTimes = new HashSet<IfcWorkTime>();
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcWorkCalendarTypeEnum? _PredefinedType;
	
	
		[Description("<EPM-HTML>\r\n    Set of times periods that are regarded as an initial set-up\r\n    " +
	    "of working times. Exception times can then further restrict\r\n    these working t" +
	    "imes.\r\n</EPM-HTML>\r\n ")]
		public ISet<IfcWorkTime> WorkingTimes { get { return this._WorkingTimes; } }
	
		[Description("<EPM-HTML>\r\n    Set of times periods that define exceptions (non-working\r\n    tim" +
	    "es) for the given working times including the base\r\n    calendar, if provided.\r\n" +
	    "</EPM-HTML>")]
		public ISet<IfcWorkTime> ExceptionTimes { get { return this._ExceptionTimes; } }
	
		[Description("<EPM-HTML>\r\n    Identifies the predefined types of a work calendar from which \r\n " +
	    "   the type required may be set.\r\n    <blockquote class=\"change-ifc2x4\">IFC4 CHA" +
	    "NGE  Attribute added</blockquote>\r\n</EPM-HTML>")]
		public IfcWorkCalendarTypeEnum? PredefinedType { get { return this._PredefinedType; } set { this._PredefinedType = value;} }
	
	
	}
	
}
