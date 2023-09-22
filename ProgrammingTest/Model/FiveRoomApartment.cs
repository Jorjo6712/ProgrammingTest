namespace ProgrammingTest.Model
{
    /// <summary>
    /// Used to make the five room apartment BoGodtApartment superclass derivative
    /// </summary>
    internal class FiveRoomApartment : BoGodtApartment
    {
        internal FiveRoomApartment(ushort Size, ushort RoomAmount, byte AmountOfWindowsPerRoom) : base(Size, RoomAmount, AmountOfWindowsPerRoom)
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
