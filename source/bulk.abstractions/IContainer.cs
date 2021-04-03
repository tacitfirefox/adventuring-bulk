//==============================================
// IContainer.cs
// tacitfirefox
//==============================================

namespace bulk.abstractions
{
    using System.Collections;
    using UnitsNet;

    /// <summary>
    /// Defines a packable container of objects that can be stowed or carried.
    /// </summary>
    public interface IContainer : IEnumerable
    {
        /// <summary>
        /// Gets the mass of the container.
        /// </summary>
        public Mass Mass { get; }

        /// <summary>
        /// Gets the volume of the container.
        /// </summary>
        public Volume Volume { get; }

        /// <summary>
        /// Gets the slot this container can be equipped to on a person.
        /// </summary>
        public IEquipmentSlot EquipmentSlot { get; }

        /// <summary>
        /// Gets the number of inventory slots this container holds.
        /// </summary>
        public uint Slots { get; }
    }
}
