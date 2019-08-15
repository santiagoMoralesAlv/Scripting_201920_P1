﻿using System.Collections.Generic;

namespace Parcial1_Base.Logic
{
    /// <summary>
    /// Definition for the player's avatar. Players dress up a doll to win the contest.
    /// </summary>
    public class Doll : IClonable<Doll>
    {
        /// <summary>
        /// The accessories collection.
        /// </summary>
        private List<Accessory> accessories = new List<Accessory>();

        /// <summary>
        /// The doll's name
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Whether the doll can be included in the contest.
        /// </summary>
        public bool CanParticipate { get => false; }

        /// <summary>
        /// The total accessories count worn by the doll.
        /// </summary>
        public int TotalAccessories { get => accessories.Count; }

        public int BraceletCount { get => 0; }

        /// <summary>
        /// The total style score, affected by each worn accessory.
        /// </summary>
        public int Style {
            get {
                int totalStyle = 0; 
                foreach (Accessory iAccesorry in accessories) {
                    totalStyle += iAccesorry.Style;
                }
                return totalStyle;
            }
           
        }

        public Doll(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Removes the given accessory.
        /// </summary>
        /// <param name="a">The accessory to be removed</param>
        /// <returns>True if the accessory was being worn, then removed. False otherwise</returns>
        public bool Remove(Accessory a)
        {
            bool result = false;

            if (a.type == Accessory.typeAccessory.Dress) {
                accessories.Clear();
                result = true;
            } else {

                if (accessories.Remove(a))
                {
                    result = true;
                }

            }

            return result;

            
        }

        /// <summary>
        /// Makes the doll wear the given accessory
        /// </summary>
        /// <param name="a">The accessory to be worn by the doll</param>
        /// <returns>True if the doll successfully wore the accessory. False otherwise</returns>
        public bool Wear(Accessory a)
        {

            bool result = false;

            switch (a.type) {
                case Accessory.typeAccessory.Bracelet:
                    accessories.Add(a);
                    result = true;
                    break;

                default:
                    foreach (Accessory iAccesorry in accessories)
                    {
                        if (iAccesorry.type == a.type)
                        {
                            break;
                        }
                    }
                    accessories.Add(a);
                    result = true;
                    break;

            }

            return result;
        }

        /// <summary>
        /// Copies this instance attributes to a new independant one
        /// </summary>
        /// <returns>A new Doll object with the same values of this instance</returns>
        public Doll Copy()
        {
            return new Doll(Name);
        }
    }
}