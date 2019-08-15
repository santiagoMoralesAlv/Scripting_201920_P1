namespace Parcial1_Base.Logic
{
    public class Necklace : Accessory
    {
        public Necklace(int style) : base(style, typeAccessory.Necklace)
        {
        }

        /// <summary>
        /// Copies this instance attributes to a new independant one
        /// </summary>
        /// <returns>A new Accessory object with the same values of this instance</returns>
        public override Accessory Copy()
        {
            return new Necklace(style);
        }
    }
}