using CinemaProject.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject
{
    public class ClassUpdate
    {
        public void Updat2(List<Seat> seatList)
        {
            seatList[1].checkFill = false;
        }
    }
}
