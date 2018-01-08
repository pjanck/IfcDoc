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
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcProcessExtension;
using BuildingSmart.IFC.IfcPropertyResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcKernel
{
	[Guid("1d05673d-0b58-4733-862e-d6626abd1efb")]
	public partial class IfcTypeObject : IfcObjectDefinition
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcIdentifier? _ApplicableOccurrence;
	
		[DataMember(Order=1)] 
		ISet<IfcPropertySetDefinition> _HasPropertySets = new HashSet<IfcPropertySetDefinition>();
	
		[InverseProperty("RelatingType")] 
		ISet<IfcRelDefinesByType> _Types = new HashSet<IfcRelDefinesByType>();
	
	
		[Description(@"<EPM-HTML>
	The attribute optionally defines the data type of the occurrence object, to which the assigned type object can relate. If not present, no instruction is given to which occurrence object the type object is applicable. The following conventions are used:
	<ul>
	  <li>The IFC entity name of the applicable occurrence using the IFC naming convention, CamelCase with IFC prefix</li>
	  <li>It can be optionally followed by the predefined type after the separator ""/"" (forward slash), using Uupper case</li>
	  <li>If one type object is applicable to many occurrence objects, then those occurrence object names should be separate by comma "","" forming a comma separated string.
	</ul>
	<blockquote class=""example"">
	  EXAMPLE  Refering to a furniture as applicable occurrence entity would be expressed as 'IfcFurnishingElement', refering to a brace as applicable entity would be expressed as 'IfcMember/BRACE', refering to a wall and wall standard case would be expressed as 'IfcWall, IfcWallStandardCase'.
	</blockquote>
	</EPM-HTML>")]
		public IfcIdentifier? ApplicableOccurrence { get { return this._ApplicableOccurrence; } set { this._ApplicableOccurrence = value;} }
	
		[Description(@"<EPM-HTML>
	Set <strike>list</strike> of unique property sets, that are associated with the object type and are common to all object occurrences referring to this object type.
	<blockquote class=""change-ifc2x3"">IFC2x3 CHANGE&nbsp; The attribute aggregate type has been changed from LIST to SET.</blockquote>
	</EPM-HTML>")]
		public ISet<IfcPropertySetDefinition> HasPropertySets { get { return this._HasPropertySets; } }
	
		[Description("Reference to the relationship IfcRelDefinedByType and thus to those occurrence ob" +
	    "jects, which are defined by this type.")]
		public ISet<IfcRelDefinesByType> Types { get { return this._Types; } }
	
	
	}
	
}
