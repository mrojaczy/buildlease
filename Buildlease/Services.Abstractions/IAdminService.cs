﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IAdminService
    {
        bool IsUserAdmin(string userId);
        void EnsureUserIsAdmin(string userId);
    }
}
