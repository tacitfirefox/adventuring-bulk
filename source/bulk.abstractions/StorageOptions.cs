//==============================================
// StorageOptions.cs
// tacitfirefox
//==============================================

namespace bulk.abstractions
{
    using System;

    /// <summary>
    /// Defines how an item can be stored.
    /// </summary>
    [Flags]
    public enum StorageOptions
    {
        /// <summary>
        /// Default/no-value.
        /// </summary>
        None,

        /// <summary>
        /// Held in an hand.
        /// </summary>
        InHand,

        /// <summary>
        /// Worn on one's person.
        /// </summary>
        Worn,

        /// <summary>
        /// Kept in a sheath or bag that requires an action to get.
        /// </summary>
        Stowed,

        /// <summary>
        /// Kept in a container not on one's person.
        /// </summary>
        Stored,

        /// <summary>
        /// Kept in a locked container not on one's person.
        /// </summary>
        Locked
    }
}
