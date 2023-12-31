﻿using ApiBolsaTrabajoUTN.API.Entities;
using ApiBolsaTrabajoUTN.API.Models.JobPosition;

namespace ApiBolsaTrabajoUTN.API.Data.JobPositions
{
    public interface IJobPositionRepository : IRepository
    {
        public Task<Company> GetCompany(string companyId);
        public void AddJobPosition(Company company, JobPosition newJobPosition);
        public IQueryable<JobPosition> GetAllJobPositions();
        public IQueryable<JobPosition> GetCompanyJobPositions(string companyId);
        public JobPosition GetJobPosition(int jobPositionId);
        public bool UpdateJobPosition(UpdateJobPositionRequest rq);
        public List<Student> GetStudentsThatAppliedToJobPosition(int jobPositionId);
        public List<JobPosition> GetJobAppliesOfStudent(string studentId);
    }
}
