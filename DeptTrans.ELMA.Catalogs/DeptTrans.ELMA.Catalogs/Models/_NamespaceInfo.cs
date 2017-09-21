namespace DeptTrans.ELMA.Catalogs.Models
{
    using System;
    
    
    /// <summary>
    /// Information about the DeptTrans.ELMA.Catalogs.Models name space
    /// </summary>
    [global::EleWise.ELMA.Model.Attributes.MetadataType(typeof(global::EleWise.ELMA.Model.Metadata.NamespaceMetadata))]
    [global::EleWise.ELMA.Model.Attributes.Uid("1ba738d7-9b8b-4385-bf8e-88679b92a3cf")]
    internal partial class _NamespaceInfo : global::EleWise.ELMA.Model.Metadata.NamespaceInfo
    {
        
        /// <summary>
        /// UID of this class
        /// </summary>
        public const string UID_S = "1ba738d7-9b8b-4385-bf8e-88679b92a3cf";
        
        private static global::System.Guid _UID = new global::System.Guid(UID_S);
        
        /// <summary>
        /// UID of this class
        /// </summary>
        public static global::System.Guid UID
        {
            get
            {
                return _UID;
            }
        }
        
        /// <summary>
        /// Displayed Name
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Департамент транспорта");
            }
        }
    }
}
