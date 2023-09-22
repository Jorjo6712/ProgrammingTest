namespace ProgrammingTest.Model
{
    /// <summary>
    /// Used to make the four room apartment BoGodtApartment superclass derivative
    /// </summary>
    internal class FourRoomApartment : BoGodtApartment
    {
        internal FourRoomApartment(ushort Size, ushort RoomAmount, byte AmountOfWindowsPerRoom) : base(Size, RoomAmount, AmountOfWindowsPerRoom)
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
