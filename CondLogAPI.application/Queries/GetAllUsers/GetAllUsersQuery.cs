﻿using CondLogAPI.application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.application.Queries.GetAllUsers
{
    public class GetAllUsersQuery:IRequest<List<UserViewModel>>
    {

    }
}
