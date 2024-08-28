//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.disputes.slashing.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> InvalidKeyOwnershipProof
        /// The key ownership proof is invalid.
        /// </summary>
        InvalidKeyOwnershipProof = 0,
        
        /// <summary>
        /// >> InvalidSessionIndex
        /// The session index is too old or invalid.
        /// </summary>
        InvalidSessionIndex = 1,
        
        /// <summary>
        /// >> InvalidCandidateHash
        /// The candidate hash is invalid.
        /// </summary>
        InvalidCandidateHash = 2,
        
        /// <summary>
        /// >> InvalidValidatorIndex
        /// There is no pending slash for the given validator index and time
        /// slot.
        /// </summary>
        InvalidValidatorIndex = 3,
        
        /// <summary>
        /// >> ValidatorIndexIdMismatch
        /// The validator index does not match the validator id.
        /// </summary>
        ValidatorIndexIdMismatch = 4,
        
        /// <summary>
        /// >> DuplicateSlashingReport
        /// The given slashing report is valid but already previously reported.
        /// </summary>
        DuplicateSlashingReport = 5,
    }
    
    /// <summary>
    /// >> 811 - Variant[polkadot_runtime_parachains.disputes.slashing.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}