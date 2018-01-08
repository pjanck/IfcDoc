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
	[Guid("5307e7a4-2270-4ad7-9e3c-ba76198cc09e")]
	public partial class IfcRelVoidsElement : IfcRelDecomposes
	{
		[DataMember(Order=0)] 
		[XmlElement("IfcElement")]
		[Required()]
		IfcElement _RelatingBuildingElement;
	
		[DataMember(Order=1)] 
		[XmlElement("IfcFeatureElementSubtraction")]
		[Required()]
		IfcFeatureElementSubtraction _RelatedOpeningElement;
	
	
		[Description(@"<EPM-HTML>
	Reference to element in which a void is created by associated feature subtraction element.
	<blockquote class=""change-ifc2x"">IFC2x CHANGE&nbsp; The data type has been changed from <em>IfcBuildingElement</em> to <em>IfcElement</em> with upward compatibility for file based exchange.</blockquote>
	</EPM-HTML>
	")]
		public IfcElement RelatingBuildingElement { get { return this._RelatingBuildingElement; } set { this._RelatingBuildingElement = value;} }
	
		[Description(@"<EPM-HTML>
	Reference to the feature subtraction element which defines a void in the associated element.
	<blockquote class=""change-ifc2x"">IFC2x CHANGE&nbsp; The data type has been changed from <em>IfcOpeningElement</em> to <em>IfcFeatureElementSubtraction</em> with upward compatibility for file based exchange.</blockquote>
	</EPM-HTML>")]
		public IfcFeatureElementSubtraction RelatedOpeningElement { get { return this._RelatedOpeningElement; } set { this._RelatedOpeningElement = value;} }
	
	
	}
	
}
