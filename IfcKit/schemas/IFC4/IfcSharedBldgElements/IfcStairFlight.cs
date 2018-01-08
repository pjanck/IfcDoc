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
using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMaterialResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcPropertyResource;
using BuildingSmart.IFC.IfcRepresentationResource;

namespace BuildingSmart.IFC.IfcSharedBldgElements
{
	[Guid("c9b965ff-02c6-41a5-937f-4788c8513e6c")]
	public partial class IfcStairFlight : IfcBuildingElement
	{
		[DataMember(Order=0)] 
		Int64? _NumberOfRiser;
	
		[DataMember(Order=1)] 
		Int64? _NumberOfTreads;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcPositiveLengthMeasure? _RiserHeight;
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		IfcPositiveLengthMeasure? _TreadLength;
	
		[DataMember(Order=4)] 
		[XmlAttribute]
		IfcStairFlightTypeEnum? _PredefinedType;
	
	
		[Description(@"<EPM-HTML>
	Number of the risers included in the stair flight
	<blockquote class=""change-ifc2x4"">IFC4 CHANGE  The attribute has been deprecated it shall only be exposed with a NIL value. Use Pset_StairFlightCommon.NumberOfRisers instead.</blockquote>
	</EPM-HTML>")]
		public Int64? NumberOfRiser { get { return this._NumberOfRiser; } set { this._NumberOfRiser = value;} }
	
		[Description(@"<EPM-HTML>
	Number of treads included in the stair flight.
	<blockquote class=""change-ifc2x4"">IFC4 CHANGE  The attribute has been deprecated it shall only be exposed with a NIL value. Use Pset_StairFlightCommon.NumberOfTreads instead.</blockquote>
	</EPM-HTML>")]
		public Int64? NumberOfTreads { get { return this._NumberOfTreads; } set { this._NumberOfTreads = value;} }
	
		[Description(@"<EPM-HTML>
	Vertical distance from tread to tread. The riser height is supposed to be equal for all stairs in a stair flight.
	  <blockquote class=""change-ifc2x4"">IFC4 CHANGE  The attribute has been deprecated it shall only be exposed with a NIL value. Use Pset_StairFlightCommon.RiserHeight instead.</blockquote>
	</EPM-HTML>")]
		public IfcPositiveLengthMeasure? RiserHeight { get { return this._RiserHeight; } set { this._RiserHeight = value;} }
	
		[Description(@"<EPM-HTML>
	Horizontal distance from the front to the back of the tread. The tread length is supposed to be equal for all steps of the stair flight.
	  <blockquote class=""change-ifc2x4"">IFC4 CHANGE  The attribute has been deprecated it shall only be exposed with a NIL value. Use Pset_StairFlightCommon.TreadLength instead.</blockquote>
	</EPM-HTML>")]
		public IfcPositiveLengthMeasure? TreadLength { get { return this._TreadLength; } set { this._TreadLength = value;} }
	
		[Description(@"<EPM-HTML>
	Predefined generic type for a stair flight that is specified in an enumeration. There may be a property set given specificly for the predefined types.
	<blockquote class=""note"">NOTE&nbsp; The <em>PredefinedType</em> shall only be used, if no <em>IfcStairFlightType</em> is assigned, providing its own <em>IfcStairFlightType.PredefinedType</em>.</blockquote>
	<blockquote class=""change-ifc2x4"">IFC4 CHANGE  The attribute has been added at the end of the entity definition.</blockquote>
	</EPM-HTML> ")]
		public IfcStairFlightTypeEnum? PredefinedType { get { return this._PredefinedType; } set { this._PredefinedType = value;} }
	
	
	}
	
}
