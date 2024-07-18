using System.Collections.Generic;
using System.Linq;
using OrganizationETMCreation.Interface;
using OrganizationETMCreation.Models;

namespace OrganizationETMCreation.Repositories
{
    public class TeamMemberRepository : ITeamMemberRepository
    {
        private readonly DataContext _context;

        public TeamMemberRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(TeamMember member)
        {
            try
            {
                var existingMember = GetById(member.memberid);
                if (existingMember != null)
                {
                    throw new Exception("Team member already exists");
                }

                _context.TeamMembers.Add(member);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding team member", ex);
            }
        }


        public void Update(TeamMember member)
        {
            try
            {
                var existingMember = GetById(member.memberid);
                if (existingMember == null)
                {
                    throw new Exception("Team member not found");
                }

                _context.Entry(existingMember).CurrentValues.SetValues(member);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating team member", ex);
            }
        }


        public void Delete(int id)
        {
            try
            {
                var member = GetById(id);
                if (member == null)
                {
                    throw new Exception("Team member not found");
                }

                _context.TeamMembers.Remove(member);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting team member with ID {id}", ex);
            }
        }

        public TeamMember GetById(int id)
        {
            try
            {
                return _context.TeamMembers.FirstOrDefault(m => m.memberid == id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving team member with ID {id}", ex);
            }
        }

        public IEnumerable<TeamMember> GetAll()
        {
            try
            {
                return _context.TeamMembers.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving all team members", ex);
            }
        }

        //public void Add(TeamMember member)
        //{
        //    _context.TeamMembers.Add(member);
        //    _context.SaveChanges();
        //}

        //public void Update(TeamMember member)
        //{
        //    _context.TeamMembers.Update(member);
        //    _context.SaveChanges();
        //}

        //public void Delete(int id)
        //{
        //    var member = GetById(id);
        //    if (member != null)
        //    {
        //        _context.TeamMembers.Remove(member);
        //        _context.SaveChanges();
        //    }
        //}

        //public TeamMember GetById(int id)
        //{
        //    return _context.TeamMembers.FirstOrDefault(m => m.memberid == id);
        //}

        //public IEnumerable<TeamMember> GetAll()
        //{
        //    return _context.TeamMembers.ToList();  
        //}
    }
}
