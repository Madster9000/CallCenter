using System;
using System.CodeDom.Compiler;
using System.Data.Services;
using System.Data.Services.Common;
using System.Runtime.Serialization;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Client.Metadata;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Support.Crm.Model.Entities
{
    /// <summary>
    /// Специальный тип действия, включающий такие сведения, как описание разрешения, статус выставления счета и длительность обращения.
    /// </summary>
    [DataContract()]
    [EntityLogicalName("incidentresolution")]
    [GeneratedCode("CrmSvcUtil", "5.0.9690.3739")]
    [DataServiceKey("Id")]
    [IgnoreProperties("Item", "Attributes", "EntityState", "FormattedValues", "RelatedEntities", "ExtensionData")]
    [Entity("IncidentResolutionSet")]
    public class IncidentResolution : CrmEntity
    {
		
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public IncidentResolution() : 
            base(EntityLogicalName)
        {
        }
		
        public const string EntityLogicalName = "incidentresolution";
		
        public const int EntityTypeCode = 4206;
		
        /// <summary>
        /// Уникальный идентификатор действия по разрешению обращения.
        /// </summary>
        [AttributeLogicalName("activityid")]
        public Guid? ActivityId
        {
            get
            {
                return GetAttributeValue<Nullable<Guid>>("activityid");
            }
            set
            {
                SetPrimaryIdAttributeValue<Nullable<Guid>>("ActivityId", "activityid", value);
            }
        }
		
        [AttributeLogicalName("activityid")]
        public override Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                ActivityId = value;
            }
        }
		
        /// <summary>
        /// Тип действия.
        /// </summary>
        [AttributeLogicalName("activitytypecode")]
        public string ActivityTypeCode
        {
            get
            {
                return GetAttributeValue<string>("activitytypecode");
            }
        }
		
        /// <summary>
        /// Фактическая длительность действия по разрешению обращения в минутах.
        /// </summary>
        [AttributeLogicalName("actualdurationminutes")]
        public int? ActualDurationMinutes
        {
            get
            {
                return GetAttributeValue<Nullable<int>>("actualdurationminutes");
            }
            set
            {
                SetAttributeValue<Nullable<int>>("ActualDurationMinutes", "actualdurationminutes", value);
            }
        }
		
        /// <summary>
        /// Фактическое время окончания действия по разрешению обращения.
        /// </summary>
        [AttributeLogicalName("actualend")]
        public DateTime? ActualEnd
        {
            get
            {
                return GetAttributeValue<Nullable<DateTime>>("actualend");
            }
            set
            {
                SetAttributeValue<Nullable<DateTime>>("ActualEnd", "actualend", value);
            }
        }
		
        /// <summary>
        /// Фактическое время начала действия по разрешению обращения.
        /// </summary>
        [AttributeLogicalName("actualstart")]
        public DateTime? ActualStart
        {
            get
            {
                return GetAttributeValue<DateTime?>("actualstart");
            }
            set
            {
                SetAttributeValue<DateTime?>("ActualStart", "actualstart", value);
            }
        }
		
        /// <summary>
        /// Категория действия по разрешению обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("category")]
        public string Category
        {
            get
            {
                return GetAttributeValue<string>("category");
            }
            set
            {
                SetAttributeValue<string>("Category", "category", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя, создавшего действие по разрешению обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("createdby")]
        public CrmEntityReference CreatedBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("createdby");
            }
        }
		
        /// <summary>
        /// Дата и время создания действия по разрешению обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("createdon")]
        public Nullable<DateTime> CreatedOn
        {
            get
            {
                return GetAttributeValue<Nullable<DateTime>>("createdon");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор делегированного пользователя, создавшего разрешение инцидента.
        /// </summary>
        [AttributeLogicalNameAttribute("createdonbehalfby")]
        public CrmEntityReference CreatedOnBehalfBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("createdonbehalfby");
            }
        }
		
        /// <summary>
        /// Специальный тип действия, включающий такие сведения, как описание разрешения, статус выставления счета и длительность обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("description")]
        public string Description
        {
            get
            {
                return GetAttributeValue<string>("description");
            }
            set
            {
                SetAttributeValue<string>("Description", "description", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор импорта или переноса данных, создавшего эту запись.
        /// </summary>
        [AttributeLogicalNameAttribute("importsequencenumber")]
        public Nullable<int> ImportSequenceNumber
        {
            get
            {
                return GetAttributeValue<Nullable<int>>("importsequencenumber");
            }
            set
            {
                SetAttributeValue<Nullable<int>>("ImportSequenceNumber", "importsequencenumber", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор обращения.
        /// </summary>
        [AttributeLogicalName("incidentid")]
        public CrmEntityReference IncidentId
        {
            get
            {
                return GetAttributeValue<EntityReference>("incidentid");
            }
            set
            {
                SetAttributeValue<EntityReference>("IncidentId", "incidentid", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, был ли выставлен счет по действию как часть разрешения обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("isbilled")]
        public Nullable<bool> IsBilled
        {
            get
            {
                return GetAttributeValue<Nullable<bool>>("isbilled");
            }
            set
            {
                SetAttributeValue<Nullable<bool>>("IsBilled", "isbilled", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, является ли действие обычным действием или событием.
        /// </summary>
        [AttributeLogicalNameAttribute("isregularactivity")]
        public Nullable<bool> IsRegularActivity
        {
            get
            {
                return GetAttributeValue<Nullable<bool>>("isregularactivity");
            }
        }
		
        /// <summary>
        /// Сведения, указывающие, было ли действие по разрешению обращения создано из бизнес-правила.
        /// </summary>
        [AttributeLogicalNameAttribute("isworkflowcreated")]
        public Nullable<bool> IsWorkflowCreated
        {
            get
            {
                return GetAttributeValue<Nullable<bool>>("isworkflowcreated");
            }
            set
            {
                SetAttributeValue<Nullable<bool>>("IsWorkflowCreated", "isworkflowcreated", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор последнего пользователя, изменившего действие по разрешению обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("modifiedby")]
        public CrmEntityReference ModifiedBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("modifiedby");
            }
        }
		
        /// <summary>
        /// Дата и время последнего изменения действия по разрешению обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("modifiedon")]
        public Nullable<DateTime> ModifiedOn
        {
            get
            {
                return GetAttributeValue<Nullable<DateTime>>("modifiedon");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор последнего делегированного пользователя, изменившего разрешение инцидента.
        /// </summary>
        [AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public CrmEntityReference ModifiedOnBehalfBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("modifiedonbehalfby");
            }
        }
		
        /// <summary>
        /// Дата и время переноса записи.
        /// </summary>
        [AttributeLogicalNameAttribute("overriddencreatedon")]
        public Nullable<DateTime> OverriddenCreatedOn
        {
            get
            {
                return GetAttributeValue<Nullable<DateTime>>("overriddencreatedon");
            }
            set
            {
                SetAttributeValue<Nullable<DateTime>>("OverriddenCreatedOn", "overriddencreatedon", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователей или рабочих групп, ответственных за действие по разрешению обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("ownerid")]
        public CrmEntityReference OwnerId
        {
            get
            {
                return GetAttributeValue<EntityReference>("ownerid");
            }
            set
            {
                SetAttributeValue<EntityReference>("OwnerId", "ownerid", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор подразделения, ответственного за действие по разрешению обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("owningbusinessunit")]
        public CrmEntityReference OwningBusinessUnit
        {
            get
            {
                return GetAttributeValue<EntityReference>("owningbusinessunit");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор рабочей группы, ответственной за разрешение обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("owningteam")]
        public CrmEntityReference OwningTeam
        {
            get
            {
                return GetAttributeValue<EntityReference>("owningteam");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя, ответственного за разрешение обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("owninguser")]
        public CrmEntityReference OwningUser
        {
            get
            {
                return GetAttributeValue<EntityReference>("owninguser");
            }
        }
		
        /// <summary>
        /// Запланированная длительность действия по разрешению обращения, указанная в минутах.
        /// </summary>
        [AttributeLogicalNameAttribute("scheduleddurationminutes")]
        public Nullable<int> ScheduledDurationMinutes
        {
            get
            {
                return GetAttributeValue<Nullable<int>>("scheduleddurationminutes");
            }
        }
		
        /// <summary>
        /// Плановое время окончания действия по разрешению обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("scheduledend")]
        public Nullable<DateTime> ScheduledEnd
        {
            get
            {
                return GetAttributeValue<Nullable<DateTime>>("scheduledend");
            }
            set
            {
                SetAttributeValue<Nullable<DateTime>>("ScheduledEnd", "scheduledend", value);
            }
        }
		
        /// <summary>
        /// Плановое время начала действия по разрешению обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("scheduledstart")]
        public Nullable<DateTime> ScheduledStart
        {
            get
            {
                return GetAttributeValue<Nullable<DateTime>>("scheduledstart");
            }
            set
            {
                SetAttributeValue<Nullable<DateTime>>("ScheduledStart", "scheduledstart", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор сервиса, с которым связано действие по разрешению обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("serviceid")]
        public CrmEntityReference ServiceId
        {
            get
            {
                return GetAttributeValue<EntityReference>("serviceid");
            }
            set
            {
                SetAttributeValue<EntityReference>("ServiceId", "serviceid", value);
            }
        }
		
        /// <summary>
        /// Состояние действия по разрешению обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("statecode")]
        public Nullable<int> StateCode
        {
            get
            {
                return GetAttributeValue<Nullable<int>>("statecode");
            }
        }
		
        /// <summary>
        /// Состояние действия по разрешению обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("statuscode")]
        public Nullable<int> StatusCode
        {
            get
            {
                return GetAttributeValue<Nullable<int>>("statuscode");
            }
            set
            {
                SetAttributeValue<OptionSetValue>("StatusCode", "statuscode", value);
            }
        }
		
        /// <summary>
        /// Подкатегория действия по разрешению обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("subcategory")]
        public string Subcategory
        {
            get
            {
                return GetAttributeValue<string>("subcategory");
            }
            set
            {
                SetAttributeValue<string>("Subcategory", "subcategory", value);
            }
        }
		
        /// <summary>
        /// Тема, связанная с действием по разрешению обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("subject")]
        public string Subject
        {
            get
            {
                return GetAttributeValue<string>("subject");
            }
            set
            {
                SetAttributeValue<string>("Subject", "subject", value);
            }
        }
		
        /// <summary>
        /// Время, затраченное на действие по разрешению обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("timespent")]
        public Nullable<int> TimeSpent
        {
            get
            {
                return GetAttributeValue<Nullable<int>>("timespent");
            }
            set
            {
                SetAttributeValue<Nullable<int>>("TimeSpent", "timespent", value);
            }
        }
		
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [AttributeLogicalNameAttribute("timezoneruleversionnumber")]
        public Nullable<int> TimeZoneRuleVersionNumber
        {
            get
            {
                return GetAttributeValue<Nullable<int>>("timezoneruleversionnumber");
            }
            set
            {
                SetAttributeValue<Nullable<int>>("TimeZoneRuleVersionNumber", "timezoneruleversionnumber", value);
            }
        }
		
        /// <summary>
        /// Код часового пояса, использовавшийся при создании записи.
        /// </summary>
        [AttributeLogicalNameAttribute("utcconversiontimezonecode")]
        public Nullable<int> UTCConversionTimeZoneCode
        {
            get
            {
                return GetAttributeValue<Nullable<int>>("utcconversiontimezonecode");
            }
            set
            {
                SetAttributeValue<Nullable<int>>("UTCConversionTimeZoneCode", "utcconversiontimezonecode", value);
            }
        }
		
        /// <summary>
        /// Номер версии обращения.
        /// </summary>
        [AttributeLogicalNameAttribute("versionnumber")]
        public Nullable<long> VersionNumber
        {
            get
            {
                return GetAttributeValue<Nullable<long>>("versionnumber");
            }
        }
		
        /// <summary>
        /// 1:N incidentresolution_activity_parties
        /// </summary>
        [RelationshipSchemaNameAttribute("incidentresolution_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> incidentresolution_activity_parties
        {
            get
            {
                return GetRelatedEntities<ActivityParty>("incidentresolution_activity_parties", null);
            }
            set
            {
                SetRelatedEntities<ActivityParty>("incidentresolution_activity_parties", "incidentresolution_activity_parties", null, value);
            }
        }
		
        /// <summary>
        /// 1:N IncidentResolution_Annotation
        /// </summary>
        [RelationshipSchemaNameAttribute("IncidentResolution_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> IncidentResolution_Annotation
        {
            get
            {
                return GetRelatedEntities<Annotation>("IncidentResolution_Annotation", null);
            }
            set
            {
                SetRelatedEntities<Annotation>("IncidentResolution_Annotation", "IncidentResolution_Annotation", null, value);
            }
        }
		
        /// <summary>
        /// N:1 activity_pointer_incident_resolution
        /// </summary>
        [AttributeLogicalNameAttribute("activityid")]
        [RelationshipSchemaNameAttribute("activity_pointer_incident_resolution")]
        public ActivityPointer activity_pointer_incident_resolution
        {
            get
            {
                return GetRelatedEntity<ActivityPointer>("activity_pointer_incident_resolution", null);
            }
            set
            {
                SetRelatedEntity("activity_pointer_incident_resolution", "activity_pointer_incident_resolution", null, value);
            }
        }
		
        /// <summary>
        /// N:1 Incident_IncidentResolutions
        /// </summary>
        [AttributeLogicalNameAttribute("incidentid")]
        [RelationshipSchemaNameAttribute("Incident_IncidentResolutions")]
        public Incident Incident_IncidentResolutions
        {
            get
            {
                return GetRelatedEntity<Incident>("Incident_IncidentResolutions", null);
            }
            set
            {
                SetRelatedEntity<Incident>("Incident_IncidentResolutions", "Incident_IncidentResolutions", null, value);
            }
        }
		
        /// <summary>
        /// N:1 lk_incidentresolution_createdby
        /// </summary>
        [AttributeLogicalNameAttribute("createdby")]
        [RelationshipSchemaNameAttribute("lk_incidentresolution_createdby")]
        public SystemUser lk_incidentresolution_createdby
        {
            get
            {
                return GetRelatedEntity<SystemUser>("lk_incidentresolution_createdby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_incidentresolution_createdonbehalfby
        /// </summary>
        [AttributeLogicalNameAttribute("createdonbehalfby")]
        [RelationshipSchemaNameAttribute("lk_incidentresolution_createdonbehalfby")]
        public SystemUser lk_incidentresolution_createdonbehalfby
        {
            get
            {
                return GetRelatedEntity<SystemUser>("lk_incidentresolution_createdonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_incidentresolution_modifiedby
        /// </summary>
        [AttributeLogicalNameAttribute("modifiedby")]
        [RelationshipSchemaNameAttribute("lk_incidentresolution_modifiedby")]
        public SystemUser lk_incidentresolution_modifiedby
        {
            get
            {
                return GetRelatedEntity<SystemUser>("lk_incidentresolution_modifiedby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_incidentresolution_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [RelationshipSchemaNameAttribute("lk_incidentresolution_modifiedonbehalfby")]
        public SystemUser lk_incidentresolution_modifiedonbehalfby
        {
            get
            {
                return GetRelatedEntity<SystemUser>("lk_incidentresolution_modifiedonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 team_incidentresolution
        /// </summary>
        [AttributeLogicalNameAttribute("owningteam")]
        [RelationshipSchemaNameAttribute("team_incidentresolution")]
        public Team team_incidentresolution
        {
            get
            {
                return GetRelatedEntity<Team>("team_incidentresolution", null);
            }
        }
		
        /// <summary>
        /// N:1 user_incidentresolution
        /// </summary>
        [AttributeLogicalNameAttribute("owninguser")]
        [RelationshipSchemaNameAttribute("user_incidentresolution")]
        public SystemUser user_incidentresolution
        {
            get
            {
                return GetRelatedEntity<SystemUser>("user_incidentresolution", null);
            }
        }
    }
}