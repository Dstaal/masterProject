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
    /// <para>The information about a user invited to become a member of a shared
    /// folder.</para>
    /// </summary>
    /// <seealso cref="MembershipInfo" />
    public class InviteeMembershipInfo : MembershipInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<InviteeMembershipInfo> Encoder = new InviteeMembershipInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<InviteeMembershipInfo> Decoder = new InviteeMembershipInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="InviteeMembershipInfo" />
        /// class.</para>
        /// </summary>
        /// <param name="accessType">The access type for this member.</param>
        /// <param name="invitee">The information for the invited user.</param>
        public InviteeMembershipInfo(AccessLevel accessType,
                                     InviteeInfo invitee)
            : base(accessType)
        {
            if (invitee == null)
            {
                throw new sys.ArgumentNullException("invitee");
            }

            this.Invitee = invitee;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="InviteeMembershipInfo" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public InviteeMembershipInfo()
        {
        }

        /// <summary>
        /// <para>The information for the invited user.</para>
        /// </summary>
        public InviteeInfo Invitee { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="InviteeMembershipInfo" />.</para>
        /// </summary>
        private class InviteeMembershipInfoEncoder : enc.StructEncoder<InviteeMembershipInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(InviteeMembershipInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("access_type", value.AccessType, writer, AccessLevel.Encoder);
                WriteProperty("invitee", value.Invitee, writer, InviteeInfo.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="InviteeMembershipInfo" />.</para>
        /// </summary>
        private class InviteeMembershipInfoDecoder : enc.StructDecoder<InviteeMembershipInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="InviteeMembershipInfo"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override InviteeMembershipInfo Create()
            {
                return new InviteeMembershipInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(InviteeMembershipInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "access_type":
                        value.AccessType = AccessLevel.Decoder.Decode(reader);
                        break;
                    case "invitee":
                        value.Invitee = InviteeInfo.Decoder.Decode(reader);
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
