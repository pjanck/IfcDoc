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
using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationDefinitionResource;
using BuildingSmart.IFC.IfcTopologyResource;

namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("0fa823f7-9891-4859-929d-fe07f0663bb1")]
	public partial class IfcTextureCoordinateGenerator : IfcTextureCoordinate
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcLabel _Mode;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IList<IfcReal> _Parameter = new List<IfcReal>();
	
	
		[Description(@"<EPM-HTML>
	The <em>Mode</em> attribute describes the algorithm used to compute texture coordinates.
	<blockquote class=""note"">NOTE&nbsp; The applicable values for the <em>Mode</em> attribute are determined by view definitions or implementer agreements. It is recommended to use the modes described in ISO/IES 19775-1.2:2008 X3D Architecture and base components Edition 2, Part 1. See <a href=""http://www.web3d.org/x3d/specifications/ISO-IEC-19775-1.2-X3D-AbstractSpecification/Part01/components/texturing.html#TextureCoordinateGenerator"">18.4.8 TextureCoordinateGenerator</a> for recommended values.</blockquote>
	</EPM-HTML>")]
		public IfcLabel Mode { get { return this._Mode; } set { this._Mode = value;} }
	
		[Description("<EPM-HTML>\r\nThe parameters used as arguments by the function as specified by <em>" +
	    "Mode</em>.\r\n<blockquote class=\"change-ifc2x4\">IFC4 CHANGE&nbsp: Data type restri" +
	    "cted to REAL.</blockquote>\r\n</EPM-HTML>")]
		public IList<IfcReal> Parameter { get { return this._Parameter; } }
	
	
	}
	
}
