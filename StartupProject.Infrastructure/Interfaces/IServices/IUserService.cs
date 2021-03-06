﻿using StartupProject.Entities.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartupProject.Infrastructure.Interfaces.IServices
{
    public interface IUserService
    {
        Task<IEnumerable<ApplicationUser>> GetNotFilledUsers();
    }
}
