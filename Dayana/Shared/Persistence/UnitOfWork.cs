﻿using Dayana.Shared.Persistence.Interfaces;
using Dayana.Shared.Persistence.Interfaces.IdentityRepositories;
using Dayana.Shared.Persistence.Repositories.IdentityRepositories.Claims;
using Dayana.Shared.Persistence.Repositories.IdentityRepositories.Permissions;
using Dayana.Shared.Persistence.Repositories.IdentityRepositories.Roles;
using Dayana.Shared.Persistence.Repositories.IdentityRepositories.Users;

namespace Dayana.Shared.Persistence;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public IUserRepository Users { get; }
    public IRoleRepository Roles { get; }
    public IClaimRepository Claims { get; }
    public IPermissionRepository Permissions { get; }

    public UnitOfWork(AppDbContext context)
    {
        _context = context;

        Users = new UserRepository(_context);
        Roles = new RoleRepository(_context);
        Claims = new ClaimRepository(_context);
        Permissions = new PermissionRepository(_context);
    }

    public async Task<bool> CommitAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}