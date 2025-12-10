using System;
using System.Collections.Generic;
using VideoGameClub.Data;
using VideoGameClub.Entities;

namespace VideoGameClub.Business
{
    public class RegistrationService
    {
        private RegistrationRepository _registrationRepository;
        private TournamentRepository _tournamentRepository;

        public RegistrationService()
        {
            _registrationRepository = new RegistrationRepository();
            _tournamentRepository = new TournamentRepository();
        }

        public void RegisterMember(Registration registration)
        {



            int maxCapacity = _tournamentRepository.GetCapacity(registration.TournamentId);


            int currentCount = _registrationRepository.GetTotalRegistrations(registration.TournamentId);


            if (currentCount >= maxCapacity)
            {

                throw new Exception("¡Lo sentimos! El torneo ha alcanzado su capacidad máxima.");
            }

            _registrationRepository.Add(registration);
        }

        public List<RegistrationDetail> GetRegistrationList()
        {
            return _registrationRepository.GetAll();
        }
        public void DeleteRegistration(int id)
        {
            _registrationRepository.Delete(id);
        }
    }
}