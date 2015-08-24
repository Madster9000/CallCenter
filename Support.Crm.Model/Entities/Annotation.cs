namespace Support.Crm.Model.Entities
{
    /// <summary>
    /// Примечание, которое прикреплено к одному или нескольким объектам, в том числе другим примечаниям.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("annotation")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9690.3739")]
    [System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    [System.Data.Services.IgnorePropertiesAttribute("Item", "Attributes", "EntityState", "FormattedValues", "RelatedEntities", "ExtensionData")]
    [Microsoft.Xrm.Client.Metadata.EntityAttribute("AnnotationSet")]
    public partial class Annotation : Microsoft.Xrm.Client.CrmEntity
    {
		
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Annotation() : 
            base(EntityLogicalName)
        {
        }
		
        public const string EntityLogicalName = "annotation";
		
        public const int EntityTypeCode = 5;
		
        /// <summary>
        /// Unique identifier of the note. 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annotationid")]
        public System.Nullable<System.Guid> AnnotationId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("annotationid");
            }
            set
            {
                this.SetPrimaryIdAttributeValue<System.Nullable<System.Guid>>("AnnotationId", "annotationid", value);
            }
        }
		
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annotationid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.AnnotationId = value;
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя, создавшего примечание.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Client.CrmEntityReference CreatedBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
            }
        }
		
        /// <summary>
        /// Дата и время создания примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор делегата, создавшего заметку.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Client.CrmEntityReference CreatedOnBehalfBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
            }
        }
		
        /// <summary>
        /// Содержимое вложения примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("documentbody")]
        public string DocumentBody
        {
            get
            {
                return this.GetAttributeValue<string>("documentbody");
            }
            set
            {
                this.SetAttributeValue<string>("DocumentBody", "documentbody", value);
            }
        }
		
        /// <summary>
        /// Имя файла примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filename")]
        public string FileName
        {
            get
            {
                return this.GetAttributeValue<string>("filename");
            }
            set
            {
                this.SetAttributeValue<string>("FileName", "filename", value);
            }
        }
		
        /// <summary>
        /// Размер файла примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filesize")]
        public System.Nullable<int> FileSize
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("filesize");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор импорта или переноса данных, создавшего эту запись.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
        public System.Nullable<int> ImportSequenceNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("ImportSequenceNumber", "importsequencenumber", value);
            }
        }
		
        /// <summary>
        /// Specifies whether the note is an attachment. 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdocument")]
        public System.Nullable<bool> IsDocument
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isdocument");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("IsDocument", "isdocument", value);
            }
        }
		
        /// <summary>
        /// Идентификатор языка примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("langid")]
        public string LangId
        {
            get
            {
                return this.GetAttributeValue<string>("langid");
            }
            set
            {
                this.SetAttributeValue<string>("LangId", "langid", value);
            }
        }
		
        /// <summary>
        /// Тип MIME вложения примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mimetype")]
        public string MimeType
        {
            get
            {
                return this.GetAttributeValue<string>("mimetype");
            }
            set
            {
                this.SetAttributeValue<string>("MimeType", "mimetype", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя, который последним изменил примечание.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Client.CrmEntityReference ModifiedBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
            }
        }
		
        /// <summary>
        /// Дата и время последнего изменения примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор делегата, который последним изменил заметку.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Client.CrmEntityReference ModifiedOnBehalfBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
            }
        }
		
        /// <summary>
        /// Текст примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("notetext")]
        public string NoteText
        {
            get
            {
                return this.GetAttributeValue<string>("notetext");
            }
            set
            {
                this.SetAttributeValue<string>("NoteText", "notetext", value);
            }
        }
		
        /// <summary>
        /// Unique identifier of the object with which the note is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        public Microsoft.Xrm.Client.CrmEntityReference ObjectId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("objectid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ObjectId", "objectid", value);
            }
        }
		
        /// <summary>
        /// Тип сущности, с которой связано примечание.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
        public string ObjectTypeCode
        {
            get
            {
                return this.GetAttributeValue<string>("objecttypecode");
            }
            set
            {
                this.SetAttributeValue<string>("ObjectTypeCode", "objecttypecode", value);
            }
        }
		
        /// <summary>
        /// Дата и время переноса записи.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("OverriddenCreatedOn", "overriddencreatedon", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя или рабочей группы, ответственных за примечание.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Client.CrmEntityReference OwnerId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("OwnerId", "ownerid", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор подразделения, ответственного за примечание.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Client.CrmEntityReference OwningBusinessUnit
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор рабочей группы, ответственной за примечание.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Client.CrmEntityReference OwningTeam
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя, ответственного за примечание.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Client.CrmEntityReference OwningUser
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
            }
        }
		
        /// <summary>
        /// Идентификатор шага бизнес-процесса, связанного с примечанием.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stepid")]
        public string StepId
        {
            get
            {
                return this.GetAttributeValue<string>("stepid");
            }
            set
            {
                this.SetAttributeValue<string>("StepId", "stepid", value);
            }
        }
		
        /// <summary>
        /// Тема, связанная с примечанием.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subject")]
        public string Subject
        {
            get
            {
                return this.GetAttributeValue<string>("subject");
            }
            set
            {
                this.SetAttributeValue<string>("Subject", "subject", value);
            }
        }
		
        /// <summary>
        /// Номер версии примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
            }
        }
		
        /// <summary>
        /// N:1 Account_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Annotation")]
        public Account Account_Annotation
        {
            get
            {
                return this.GetRelatedEntity<Account>("Account_Annotation", null);
            }
            set
            {
                this.SetRelatedEntity<Account>("Account_Annotation", "Account_Annotation", null, value);
            }
        }
		
        /// <summary>
        /// N:1 annotation_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("annotation_owning_user")]
        public SystemUser annotation_owning_user
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("annotation_owning_user", null);
            }
        }
		
        /// <summary>
        /// N:1 Contact_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Annotation")]
        public Contact Contact_Annotation
        {
            get
            {
                return this.GetRelatedEntity<Contact>("Contact_Annotation", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("Contact_Annotation", "Contact_Annotation", null, value);
            }
        }
		
        /// <summary>
        /// N:1 Email_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_Annotation")]
        public Email Email_Annotation
        {
            get
            {
                return this.GetRelatedEntity<Email>("Email_Annotation", null);
            }
            set
            {
                this.SetRelatedEntity<Email>("Email_Annotation", "Email_Annotation", null, value);
            }
        }
		
        /// <summary>
        /// N:1 Incident_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_Annotation")]
        public Incident Incident_Annotation
        {
            get
            {
                return this.GetRelatedEntity<Incident>("Incident_Annotation", null);
            }
            set
            {
                this.SetRelatedEntity<Incident>("Incident_Annotation", "Incident_Annotation", null, value);
            }
        }
		
        /// <summary>
        /// N:1 iok_action_send_sms_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_action_send_sms_Annotations")]
        public iok_action_send_SMS iok_action_send_sms_Annotations
        {
            get
            {
                return this.GetRelatedEntity<iok_action_send_SMS>("iok_action_send_sms_Annotations", null);
            }
            set
            {
                this.SetRelatedEntity<iok_action_send_SMS>("iok_action_send_sms_Annotations", "iok_action_send_sms_Annotations", null, value);
            }
        }
		
        /// <summary>
        /// N:1 iok_getphonecall_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_getphonecall_Annotations")]
        public iok_getphonecall iok_getphonecall_Annotations
        {
            get
            {
                return this.GetRelatedEntity<iok_getphonecall>("iok_getphonecall_Annotations", null);
            }
            set
            {
                this.SetRelatedEntity<iok_getphonecall>("iok_getphonecall_Annotations", "iok_getphonecall_Annotations", null, value);
            }
        }
		
        /// <summary>
        /// N:1 lk_annotationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_createdby")]
        public SystemUser lk_annotationbase_createdby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_annotationbase_createdby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_annotationbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_createdonbehalfby")]
        public SystemUser lk_annotationbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_annotationbase_createdonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_annotationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_modifiedby")]
        public SystemUser lk_annotationbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_annotationbase_modifiedby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_annotationbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_modifiedonbehalfby")]
        public SystemUser lk_annotationbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_annotationbase_modifiedonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 new_probe_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_probe_Annotations")]
        public New_Probe new_probe_Annotations
        {
            get
            {
                return this.GetRelatedEntity<New_Probe>("new_probe_Annotations", null);
            }
            set
            {
                this.SetRelatedEntity<New_Probe>("new_probe_Annotations", "new_probe_Annotations", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_shtrafy_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_shtrafy_Annotations")]
        public new_shtrafy new_shtrafy_Annotations
        {
            get
            {
                return this.GetRelatedEntity<new_shtrafy>("new_shtrafy_Annotations", null);
            }
            set
            {
                this.SetRelatedEntity<new_shtrafy>("new_shtrafy_Annotations", "new_shtrafy_Annotations", null, value);
            }
        }
		
        /// <summary>
        /// N:1 svk_project_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_project_Annotations")]
        public svk_project svk_project_Annotations
        {
            get
            {
                return this.GetRelatedEntity<svk_project>("svk_project_Annotations", null);
            }
            set
            {
                this.SetRelatedEntity<svk_project>("svk_project_Annotations", "svk_project_Annotations", null, value);
            }
        }
    }
}