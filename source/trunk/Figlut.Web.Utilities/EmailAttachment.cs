namespace Figlut.Web.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #endregion //Using Directives

    public class EmailAttachment
    {
        #region Constructors

        public EmailAttachment(string attachmentFileName, byte[] attachmentBytes)
        {
            if (string.IsNullOrEmpty(attachmentFileName))
            {
                throw new NullReferenceException("Attachment File Name may not be null or empty.");
            }
            if (attachmentBytes == null)
            {
                throw new NullReferenceException("Attachment bytes cannot be null.");
            }
            _attachmentBytes = attachmentBytes;
        }

        #endregion //Constructors

        #region Fields

        private string _attachmentFileName;
        private byte[] _attachmentBytes;

        #endregion //Fields

        #region Properties

        public string AttachmentFileName
        {
            get { return _attachmentFileName; }
        }

        public byte[] AttachmentBytes
        {
            get { return _attachmentBytes; }
        }

        #endregion //Properties
    }
}