﻿using Bootcamp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Queries.DocumenType
{
    public interface IDocumenTypeQueries
    {
        Task<IEnumerable<DocumenTypeViewModel>> GetAll();
    }
}
