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
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPropertyResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcConstraintResource
{
	[Guid("d03dd5c6-bc93-4f7a-903f-d59e7c256d59")]
	public abstract partial class IfcConstraint :
		BuildingSmart.IFC.IfcExternalReferenceResource.IfcResourceObjectSelect
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcLabel _Name;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcText? _Description;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		[Required()]
		IfcConstraintEnum _ConstraintGrade;
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		IfcLabel? _ConstraintSource;
	
		[DataMember(Order=4)] 
		IfcActorSelect _CreatingActor;
	
		[DataMember(Order=5)] 
		[XmlAttribute]
		IfcDateTime? _CreationTime;
	
		[DataMember(Order=6)] 
		[XmlAttribute]
		IfcLabel? _UserDefinedGrade;
	
		[InverseProperty("RelatedResourceObjects")] 
		ISet<IfcExternalReferenceRelationship> _HasExternalReferences = new HashSet<IfcExternalReferenceRelationship>();
	
		[InverseProperty("RelatingConstraint")] 
		ISet<IfcResourceConstraintRelationship> _ConstrainedResources = new HashSet<IfcResourceConstraintRelationship>();
	
		[InverseProperty("RelatingConstraint")] 
		ISet<IfcRelAssociatesConstraint> _ConstrainedObjects = new HashSet<IfcRelAssociatesConstraint>();
	
	
		[Description("A name to be used for the constraint (e.g., ChillerCoefficientOfPerformance).")]
		public IfcLabel Name { get { return this._Name; } set { this._Name = value;} }
	
		[Description("A description that may apply additional information about a constraint.")]
		public IfcText? Description { get { return this._Description; } set { this._Description = value;} }
	
		[Description("Enumeration that qualifies the type of constraint.")]
		public IfcConstraintEnum ConstraintGrade { get { return this._ConstraintGrade; } set { this._ConstraintGrade = value;} }
	
		[Description("Any source material, such as a code or standard, from which the constraint origin" +
	    "ated.")]
		public IfcLabel? ConstraintSource { get { return this._ConstraintSource; } set { this._ConstraintSource = value;} }
	
		[Description("Person and/or organization that has created the constraint.")]
		public IfcActorSelect CreatingActor { get { return this._CreatingActor; } set { this._CreatingActor = value;} }
	
		[Description("Time when information specifying the constraint instance was created.")]
		public IfcDateTime? CreationTime { get { return this._CreationTime; } set { this._CreationTime = value;} }
	
		[Description(@"Allows for specification of user defined grade of the constraint  beyond the enumeration values (hard, soft, advisory) provided by ConstraintGrade attribute of type <em>IfcConstraintEnum</em>. 
	When a value is provided for attribute UserDefinedGrade in parallel the attribute ConstraintGrade shall have enumeration value USERDEFINED.")]
		public IfcLabel? UserDefinedGrade { get { return this._UserDefinedGrade; } set { this._UserDefinedGrade = value;} }
	
		[Description("<EPM-HTML>\r\nReference to an external references, e.g. library, classification, or" +
	    " document information, that are associated to the constraint.\r\n<blockquote class" +
	    "=\"change-ifc2x4\">IFC4 CHANGE New inverse attribute.</blockquote>\r\n</EPM-HTML> ")]
		public ISet<IfcExternalReferenceRelationship> HasExternalReferences { get { return this._HasExternalReferences; } }
	
		[Description("The set of relationships by which resource objects that are are constrained by th" +
	    "is constraint are known.")]
		public ISet<IfcResourceConstraintRelationship> ConstrainedResources { get { return this._ConstrainedResources; } }
	
		[Description("Reference to the <em>IfcRelAssociatesConstraint</em> instances associating this a" +
	    "pproval to objects.")]
		public ISet<IfcRelAssociatesConstraint> ConstrainedObjects { get { return this._ConstrainedObjects; } }
	
	
	}
	
}
