﻿using Hospital_Management_System_DAL.Entities;
using Hospital_Management_System_DAL.Generic_Repository_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Repositories.Interfaces
{
    internal interface IEmployeesRepository : IGenericRepository<Employees>
    {
    }
}
