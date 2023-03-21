using CinemaProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaProject.Other;

namespace CinemaProject
{
    public class ClassShow
    {
        public void Showseat(List<Seat> seatList)
        {
            byte a = 5;
            byte b = 6;
            seatList[a].checkFill = false;
            seatList[b].checkFill = false;  
            foreach (var VARIABLE in seatList)
            {
                Console.WriteLine("Id : {0} Boş: {1}", VARIABLE.Id, VARIABLE.checkFill);
            }
            
        } 
    }
}
