using System;
using System.Collections.Generic;
using System.Linq;
using VideoGameClub.Data;
using VideoGameClub.Entities;

namespace VideoGameClub.Business
{
    public class MemberService
    {
        private readonly MemberRepository _repository;
        private readonly MembershipTypeRepository _membershipRepo = new MembershipTypeRepository();

        public MemberService()
        {
            _repository = new MemberRepository();
        }

        public List<MembershipType> GetMembershipTypes()
        {
            return _membershipRepo.GetAll();
        }

        public void RegisterMember(Member member)
        {
            // Validation: Name cannot be empty
            if (string.IsNullOrWhiteSpace(member.FirstName))
            {
                throw new ArgumentException("El nombre es obligatorio.");
            }

            // Validation: Name cannot contain digits
            if (member.FirstName.Any(char.IsDigit))
            {
                throw new ArgumentException("El nombre no puede contener números.");
            }

            // Validation: Last name cannot contain digits
            if (member.LastName.Any(char.IsDigit))
            {
                throw new ArgumentException("El apellido no puede contener números.");
            }

            // If validations pass, save to database
            _repository.Add(member);
        }

        // Overload 1: Find by ID
        public Member FindMember(int id)
        {
            return _repository.GetById(id);
        }

        // Overload 2: Find by Email
        public Member FindMember(string email)
        {
            return _repository.GetByEmail(email);
        }

        public List<Member> GetMembers()
        {
            return _repository.GetAll();
        }

        public void UpdateMember(Member member)
        {
            _repository.Update(member);
        }

        public Member GetMemberById(int id)
        {
            return _repository.GetById(id);
        }

        public void DeleteMember(int id)
        {
            _repository.Delete(id);
        }
    }
}