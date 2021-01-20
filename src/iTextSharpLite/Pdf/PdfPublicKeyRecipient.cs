using System.Security.Cryptography.X509Certificates;

namespace iTextSharp.Pdf
{
    public class PdfPublicKeyRecipient
    {
        private X509Certificate certificate = null;

        private int permission = 0;

        protected byte[] cms = null;

        public PdfPublicKeyRecipient(X509Certificate certificate, int permission)
        {
            this.certificate = certificate;
            this.permission = permission;
        }

        public X509Certificate Certificate
        {
            get
            {
                return certificate;
            }
        }

        public int Permission
        {
            get
            {
                return permission;
            }
        }

        protected internal byte[] Cms
        {
            set
            {
                cms = value;
            }
            get
            {
                return cms;
            }
        }
    }
}