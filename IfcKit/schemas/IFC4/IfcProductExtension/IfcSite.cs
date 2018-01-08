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
using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMaterialResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPropertyResource;
using BuildingSmart.IFC.IfcQuantityResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcSharedBldgElements;
using BuildingSmart.IFC.IfcSharedBldgServiceElements;
using BuildingSmart.IFC.IfcSharedComponentElements;
using BuildingSmart.IFC.IfcSharedFacilitiesElements;
using BuildingSmart.IFC.IfcStructuralElementsDomain;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("1208b73f-6d28-45b8-bda4-7dc5d67a886b")]
	public partial class IfcSite : IfcSpatialStructureElement
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcCompoundPlaneAngleMeasure? _RefLatitude;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcCompoundPlaneAngleMeasure? _RefLongitude;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcLengthMeasure? _RefElevation;
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		IfcLabel? _LandTitleNumber;
	
		[DataMember(Order=4)] 
		[XmlElement("IfcPostalAddress")]
		IfcPostalAddress _SiteAddress;
	
	
		[Description(@"<EPM-HTML>
	World Latitude at reference point (most likely defined in legal description). Defined as integer values for degrees, minutes, seconds, and, optionally, millionths of seconds with respect to the world geodetic system WGS84.
	<blockquote class=""note"">NOTE&nbsp; Latitudes are measured relative to the geodetic equator, north of the equator by positive values - from 0 till +90,   south of the equator by negative values - from 0 till  -90.</blockquote>
	</EPM-HTML>")]
		public IfcCompoundPlaneAngleMeasure? RefLatitude { get { return this._RefLatitude; } set { this._RefLatitude = value;} }
	
		[Description(@"<EPM-HTML>
	World Longitude at reference point (most likely defined in legal description). Defined as integer values for degrees, minutes, seconds, and, optionally, millionths of seconds with respect to the world geodetic system WGS84.
	<blockquote class=""note"">NOTE&nbsp; Longitudes are measured relative to the geodetic zero meridian, nominally the same as the Greenwich prime meridian: longitudes west of the zero meridian have negative values - from 0 till -180, longitudes east of the zero meridian have positive values - from 0 till -180.</blockquote>
	<blockquote class=""example"">EXAMPLE&nbsp; Chicago Harbor Light has according to WGS84 a longitude -87.35.40 (or 87.35.40W) and a latitude 41.53.30 (or 41.53.30N).</blockquote>
	</EPM-HTML>")]
		public IfcCompoundPlaneAngleMeasure? RefLongitude { get { return this._RefLongitude; } set { this._RefLongitude = value;} }
	
		[Description("Datum elevation relative to sea level.\r\n")]
		public IfcLengthMeasure? RefElevation { get { return this._RefElevation; } set { this._RefElevation = value;} }
	
		[Description("The land title number (designation of the site within a regional system).")]
		public IfcLabel? LandTitleNumber { get { return this._LandTitleNumber; } set { this._LandTitleNumber = value;} }
	
		[Description("Address given to the site for postal purposes.")]
		public IfcPostalAddress SiteAddress { get { return this._SiteAddress; } set { this._SiteAddress = value;} }
	
	
	}
	
}
