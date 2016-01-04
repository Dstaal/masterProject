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
    /// <para>The job status object</para>
    /// </summary>
    public class JobStatus
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<JobStatus> Encoder = new JobStatusEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<JobStatus> Decoder = new JobStatusDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="JobStatus" /> class.</para>
        /// </summary>
        public JobStatus()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Complete</para>
        /// </summary>
        public bool IsComplete
        {
            get
            {
                return this is Complete;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Complete, or <c>null</c>.</para>
        /// </summary>
        public Complete AsComplete
        {
            get
            {
                return this as Complete;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Failed</para>
        /// </summary>
        public bool IsFailed
        {
            get
            {
                return this is Failed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Failed, or <c>null</c>.</para>
        /// </summary>
        public Failed AsFailed
        {
            get
            {
                return this as Failed;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="JobStatus" />.</para>
        /// </summary>
        private class JobStatusEncoder : enc.StructEncoder<JobStatus>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(JobStatus value, enc.IJsonWriter writer)
            {
                if (value is Complete)
                {
                    WriteProperty(".tag", "complete", writer, enc.StringEncoder.Instance);
                    Complete.Encoder.EncodeFields((Complete)value, writer);
                    return;
                }
                if (value is Failed)
                {
                    WriteProperty(".tag", "failed", writer, enc.StringEncoder.Instance);
                    Failed.Encoder.EncodeFields((Failed)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="JobStatus" />.</para>
        /// </summary>
        private class JobStatusDecoder : enc.UnionDecoder<JobStatus>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="JobStatus" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override JobStatus Create()
            {
                return new JobStatus();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override JobStatus Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "complete":
                        return Complete.Decoder.DecodeFields(reader);
                    case "failed":
                        return Failed.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The asynchronous job has finished.</para>
        /// </summary>
        public sealed class Complete : JobStatus
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Complete> Encoder = new CompleteEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Complete> Decoder = new CompleteDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Complete" /> class.</para>
            /// </summary>
            private Complete()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Complete</para>
            /// </summary>
            public static readonly Complete Instance = new Complete();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Complete" />.</para>
            /// </summary>
            private class CompleteEncoder : enc.StructEncoder<Complete>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Complete value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Complete" />.</para>
            /// </summary>
            private class CompleteDecoder : enc.StructDecoder<Complete>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Complete" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Complete Create()
                {
                    return new Complete();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Complete DecodeFields(enc.IJsonReader reader)
                {
                    return Complete.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The asynchronous job returned an error.</para>
        /// </summary>
        public sealed class Failed : JobStatus
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Failed> Encoder = new FailedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Failed> Decoder = new FailedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Failed" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Failed(JobError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Failed" /> class.</para>
            /// </summary>
            private Failed()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public JobError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Failed" />.</para>
            /// </summary>
            private class FailedEncoder : enc.StructEncoder<Failed>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Failed value, enc.IJsonWriter writer)
                {
                    JobError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Failed" />.</para>
            /// </summary>
            private class FailedDecoder : enc.StructDecoder<Failed>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Failed" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Failed Create()
                {
                    return new Failed();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(Failed value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "failed":
                            value.Value = JobError.Decoder.Decode(reader);
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
}
