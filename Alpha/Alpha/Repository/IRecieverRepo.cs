﻿using Alpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Alpha.Repository
{
    interface IRecieverRepo : IRepository<RecieverTB>
    {
        IEnumerable<RecieverTB> GetHighestPaidEmployees();
        List<RecieverTB> GetReciverAccordingArea(int addressID);
    }
}
