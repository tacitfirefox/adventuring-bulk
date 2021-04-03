//==============================================
// IItem.cs
// tacitfirefox
//==============================================

namespace bulk.abstractions
{
    using System;
    using UnitsNet;

    /// <summary>
    /// A generalisation of an enumerable item in a character's inventory.
    /// </summary>
    public interface IItem
    {
        /// <summary>
        /// Gets the unique identifier of this inventory item.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the mass of this inventory item.
        /// </summary>
        Mass Mass { get; }

        /// <summary>
        /// Gets the volume of this inventory item.
        /// </summary>
        Volume Volume { get; }

        /// <summary>
        /// Gets the name of this inventory item.
        /// </summary>
        string Name { get; }
    }
}
