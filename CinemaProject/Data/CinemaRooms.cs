using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Data
{
    public class CinemaRooms : CinemaRoom
    {

public List<CinemaRoom> CinemaRoomsList = new List<CinemaRoom>()
{
    new CinemaRoom(){}
};
        


        public Dictionary<int, bool> film1 = new Dictionary<int, bool>()
        {
            {1,true},{2,true},{3,true},{4,true},{5,true},{6,true},{7,true},{8,true},{9,true},{10,true},{11,true},{13,true}
        };

        
    }
}
