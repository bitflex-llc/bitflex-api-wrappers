/* 
 * BITFLEX Public API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Defines TradeType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TradeType
    {
        /// <summary>
        /// Enum Buy for value: Buy
        /// </summary>
        [EnumMember(Value = "Buy")]
        Buy = 1,

        /// <summary>
        /// Enum Sell for value: Sell
        /// </summary>
        [EnumMember(Value = "Sell")]
        Sell = 2

    }

}