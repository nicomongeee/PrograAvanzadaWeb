﻿using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class EmpleadosDALImpl : DALGenerioImpl<Empleado>, IEmpleadosDAL
    {
        QuizContext _context;

        public EmpleadosDALImpl(QuizContext context): base(context)
        {
            _context = context;
        }
    }   
}
