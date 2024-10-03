using System;

namespace GuestsRoomLogic
{
    public class BookRoom
    {
        public static string RoomSeperation(int nAdult, int nChildren)
        {
          
            int nRooms = 0;
            int nMaxGuestsPerRoom = 4;        
            string strResult = "";

            if(nAdult <= 0)
            {
                if(nChildren > 0)
                {
                    return $"No Adults Found. {nChildren} children have no rooms.";
                }

                return $"Oops! There are no people Entered.";
            }

            int nOverallGuests = nAdult + nChildren;

            if( nOverallGuests > 16)
            {
                return "Allows Only 16 persons.";
            }

            while (nAdult > 0 || nChildren > 0)
            {             
                nRooms++;
                int nAdultRoom = 0;
                int nChildrenRoom = 0;

               if(nAdult >=2)
                {
                    nAdultRoom = 2;
                    nAdult -= 2;
                }
               else if(nAdult == 1)
                {
                    nAdultRoom = 1;
                    nAdult--;
                }
                
                nChildrenRoom = Math.Min(nMaxGuestsPerRoom - nAdultRoom, nChildren);
                nChildren -= nChildrenRoom;
                
                strResult += $"Room {nRooms}: Adults {nAdultRoom} - Children {nChildrenRoom}\n";

                if(nAdult == 0 && nChildren > 0)
                {
                    strResult += $"No adults available. {nChildren} children have no rooms.";
                    break;
                }                           
            }
            return strResult;
        }              
      }
 }




