using System;

namespace GuestsRoomLogic
{
    public class BookRoom
    {
        public static string RoomSeperation(int nAdult, int nChildren)
        {
          

            int nRooms = 0;
            int nMaxGuestsPerRoom = 4;
            int nOverallGuests = nAdult + nChildren;
            string strResult = "";


            while (nAdult >= 0 || nChildren > 0)
            {
                if (nAdult == 0)
                {
                    strResult += "Error: At least one adult is required to book rooms.";
                }

                nRooms++;
                int nAdultRoom = 0;
                int nChildrenRoom = 0;

                if (nAdult > 0)
                {
                    if (nAdult >= 2)
                    {
                        nAdultRoom = 2;
                        nAdult -= 2;
                    }

                    else
                    {
                        nAdultRoom = 1;
                        nAdult--;
                    }
                }

                if (nChildren > 0)
                {
                    nChildrenRoom = Math.Min(nMaxGuestsPerRoom - nAdultRoom, nChildren);
                    nChildren -= nChildrenRoom;
                }

                strResult += $"Room {nRooms}: Adults {nAdultRoom} - Children {nChildrenRoom}";

                if (nAdult > 0 || nChildren > 0)
                {
                    strResult += "\n";
                }
               
            }

            return strResult;
        }              
      }
 }




