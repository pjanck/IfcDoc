// This file may be edited manually or auto-generated using IfcKit at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	public partial class IfcSweptDiskSolid : IfcSolidModel
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("The curve used to define the sweeping operation. The solid is generated by sweeping a circular disk along the <em>Directrix</em>.")]
		[Required()]
		public IfcCurve Directrix { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The <em>Radius</em> of the circular disk to be swept along the <em>directrix</em>. Denotes the outer radius, if an <em>InnerRadius</em> is applied.")]
		[Required()]
		public IfcPositiveLengthMeasure Radius { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("This attribute is optional, if present it defines the radius of a circular hole in the centre of the disk.")]
		public IfcPositiveLengthMeasure? InnerRadius { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("The parameter value on the <em>Directrix</em> at which the sweeping operation commences. <font color=\"#0000ff\">If no value is provided the start of the sweeping operation is at the start of the <em>Directrix</em>.</font>.   <blockquote class=\"change-ifc2x4\">IFC4 CHANGE&nbsp; The attribute has been changed to OPTIONAL with upward compatibility for file-based exchange.</blockquote>")]
		public IfcParameterValue? StartParam { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("The parameter value on the <em>Directrix</em> at which the sweeping operation ends. <font color=\"#0000ff\">If no value is provided the end of the sweeping operation is at the end of the <em>Directrix</em>.</font>.   <blockquote class=\"change-ifc2x4\">IFC4 CHANGE&nbsp; The attribute has been changed to OPTIONAL with upward compatibility for file-based exchange.</blockquote>")]
		public IfcParameterValue? EndParam { get; set; }
	
	
		public IfcSweptDiskSolid(IfcCurve __Directrix, IfcPositiveLengthMeasure __Radius, IfcPositiveLengthMeasure? __InnerRadius, IfcParameterValue? __StartParam, IfcParameterValue? __EndParam)
		{
			this.Directrix = __Directrix;
			this.Radius = __Radius;
			this.InnerRadius = __InnerRadius;
			this.StartParam = __StartParam;
			this.EndParam = __EndParam;
		}
	
	
	}
	
}
