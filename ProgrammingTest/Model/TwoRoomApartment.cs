using System.Drawing;

namespace ProgrammingTest.Model
{
    /// <summary>
    /// Used to make the two room apartment BoGodtApartment superclass derivative
    /// </summary>
    internal class TwoRoomApartment : BoGodtApartment
    {
        internal TwoRoomApartment(ushort Size, ushort RoomAmount, byte AmountOfWindowsPerRoom) : base(Size, RoomAmount, AmountOfWindowsPerRoom)
        {
            
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
