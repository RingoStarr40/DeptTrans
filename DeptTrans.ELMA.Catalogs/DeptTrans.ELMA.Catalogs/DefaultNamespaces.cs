using EleWise.ELMA.Model.Metadata;

namespace DeptTrans.ELMA.Catalogs
{
    internal class DefaultNamespaces
    {
        public class DeptTrans : NamespaceInfo
        {
            public override string Namespace
            {
                get { return "DeptTrans"; }
            }

            public override string DisplayName
            {
                get { return ""; }
            }
        }

        public class ELMA : NamespaceInfo
        {
            public override string Namespace
            {
                get { return "DeptTrans.ELMA"; }
            }

            public override string DisplayName
            {
                get { return ""; }
            }
        }
    }
}
