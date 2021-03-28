//==============================================
// PersonalEquipmentSlots.cs
// tacitfirefox
//==============================================

namespace bulk.abstractions
{
    using System;

    /// <summary>
    /// Defines supported equipment slots for a single person.
    /// </summary>
    [Flags]
    public enum PersonalEquipmentSlots
    {
        /// <summary>
        /// Default/no-value.
        /// </summary>
        None,

        /// <summary>
        /// Equipped in the carrier's left hand.
        /// </summary>
        LeftHand,

        /// <summary>
        /// Equipped in the carrier's right hand.
        /// </summary>
        RightHand,

        /// <summary>
        /// The carrier's equipped cloak slot.
        /// </summary>
        Cloak,

        /// <summary>
        /// Equipped on the carrier's shoulders.
        /// </summary>
        Shoulders,

        /// <summary>
        /// Equipped on the carrier's head.
        /// </summary>
        Head,

        /// <summary>
        /// Equipped on the carrier's left eye.
        /// </summary>
        LeftEye,

        /// <summary>
        /// Equipped on the carrier's right eye.
        /// </summary>
        RightEye,

        /// <summary>
        /// Equipped on the carrier's eyes.
        /// </summary>
        BothEyes,

        /// <summary>
        /// Equipped on the carrier's left ear.
        /// </summary>
        LeftEar,

        /// <summary>
        /// Equipped on the carrier's right ear.
        /// </summary>
        RightEar,

        /// <summary>
        /// Equipped on the carrier's bandolier (shoulder belt).
        /// </summary>
        Bandolier,

        /// <summary>
        /// Equipped on the carrier's waist belt.
        /// </summary>
        Belt,

        /// <summary>
        /// Equipped on the carrier's back as a bag.
        /// </summary>
        BackPack,

        /// <summary>
        /// Equipped on the carrier's shoulder as a bag.
        /// </summary>
        ShoulderPack,

        /// <summary>
        /// A weapon sheath for the carrier's left hand (can be on waist or back).
        /// </summary>
        WeaponSheathLeft,

        /// <summary>
        /// A weapon sheath for the carrier's right hand (can be on waist or back).
        /// </summary>
        WeaponSheathRight,

        /// <summary>
        /// A small weapon sheath for the carrier's left calf/ankle/foot.
        /// </summary>
        WeaponSheathLeftFoot,

        /// <summary>
        /// A small weapon sheath for the carrier's right calf/ankle/foot.
        /// </summary>
        WeaponSheathRightFoot,
    }
}
