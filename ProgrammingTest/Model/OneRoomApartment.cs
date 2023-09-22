namespace ProgrammingTest.Model
{
    /// <summary>
    /// Used to make the one room apartment BoGodtApartment superclass derivative
    /// </summary>
    internal class OneRoomApartment : BoGodtApartment
    {
        internal OneRoomApartment(ushort Size, ushort RoomAmount, byte AmountOfWindowsPerRoom) : base (Size, RoomAmount, AmountOfWindowsPerRoom)
        {

        }


        public override string ToString()
        {
            return $"{base.ToString()}";
        }

    }
}
