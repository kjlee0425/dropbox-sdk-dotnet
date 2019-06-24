// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Changed integration policy for team.</para>
    /// </summary>
    public class IntegrationPolicyChangedDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<IntegrationPolicyChangedDetails> Encoder = new IntegrationPolicyChangedDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<IntegrationPolicyChangedDetails> Decoder = new IntegrationPolicyChangedDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="IntegrationPolicyChangedDetails"
        /// /> class.</para>
        /// </summary>
        /// <param name="integrationName">Name of the third-party integration.</param>
        /// <param name="newValue">New integration policy.</param>
        /// <param name="previousValue">Previous integration policy.</param>
        public IntegrationPolicyChangedDetails(string integrationName,
                                               IntegrationPolicy newValue,
                                               IntegrationPolicy previousValue)
        {
            if (integrationName == null)
            {
                throw new sys.ArgumentNullException("integrationName");
            }

            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            if (previousValue == null)
            {
                throw new sys.ArgumentNullException("previousValue");
            }

            this.IntegrationName = integrationName;
            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="IntegrationPolicyChangedDetails"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public IntegrationPolicyChangedDetails()
        {
        }

        /// <summary>
        /// <para>Name of the third-party integration.</para>
        /// </summary>
        public string IntegrationName { get; protected set; }

        /// <summary>
        /// <para>New integration policy.</para>
        /// </summary>
        public IntegrationPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous integration policy.</para>
        /// </summary>
        public IntegrationPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="IntegrationPolicyChangedDetails" />.</para>
        /// </summary>
        private class IntegrationPolicyChangedDetailsEncoder : enc.StructEncoder<IntegrationPolicyChangedDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(IntegrationPolicyChangedDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("integration_name", value.IntegrationName, writer, enc.StringEncoder.Instance);
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.IntegrationPolicy.Encoder);
                WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.IntegrationPolicy.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="IntegrationPolicyChangedDetails" />.</para>
        /// </summary>
        private class IntegrationPolicyChangedDetailsDecoder : enc.StructDecoder<IntegrationPolicyChangedDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="IntegrationPolicyChangedDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override IntegrationPolicyChangedDetails Create()
            {
                return new IntegrationPolicyChangedDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(IntegrationPolicyChangedDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "integration_name":
                        value.IntegrationName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.IntegrationPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.IntegrationPolicy.Decoder.Decode(reader);
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
