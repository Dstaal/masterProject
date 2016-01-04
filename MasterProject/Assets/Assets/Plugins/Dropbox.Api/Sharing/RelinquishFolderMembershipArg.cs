// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The relinquish folder membership arg object</para>
    /// </summary>
    public class RelinquishFolderMembershipArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RelinquishFolderMembershipArg> Encoder = new RelinquishFolderMembershipArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RelinquishFolderMembershipArg> Decoder = new RelinquishFolderMembershipArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RelinquishFolderMembershipArg"
        /// /> class.</para>
        /// </summary>
        /// <param name="sharedFolderId">The ID for the shared folder.</param>
        public RelinquishFolderMembershipArg(string sharedFolderId)
        {
            if (sharedFolderId == null)
            {
                throw new sys.ArgumentNullException("sharedFolderId");
            }
            else if (!re.Regex.IsMatch(sharedFolderId, @"\A(?:[-_0-9a-zA-Z:]+)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("sharedFolderId");
            }

            this.SharedFolderId = sharedFolderId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RelinquishFolderMembershipArg"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public RelinquishFolderMembershipArg()
        {
        }

        /// <summary>
        /// <para>The ID for the shared folder.</para>
        /// </summary>
        public string SharedFolderId { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RelinquishFolderMembershipArg" />.</para>
        /// </summary>
        private class RelinquishFolderMembershipArgEncoder : enc.StructEncoder<RelinquishFolderMembershipArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RelinquishFolderMembershipArg value, enc.IJsonWriter writer)
            {
                WriteProperty("shared_folder_id", value.SharedFolderId, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RelinquishFolderMembershipArg" />.</para>
        /// </summary>
        private class RelinquishFolderMembershipArgDecoder : enc.StructDecoder<RelinquishFolderMembershipArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RelinquishFolderMembershipArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RelinquishFolderMembershipArg Create()
            {
                return new RelinquishFolderMembershipArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(RelinquishFolderMembershipArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "shared_folder_id":
                        value.SharedFolderId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
