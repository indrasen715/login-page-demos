//-----------------------------------------------------------------------
// <copyright file="ModelClass" company="LoginRadius">
//     Created by LoginRadius Development Team
//     Copyright 2019 LoginRadius Inc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using Newtonsoft.Json;
namespace LoginRadiusSDK.V2.Models.RequestModels

{

    /// <summary>
    ///	Model Class containing Definition of payload for MultiFactorAuthModel By GoogleAuthenticator Code API
    /// </summary>
    public class MultiFactorAuthModelByGoogleAuthenticatorCode
    {
		/// <summary>
		///	The code generated by google authenticator app after scanning QR code
		/// </summary>
		[JsonProperty(PropertyName = "GoogleAuthenticatorCode")]
        public  string GoogleAuthenticatorCode {get;set;}

    }
}