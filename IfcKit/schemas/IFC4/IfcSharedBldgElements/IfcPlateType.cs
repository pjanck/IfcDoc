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
	[Guid("67bc5143-2c23-49ee-9fc3-422c27dd5452")]
	public partial class IfcPlateType : IfcBuildingElementType
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcPlateTypeEnum _PredefinedType;
	
	
		[Description("<EPM-HTML>\r\nIdentifies the predefined types of a planar member element from which" +
	    " the type required may be set.\r\n</EPM-HTML>")]
		public IfcPlateTypeEnum PredefinedType { get { return this._PredefinedType; } set { this._PredefinedType = value;} }
	
	
	}
	
}
