﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LogInPage.Areas.Identity.Data;

// Add profile data for application users by adding properties to the LogUser class
public class LogUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

