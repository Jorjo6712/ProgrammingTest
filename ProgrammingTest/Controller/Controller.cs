using ProgrammingTest.View;
using ProgrammingTest.Model;

namespace ProgrammingTest.Controller
{
    /// <summary>
    /// Used to define some apartment values and instantiate apartment objects from the BoGodtApartment class
    /// </summary>
    internal class Controller
    {
        // Defining some constants for the different itterations of apartments amounts
        private const ushort fiveRoomApartmentTotal = 47;
        private const ushort fourRoomApartmentTotal = 97;
        private const ushort threeRoomApartmentTotal = 167;
        private const ushort twoRoomApartmentTotal = 235;
        private const ushort oneRoomApartmentTotal = 368;

        // Instantiating bookKeeping and View
        BookKeeping bookKeeping = new BookKeeping();
        View.View view = new View.View();

        // MainController method which runs all other methods
        internal void MainController()
        {
            CreateAllApartments();
            ShowOneRoomApartmentInfo();
            view.Text("\nPress enter to display next available apartment information.");
            view.RL();
            ShowTwoRoomApartmentInfo();
            view.Text("\nPress enter to display next available apartment information.");
            view.RL();
            ShowThreeRoomApartmentInfo();
            view.Text("\nPress enter to display next available apartment information.");
            view.RL();
            ShowFourRoomApartmentInfo();
            view.Text("\nPress enter to display next available apartment information.");
            view.RL();
            ShowFiveRoomApartmentInfo();
            view.Text("\nPress enter to exit program");
            view.RL();
        }

        // Method used to create all BoGodtApartment superclass derivatives
        private void CreateAllApartments()
        {
            for (int i = 0; i < oneRoomApartmentTotal; i++) 
            {
                bookKeeping.oneRoomApartments.Add(new OneRoomApartment(40, 1, 1));
            }

            for (int i = 0; i < twoRoomApartmentTotal; i++)
            {
                bookKeeping.twoRoomApartments.Add(new TwoRoomApartment(55, 2, 1));
            }

            for (int i = 0; i < threeRoomApartmentTotal; i++)
            {
                bookKeeping.threeRoomApartments.Add(new ThreeRoomApartment(70, 3, 1));
            }

            for (int i = 0; i < fourRoomApartmentTotal; i++)
            {
                bookKeeping.fourRoomApartments.Add(new FourRoomApartment(85, 4, 1));
            }
            
            for (int i = 0; i < fiveRoomApartmentTotal; i++)
            {
                bookKeeping.fiveRoomApartments.Add(new FiveRoomApartment(110, 1, 1));
            }

        }

        // Methods used to show 10 itterations of the different apartment types
        private void ShowOneRoomApartmentInfo()
        {
            for (int i = 0; i < 10; i++) 
            {
                OneRoomApartment apartment = bookKeeping.oneRoomApartments[i];
                view.Text($"\nOne Room Apartment {i} details: " + "\n" + apartment.ToString());
            }
        }

        private void ShowTwoRoomApartmentInfo()
        {
            for (int i = 0; i < 10; i++)
            {
                TwoRoomApartment apartment = bookKeeping.twoRoomApartments[i];
                view.Text($"\nTwo Room Apartment {i} details: " + "\n" + apartment.ToString());
            }
        }

        private void ShowThreeRoomApartmentInfo()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreeRoomApartment apartment = bookKeeping.threeRoomApartments[i];
                view.Text($"\n Three Room Apartment {i} details: " + "\n" + apartment.ToString());
            }
        }
        private void ShowFourRoomApartmentInfo()
        {
            for (int i = 0; i < 10; i++)
            {
                FourRoomApartment apartment = bookKeeping.fourRoomApartments[i];
                view.Text($"\nFour Room Apartment {i} details: " + "\n" + apartment.ToString());
            }
        }
        private void ShowFiveRoomApartmentInfo()
        {
            for (int i = 0; i < 10; i++)
            {
                FiveRoomApartment apartment = bookKeeping.fiveRoomApartments[i];
                view.Text($"\n Five Room Apartment {i} details: " + "\n" + apartment.ToString());
            }
        }
    }
}
