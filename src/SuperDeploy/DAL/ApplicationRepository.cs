﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using SuperDeploy.Models;

namespace SuperDeploy.DAL
{
    public interface IApplicationRepository
    {
        Task<Application> GetApplicationById(Guid id);
        Task<Application> NewApplication(Application application);
    }

    public class ApplicationRepository : IApplicationRepository
    {
        private readonly SuperDeployDbContext _db;

        public ApplicationRepository(SuperDeployDbContext db)
        {
            _db = db;
        }

        public async Task<Application> GetApplicationById(Guid id)
        {
            return await _db.Applications.Where(application => application.Id == id).FirstAsync();
        }
        
        public async Task<Application> NewApplication(Application application) {
            _db.Applications.Add(application);
            await _db.SaveChangesAsync();
            return application;
        }
    }
}
