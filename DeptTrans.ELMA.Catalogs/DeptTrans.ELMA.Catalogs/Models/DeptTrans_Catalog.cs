namespace DeptTrans.ELMA.Catalogs.Models
{
    using System;
    using System.Linq;
    using EleWise.ELMA.Extensions;
    using Iesi.Collections.Generic;
    
    
    /// <summary>
    /// Список справочников
    /// </summary>
    [global::EleWise.ELMA.Model.Attributes.MetadataType(typeof(global::EleWise.ELMA.Model.Metadata.EntityMetadata))]
    [global::EleWise.ELMA.Model.Attributes.Uid("0a89b5ac-ba2c-4283-a3ab-7738cae7a505")]
    [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IDeptTrans_Catalog), "DisplayName")]
    [global::EleWise.ELMA.Model.Attributes.DisplayFormat(null)]
    [global::EleWise.ELMA.Model.Attributes.ClassFormsScheme(global::EleWise.ELMA.Model.Metadata.ClassFormsScheme.FormConstructor)]
    [global::EleWise.ELMA.Model.Attributes.Form(typeof(IDeptTrans_Catalog), "DeptTrans.ELMA.Catalogs.Models.DeptTrans_Catalog.Form.Form.xml")]
    [global::EleWise.ELMA.Model.Attributes.TableView(@"<?xml version=""1.0"" encoding=""utf-8""?>
<TableView xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <Uid>548e87a8-650e-4e25-83a3-3e9144c9f319</Uid>
  <ViewType>List</ViewType>
  <SortDescriptors />
  <GroupDescriptors />
</TableView>")]
    [global::EleWise.ELMA.Model.Attributes.Entity("DeptTrans_Catalog")]
    [global::EleWise.ELMA.Model.Attributes.IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [global::EleWise.ELMA.Model.Attributes.EntityMetadataType(global::EleWise.ELMA.Model.Metadata.EntityMetadataType.Interface)]
    [global::EleWise.ELMA.Model.Attributes.SaveHistory()]
    [global::EleWise.ELMA.Model.Attributes.ShowInCatalogList()]
    [global::EleWise.ELMA.Model.Attributes.Filterable()]
    [global::EleWise.ELMA.Model.Attributes.ImplementationUid("7f1e0dfa-c34c-4200-a75a-703ac7de4ee7")]
    [global::EleWise.ELMA.Model.Attributes.FilterType(typeof(IDeptTrans_CatalogFilter))]
    public partial interface IDeptTrans_Catalog : global::EleWise.ELMA.Model.Entities.IEntity<long>
    {
        
        /// <summary>
        /// UID
        /// </summary>
        [global::EleWise.ELMA.Model.Attributes.Uid("d9b1a2a9-cf6a-4df5-872c-898060e775a9")]
        [global::EleWise.ELMA.ComponentModel.NotNull()]
        [global::EleWise.ELMA.Model.Attributes.SystemProperty()]
        [global::EleWise.ELMA.Model.Attributes.Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
        [global::EleWise.ELMA.Model.Types.Settings.GuidSettings(FieldName="Uid")]
        [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IDeptTrans_Catalog), "P_Uid_DisplayName")]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.All, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Hidden, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.EntityProperty()]
        System.Guid Uid
        {
            get;
            set;
        }
        
        /// <summary>
        /// Справочник
        /// </summary>
        [global::EleWise.ELMA.Model.Attributes.Uid("4ded7db4-13f2-4197-b9fc-fd764423688a")]
        [global::EleWise.ELMA.Model.Attributes.Order(1)]
        [global::EleWise.ELMA.Model.Attributes.Property("2df8e9ca-3ac4-4ba5-832f-18f6374397e7")]
        [global::EleWise.ELMA.Model.Types.Settings.ReferenceOnEntityTypeSettings(FieldName="Spravochnik")]
        [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IDeptTrans_Catalog), "P_Spravochnik_DisplayName")]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Create, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Edit, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Display, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.List, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Filter, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.Filterable()]
        [global::EleWise.ELMA.Model.Attributes.EntityProperty()]
        EleWise.ELMA.Model.Entities.EntityReferences.ReferenceOnEntityType Spravochnik
        {
            get;
            set;
        }
    }
    
    internal class @__Resources_IDeptTrans_Catalog
    {
        
        public static string DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Список справочников");
            }
        }
        
        public static string P_Uid_DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("UID");
            }
        }
        
        public static string P_Spravochnik_DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Справочник");
            }
        }
        
        private static string @__AllFormsResources
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Создание");
                return global::EleWise.ELMA.SR.T("Запись справочника");
            }
        }
        
        public static string FP_TypeUidSpravochnika_DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("TypeUid справочника");
            }
        }
    }
    
    /// <summary>
    /// Filter for the "Список справочников" object
    /// </summary>
    [global::EleWise.ELMA.Model.Attributes.FilterFor(typeof(IDeptTrans_Catalog))]
    public interface IDeptTrans_CatalogFilter : global::EleWise.ELMA.Model.Common.IEntityFilter
    {
        
        /// <summary>
        /// Filter for the "Справочник" property
        /// </summary>
        EleWise.ELMA.Model.Entities.EntityReferences.ReferenceOnEntityType Spravochnik
        {
            get;
            set;
        }
        
        /// <summary>
        /// TypeUid справочника
        /// </summary>
        [global::EleWise.ELMA.Model.Attributes.CustomFilterProperty()]
        [global::EleWise.ELMA.Model.Attributes.Uid("743659af-d61d-43af-ae30-2072d83f4b0a")]
        [global::EleWise.ELMA.ComponentModel.CanBeNull()]
        [global::EleWise.ELMA.Model.Attributes.Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
        [global::EleWise.ELMA.Model.Types.Settings.GuidSettings(FieldName="TypeUidSpravochnika")]
        [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IDeptTrans_Catalog), "FP_TypeUidSpravochnika_DisplayName")]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Create, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Edit, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Display, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.List, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Hidden, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Filter, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        System.Nullable<System.Guid> TypeUidSpravochnika
        {
            get;
            set;
        }
    }
}
