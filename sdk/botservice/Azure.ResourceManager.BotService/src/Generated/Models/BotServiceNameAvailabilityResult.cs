// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The response body returned for a request to Bot Service Management to check availability of a bot name. </summary>
    public partial class BotServiceNameAvailabilityResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BotServiceNameAvailabilityResult"/>. </summary>
        internal BotServiceNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BotServiceNameAvailabilityResult"/>. </summary>
        /// <param name="isValid"> indicates if the bot name is valid. </param>
        /// <param name="message"> additional message from the bot management api showing why a bot name is not available. </param>
        /// <param name="absCode"> response code from ABS. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BotServiceNameAvailabilityResult(bool? isValid, string message, string absCode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsValid = isValid;
            Message = message;
            AbsCode = absCode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> indicates if the bot name is valid. </summary>
        public bool? IsValid { get; }
        /// <summary> additional message from the bot management api showing why a bot name is not available. </summary>
        public string Message { get; }
        /// <summary> response code from ABS. </summary>
        public string AbsCode { get; }
    }
}
