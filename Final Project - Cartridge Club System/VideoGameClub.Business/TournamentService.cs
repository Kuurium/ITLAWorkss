using System.Collections.Generic;
using VideoGameClub.Data;
using VideoGameClub.Entities;

namespace VideoGameClub.Business
{
    public class TournamentService
    {
        private readonly TournamentRepository _repository;

        public TournamentService()
        {
            _repository = new TournamentRepository();
        }

        public void RegisterTournament(Tournament tournament)
        {
            _repository.Add(tournament);
        }

        public List<Tournament> GetTournaments()
        {
            return _repository.GetAll();
        }

        public void UpdateTournamentStatus(int id, int status)
        {
            _repository.UpdateStatus(id, status);
        }

        public void DeleteTournament(int id)
        {
            _repository.Delete(id);
        }
    }
}