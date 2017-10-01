﻿//-----------------------------------------------------------------------
// <copyright file="CheckErrorKeys.cs" company="Chesil Media">
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
// </copyright>
//-----------------------------------------------------------------------

namespace ORMS.Shared.SharedKernel.Constants.ErrorKeys
{
    using Guards;

    /// <summary>
    /// Represents the keys strings for <see cref="Check"/> errors, which can be converted by the UI
    /// to meaningful messages;
    /// </summary>
    public class CheckErrorKeys : ErrorKeyBase
    {
        /// <summary>
        /// The key for when the value is null
        /// </summary>
        public const string ArgumentIsNull = "ArgumentIsNull";

        /// <summary>
        /// The key for when the value is null or empty
        /// </summary>
        public const string ArgumentIsNullOrEmpty = "ArgumentIsNullOrEmpty";

        /// <summary>
        /// The key for when the value is null, empty or white space
        /// </summary>
        public const string ArgumentIsNullEmptyOrWhiteSpace = "ArgumentIsNullEmptyOrWhiteSpace";
    }
}