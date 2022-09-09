using System;
using System.Data;
using John.SocialClub.Data.Entities;
using John.SocialClub.Data.Service.Interface;

namespace John.SocialClub.Data.Service
{
    public class ClubMemberServiceMock : IClubMemberService
    {
        public bool Create(ClubMember clubMember)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {
            throw new NotImplementedException();
        }

        public DataRow GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public DataTable Search(int occupation, int maritalStatus, string operand)
        {
            throw new NotImplementedException();
        }

        public bool Update(ClubMember clubMember)
        {
            throw new NotImplementedException();
        }
    }
}
