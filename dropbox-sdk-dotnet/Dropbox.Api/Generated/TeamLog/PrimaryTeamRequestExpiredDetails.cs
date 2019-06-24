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
    /// <para>Team merge request expiration details shown to the primary team</para>
    /// </summary>
    public class PrimaryTeamRequestExpiredDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PrimaryTeamRequestExpiredDetails> Encoder = new PrimaryTeamRequestExpiredDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PrimaryTeamRequestExpiredDetails> Decoder = new PrimaryTeamRequestExpiredDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="PrimaryTeamRequestExpiredDetails" /> class.</para>
        /// </summary>
        /// <param name="secondaryTeam">The secondary team name.</param>
        /// <param name="sentBy">The name of the secondary team admin who sent the request
        /// originally.</param>
        public PrimaryTeamRequestExpiredDetails(string secondaryTeam,
                                                string sentBy)
        {
            if (secondaryTeam == null)
            {
                throw new sys.ArgumentNullException("secondaryTeam");
            }

            if (sentBy == null)
            {
                throw new sys.ArgumentNullException("sentBy");
            }

            this.SecondaryTeam = secondaryTeam;
            this.SentBy = sentBy;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="PrimaryTeamRequestExpiredDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public PrimaryTeamRequestExpiredDetails()
        {
        }

        /// <summary>
        /// <para>The secondary team name.</para>
        /// </summary>
        public string SecondaryTeam { get; protected set; }

        /// <summary>
        /// <para>The name of the secondary team admin who sent the request originally.</para>
        /// </summary>
        public string SentBy { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PrimaryTeamRequestExpiredDetails" />.</para>
        /// </summary>
        private class PrimaryTeamRequestExpiredDetailsEncoder : enc.StructEncoder<PrimaryTeamRequestExpiredDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PrimaryTeamRequestExpiredDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("secondary_team", value.SecondaryTeam, writer, enc.StringEncoder.Instance);
                WriteProperty("sent_by", value.SentBy, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PrimaryTeamRequestExpiredDetails" />.</para>
        /// </summary>
        private class PrimaryTeamRequestExpiredDetailsDecoder : enc.StructDecoder<PrimaryTeamRequestExpiredDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="PrimaryTeamRequestExpiredDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PrimaryTeamRequestExpiredDetails Create()
            {
                return new PrimaryTeamRequestExpiredDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(PrimaryTeamRequestExpiredDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "secondary_team":
                        value.SecondaryTeam = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "sent_by":
                        value.SentBy = enc.StringDecoder.Instance.Decode(reader);
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
