namespace Parcial1_Base.Logic
{
    /// <summary>
    /// Bracelets are a kind of accessory that can be stacked up to a certain amount, and are compatible with all dresses.
    /// </summary>
    public class Bracelet : Accessory
    {
        public Bracelet(int style) : base(style, typeAccessory.Bracelet)
        {
        }

        /// <summary>
        /// Copies this instance attributes to a new independant one
        /// </summary>
        /// <returns>A new Accessory object with the same values of this instance</returns>
        public override Accessory Copy()
        {
            return new Bracelet(style);
        }
    }
}