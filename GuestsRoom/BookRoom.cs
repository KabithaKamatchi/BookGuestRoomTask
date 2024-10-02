using System;
using System.Reflection.Metadata;

namespace GuestsRoomProblem
{
    public class BookRoom
    {
        public static void RoomSeperation(int nRooms, int nAdult, int nChidren)
        {

            int nMaxGuestsPerRoom = 4;

            for( int i = 0; i <= nRooms; i++)
            {
                int nAdultRoom = Math.Min(1, nAdult);
                 nAdult -= nAdultRoom;

                int nChildrenRoom = Math.Min(nMaxGuestsPerRoom - nAdultRoom, nChidren);
                nChidren -= nChildrenRoom;

                Console.WriteLine($"Room {i}: nAdult {nAdultRoom} - nChildren {nChildrenRoom}");
            }

            ////int nOverallPersons = nAdult + nChidren;

            ////if (nOverallPersons > Constant.nMaxGuest  )
            ////{
            ////    Console.WriteLine($"Guests Exceeds more than {Constant.nMaxGuest}");

            ////}
            ////else
            ////{
            ////    Console.WriteLine($"Total guests do not exceed {Constant.nMaxGuest}");
            ////}         

            ////int nRooms = (nOverallPersons + Constant.nMaxGuestPerRoom - 1) / Constant.nMaxGuestPerRoom;

            ////if (nRooms > Constant.nPersonBookRooms)
            ////{
            ////    Console.WriteLine($" A person cannot book the more than {Constant.nPersonBookRooms} rooms");
            ////}
            ////else
            ////{              
            ////    Console.WriteLine($" A one person can {Constant.nPersonBookRooms} Rooms");
            ////}

            //Console.WriteLine("Rooms Allocation");
            //for (int i = 1; i <= nRooms; i++)
            //{
            //    int nAdultRoom = Math.Min(1, nAdult);
            //    nAdult -= nAdultRoom;

            //    int nChildrenRoom = Math.Min(Constant.nMaxGuestPerRoom - nAdultRoom, nChildren);
            //    nChildren -= nChildrenRoom;

            //    Console.WriteLine($"Room : nAdult {nAdultRoom} - nChildren {nChildrenRoom} ");
            //}

        }

    }
}
