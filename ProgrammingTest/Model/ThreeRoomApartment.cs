namespace ProgrammingTest.Model
{
    /// <summary>
    /// Used to make the three room apartment BoGodtApartment superclass derivative
    /// </summary>
    internal class ThreeRoomApartment : BoGodtApartment
    {
        internal ThreeRoomApartment(ushort Size, ushort RoomAmount, byte AmountOfWindowsPerRoom) : base(Size, RoomAmount, AmountOfWindowsPerRoom)
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
