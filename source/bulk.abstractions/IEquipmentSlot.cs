//==============================================
// IEquipmentSlot.cs
// tacitfirefox
//==============================================

namespace bulk.abstractions
{
    using System;

    /// <summary>
    /// Defines a specific, permanent equipment slot on a character.
    /// </summary>
    public interface IEquipmentSlot
    {
        /// <summary>
        /// Gets a method that determines if the class of item can be assigned to this slot.
        /// </summary>
        Func<string, bool> AcceptsItemsOfCategory { get; }

        /// <summary>
        /// Gets the unique identifier of this slot.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the item currently assigned to this slot.
        /// </summary>
        IItem AssignedItem { get; }

        /// <summary>
        /// Gets the name of this equipment slot.
        /// </summary>
        string Name { get; }
    }
}
