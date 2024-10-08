﻿using Microsoft.AspNetCore.Identity;

namespace MonoModularNet.Infrastructure.DAL.Identity;

public sealed class ApplicationUserLogin: IdentityUserLogin<string>
{
    public ApplicationUser User { get; set; } = null!;
}
