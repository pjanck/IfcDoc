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

using BuildingSmart.IFC.IfcApprovalResource;
using BuildingSmart.IFC.IfcConstraintResource;
using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcProductExtension;

namespace BuildingSmart.IFC.IfcControlExtension
{
	[Guid("e8ca45f2-cf0b-4a93-84ca-ea3c10c7b27e")]
	public partial class IfcPerformanceHistory : IfcControl
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcLabel _LifeCyclePhase;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcPerformanceHistoryTypeEnum? _PredefinedType;
	
	
		[Description("Describes the applicable building life-cycle phase. Typical values should be DESI" +
	    "GNDEVELOPMENT, SCHEMATICDEVELOPMENT, CONSTRUCTIONDOCUMENT, CONSTRUCTION, ASBUILT" +
	    ", COMMISSIONING, OPERATION, etc. ")]
		public IfcLabel LifeCyclePhase { get { return this._LifeCyclePhase; } set { this._LifeCyclePhase = value;} }
	
		[Description("<EPM-HTML>\r\nPredefined generic type for a performace history that is specified in" +
	    " an enumeration.\r\n<blockquote class=\"change-ifc2x4\">IFC4 CHANGE  The attribute h" +
	    "as been added at the end of the entity definition.</blockquote>\r\n</EPM-HTML> ")]
		public IfcPerformanceHistoryTypeEnum? PredefinedType { get { return this._PredefinedType; } set { this._PredefinedType = value;} }
	
	
	}
	
}
