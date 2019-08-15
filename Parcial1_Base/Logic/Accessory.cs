namespace Parcial1_Base.Logic
{
    /// <summary>
    /// Base definition for all accessories
    /// </summary>
    public abstract class Accessory : IClonable<Accessory>
    {
        public enum typeAccessory
        {
            Dress,
            Purse,
            Bracelet,
            Necklace
        }
        public typeAccessory type;


        /// <summary>
        /// The base style score.
        /// </summary>
        protected int style;

        /// <summary>
        /// The style score bonus percentage, if any applies.
        /// </summary>
        protected virtual float StyleMod { get {

                float value = 1;

                switch (type)
                {
                    case Accessory.typeAccessory.Bracelet:
                        break;
                        

                    default:
                        value = 1;
                    break;

                }

                return value;
            }



        }

        /// <summary>
        /// Returns the Style score for this accessory
        /// </summary>
        public virtual int Style
        {
            // Returns the base style score and any style bonus, if any applies.
            get => (int)(System.Math.Round(style * StyleMod));

            // Sets the base style score for this accessory.
            protected set => style = value;
        }

        public Accessory(int style, typeAccessory mtype)
        {
            Style = style;
            this.type = mtype;
        }

        /// <summary>
        /// Copies this instance attributes to a new independant one
        /// </summary>
        /// <returns>A new Accessory object with the same values of this instance</returns>
        public abstract Accessory Copy();
    }
}