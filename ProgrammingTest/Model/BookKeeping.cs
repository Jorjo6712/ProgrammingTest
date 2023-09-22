namespace ProgrammingTest.Model
{
    /// <summary>
    /// Used for storing the different objects of the BoGodtApartment superclass' derivatives
    /// </summary>
    internal class BookKeeping
    {
        internal List<BoGodtApartment> apartments = new List<BoGodtApartment>();
        internal List<OneRoomApartment> oneRoomApartments = new List<OneRoomApartment>();
        internal List<TwoRoomApartment> twoRoomApartments = new List<TwoRoomApartment>();
        internal List<ThreeRoomApartment> threeRoomApartments = new List<ThreeRoomApartment>();
        internal List<FourRoomApartment> fourRoomApartments = new List<FourRoomApartment>();
        internal List<FiveRoomApartment> fiveRoomApartments= new List<FiveRoomApartment>();

    }
}
