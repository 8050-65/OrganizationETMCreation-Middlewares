using OrganizationETMCreation.Interface;
using OrganizationETMCreation.Models;
using Microsoft.EntityFrameworkCore;
using DocumentFormat.OpenXml.Office2010.Excel;



namespace OrganizationETMCreation.Data.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly DataContext _context;

        //public object TeamMembers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public TeamRepository(DataContext context)
        {
            _context = context;
        }

         public void Add(Team team)
        {
            try
            {
                _context.Teams.Add(team);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                
                var errorMessage = ex.InnerException?.Message ?? ex.Message;
                throw new Exception($"Error adding team: {errorMessage}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred while adding the team.", ex);
            }
        }

        public void Update(Team team)
        {
            _context.Teams.Update(team);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var team = _context.Teams.Find(id);
            if (team != null)
            {
                _context.Teams.Remove(team);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Team> GetAll()
        {
            return _context.Teams.ToList();
        }

        public Team? GetById(int id) 
        {
            return _context.Teams.Find(id);
        }

        public void AddTeamMember(TeamMember teamMember)
        {
            _context.TeamMembers.Add(teamMember);
            _context.SaveChanges();
        }

        public void UpdateTeamMember(TeamMember teamMember)
        {
            _context.TeamMembers.Update(teamMember);
            _context.SaveChanges();
        }

        public void DeleteTeamMember(int id)
        {
            var teamMember = _context.TeamMembers.Find(id);
            if (teamMember != null)
            {
                _context.TeamMembers.Remove(teamMember);
                _context.SaveChanges();
            }
        }

        public TeamMember? GetTeamMemberById(int id)
        {
            return _context.TeamMembers.Find(id);
        }

        public IEnumerable<TeamMember> GetAllTeamMembers()
        {
            return _context.TeamMembers.ToList();
        }

        //public Employee GetTeamManager(int teamId)
        //{
        //    return _context.TeamMembers
        //        .Where(tm => tm.TeamId == teamId && tm.role == "Manager")
        //        .Select(tm => tm.Employee)
        //        .FirstOrDefault();
        //}

        public IEnumerable<TeamMember> GetTeamMembers(int teamId)
        {
            return _context.TeamMembers
                .Where(tm => tm.TeamId == teamId)
                .Include(tm => tm.Employee)
                .ToList();
        }

        public TeamMember? GetByTeamAndMemberId(int teamId, int memberId) 
        {
            return _context.TeamMembers
                .FirstOrDefault(tm => tm.TeamId == teamId && tm.EmployeeId == memberId);
        }

        public void AddMemberToTeam(int teamId, int memberId)
        {
            var teamMember = new TeamMember
            {
                TeamId = teamId,
                EmployeeId = memberId
            };
            _context.TeamMembers.Add(teamMember);
            _context.SaveChanges();
        }

        public void RemoveMemberFromTeam(int teamId, int memberId)
        {
            var teamMember = GetByTeamAndMemberId(teamId, memberId);
            if (teamMember != null)
            {
                _context.TeamMembers.Remove(teamMember);
                _context.SaveChanges();
            }
        }

        public void ReassignMember(int memberId, int oldTeamId, int newTeamId)
        {
            var teamMember = GetByTeamAndMemberId(oldTeamId, memberId);
            if (teamMember != null)
            {
                teamMember.TeamId = newTeamId;
                _context.TeamMembers.Update(teamMember);
                _context.SaveChanges();
            }
        }

        public void ChangeMemberRole(int memberId, string newRole)
        {
            var teamMember = _context.TeamMembers
                .FirstOrDefault(tm => tm.EmployeeId == memberId);
            if (teamMember != null)
            {
                teamMember.memberrole = newRole;
                _context.TeamMembers.Update(teamMember);
                _context.SaveChanges();
            }
        }

        public int GetTotalTeamEfforts(int teamId)
        {
            return _context.TeamMembers
                .Where(tm => tm.TeamId == teamId)
                .Sum(tm => tm.WorkingHours);
        } 


        public void InitializeTeams()
        {
            var teams = new List<Team>
            {
                new Team { Name = "Development" },
                new Team { Name = "QA" },
                new Team { Name = "Product" },
                new Team { Name = "Marketing" },
                new Team { Name = "HR" }
            };

            foreach (var team in teams)
            {
                _context.Teams.Add(team);
            }

            _context.SaveChanges();
        }

        //object ITeamRepository.GetTeamMemberById(int teamid, int memberId)
        //{
        //    return _context.TeamMembers.Find( memberId);
        //    _context.SaveChanges();
        //}

        object ITeamRepository.GetAllTeamMembers()
        {
            return _context.TeamMembers.ToList();
            //_context.SaveChanges();
        }

        TeamManager? ITeamRepository.GetTeamManager(int EmployeeId)   
        {  
            return _context.teammanagers.FirstOrDefault(x => x.id == EmployeeId); 
        }

        //public TeamMember GetTeamMemberById(int memberId)
        //{
        //    return _context.TeamMembers.FirstOrDefault(tm => tm.MemberId == memberId);
        //}


        public TeamMember? GetTeamMemberById(int teamId, int memberId)
        {
            return _context.TeamMembers.Find(teamId);
        }
        public void Delete(object teamMember)
        {
            _context.TeamMembers.Remove((TeamMember)teamMember);
            _context.SaveChanges();
        }

        public void Update(object teamMember)
        {
            _context.TeamMembers.Update((TeamMember)teamMember);
            _context.SaveChanges();
        }

        public void Delete(TeamMember teamMember)
        {
            _context.TeamMembers.Remove((TeamMember)teamMember);
            _context.SaveChanges();
        }

        public void Update(TeamMember teamMember)
        {
            _context.TeamMembers.Update((TeamMember)teamMember);
            _context.SaveChanges();
        }

        object? ITeamRepository.GetTeamMemberById(int id)
        {
            return _context.TeamMembers.Find(id);
            _context.SaveChanges();
        }

        public TeamMember? TeamMemberById(int teamId, int memberId) 
        {
            return _context.TeamMembers.Find(memberId);
            _context.SaveChanges();
        }

        //public Team GetId(int Id)
        //{
        //    _context.TeamMembers.Add(teamMember);
        //    _context.SaveChanges();
        //}
    } 
}


//namespace OrganizationETMCreation.Data.Repositories
//{
//    public class TeamRepository : ITeamRepository
//    {
//        private readonly DataContext _context;

//        public TeamRepository(DataContext context)
//        {
//            _context = context;
//        }

//        public void Add(Team team)
//        {
//            _context.Teams.Add(team);
//            _context.SaveChanges();
//        }

//        public void Update(Team team)
//        {
//            _context.Teams.Update(team);
//            _context.SaveChanges();
//        }

//        public void Delete(int id)
//        {
//            var team = _context.Teams.Find(id);
//            if (team != null)
//            {
//                _context.Teams.Remove(team);
//                _context.SaveChanges();
//            }
//        }

//        public IEnumerable<Team> GetAll()
//        {
//            return _context.Teams.ToList();
//        }

//        public Team GetById(int id)
//        {
//            return _context.Teams.Find(id);
//        }

//        //public void AddMember(TeamMember teamMember)
//        //{
//        //    _context.TeamMembers.Add(teamMember);
//        //    _context.SaveChanges();
//        //}

//        //public void RemoveMember(TeamMember teamMember)
//        //{
//        //    _context.TeamMembers.Remove(teamMember);
//        //    _context.SaveChanges();
//        //}

//        //public TeamMember GetMemberById(int id)
//        //{
//        //    return _context.TeamMembers.Find(id);
//        //}

//        public void AddTeamMember(TeamMember teamMember)
//        {
//            throw new NotImplementedException();
//        }

//        public void UpdateTeamMember(TeamMember teamMember)
//        {
//            throw new NotImplementedException();
//        }

//        public void DeleteTeamMember(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public object GetTeamMemberById(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public object GetAllTeamMembers()
//        {
//            throw new NotImplementedException();
//        }

//        public void AddMember(TeamMember teamMember)
//        {
//            throw new NotImplementedException();
//        }

//        public void RemoveMember(TeamMember teamMember)
//        {
//            throw new NotImplementedException();
//        }

//        public TeamMember GetMemberById(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public Team GetTeamById(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public object GetAllTeams()
//        {
//            throw new NotImplementedException();
//        }

//        public object GetTeamManager(int Id)
//        {
//            throw new NotImplementedException();
//        }

//        public Team GetTeamMembers(int Teamid)
//        {
//            throw new NotImplementedException();
//        }

//        public object UpdateTeamManager(TeamManager teamManager)
//        {
//            throw new NotImplementedException();
//        }

//        public object GetByTeamAndMemberId(int teamId, int memberId)
//        {
//            throw new NotImplementedException();
//        }

//        public void InitializeTeams()
//        {
//            throw new NotImplementedException();
//        }

//        public void AddMemberToTeam(int teamId, int memberId)
//        {
//            throw new NotImplementedException();
//        }

//        public void RemoveMemberFromTeam(int teamId, int memberId)
//        {
//            throw new NotImplementedException();
//        }

//        public void ReassignMember(int memberId, int oldTeamId, int newTeamId)
//        {
//            throw new NotImplementedException();
//        }

//        public void ChangeMemberRole(int memberId, string newRole)
//        {
//            throw new NotImplementedException();
//        }

//        public int GetTotalTeamEfforts(int teamId)
//        {
//            throw new NotImplementedException();
//        }

//        public void Delete(object teamMember)
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(object teamMember)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}

