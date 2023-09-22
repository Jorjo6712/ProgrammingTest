namespace ProgrammingTest.Model
{
    internal abstract class BoGodtApartment
    {
        /// <summary>
        /// The BoGodtApartment superclass used to define base information for derivative classes
        /// </summary>

        private protected ushort size;
        private protected ushort roomAmount;
        private protected byte amountOfWindowsPerRoom;
        private protected BoGodtApartment(ushort Size, ushort RoomAmount, byte AmountOfWindowsPerRoom) 
        { 
            size = Size;
            roomAmount = RoomAmount;
            amountOfWindowsPerRoom = AmountOfWindowsPerRoom;
        }

        public virtual string ToString()
        {
            return $"Apartment size: {size}, Amount of rooms in apartment: {roomAmount}, Amount of windows per room {amountOfWindowsPerRoom}";
        }
    }
}
    